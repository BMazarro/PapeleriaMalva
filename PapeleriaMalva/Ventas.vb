Imports System.Data.SqlClient

Public Class Ventas

    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New PapeleriaDataSet

    Private estado As Integer = 0
    Private fecha As Date = Date.Now        ' - Variable que contiene la fecha de hoy
    Public cant As Integer = 1
    Public numLinea As Integer = 1         ' - Variable Contador de lineas de albarán
    Private importetotal As Double = 0.0    ' - Variable Global para el importe total
    Private des As Double = 0.0             ' - Variable que uso para hacer calcular el descuento y sus cambios
    Private pep As Double = 0.0
    Dim Iiva As Integer                     ' - Variable Global para el IVA
    Dim c As Integer = 0                    ' - Variable que controla que la cabecera solo se inserte una vez
    Dim importeLinea As Double = 0.0        ' - Variable Global para el importe de linea
    Dim precio As Double = 0.0              ' - Variable Global para el precio de un producto
    Dim descuentoLinea As Double = 0.0      ' - Variable Global para el descuento en linea
    Dim facturado As String                 ' - Variable Global para el facturado (S/N)
    Dim porcentajeiva As Integer            ' - Variable Global para almacenar el porcentaje de Iva
    Dim formapago As Char                   ' - Variable Global para almacenar la Forma de Pago (1|2|3)
    Dim conreserva As String
    Dim ultimoregistro As Integer = 0
    Dim cadena As String
    Dim contador As Integer = 0
    Dim posicion As Integer = 0

    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ventana = 1
        Me.CenterToScreen()
        ' ----------------------------------------------------------------------------------------------------

        tbnumres.ReadOnly = True
        BotonesInactivos()
        bbuscarcli.Enabled = False
        bborrar.Enabled = False
        bmodificar.Enabled = False
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
            Iiva = CSng(ComboBox2.SelectedItem.ToString)

            ' Rellenamos el Combo del FormasPago
            consulta = New SqlCommand("SELECT nombre FROM FormasPago", Conexion)
            Mireader = consulta.ExecuteReader()
            While Mireader.Read()
                ComboBox1.Items.Add(Mireader("nombre").ToString)
            End While
            Mireader.Close()
            ComboBox1.SelectedIndex = 0
            ComboBox1.Enabled = False


            cadena = "SELECT COUNT(*) FROM VENTAS"
            consulta = New SqlCommand(cadena, Conexion)
            ultimoregistro = consulta.ExecuteScalar()   'Obtenemos la cantidad de registros
            Conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Mireader.Close()
            Conexion.Close()
        End Try
        If Not ultimoregistro = Nothing Then
            CargarEnPosicion(ultimoregistro - 1)
        End If
        cb1.Enabled = False
        cb2.Enabled = False
        SoloLectura()
        tcliente.ReadOnly = True
        bbuscar.Enabled = True
    End Sub

    ' CARGA EN LA POSICION INDICADA
    Private Sub CargarEnPosicion(ByVal pos As Integer)
        Try
            Conexion.Open()
            cadena = "SELECT * FROM VENTAS ORDER BY CODVENTA"
            consulta = New SqlCommand(cadena, Conexion)
            Mireader = consulta.ExecuteReader()
        Catch ex As Exception
            Conexion.Close()
        End Try
        Try
            pos = pos + 1
            contador = 0
            While (contador < pos)
                Mireader.Read()
                contador = contador + 1
            End While
            MostrarDatos()
            posicion = pos - 1
            Mireader.Close()
            Conexion.Close()
        Catch ex As Exception
            Conexion.Close()
        End Try
    End Sub

    Private Sub MostrarDatos()
        ' Mostramos la cabecera del albaran
        MostrarCabeceraPie()
        ' Mostramos el iva correspondiente
        BuscarItenIva()
        ' Mostramos la forma de pago
        BuscarItenFP()
        activa2()
        bsalir.Enabled = True
        bbuscarcli.Enabled = True
        ' Mostramos si el albaran está facturado o no
        ComprobarFacturacion()
        ' Mostramos si tiene reserva y cual es
        ComprobarReserva()
        BuscarReserva()
        If cb1.Checked = True Then
            bborrar.Enabled = False
            bmodificar.Enabled = False
            bfactura.Enabled = False
        End If
        ' Mostrar datos del cliente de este albaran
        MostrarDatosCliente2()
        ' Mostrar lineas de articulos de este albaran
        MostrarLineasArticulo()

    End Sub

    ' ------- BOTONES INACTIVOS AL INICIO DE LA APLICACION -----------
    Private Sub BotonesInactivos()
        bvertodos.Enabled = False
        blimpiar.Enabled = False
        bfactura.Enabled = False       ' - BOTON FACTURA DIRECTA
        baceptar.Enabled = False      ' - BOTON ACEPTAR 
        bcancelar.Enabled = False      ' - BOTON CANCELAR
        bimprimir.Enabled = False       ' - BOTON IMPRIMIR
        banadir.Enabled = False         ' - BOTON AÑADIR LINEA DE ALBARAN
        beliminar.Enabled = False         ' - BOTON CANCELAR LINEA DE ALBARAN
        bnomaslineas.Enabled = False        ' - BOTON NO MAS LINEAS DE ALBARAN
        bbuscarcli.Enabled = True     ' - BOTON BUSCAR CLIENTE
    End Sub

    ' ------- BOTONES ACTIVOS DESPUES DE BUSCAR EL CLIENTE -----------
    Private Sub BotonesActivos()
        bvertodos.Enabled = True
        blimpiar.Enabled = False
        bfactura.Enabled = False       ' - BOTON FACTURA DIRECTA
        baceptar.Enabled = False      ' - BOTON ACEPTAR 
        bcancelar.Enabled = True       ' - BOTON CANCELAR
        bimprimir.Enabled = False       ' - BOTON IMPRIMIR
        banadir.Enabled = False          ' - BOTON AÑADIR LINEA DE ALBARAN
        beliminar.Enabled = False         ' - BOTON CANCELAR LINEA DE ALBARAN
        bnomaslineas.Enabled = False         ' - BOTON NO MAS LINEAS DE ALBARAN
        bbuscarcli.Enabled = False     ' - BOTON BUSCAR CLIENTE
        bsalir.Enabled = False       ' - BOTON SALIR
    End Sub

    ' ------- MODO SOLO LECTURA PARA LOS TEXTBOX'S -------
    Private Sub SoloLectura()
        tobservaciones.Enabled = False            ' - TEXTBOX OBSERVACIONES A NOT ENABLED
        'tventa.ReadOnly = True            ' - TEXTBOX NUMERO DE VENTA
        tlinea.ReadOnly = True            ' - TEXTBOX LINEA
        tcodprod.ReadOnly = True            ' - TEXTBOX CODIGO ARTICULO
        tdescripcion.ReadOnly = True            ' - TEXTBOX DESCRIPCION
        tpvp.ReadOnly = True            ' - TEXTBOX PVP
        tcantidad.ReadOnly = True            ' - TEXTBOX CANTIDAD
        tdto.ReadOnly = True            ' - TEXTBOX DTO.LINEA
        timporte.ReadOnly = True            ' - TEXTBOX IMPORTE
        tobservaciones.ReadOnly = True            ' - TEXTBOX OBSERVACIONES

    End Sub

    Private Sub InhabilitaEL()
        tlinea.ReadOnly = True            ' - TEXTBOX LINEA
        tcodprod.ReadOnly = True           ' - TEXTBOX CODIGO ARTICULO
        tdescripcion.ReadOnly = True            ' - TEXTBOX DESCRIPCION
        tpvp.ReadOnly = True            ' - TEXTBOX PVP
        tcantidad.ReadOnly = True           ' - TEXTBOX CANTIDAD
        tdto.ReadOnly = True           ' - TEXTBOX DTO.LINEA
        timporte.ReadOnly = True
    End Sub

    ' -------- MODO ESCRITURA PARA LAS LINEAS DE ALBARAN --------
    Private Sub EscrituraLineas()
        tlinea.ReadOnly = True            ' - TEXTBOX LINEA
        tcodprod.ReadOnly = True           ' - TEXTBOX CODIGO ARTICULO
        tdescripcion.ReadOnly = True            ' - TEXTBOX DESCRIPCION
        tpvp.ReadOnly = True            ' - TEXTBOX PVP
        tcantidad.ReadOnly = False           ' - TEXTBOX CANTIDAD
        tdto.ReadOnly = False           ' - TEXTBOX DTO.LINEA
        timporte.ReadOnly = True            ' - TEXTBOX IMPORTE
    End Sub

    ' -------- MODO ESCRITURA PARA EL PIE ----------------------
    Private Sub EscrituraPie()
        ComboBox1.Enabled = True            ' - COMBOBOX1 ENABLED
        ComboBox2.Enabled = True            ' - COMBOBOX2 ENABLED
        tobservaciones.Enabled = True             ' - TEXTBOX OBSERVACIONES ENABLED
        tobservaciones.ReadOnly = False           ' - TEXTBOX OBSERVACIONES
        'TextBox10.ReadOnly = False          ' - TEXTBOX DESCUENTO
        'tbportes.ReadOnly = False           ' - TEXTBOX PORTES
    End Sub

        ' --------- LIMPIAR LA LINEA DE ARTICULOS ------
    Private Sub limpiarlinea()
        tlinea.Text = ""                  ' - TEXTBOX LINEA
        tcodprod.Text = ""                  ' - TEXTBOX CODIGO ARTICULO
        tdescripcion.Text = ""                  ' - TEXTBOX DESCRIPCION
        tpvp.Text = ""                  ' - TEXTBOX PVP
        tcantidad.Text = ""                  ' - TEXTBOX CANTIDAD
        tdto.Text = ""                  ' - TEXTBOX DTO.LINEA
        timporte.Text = ""                  ' - TEXTBOX IMPORTE
    End Sub

    ' -------- LIMPIA TODO EL ALBARÁN MENOS LINEAS DE ARTICULOS ---------
    Private Sub limpiar()
        baceptar.Enabled = False
        bsalir.Enabled = True
        banadir.Enabled = False
        beliminar.Enabled = False
        bnomaslineas.Enabled = False
        bvertodos.Enabled = False
        tcliente.Enabled = True
        tcliente.Text = ""
        'LabDes.Text = ""
        ldireccion.Text = ""
        lnif.Text = ""
        lnombre.Text = ""
        lcp.Text = ""
        llocalidad.Text = ""
        lprovincia.Text = ""
        ltfn.Text = ""
        'LabTar.Text = ""
        limporte.Text = ""
        liva.Text = ""
        ltotal.Text = ""
        tobservaciones.Text = ""

    End Sub

    Private Sub bbuscarcli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscarcli.Click
        tventa.ReadOnly = True
        Dim posicion As Integer
        tcliente.Focus()
        tdto.Text = Format(des, "N2")
        tpvp.Text = Format(pep, "N2")
        Try ' Abrimos la conexion
            Conexion.Open()

            ' Buscamos el codigo introducido y vemos en que posicion se encuentra
            consulta = New SqlCommand("Select codcli from Clientes where codcli='" &
                                      tcliente.Text & "';", Conexion)
            posicion = consulta.ExecuteScalar()   'Obtenemos la cantidad de registros que tiene hasta su posicion

            ' Si el valor devuelto no existe entonces volvemos al inicio de la aplicacion
            If posicion = Nothing Then

                If MessageBox.Show("Desea crear uno nuevo?", "El cliente no existe", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                        = DialogResult.Yes Then
                    ' Gestionamos el cierre de la ventana actual y la abertura de la nueva
                    Dim alta As New Clientes
                    alta.ShowDialog()
                Else
                    tcliente.Text = ""
                End If
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
                ' Habilitamos botones de las lineas de albaran
                BotonesActivos()
                ' Habilitamos la escritura en los campos del articulo de las lineas de albaran
                tcodprod.Enabled = True
                tcodprod.ReadOnly = True           ' - TEXTBOX CODIGO ARTICULO

                ' Damos color indicativo al campo codigo articulo
                tcodprod.BackColor = Color.LightBlue
                tcantidad.BackColor = Color.LightBlue
                dg.ClearSelection()
                Me.dg.Item(1, 0).Selected = True
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

    'Private Sub bbuscarprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim posicion As Integer
    '    tcodprod.ReadOnly = True
    '    tdto.Text = descuentoLinea.ToString
    '    tdto.ReadOnly = False
    '    tcantidad.ReadOnly = False
    '    ' Calculamos la linea correspondiente
    '    ' Calculamos la linea correspondiente
    '    For i = 0 To dg.RowCount - 1
    '        numLinea = i + 1
    '    Next
    '    tlinea.Text = numLinea.ToString
    '    tcliente.Enabled = False
    '    blimpiar.Enabled = True
    '    bvertodos.Enabled = True
    '    banadir.Enabled = True          ' - BOTON AÑADIR LINEA DE ALBARAN
    '    beliminar.Enabled = True          ' - BOTON CANCELAR LINEA DE ALBARAN
    '    bnomaslineas.Enabled = True         ' - BOTON NO MAS LINEAS DE ALBARAN
    '    EscrituraLineas()
    '    Try ' Abrimos la conexion
    '        Conexion.Open()

    '        If tcodprod.TextLength = 13 Then
    '            Try
    '                ' Buscamos los datos del articulo correspondiente al codigo introducido
    '                consulta = New SqlCommand("SELECT * from LIBROS where isbn='" &
    '                                          tcodprod.Text & "'", Conexion)
    '                posicion = consulta.ExecuteScalar
    '                If posicion = Nothing Then
    '                    If MessageBox.Show("Desea crear uno nuevo?", "El libro no existe", _
    '                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
    '                                        = DialogResult.Yes Then
    '                        ' Gestionamos el cierre de la ventana actual y la abertura de la nueva
    '                        Dim alta As New Libros
    '                        alta.ShowDialog()
    '                    Else
    '                        tcodprod.Text = ""
    '                    End If
    '                End If
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try

    '        Else
    '            ' Buscamos los datos del articulo correspondiente al codigo introducido
    '            consulta = New SqlCommand("SELECT * from Articulos where codart='" &
    '                                      tcodprod.Text & "'", Conexion)
    '            posicion = consulta.ExecuteScalar
    '            If posicion = Nothing Then
    '                If MessageBox.Show("Desea crear uno nuevo?", "El artículo no existe", _
    '                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
    '                                    = DialogResult.Yes Then
    '                    ' Gestionamos el cierre de la ventana actual y la abertura de la nueva
    '                    Dim alta As New Articulos
    '                    alta.ShowDialog()
    '                Else
    '                    tcodprod.Text = ""
    '                End If
    '            End If
    '        End If
    '        Mireader = consulta.ExecuteReader()
    '        Mireader.Read()
    '        ' Mostramos los datos
    '        'MostrarDatosProducto()
    '        ' Cerramos el DataReader y la conexion
    '        Mireader.Close()
    '        Conexion.Close()
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '        Mireader.Close()
    '    Finally
    '        If Conexion.State = ConnectionState.Open Then
    '            Conexion.Close()
    '        End If
    '    End Try
    'End Sub

    ' -------- MOSTRAR LOS DATOS DEL PRODUCTO ---------------------------
    Private Sub MostrarDatosProducto()
        Dim titulo, autores, editorial As String
        If tcodprod.TextLength = 13 Then
            titulo = Mireader("titulo").ToString
            autores = Mireader("autor").ToString
            editorial = Mireader("editorial").ToString
            tdescripcion.Text = titulo & "," & autores & "," & editorial
            tpvp.Text = Mireader("pvp").ToString
            tpvp.Text = Format(CDbl(tpvp.Text), "N2")
        Else
            ' Muestra la descripcion
            tdescripcion.Text = Mireader("descripcion").ToString
            ' Muestra el pvp
            tpvp.Text = Mireader("pvp").ToString
            tpvp.Text = Format(CDbl(tpvp.Text), "N2")
        End If
        tpvp.ReadOnly = False
    End Sub

    Private Sub tcantidad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcantidad.TextChanged
        If Not tcantidad.Text = "" Then
            Dim pvp, cant As Double
            pvp = CDbl(tpvp.Text)
            cant = CDbl(tcantidad.Text)
            importeLinea = pvp * cant
            'Formateamos la salida
            timporte.Text = Format(importeLinea, "N2")
        Else

        End If
    End Sub


    Private Sub tdto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdto.TextChanged
        'Dim precio As Double
        Dim cant As Double
        Dim desc As Double
        If Not tcantidad.Text = "" Then
            cant = CDbl(tcantidad.Text)
        End If

        Try ' Controlamos el precio
            If Not tpvp.Text = "" Then
                precio = tpvp.Text
            Else
                precio = 0.0
            End If
            ' Controlamos el descuento
            If Not tdto.Text = "" Then
                descuentoLinea = CDbl(tdto.Text)
                desc = (cant * precio) * (descuentoLinea / 100)
            Else
                desc = 0.0
                descuentoLinea = 0.0
            End If
            importeLinea = (cant * precio) - desc
            ' Formateamos la salida
            timporte.Text = Format(importeLinea, "N2")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub banadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles banadir.Click
        InhabilitaEL()
        If estado = 1 Then
            ' Inhabilitamos a partir de ahora el codigo del cliente, ya no se puede cambiar 
            tcliente.Enabled = False
            ' Inabilitamos la direccion de entrega, ya no se puede cambiar
            If Not tcodprod.Text = "" And Not tcantidad.Text = "" And Not tdto.Text = "" Then
                Try ' Abrimos la conexion
                    Conexion.Open()
                    ' Añadimos la linea al DataGrid
                    dg.Rows.Add(tlinea.Text, tcodprod.Text, tdescripcion.Text, tpvp.Text, tcantidad.Text, Format(CDbl(tdto.Text), "N2"), timporte.Text)

                    ' Insertamos la cabecera. Controlamos con la variable c que solo se inserte una vez
                    If (c = 0) Then
                        consulta =
                            New SqlCommand("INSERT INTO Ventas(codventa,codcli,facturado,conreserva)" &
                        " values(" & "'" & tventa.Text & "'" & "," & "'" & tcliente.Text & "'" & "," & "'N'" & "," & "'N'" & ")", Conexion)
                        consulta.ExecuteNonQuery()
                        c = 1
                    End If

                    ' Insertamos la linea introducida
                    consulta =
                        New SqlCommand("INSERT INTO LineasVenta(codventa,numlinea,codprod,descripcion,pvp,cantidad,dtolinea,importe)" &
                         " values(" & "'" & tventa.Text & "'" & "," & "'" & numLinea & "'" &
                         "," & "'" & tcodprod.Text & "'" & "," & "'" & tdescripcion.Text & "'" &
                         "," & tpvp.Text.Replace(".", "").Replace(",", ".") & "," & tcantidad.Text.Replace(",", ".") &
                         "," & tdto.Text.Replace(",", ".") & "," & timporte.Text.Replace(".", "").Replace(",", ".") & ")", Conexion)

                    consulta.ExecuteNonQuery()
                    'MsgBox("Línea guardada")

                    ' Cerramos la conexion
                    Conexion.Close()

                Catch ex As Exception
                    Conexion.Close()
                End Try

                ' Recalculamos el stock de los articulos pedidos

                Try
                    Conexion.Open()
                    If tcodprod.TextLength = 13 Then
                        consulta = New SqlCommand("UPDATE LIBROS set stock = stock - " & _
                                             CInt(tcantidad.Text) & " where isbn = '" & tcodprod.Text & "';", Conexion)
                    Else
                        consulta = New SqlCommand("UPDATE Articulos set stock = stock - " & _
                                             CInt(tcantidad.Text) & " where codart = '" & tcodprod.Text & "';", Conexion)
                    End If

                    consulta.ExecuteNonQuery()
                    Conexion.Close()
                Catch ex As Exception
                    Conexion.Close()
                End Try

                ' Limpiamos las lineas 
                limpiarlinea()

            Else
                MsgBox("Debe introducir el código y la cantidad")
            End If
            numLinea = numLinea + 1
        End If

        If estado = 3 Then
            ' Calculamos la linea correspondiente
            For i = 0 To dg.RowCount - 1
                numLinea = i + 1
            Next

            ' Inhabilitamos a partir de ahora el codigo del albaran, ya no se puede cambiar 
            tcliente.Enabled = False

            ' Controlamos que se haya introducido una cantidad
            If Not tcodprod.Text = "" And Not tcantidad.Text = "" And Not tdto.Text = "" Then
                Try ' Abrimos la conexion
                    Conexion.Open()

                    ' Añadimos la linea al DataGrid
                    dg.Rows.Add(numLinea, tcodprod.Text, tdescripcion.Text, tpvp.Text, tcantidad.Text, Format(CDbl(tdto.Text), "N2"), timporte.Text)

                    ' Cerramos la conexion
                    Conexion.Close()

                Catch ex As Exception
                    Conexion.Close()
                End Try

                ' Recalculamos el stock de los articulos pedidos
                Try
                    Conexion.Open()
                    If tcodprod.TextLength = 13 Then
                        consulta = New SqlCommand("UPDATE LIBROS set stock = stock - " & _
                                             CInt(tcantidad.Text) & " where isbn = '" & tcodprod.Text & "';", Conexion)
                    Else
                        consulta = New SqlCommand("UPDATE Articulos set stock = stock - " & _
                                             CInt(tcantidad.Text) & " where codart = '" & tcodprod.Text & "';", Conexion)
                    End If

                    consulta.ExecuteNonQuery()
                    Conexion.Close()
                Catch ex As Exception
                    Conexion.Close()
                End Try

                ' Limpiamos las lineas 
                limpiarlinea()
            Else
                MsgBox("Debe introducir una cantidad")
            End If
        End If
    End Sub

    Private Sub beliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beliminar.Click

        If estado = 1 Then
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

                consulta = New SqlCommand("DELETE FROM LINEASVENTA WHERE CODVENTA='" & tventa.Text & "' and NUMLINEA='" & linea & "';", Conexion)
                consulta.ExecuteNonQuery()

                Conexion.Close()
                ' Borramos la fila seleccionada
                dg.Rows.Remove(dg.CurrentRow)
            Catch ex As Exception
                Conexion.Close()
            End Try
        End If

        If estado = 3 Then
            Dim cant As Integer
            Dim cod As String
            Dim linea As String
            Try
                ' Tomamos la cantidad de ese articulo
                cant = dg.Item(4, dg.CurrentRow.Index).Value
                ' Tomamos el codigo del articulo seleccionado
                cod = CStr(dg.Item(1, dg.CurrentRow.Index).Value.ToString)
                ' Tomamos la linea del articulo seleccionado para borrar
                linea = dg.Item(0, dg.CurrentRow.Index).Value.ToString
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

                'Borramos la fila seleccionada
                dg.Rows.Remove(dg.CurrentRow)
            Catch ex As Exception
                dg.Rows.Remove(dg.CurrentRow)
            End Try
        End If
    End Sub

    Private Sub bnomaslineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnomaslineas.Click
        If estado = 1 Then
            CalcularImportes()
        End If
        If estado = 3 Then
            CalcularImportes2()
        End If
        ' Habilitamos los controles del pie
        EscrituraPie()
        ' Asignamos el descuento correspondiente a ese cliente
        'TextBox10.Text = LabDes.Text
        ' Calculamos el descuento que se le restará y lo formateamos
        'des = (TextBox10.Text / 100) * Label19.Text
        'Label17.Text = Format(des, "N2")
        ' ----------------------------------------------------------------------------
        ' Inhabilitamos las lineas del albarán para que no se puedan introducir datos
        tlinea.Enabled = False
        tcodprod.Enabled = False
        tdescripcion.Enabled = False
        tcantidad.Enabled = False
        tpvp.Enabled = False
        tdto.Enabled = False
        timporte.Enabled = False
        ' ----------------------------------------------------------------------------
        ' Inhabilitamos los botones correspondientes a las lineas del albarán
        blimpiar.Enabled = False
        bvertodos.Enabled = False
        banadir.Enabled = False
        beliminar.Enabled = False
        bnomaslineas.Enabled = False
        tpvp.ReadOnly = True
    End Sub

    Public Sub CalcularImportes2()
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

    ' ------- CALCULAR IMPORTES --------------
    Private Sub CalcularImportes()
        Dim a, b As Double
        Dim imponible As Double
        Conexion.Open()
        consulta = New SqlCommand("SELECT SUM(IMPORTE) FROM LINEASVENTA WHERE CODVENTA='" &
                                     tventa.Text & "'", Conexion)
        Mireader = consulta.ExecuteReader()
        Mireader.Read()
        limporte.Text = Mireader(0).ToString()
        limporte.Text = Format(CDbl(limporte.Text), "N2")
        'limporte.Text = String.Format("{0:N2}", importetotal)
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

    Private Sub tcliente_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcliente.TextChanged
        bbuscarcli.Enabled = True
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ' Variables del evento
        Dim imponible As Double
        Dim a As Double
        Dim b As Double

        ' Controlamos que exista un valor en el importe y los portes no este vacios
        If Not limporte.Text = "" Then
            ' Calculamos la base imponible y formateamos la salida
            imponible = CDbl(limporte.Text)
            ' Obtenemos el valor del IVA
            Dim iva = CSng(ComboBox2.SelectedItem)
            ' Calculamos lo que hay que sumarle de IVA
            a = CDbl(iva / 100) * imponible
            liva.Text = Format(a, "N2")
            ' Sumamos la base imponible y el IVA correspondiente
            b = a + imponible
            ' Formateamos la salida y lo asignamos al TOTAL
            ltotal.Text = Format(b, "N2")
            ' Asignamos el nuevo IVA a su variable GLOBAL. Se inicializó al rellenar el Combo
            Iiva = iva
        End If
    End Sub

    Private Sub bcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcancelar.Click
        If estado = 1 Then      ' Proviene de cancelar una venta
            ' Inhabilitamos el boton CANCELAR
            bcancelar.Enabled = False
            SoloLectura()
            ' Limpiamos el DataGrid, las lineas de articulos, y el albaran entero
            dg.Rows.Clear()
            limpiarlinea()
            limpiar()
            ' Borramos de la base de datos las lineas de articulo dadas de alta
            BorrarLineasVenta()
            ' Borramos de la base de datos la parte de la cabecera que habiamos dado de alta. 
            ' Habiamos guardado el codigo del albaran, el codigo del cliente y facturado=N
            BorrarCabeceraAlbaran()
            ' Inicializamos el numero de lineas de articulo a 1
            numLinea = 1
            ' Inicializamos el importetotal a 0
            importetotal = 0
            tventa.Enabled = True
            tventa.Text = ""
            Ventas_Load(sender, e)
        End If
        If estado = 3 Then      ' Proviene de cancelar una modificacion
            'dg.Rows.Clear()
            'limpiar()
            'limpiarlinea()
            'tventa.Enabled = True
            'tventa.Text = ""
            'Ventas_Load(sender, e)
            bimprimir.Enabled = True
            bfactura.Enabled = True
            bbuscar.Enabled = True
            baceptar.Enabled = False
            bcancelar.Enabled = False
            bborrar.Enabled = True
            bverres.Enabled = True
        End If

    End Sub

    ' ------- BORRAR CABECERA DEL ALBARÁN -----------------------------------------------------------------------------
    Private Sub BorrarCabeceraAlbaran()
        ' Borramos codventa, codcli y facturado del albaran
        Try
            Conexion.Open()
            consulta = New SqlCommand("Delete from Ventas where codventa ='" & tventa.Text & "';", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
        End Try
        'MsgBox("Datos de la cabecera del albaran borrados de la base de datos")
    End Sub


    ' -------- BORRAR LAS LINEAS DE ARTICULOS -------------------------------
    Private Sub BorrarLineasVenta()

        Dim contador As Integer
        Dim i As Integer = 1

        ' Primero calculamos cuantas lineas tiene este albaran
        Try
            Conexion.Open()
            consulta = New SqlCommand("Select count(codventa) from LineasVenta where codventa='" & tventa.Text & "';", Conexion)
            contador = consulta.ExecuteScalar
            Conexion.Close()
            'MsgBox("Este albaran contiene " & contador & " lineas de venta")
        Catch ex As Exception
        End Try

        ' Recorremos cada fila y por cada una, obtenemos el codigo del articulo y la cantidad que se ha pedido
        While i <= contador
            Dim cant As Integer = 0
            Dim codigoproducto As String = ""
            ' Calcula la cantidad de articulos
            Try
                Conexion.Open()
                consulta = New SqlCommand("Select cantidad, codprod from LineasVenta where codventa = " & tventa.Text &
                    " and numlinea = " & i & ";", Conexion)
                Mireader = consulta.ExecuteReader()
                Mireader.Read()
                cant = CInt(Mireader("cantidad").ToString)      ' Cantidad de este articulo
                codigoproducto = Mireader("codprod").ToString    ' Codigo de este articulo
                Conexion.Close()
                Mireader.Close()
                'MsgBox("ha cogido la cantidad y el producto")
            Catch ex As Exception
                'MsgBox(ex.Message)
                Conexion.Close()
            End Try

            ' Recalculamos el stock de cada articulo
            Try
                If Not codigoproducto = "" Then
                    Conexion.Open()
                    If codigoproducto.Length = 13 Then
                        consulta = New SqlCommand("UPDATE LIBROS set stock = stock + " & _
                                             cant & " where isbn = '" & codigoproducto & "';", Conexion)
                    Else
                        consulta = New SqlCommand("UPDATE Articulos set stock = stock + " & _
                                             cant & " where codart = '" & codigoproducto & "';", Conexion)
                    End If
                    consulta.ExecuteNonQuery()
                    Conexion.Close()
                End If
            Catch ex As Exception
                Conexion.Close()
            End Try
            i = i + 1
        End While

        ' Borramos las lineas del albaran
        Try
            Conexion.Open()
            consulta = New SqlCommand("Delete from LineasVenta where codventa ='" & tventa.Text & "';", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        'MsgBox("Datos de lineas de venta borrados de la base de datos")
    End Sub

    Private Sub baceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baceptar.Click
        If estado = 1 Then
            Try ' Abrimos la conexion
                Conexion.Open()

                ' LA CABECERA DEL ALBARAN SE INSERTÓ CON ALGUNOS VALORES AL INSERTAR LINEAS DE ARTICULOS
                ' ACTUALIZAMOS LOS CAMPOS QUE FALTAN EN LA CABECERA
                consulta =
                    New SqlCommand("UPDATE VENTAS SET fecha = '" & dtp.Text & "'," &
                                   " baseimponible = " & limporte.Text.Replace(".", "").Replace(",", ".") & "," &
                                   " iva = " & liva.Text.Replace(",", ".") & "," &
                                   " importe = " & ltotal.Text.Replace(".", "").Replace(",", ".") & "," &
                                   " formapago = '" & CStr(ComboBox1.SelectedIndex + 1) & "'," &
                                   " observaciones ='" & tobservaciones.Text & "'" &
                                   " where codventa ='" & tventa.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' INTRODUZCO EL PORCENTAJE POR SEPARADO PORQUE ME DIÓ PROBLEMAS
                consulta = New SqlCommand("UPDATE Ventas SET porcentajeiva = " & CInt(ComboBox2.SelectedItem.ToString) &
                                  " where codventa ='" & tventa.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                'MsgBox("Alta Albarán")

                ' Cerramos la conexion
                Conexion.Close()

                ' Inhabilitamos los botones ACEPTAR Y CANCELAR
                ' Habilitamos los botones IMPRIMIR Y SALIR 
                bsalir.Enabled = True
                baceptar.Enabled = False
                bcancelar.Enabled = False
                bimprimir.Enabled = True
                bfactura.Enabled = True
                bbuscar.Enabled = True
                bborrar.Enabled = True
                bverres.Enabled = True
                'limpiarlinea()
                'limpiar()
                'dg.Rows.Clear()
            Catch ex As Exception
                ' MsgBox(ex.Message)
                Conexion.Close()
            End Try
        End If

        If estado = 3 Then
            Dim i As Integer = 0
            Dim n As Integer
            Dim codart As String
            Dim descripcion As String
            Dim pvp, dtolinea, importe As Double
            Dim cantidad, numlinea As Integer

            Try ' Eliminamos las lineas de albaran de la bbdd
                Conexion.Open()
                consulta = New SqlCommand("Delete from LineasVenta where codventa='" & tventa.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                Conexion.Close()
            Catch ex As Exception
                Conexion.Close()
            End Try

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
                    consulta = New SqlCommand("Insert into LineasVenta(codventa,numlinea,codprod,descripcion,pvp,cantidad,dtolinea,importe) values ('" &
                                              tventa.Text & "','" &
                                              numlinea & "','" &
                                              codart & "','" &
                                              descripcion & "'," & Replace(pvp, ",", ".") & "," & cantidad & "," &
                                              Replace(dtolinea, ",", ".") & "," & Replace(importe, ",", ".") & ")", Conexion)
                    consulta.ExecuteNonQuery()
                    Conexion.Close()
                    i = i + 1
                End While
            Catch ex As Exception
                Conexion.Close()
            End Try

            Try ' Actualizamos el pie del albaran

                Conexion.Open()
                consulta =
                    New SqlCommand("UPDATE VENTAS SET fecha = '" & dtp.Text & "'," &
                                   " baseimponible = " & limporte.Text.Replace(".", "").Replace(",", ".") & "," &
                                   " iva = " & liva.Text.Replace(",", ".") & "," &
                                   " importe = " & ltotal.Text.Replace(".", "").Replace(",", ".") & "," &
                                   " formapago = '" & CStr(ComboBox1.SelectedIndex + 1) & "'," &
                                   " observaciones ='" & tobservaciones.Text & "'" &
                                   " where codventa ='" & tventa.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' INTRODUZCO EL PORCENTAJE POR SEPARADO PORQUE ME DIÓ PROBLEMAS
                consulta = New SqlCommand("UPDATE Ventas SET porcentajeiva = " & CInt(ComboBox2.SelectedItem.ToString) &
                                  " where codventa ='" & tventa.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' Cerramos la conexion
                Conexion.Close()

            Catch ex As Exception
                Conexion.Close()
            End Try
            bimprimir.Enabled = True
            bfactura.Enabled = True
            bbuscar.Enabled = True
            baceptar.Enabled = False
            bcancelar.Enabled = False
            bborrar.Enabled = True
            bverres.Enabled = True
        End If

    End Sub


    Private Sub bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsalir.Click
        Me.Close()
    End Sub

    Private Sub bvertodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bvertodos.Click
        Dim b As New Productos
        AddHandler b.Closed, AddressOf b_Closed
        b.Show()
        blimpiar.Enabled = True
        banadir.Enabled = True          ' - BOTON AÑADIR LINEA DE ALBARAN
        beliminar.Enabled = True          ' - BOTON CANCELAR LINEA DE ALBARAN
        bnomaslineas.Enabled = True         ' - BOTON NO MAS LINEAS DE ALBARAN
        EscrituraLineas()
        tlinea.Enabled = True
        tcodprod.Enabled = True
        tdescripcion.Enabled = True
        tpvp.Enabled = True
        tcantidad.Enabled = True
        tdto.Enabled = True
        timporte.Enabled = True
        tcantidad.ReadOnly = False
    End Sub

    Private Sub b_Closed(ByVal sender As Object, ByVal e As System.EventArgs)
        tcodprod.Text = codproducto.ToString
        tdto.Text = descuentoLinea
        Dim titulo, autores, editorial As String
        If tcodprod.TextLength = 13 Then                ' es un libro
            titulo = titulolibro.ToString
            autores = autorlibro.ToString
            editorial = editoriallibro.ToString
            tdescripcion.Text = titulo & "," & autores & "," & editorial
            tpvp.Text = Format(CDbl(pvplibro.ToString), "N2")
        Else                                            ' es un articulo
            'Muestra la descripcion
            tdescripcion.Text = descripcionart.ToString
            'Muestra el pvp
            tpvp.Text = Format(CDbl(pvpart.ToString), "N2")
        End If
        ' Calculamos la linea correspondiente
        For i = 0 To dg.RowCount - 1
            numLinea = i + 1
        Next
        tlinea.Text = numLinea.ToString
        tpvp.ReadOnly = False
    End Sub

    Private Sub bimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bimprimir.Click
        ' Creamos una nueva conexion
        Dim Conexion2 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        ' Creamos un Visor
        Dim visor As New Visor
        ' Creamos un dataset
        Dim dataset As New PapeleriaDataSet
        ' Creamos un Listado para Albaranes
        Dim listado As New Albaran
        ' Creamos un DataAdapter
        Dim da1 As SqlClient.SqlDataAdapter


        ' Creamos las consultas y rellenamos el dataset 
        da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Ventas WHERE Ventas.codventa= '" & tventa.Text & "';", Conexion2)
        da1.Fill(dataset, "ventas")
        da1 = New SqlClient.SqlDataAdapter("SELECT  Lineasventa.* FROM LineasVenta WHERE LineasVenta.codventa = '" & tventa.Text & "';", Conexion2)
        Try
            da1.Fill(dataset, "lineasventa")
        Catch ex As System.Data.ConstraintException
            da1.Fill(dataset, "lineasventa")
        End Try

        da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Clientes WHERE Clientes.codcli = '" & tcliente.Text & "';", Conexion2)
        da1.Fill(dataset, "CLIENTES")
        da1 = New SqlClient.SqlDataAdapter("SELECT FormasPago.* FROM FormasPago, Ventas WHERE Ventas.formapago = FormasPago.tipo and Ventas.codventa= '" & tventa.Text & "';", Conexion2)
        Try
            da1.Fill(dataset, "FORMASPAGO")
        Catch ex As System.Data.ConstraintException
            da1.Fill(dataset, "FORMASPAGO")
        End Try
        da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Empresa;", Conexion2)
        da1.Fill(dataset, "EMPRESA")
        '---Cerramos la conexion 
        Conexion2.Close()

        'Mostramos los parámetros de los datos de Empresa
        'listado.SetParameterValue("nombre", razon.ToString)
        'listado.SetParameterValue("domicilio", domicilio.ToString)
        'listado.SetParameterValue("localidad", localidad.ToString)
        'listado.SetParameterValue("provincia", provincia.ToString)
        'listado.SetParameterValue("cp", cp.ToString)
        'listado.SetParameterValue("nif", nif.ToString)
        'listado.SetParameterValue("telefono", telefono.ToString)

        ' Preparamos el Visor 
        visor.CrViewer.ReportSource = listado
        listado.SetDataSource(dataset)

        ' Mostramos el Visor
        visor.Show()

    End Sub


    Private Sub bfactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bfactura.Click
        Dim cant As Integer = 0
        Dim contador As Integer = 0
        Dim codigoF As String
        ' Calcula la cantidad de facturas
        Try
            Conexion.Open()
            ' Obtenemos el Nº de Factura contando los registros que hay en la BD
            consulta = New SqlCommand("Select count(codfact) from Facturas", Conexion)
            contador = consulta.ExecuteScalar() ' Devuelve un número
            codigoF = (contador + 1).ToString
            Conexion.Close()
            'MsgBox("Hay " & contador & " facturas")
        Catch ex As Exception
            Conexion.Close()
        End Try

        Try  ' Damos de alta la cabecera de la factura
            Conexion.Open()
            consulta = New SqlCommand("Insert into Facturas (codfact,fecha,codcli,baseimponible,porcentajeiva,iva,total,formapago," &
                "observaciones,direccion,impreso,sustituida,codventa)" & " values('" & codigoF & "','" &
                dtp.Text & "','" & tcliente.Text & "'," & limporte.Text.Replace(".", "").Replace(",", ".") & "," &
                CInt(ComboBox2.SelectedItem.ToString) & "," &
                    liva.Text.Replace(",", ".") & "," &
                    ltotal.Text.Replace(".", "").Replace(",", ".") & ",'" &
                CStr(ComboBox1.SelectedIndex + 1) & "','" &
                tobservaciones.Text & "','" & ldireccion.Text & "'," & "'N'" & ",'" & "" & "','" & tventa.Text & "');", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
            'MsgBox("Factura dada de alta")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try

        Try 'Damos de alta el cuerpo de la factura
            Conexion.Open()
            consulta = New SqlCommand("Insert into LineasFactura Select * from LineasVenta where codventa = '" & tventa.Text & "'", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
            'MsgBox("LineasFactura dada de alta")
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try

        Try  ' Actualizamos el codigo de factura de las lineas
            Conexion.Open()
            consulta = New SqlCommand("Update LineasFactura set codfact = '" & codigoF & "' where codfact = '" & tventa.Text & "'", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try

        Try ' Ponemos el albaran como facturado
            Conexion.Open()
            consulta = New SqlCommand("Update Ventas set facturado = 'S' where codventa = '" & tventa.Text & "'", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try

        'Dar de alta la factura en el libro de iva
        Dim icodfactura, ifecha, icodcli, ibases, iiva, iimporte, inombre, inif, ibanco, icuenta, iporcentaje As String
        iimporte = "0"
        Try ' Obtenemos los datos de la factura
            Conexion.Open()
            consulta = New SqlCommand("Select codfact,fecha,codcli,baseimponible,porcentajeiva,iva,total from Facturas where codfact ='" & codigoF & "'", Conexion)
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
            "','R','N')", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try

        Try
            Conexion.Open()
            consulta = New SqlCommand("Update Reservas set entregado='S' where codventa='" & tventa.Text & "';", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            Conexion.Close()
        Finally
            Conexion.Close()
        End Try

        If MessageBox.Show("Desea imprimir la factura?", "Advertencia", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                        = DialogResult.Yes Then
            ' Creamos una nueva conexion
            Dim Conexion2 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
            ' Creamos un Visor
            Dim visor As New Visor
            ' Creamos un dataset
            Dim dataset As New PapeleriaDataSet
            ' Creamos un Listado para Albaranes
            Dim listado As New Factura
            ' Creamos un DataAdapter
            Dim da1 As SqlClient.SqlDataAdapter


            ' Creamos las consultas y rellenamos el dataset 
            da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Facturas WHERE Facturas.codfact= '" & codigoF & "';", Conexion2)
            da1.Fill(dataset, "FACTURAS")
            da1 = New SqlClient.SqlDataAdapter("SELECT LineasFactura.* FROM LineasFactura WHERE LineasFactura.codfact = '" & codigoF & "';", Conexion2)

            Try
                da1.Fill(dataset, "LINEASFACTURA")
            Catch ex As System.Data.ConstraintException
                da1.Fill(dataset, "LINEASFACTURA")
            End Try

            da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Clientes WHERE Clientes.codcli = '" & tcliente.Text & "';", Conexion2)
            da1.Fill(dataset, "CLIENTES")
            da1 = New SqlClient.SqlDataAdapter("SELECT FormasPago.* FROM FormasPago, FacturaS WHERE Facturas.formapago = FormasPago.tipo and Facturas.codfact= '" & codigoF & "';", Conexion2)
            Try
                da1.Fill(dataset, "FORMASPAGO")
            Catch ex As System.Data.ConstraintException
                da1.Fill(dataset, "FORMASPAGO")
            End Try
            da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Empresa;", Conexion2)
            da1.Fill(dataset, "EMPRESA")
            '---Cerramos la conexion 
            Conexion2.Close()

            ' Preparamos el Visor 
            visor.CrViewer.ReportSource = listado
            listado.SetDataSource(dataset)

            ' Mostramos el Visor
            visor.Show()
            


            'Mostramos los parámetros de los datos de Empresa
            'listado.SetParameterValue("nombre", razon.ToString)
            'listado.SetParameterValue("domicilio", domicilio.ToString)
            'listado.SetParameterValue("localidad", localidad.ToString)
            'listado.SetParameterValue("provincia", provincia.ToString)
            'listado.SetParameterValue("cp", cp.ToString)
            'listado.SetParameterValue("nif", nif.ToString)
            'listado.SetParameterValue("telefono", telefono.ToString)


            ' Ponemos la factura impresa
            Try
                Conexion.Open()
                consulta = New SqlCommand("Update Facturas set impreso = 'S' where codfact = '" & codigoF & "'", Conexion)
                consulta.ExecuteNonQuery()
                Conexion.Close()
            Catch ex As Exception
            Finally
                Conexion.Close()
            End Try
        End If

        ' Inhabilitamos el boton factura 
        bfactura.Enabled = False
     
    End Sub

    ' BOTON NUEVA VENTA
    Private Sub bnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnuevo.Click
        cb1.Checked = False
        cb2.Checked = False
        tbnumres.Text = ""
        c = 0
        estado = 1
        Dim contador As Integer         ' - Variable que cuenta la cantidad de albaranes que hay dados de alta
        Dim num As Integer = 1
        tcliente.ReadOnly = False
        tventa.ReadOnly = False
        ' Ponemos el foco en el codigo del cliente a buscar
        tcliente.Focus()
        tcliente.BackColor = Color.Aquamarine
        ' Inicializamos la fecha de hoy
        'Labfe.Text = fecha
        bbuscarcli.Enabled = True
        ' Solo lectura para los textbox's
        SoloLectura()
        ' Limpiamos el DataGrid, las lineas de articulos, y el albaran entero
        dg.Rows.Clear()
        limpiarlinea()
        limpiar()
        ' Desactivar botones
        BotonesInactivos()
        bverres.Enabled = False
        bbuscar.Enabled = False
        bcancelar.Enabled = True
        Dim position As Integer
        Dim sigue As Boolean = True
        Try ' Abrimos conexion --------------------------------------------------------
            Conexion.Open()

            ' Obtenemos el Nº de Albarán contando los registros que hay en la BD
            consulta = New SqlCommand("Select count(codventa) from Ventas", Conexion)
            contador = consulta.ExecuteScalar() ' Devuelve un número
            If contador = 0 Then
                tventa.Text = num.ToString
            Else
                While sigue = True
                    consulta = New SqlCommand("Select codventa from Ventas where codventa='" & (contador + 1) & "';", Conexion)
                    position = consulta.ExecuteScalar() ' Devuelve un conjunto de registros
                    If position = Nothing Then

                        tventa.Text = (contador + 1).ToString
                        sigue = False
                    Else
                        contador = contador + 1
                    End If
                End While

            End If

            

            '- Cerramos conexion
            Conexion.Close()
            ' -----------------------------------------------------------------------

            ' Limpiamos el DataGrid y lo inicializamos para que marque el campo Codigo
            dg.ClearSelection()
            Me.dg.Item(1, 0).Selected = True    ' Campo Codigo = columan 1, fila 0

        Catch ex As Exception
            'MsgBox(ex.Message)
            'MsgBox("No se ha podido establecer la conexión")
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub

    Private Sub bbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscar.Click
        estado = 2
        Dim b1 As New Busquedas
        AddHandler b1.Closed, AddressOf b1_Closed
        b1.Show()
    End Sub

    Private Sub b1_Closed(ByVal sender As Object, ByVal e As System.EventArgs)
        tbnumres.Text = ""
        bverres.Enabled = False
        dg.Rows.Clear()
        Try ' Abrimos la conexion
            Conexion.Open()
            ComboIva()
            ComboFormasPago()

            ' Intentamos buscar en la base de datos el albaran correspondiente
            consulta = New SqlCommand("SELECT * FROM Ventas WHERE codventa='" & cv & "';", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            ' Mostramos la cabecera del albaran
            MostrarCabeceraPie()
            ' Mostramos el iva correspondiente
            BuscarItenIva()
            ' Mostramos la forma de pago
            BuscarItenFP()
            activa2()
            ' Mostramos si el albaran está facturado o no
            ComprobarFacturacion()
            ' Mostramos si tiene reserva y cual es
            ComprobarReserva()
            BuscarReserva()
            If cb1.Checked = True Then
                bborrar.Enabled = False
                bmodificar.Enabled = False
                bfactura.Enabled = False
            End If
            ' Mostrar datos del cliente de este albaran
            MostrarDatosCliente2()
            ' Mostrar lineas de articulos de este albaran
            MostrarLineasArticulo()

            'Cerramos la conexion y el datareader
            Conexion.Close()
            Mireader.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    ' Buscamos la reserva y la mostramos, si tiene
    Private Sub BuscarReserva()
        'Dim r As String
        Try
            Conexion.Open()
            consulta = New SqlCommand("SELECT Reservas.codres FROM Reservas,Ventas WHERE Ventas.codventa='" & tventa.Text & "' and Ventas.codventa=Reservas.codventa;", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            tbnumres.Text = Mireader(0).ToString

            Mireader.Close()
            Conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            Mireader.Close()
            Conexion.Close()
        End Try
    End Sub

    ' ------- MOSTRAMOS LAS LINEAS DE ARTICULOS DEL ALBARAN ------------------------------------------------------------
    Private Sub MostrarLineasArticulo()
        Dim contadorF As Integer
        Dim n As Integer = 0          ' Variable a usar en el while de las filas 
        Dim i As Integer
        Dim aux As String
        Try
            ' Abrimos la conexion
            Conexion.Open()
            ' Obtenemos la cantidad de lineas que corresponden a este albaran
            consulta = New SqlCommand("Select count(*) from LineasVenta where codventa='" & tventa.Text & "';", Conexion)
            contadorF = consulta.ExecuteScalar()
            ' Buscamos en la base de datos los datos de los articulos correspondientes
            consulta = New SqlCommand("SELECT * FROM LineasVenta WHERE codventa='" & tventa.Text & "';", Conexion)
            Mireader = consulta.ExecuteReader()
            dg.Rows.Clear()
            While Mireader.Read
                dg.Rows.Add()
                dg.Rows(n).Cells(0).Value = Mireader("numlinea").ToString
                dg.Rows(n).Cells(1).Value = Mireader("codprod").ToString
                dg.Rows(n).Cells(2).Value = Mireader("descripcion").ToString
                aux = Mireader("pvp").ToString
                aux = Format(CDbl(aux), "N2")
                dg.Rows(n).Cells(3).Value = aux
                dg.Rows(n).Cells(4).Value = Mireader("cantidad").ToString
                aux = Mireader("dtolinea").ToString
                aux = Format(CDbl(aux), "N2")
                dg.Rows(n).Cells(5).Value = aux
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
            ' MsgBox(ex.Message)
            Conexion.Close()
            Mireader.Close()
        End Try

    End Sub

    ' -------- MUESTRA LOS DATOS DE LA CABECERA Y EL PIE DEL ALBARAN -------------
    Private Sub MostrarCabeceraPie()
        tventa.Text = Mireader("codventa").ToString
        tcliente.Text = Mireader("codcli").ToString
        facturado = Mireader("facturado").ToString
        dtp.Text = Mireader("fecha").ToString
        conreserva = Mireader("conreserva").ToString
        limporte.Text = Format(CDbl(Mireader("baseimponible").ToString), "N2")
        liva.Text = Format(CDbl(Mireader("iva").ToString), "N2")
        ltotal.Text = Format(CDbl(Mireader("importe").ToString), "N2")
        porcentajeiva = CInt(Mireader("porcentajeiva").ToString)
        formapago = Mireader("formapago").ToString
        tobservaciones.Text = Mireader("observaciones").ToString

        Conexion.Close()
        Mireader.Close()

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

    ' -------- CONTROLA EL CHECKBOX QUE MUESTRA EL ESTADO DE LA FACTURACION -------
    Private Sub ComprobarFacturacion()
        If facturado = "N" Then
            cb1.Checked = False
        ElseIf facturado = "S" Then
            cb1.Checked = True
        End If

    End Sub

    Private Sub ComprobarReserva()
        If conreserva = "N" Then
            cb2.Checked = False
        ElseIf conreserva = "S" Then
            cb2.Checked = True
        End If
    End Sub
    ' -------- MOSTRAMOS LOS DATOS DEL CLIENTE DEL ALBARAN ------------------------------------------------------------------
    Private Sub MostrarDatosCliente2()
        Try
            ' Abrimos la conexion
            Conexion.Open()
            ' Buscamos en la base de datos los datos del cliente
            consulta = New SqlCommand("SELECT * FROM Clientes WHERE codcli='" & tcliente.Text & "';", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            ' Campos a mostrar
            lnombre.Text = Mireader("nombre").ToString
            ldireccion.Text = Mireader("direccion").ToString
            lnif.Text = Mireader("nif").ToString
            lcp.Text = Mireader("cp").ToString
            llocalidad.Text = Mireader("localidad").ToString
            lprovincia.Text = Mireader("provincia").ToString
            ltfn.Text = Mireader("telefono").ToString
            ' Cerramos las conexiones
            Conexion.Close()
            Mireader.Close()
            ' -------------------------------------------
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    ' ------- RELLENA EL COMBO DEL IVA ----------------------------------
    Private Sub ComboIva()
        consulta = New SqlCommand("Select Tipo from IVA", Conexion)
        Mireader = consulta.ExecuteReader()
        While Mireader.Read()
            ComboBox2.Items.Add(Mireader("Tipo").ToString)
        End While
        Mireader.Close()
        ComboBox2.Enabled = False
    End Sub

    ' ------- RELLENA EL COMBO DE FORMAS DE PAGO ------------
    Private Sub ComboFormasPago()
        consulta = New SqlCommand("SELECT nombre FROM FormasPago", Conexion)
        Mireader = consulta.ExecuteReader()
        While Mireader.Read()
            ComboBox1.Items.Add(Mireader("nombre").ToString)
        End While
        Mireader.Close()
        ComboBox1.Enabled = False
    End Sub

    Public Sub activa2()
        bnuevo.Enabled = True
        bvertodos.Enabled = False
        tcliente.ReadOnly = True
        SoloLectura()
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        bcancelar.Enabled = False
        bimprimir.Enabled = True
        bfactura.Enabled = True
        bsalir.Enabled = True
        bmodificar.Enabled = True
        bborrar.Enabled = True
    End Sub

    Private Sub bmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmodificar.Click
        estado = 3
        bfactura.Enabled = False
        EscrituraLineas()
        EscrituraPie()
        bimprimir.Enabled = False
        bbuscarcli.Enabled = False
        bborrar.Enabled = False
        bbuscar.Enabled = False
        banadir.Enabled = True
        beliminar.Enabled = True
        bnomaslineas.Enabled = True
        blimpiar.Enabled = True
        bvertodos.Enabled = True
        bcancelar.Enabled = True
    End Sub

    Private Sub bborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bborrar.Click
        Dim Conexion2 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        Dim consulta2 As New SqlCommand
        If MessageBox.Show("Desea borrar la venta?", "AVISO", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                        = DialogResult.Yes Then

            Try ' Volvemos a dejar el stock como estaba
                Conexion.Open()
                consulta = New SqlCommand("Select codprod,cantidad from LineasVenta where codventa = '" & tventa.Text & "';", Conexion)
                Mireader = consulta.ExecuteReader()
                Conexion2.Open()
                While Mireader.Read
                    If Mireader("codprod").ToString.Length = 13 Then
                        consulta2 = New SqlCommand("Update Libros set stock=(Select stock from Libros where isbn ='" &
                                Mireader("codprod") & "') + " & Mireader("cantidad") & " where isbn='" & Mireader("codprod") & "';", Conexion2)
                        consulta2.ExecuteNonQuery()
                        
                    Else
                        consulta2 = New SqlCommand("Update Articulos set stock=(Select stock from Articulos where codart ='" &
                                Mireader("codprod") & "') + " & Mireader("cantidad") & " where codart='" & Mireader("codprod") & "';", Conexion2)
                        consulta2.ExecuteNonQuery()
                    End If
                    
                End While
                Mireader.Close()
                Conexion2.Close()
                ' Borramos las lineas del albaran
                consulta = New SqlCommand("Delete from LineasVenta where codventa = '" & tventa.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' Borramos la cabecera y el pie del albaran
                consulta = New SqlCommand("Delete from Ventas where codventa = '" & tventa.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' Cerramos las conexiones
                Conexion.Close()
                'Limpiamos el datagrid
                While dg.RowCount > 1
                    dg.Rows.Remove(dg.CurrentRow)
                End While
                limpiar()
                limpiarlinea()
                tventa.Text = ""
                tventa.Enabled = True
                BotonesInactivos()
            Catch ex As Exception
                'MsgBox(ex.Message)
                Conexion2.Close()
                Conexion.Close()
            End Try
        End If
    End Sub

    Private Sub blimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blimpiar.Click
        tlinea.Text = ""
        tcodprod.Text = ""
        tdescripcion.Text = ""
        tpvp.Text = ""
        tcantidad.Text = ""
        tdto.Text = ""
        timporte.Text = ""
    End Sub


    Private Sub bprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprimer.Click
        CargarEnPosicion(0)
    End Sub

    Private Sub bretroceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bretroceso.Click
        If ((posicion - 1) < 0) Then
            'MsgBox("No hay más registros")
        End If
        If ((posicion - 1) >= 0) Then
            CargarEnPosicion(posicion - 1)
        End If
    End Sub

    Private Sub bavance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bavance.Click
        If ((posicion + 1) >= ultimoregistro) Then
            'MsgBox("No hay más registros")
        End If
        If ((posicion + 1) < ultimoregistro) Then
            CargarEnPosicion(posicion + 1)
        End If
    End Sub

    Private Sub bultimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bultimo.Click
        CargarEnPosicion(ultimoregistro - 1)
    End Sub

    Private Sub bverres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bverres.Click
        Dim b2 As New VerReservas
        AddHandler b2.Closed, AddressOf b2_Closed
        b2.Show()
    End Sub

    Private Sub b2_Closed(ByVal sender As Object, ByVal e As System.EventArgs)
        tbnumres.Text = ""
        'bverres.Enabled = False
        dg.Rows.Clear()
        Try ' Abrimos la conexion
            Conexion.Open()
            ComboIva()
            ComboFormasPago()
            ' Intentamos buscar en la base de datos el albaran correspondiente
            consulta = New SqlCommand("SELECT Ventas.* FROM Ventas,Reservas WHERE Reservas.codres='" & cres & "' and reservas.codventa=ventas.codventa;", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            ' Mostramos la cabecera del albaran
            MostrarCabeceraPie()
            ' Mostramos el iva correspondiente
            BuscarItenIva()
            ' Mostramos la forma de pago
            BuscarItenFP()
            activa2()
            ' Mostramos si el albaran está facturado o no
            ComprobarFacturacion()
            ' Mostramos si tiene reserva y cual es
            ComprobarReserva()
            BuscarReserva()
            If cb1.Checked = True Then
                bborrar.Enabled = False
                bmodificar.Enabled = False
                bfactura.Enabled = False
            End If
            ' Mostrar datos del cliente de este albaran
            MostrarDatosCliente2()
            ' Mostrar lineas de articulos de este albaran
            MostrarLineasArticulo()

            'Cerramos la conexion y el datareader
            Conexion.Close()
            Mireader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class