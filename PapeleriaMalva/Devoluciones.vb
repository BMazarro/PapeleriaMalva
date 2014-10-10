Imports System.Data.SqlClient

Public Class Devoluciones
    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New PapeleriaDataSet

    Dim descuentoLinea As Double = 0.0      ' - Variable Global para el descuento en linea
    Dim venta As String
    Dim porcentajeiva As Integer            ' - Variable Global para almacenar el porcentaje de Iva
    Dim formapago As Char                   ' - Variable Global para almacenar la Forma de Pago (1|2|3)


    Private Sub Devoluciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        bbuscarcli.Enabled = True
        beliminar.Enabled = False
        bnomaslineas.Enabled = False
        bcancelar.Enabled = False
        baceptar.Enabled = False
        bsalir.Enabled = True
        Try
            Conexion.Open()
            ' Rellenamos el Combo del IVA
            consulta = New SqlCommand("Select Tipo from IVA", Conexion)
            Mireader = consulta.ExecuteReader() ' Devuelve un conjunto de registros
            While Mireader.Read()
                ComboBox2.Items.Add(Mireader("Tipo").ToString)
            End While
            Mireader.Close()
            ComboBox2.SelectedIndex = 0
            ComboBox2.Enabled = False

            ' Rellenamos el Combo del FormasPago
            consulta = New SqlCommand("SELECT nombre FROM FormasPago", Conexion)
            Mireader = consulta.ExecuteReader()
            While Mireader.Read()
                ComboBox1.Items.Add(Mireader("nombre").ToString)
            End While
            Mireader.Close()
            ComboBox1.SelectedIndex = 0
            ComboBox1.Enabled = False

            Conexion.Close()
            Mireader.Close()

        Catch ex As Exception
            MsgBox("No ha introducido ningun código de cliente")
            Mireader.Close()

        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

        
    End Sub

    Private Sub bbuscarcli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscarcli.Click
        bcancelar.Enabled = True
        dg2.Rows.Clear()
        Dim posicion As Integer
        tcliente.Focus()
        'tdto.Text = descuentoLinea.ToString
        Try ' Abrimos la conexion
            Conexion.Open()

            ' Buscamos el codigo introducido y vemos en que posicion se encuentra
            consulta = New SqlCommand("Select codcli from Clientes where codcli='" &
                                      tcliente.Text & "';", Conexion)
            posicion = consulta.ExecuteScalar()   'Obtenemos la cantidad de registros que tiene hasta su posicion

            ' Si el valor devuelto no existe entonces volvemos al inicio de la aplicacion
            If posicion = Nothing Then
                MsgBox("Ese cliente no existe")
            Else
                ' Seleccionamos los datos del cliente introducido
                consulta = New SqlCommand("Select * from Clientes where codcli='" &
                                          tcliente.Text & "';", Conexion)
                ' Rellemos el datareader con los datos
                Mireader = consulta.ExecuteReader()
                ' Leemos el datareader
                Mireader.Read()
                ' Mostramos los datos del cliente
                MostrarDatosCliente()
                Mireader.Close()
                MostrarVentas()
            End If
            ' - Cerramos la conexion y el datareader
            Conexion.Close()
            Mireader.Close()

        Catch ex As Exception
            MsgBox("No ha introducido ningun código de cliente")
            Mireader.Close()

        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub

    ' -------- MOSTRAR LOS DATOS DEL CLIENTE -------------
    Private Sub MostrarDatosCliente()
        lnombre.Text = Mireader("nombre").ToString
        ldireccion.Text = Mireader("direccion").ToString
        lnif.Text = Mireader("nif").ToString
        lcp.Text = Mireader("cp").ToString
        llocalidad.Text = Mireader("localidad").ToString
        lprovincia.Text = Mireader("provincia").ToString
        ltfn.Text = Mireader("telefono").ToString
    End Sub

    Public Sub MostrarVentas()
        Dim v As String
        Dim fi As Date
        Dim im As Double
        Try
            consulta = New SqlCommand("Select Ventas.codventa,Ventas.fecha,Ventas.importe from Ventas,Clientes where Clientes.codcli='" &
                                          tcliente.Text & "' and Clientes.codcli=Ventas.codcli and Ventas.facturado='S';", Conexion)
            ' Rellemos el datareader con los datos
            Mireader = consulta.ExecuteReader()

            ' Leemos el datareader
            While Mireader.Read()
                ' Mostramos los datos de los clientes
                v = Mireader("codventa").ToString
                fi = Mireader("fecha").ToString
                im = Mireader("importe").ToString
                dg2.Rows.Add(v, CDate(fi), im)

            End While

            Conexion.Close()
            Mireader.Close()

        Catch ex As Exception
            Mireader.Close()
            MsgBox(ex.Message)
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub

    Private Sub dg2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg2.CellClick
        Label1.Text = ""
        dg.Rows.Clear()
        venta = dg2.Item(0, dg2.CurrentRow.Index).Value.ToString

        ComprobarDevoluciones()
        
    End Sub

    Public Sub ComprobarDevoluciones()
        Dim posicion As Integer
        Try
            Conexion.Open()
            ' Buscamos el codigo introducido y vemos en que posicion se encuentra
            consulta = New SqlCommand("Select * from Devoluciones where codventa='" &
                                      venta & "';", Conexion)
            posicion = consulta.ExecuteScalar()
            If posicion = Nothing Then
                MostrarLineasArticulos()
                MostrarPie()
                BuscarItenIva()
                ' Mostramos la forma de pago
                BuscarItenFP()
                beliminar.Enabled = True
                bnomaslineas.Enabled = True
            Else
                Label1.Text = "NO ADMITE DEVOLUCIONES"
            End If

            Conexion.Close()
            Mireader.Close()

        Catch ex As Exception
            Mireader.Close()
            MsgBox(ex.Message)
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub

    ' -------- BUSCA ITEM CORRESPONDIENTE DEL COMBO FORMA DE PAGO ----
    Public Sub BuscarItenFP()
        If formapago = "1" Then
            ComboBox1.SelectedIndex = 0
        ElseIf formapago = "2" Then
            ComboBox1.SelectedIndex = 1
        ElseIf formapago = "3" Then
            ComboBox1.SelectedIndex = 2
        ElseIf formapago = "4" Then
            ComboBox1.SelectedIndex = 3
        End If

    End Sub


    Public Sub MostrarPie()
        Try
            Conexion.Open()
            consulta = New SqlCommand("SELECT * FROM Ventas WHERE codventa='" & venta & "';", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            limporte.Text = Format(CDbl(Mireader("baseimponible").ToString), "N2")
            liva.Text = Format(CDbl(Mireader("iva").ToString), "N2")
            ltotal.Text = Format(CDbl(Mireader("importe").ToString), "N2")
            porcentajeiva = CInt(Mireader("porcentajeiva").ToString)
            formapago = Mireader("formapago").ToString
            Conexion.Close()
            Mireader.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
            Conexion.Close()
            Mireader.Close()
        End Try
    End Sub

    ' -------- BUSCA ITEM CORRESPONDIENTE DEL COMBO IVA ------------
    Public Sub BuscarItenIva()
        If porcentajeiva = 21 Then
            ComboBox2.SelectedIndex = 0
        ElseIf porcentajeiva = 10 Then
            ComboBox2.SelectedIndex = 1
        ElseIf porcentajeiva = 4 Then
            ComboBox2.SelectedIndex = 2
        End If
    End Sub

    Public Sub MostrarLineasArticulos()
        Dim contadorF As Integer
        Dim n As Integer = 0          ' Variable a usar en el while de las filas 
        Dim i As Integer
        Dim aux As String
        Try
            ' Abrimos la conexion

            ' Obtenemos la cantidad de lineas que corresponden a este albaran
            consulta = New SqlCommand("Select count(*) from LineasVenta where codventa='" & venta & "';", Conexion)
            contadorF = consulta.ExecuteScalar()
            ' Buscamos en la base de datos los datos de los articulos correspondientes
            consulta = New SqlCommand("SELECT * FROM LineasVenta WHERE codventa='" & venta & "';", Conexion)
            Mireader = consulta.ExecuteReader()

            While Mireader.Read
                dg.Rows.Add()
                dg.Rows(n).Cells(0).Value = Mireader("numlinea").ToString
                dg.Rows(n).Cells(1).Value = Mireader("codprod").ToString
                dg.Rows(n).Cells(2).Value = Mireader("descripcion").ToString
                aux = Mireader("pvp").ToString
                aux = Format(CDbl(aux), "N2")
                dg.Rows(n).Cells(3).Value = aux
                dg.Rows(n).Cells(4).Value = Mireader("cantidad").ToString
                dg.Rows(n).Cells(5).Value = Mireader("dtolinea").ToString
                aux = Mireader("importe").ToString
                aux = Format(CDbl(aux), "N2")
                dg.Rows(n).Cells(6).Value = aux
                n = n + 1
            End While
            Mireader.Close()

            'For i = 0 To dg.RowCount - 1
            '    consulta = New SqlCommand("Select descripcion from Articulos where codigo='" & dg.Rows(i).Cells(1).Value & "';", Conexion)
            '    Mireader = consulta.ExecuteReader
            '    Mireader.Read()
            '    dg.Rows(i).Cells(2).Value = Mireader("descripcion").ToString
            '    Mireader.Close()
            'Next
            Conexion.Close()
            Mireader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Conexion.Close()
            Mireader.Close()
        End Try

    End Sub
    
    Private Sub bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsalir.Click
        Me.Close()
    End Sub

    Private Sub beliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beliminar.Click
        Dim cant As Integer
        Dim cod As String
        Dim linea As Integer
        Try
            'Tomamos la linea elegida
            linea = dg.Item(0, dg.CurrentRow.Index).Value
            ' Tomamos la cantidad de ese articulo
            cant = dg.Item(4, dg.CurrentRow.Index).Value
            ' Tomamos el codigo del articulo seleccionado
            cod = CStr(dg.Item(1, dg.CurrentRow.Index).Value.ToString)
            ' Recalculamos el stock de los articulos
            Conexion.Open()

            If cod.Length = 13 Then
                consulta = New SqlCommand("UPDATE LIBROS set stock = stock + " & _
                                     CInt(cant) & " where isbn = '" & cod & "';", Conexion)
            Else
                consulta = New SqlCommand("UPDATE Articulos set stock = stock + " & _
                                     CInt(cant) & " where codart = '" & cod & "';", Conexion)
            End If
            consulta.ExecuteNonQuery()

            Conexion.Close()
            ' Borramos la fila seleccionada
            dg.Rows.Remove(dg.CurrentRow)
        Catch ex As Exception
            Conexion.Close()
        End Try
    End Sub

    Private Sub bnomaslineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnomaslineas.Click
        CalcularImportes()
    End Sub

    Public Sub CalcularImportes()
        Dim a, b As Double
        Dim imponible As Double
        ' Calculamos la linea correspondiente
        Dim importetotal As Double = 0.0
        For i = 0 To dg.RowCount - 1
            importetotal = importetotal + dg.Item(6, i).Value
        Next
        'limporte.Text = String.Format("{0:N2}", importetotal)
        limporte.Text = Format(importetotal, "N2")
        imponible = CDbl(limporte.Text)
        Dim iva = CSng(ComboBox2.SelectedItem)
        ' Calculamos lo que hay que sumarle de IVA
        a = CDbl(iva / 100) * imponible
        liva.Text = Format(a, "N2")
        ' Sumamos la base imponible y el IVA correspondiente
        b = a + imponible
        ' Formateamos la salida y lo asignamos al TOTAL
        ltotal.Text = Format(b, "N2")
        Mireader.Close()
        Conexion.Close()
        baceptar.Enabled = True
    End Sub

    Private Sub bcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcancelar.Click
        Label1.Text = ""
        dg.Rows.Clear()
        dg2.Rows.Clear()
        tcliente.Text = ""
        limpiarcabpie()
        beliminar.Enabled = False
        bnomaslineas.Enabled = False
        baceptar.Enabled = False
    End Sub

    Public Sub limpiarcabpie()
        ldireccion.Text = ""
        lnif.Text = ""
        lnombre.Text = ""
        lcp.Text = ""
        llocalidad.Text = ""
        lprovincia.Text = ""
        ltfn.Text = ""
        limporte.Text = ""
        liva.Text = ""
        ltotal.Text = ""
    End Sub

    Private Sub baceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baceptar.Click
        Dim contador As Integer = 0
        Dim codigoF As String
        Dim sustituye As String

        Try ' Eliminamos las lineas de albaran de la bbdd
            Conexion.Open()
            consulta = New SqlCommand("Insert into Devoluciones(codventa,fecha,codcli) values ('" &
                                      venta & "','" & dtp.Text & "','" & tcliente.Text & "')", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
            'MsgBox("guardada la devolucion")
        Catch ex As Exception
            Conexion.Close()
        End Try

        Try
            Conexion.Open()
            ' Obtenemos el Nº de Factura contando los registros que hay en la BD
            consulta = New SqlCommand("Select count(codfact) from FacturasRectificativas", Conexion)
            contador = consulta.ExecuteScalar() ' Devuelve un número
            codigoF = (contador + 1).ToString
            tventa.Text = codigoF
            Conexion.Close()
            'MsgBox("Hay " & contador & " facturas")
        Catch ex As Exception
            'MsgBox(ex.Message)
            Conexion.Close()
        End Try

        Try
            Conexion.Open()
            ' Obtenemos el Nº de Factura contando los registros que hay en la BD
            consulta = New SqlCommand("Select codfact from Facturas where codventa='" & venta & "'", Conexion)
            Mireader = consulta.ExecuteReader()
            While Mireader.Read
                sustituye = Mireader("codfact").ToString

            End While
            Conexion.Close()
            'MsgBox("Hay " & contador & " facturas")
        Catch ex As Exception
            'MsgBox(ex.Message)
            Conexion.Close()
        End Try

        Try  ' Damos de alta la cabecera de la factura
            Conexion.Open()
            consulta = New SqlCommand("Insert into FacturasRectificativas(codfact,fecha,codcli,baseimponible,porcentajeiva,iva,total,formapago," &
                "observaciones,direccion,impreso,sustituyente)" & " values('" & codigoF & "','" &
                dtp.Text & "','" & tcliente.Text & "'," & limporte.Text.Replace(".", "").Replace(",", ".") & "," &
                CInt(ComboBox2.SelectedItem.ToString) & "," &
                    liva.Text.Replace(",", ".") & "," &
                    ltotal.Text.Replace(".", "").Replace(",", ".") & ",'" &
                CStr(ComboBox1.SelectedIndex + 1) & "','" &
                 "" & "','" & ldireccion.Text & "'," & "'N'" & ",'" & sustituye & "');", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
            'MsgBox("Factura dada de alta")
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try

        Try
            Conexion.Open()
            consulta =
                    New SqlCommand("UPDATE FACTURAS SET SUSTITUIDA = '" & codigoF & "' where codfact='" & sustituye & "';", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Dim i As Integer = 0
        Dim n As Integer
        Dim codart As String
        Dim descripcion As String
        Dim pvp, dtolinea, importe As Double
        Dim cantidad, numlinea As Integer
        Try ' Añadimos las nuevas lineas de albaran a la bbdd
            n = dg.RowCount
            While i < n
                numlinea = dg.Rows(i).Cells(0).Value
                codart = dg.Rows(i).Cells(1).Value.ToString
                descripcion = dg.Rows(i).Cells(2).Value.ToString
                pvp = CDbl(dg.Rows(i).Cells(3).Value)
                cantidad = CInt(dg.Rows(i).Cells(4).Value)
                dtolinea = CDbl(dg.Rows(i).Cells(5).Value)
                importe = CDbl(dg.Rows(i).Cells(6).Value)
                Conexion.Open()
                consulta = New SqlCommand("Insert into LineasFRectificativa(codfact,numlinea,codprod,descripcion,pvp,cantidad,dtolinea,importe) values ('" &
                                          tventa.Text & "','" &
                                          numlinea & "','" &
                                          codart & "','" &
                                          descripcion & "'," & Replace(pvp, ",", ".") & "," & cantidad & "," &
                                          Replace(dtolinea, ",", ".") & "," & Replace(importe, ",", ".") & ")", Conexion)
                consulta.ExecuteNonQuery()
                Conexion.Close()
                i = i + 1
            End While
            'MsgBox("Ha actualizado las nuevas lineasrectificativas")
        Catch ex As Exception
            'MsgBox(ex.Message)
            Conexion.Close()
        End Try

        'Dar de alta la factura en el libro de iva
        Dim icodfactura, ifecha, icodcli, ibases, iiva, iimporte, inombre, inif, ibanco, icuenta, iporcentaje As String
        iimporte = "0"
        Try ' Obtenemos los datos de la factura
            Conexion.Open()
            consulta = New SqlCommand("Select codfact,fecha,codcli,baseimponible,porcentajeiva,iva,total from FacturasRectificativas where codfact ='" & codigoF & "'", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            icodfactura = Mireader("codfact").ToString
            ifecha = CStr(Format(CDate(Mireader("fecha").ToString), "d"))
            icodcli = Mireader("codcli").ToString
            ibases = Mireader("baseimponible").ToString.Replace(".", "").Replace(",", ".")
            iiva = CStr(Format(CDbl(Mireader("iva").ToString), "N")).Replace(".", "").Replace(",", ".")
            iporcentaje = Mireader("porcentajeiva").ToString
            iimporte = CStr(Format(CDbl(Mireader("total").ToString), "N")).Replace(".", "").Replace(",", ".")
            Mireader.Close()
            Conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try

        Try ' Obtenemos los datos de la factura
            Conexion.Open()
            consulta = New SqlCommand("Select nombre,nif,banco,cuenta from clientes where codcli='" & icodcli & "'", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            inombre = Mireader("nombre").ToString
            inif = Mireader("nif").ToString
            ibanco = Mireader("banco").ToString
            icuenta = Mireader("cuenta").ToString
            Mireader.Close()
            Conexion.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try

        Try ' Damos de alta en el libro de IVA
            Conexion.Open()
            consulta = New SqlCommand("Insert into LibroIva values('" & icodfactura & "','" & ifecha & "','" & inombre &
            "','" & inif & "','" & ibases & "','" & iiva & "','" & iporcentaje & "','" & iimporte &
            "','R','R')", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try

        Try ' Damos de alta en el libro de IVA
            Conexion.Open()
            consulta = New SqlCommand("Delete from LibroIVA where codfact ='" & sustituye & "' and tipo2='N';", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub

    Private Sub calcula(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellEndEdit
        Dim pvp, cant, importe As Double
        Dim linea As Integer
        Try
            linea = dg.Item(0, dg.CurrentRow.Index).Value
            pvp = CDbl(dg.Item(3, dg.CurrentRow.Index).Value.ToString)
            cant = CDbl(dg.Item(4, dg.CurrentRow.Index).Value.ToString)
            importe = pvp * cant
            'Formateamos la salida
            'dg.Item(6, dg.CurrentRow.Index).Value() = Format(importe, "N2")
            dg.Rows(linea - 1).Cells(6).Value = Format(importe, "N2")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class