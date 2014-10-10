Imports System.Data.SqlClient

Public Class Reservas
    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New PapeleriaDataSet


    Private fecha As Date = Date.Now        ' - Variable que contiene la fecha de hoy
    Public cant As Integer = 1
    Public numLinea As Integer = 1         ' - Variable Contador de lineas de albarán
    Private importetotal As Double = 0.0    ' - Variable Global para el importe total
    Private des As Double = 0.0             ' - Variable que uso para hacer calcular el descuento y sus cambios
    Private pep As Double = 0.0
    Dim Iiva As Integer                     ' - Variable Global para el IVA
    Dim c As Integer = 0                    ' - Variable que controla que la cabecera solo se inserte una vez
    Dim d As Integer = 0                    ' - Variable que controla que la cabecera solo se inserte una vez
    Dim importeLinea As Double = 0.0        ' - Variable Global para el importe de linea
    Dim precio As Double = 0.0              ' - Variable Global para el precio de un producto
    Dim descuentoLinea As Double = 0.0      ' - Variable Global para el descuento en linea
    Dim numventa As String                  ' - Variable Global para el contador de ventas
    Dim estado As Integer = 0
    Dim porcentajeiva As Integer            ' - Variable Global para almacenar el porcentaje de Iva
    Dim ultimoregistro As Integer = 0
    Dim cadena As String
    Dim contador As Integer = 0
    Dim posicion As Integer = 0

    Private Sub Reservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ventana = 3
        Me.CenterToScreen()
        ' ----------------------------------------------------------------------------------------------------
        BotonesInactivos()
        bbuscarcli.Enabled = False
        bborrar.Enabled = True
        bmodificar.Enabled = True
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

            cadena = "SELECT COUNT(*) FROM RESERVAS"
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
        SoloLectura()
        tcliente.ReadOnly = True
        bbuscar.Enabled = True
    End Sub

    ' CARGA EN LA POSICION INDICADA
    Private Sub CargarEnPosicion(ByVal pos As Integer)
        Try
            Conexion.Open()
            cadena = "SELECT * FROM RESERVAS ORDER BY CODRES"
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
        activa2()
        bsalir.Enabled = True
        bbuscarcli.Enabled = True
        ' Mostramos si el albaran está facturado o no
        ' Mostramos si tiene reserva y cual es
        If cb1.Checked = True Then
            bborrar.Enabled = False
            bmodificar.Enabled = False
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
        'tventa.ReadOnly = True            ' - TEXTBOX NUMERO DE VENTA
        tlinea.ReadOnly = True            ' - TEXTBOX LINEA
        tcodprod.ReadOnly = True            ' - TEXTBOX CODIGO ARTICULO
        tdescripcion.ReadOnly = True            ' - TEXTBOX DESCRIPCION
        tpvp.ReadOnly = True            ' - TEXTBOX PVP
        tcantidad.ReadOnly = True            ' - TEXTBOX CANTIDAD
        tdto.ReadOnly = True            ' - TEXTBOX DTO.LINEA
        timporte.ReadOnly = True            ' - TEXTBOX IMPORTE
    End Sub
    ' -------- MODO ESCRITURA PARA LAS LINEAS DE LA RESERVA --------
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
        ComboBox2.Enabled = True            ' - COMBOBOX2 ENABLED
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
    End Sub

    Private Sub bbuscarcli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscarcli.Click
        treserva.ReadOnly = True
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

    'Private Sub bbuscarprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscarprod.Click
    '    Dim posicion As Integer
    '    tcodprod.ReadOnly = True
    '    tdto.Text = descuentoLinea.ToString
    '    tdto.ReadOnly = False
    '    tcantidad.ReadOnly = False
    '    ' Calculamos la linea correspondiente
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
    '            ' Buscamos los datos del articulo correspondiente al codigo introducido
    '            consulta = New SqlCommand("SELECT * from LIBROS where isbn='" &
    '                                      tcodprod.Text & "'", Conexion)
    '            posicion = consulta.ExecuteScalar
    '            If posicion = Nothing Then
    '                If MessageBox.Show("Desea crear uno nuevo?", "El libro no existe", _
    '                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
    '                                    = DialogResult.Yes Then
    '                    ' Gestionamos el cierre de la ventana actual y la abertura de la nueva
    '                    Dim alta As New Libros
    '                    alta.ShowDialog()
    '                Else
    '                    tcodprod.Text = ""
    '                End If
    '            End If
    '        Else
    '            MsgBox("El isbn debe contener 13 dígitos")
    '        End If
    '        Mireader = consulta.ExecuteReader()
    '        Mireader.Read()
    '        ' Mostramos los datos
    '        MostrarDatosProducto()
    '        ' Cerramos el DataReader y la conexion
    '        Mireader.Close()
    '        Conexion.Close()
    '    Catch ex As Exception
    '        MsgBox("No ha introducido ningun código de producto")
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
            tpvp.ReadOnly = False
        End If
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

    Private Sub InhabilitaEL()
        tlinea.ReadOnly = True            ' - TEXTBOX LINEA
        tcodprod.ReadOnly = True           ' - TEXTBOX CODIGO ARTICULO
        tdescripcion.ReadOnly = True            ' - TEXTBOX DESCRIPCION
        tpvp.ReadOnly = True            ' - TEXTBOX PVP
        tcantidad.ReadOnly = True           ' - TEXTBOX CANTIDAD
        tdto.ReadOnly = True           ' - TEXTBOX DTO.LINEA
        timporte.ReadOnly = True
    End Sub

    Private Sub banadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles banadir.Click
        InhabilitaEL()
        If estado = 1 Then
            ' Inhabilitamos a partir de ahora el codigo del cliente, ya no se puede cambiar 
            tcliente.Enabled = False
            If Not tcodprod.Text = "" And Not tcantidad.Text = "" And Not tdto.Text = "" Then
                Try ' Abrimos la conexion
                    Conexion.Open()
                    ' Añadimos la linea al DataGrid
                    dg.Rows.Add(tlinea.Text, tcodprod.Text, tdescripcion.Text, tpvp.Text, tcantidad.Text, Format(CDbl(tdto.Text), "N2"), timporte.Text)

                    ' Insertamos la cabecera. Controlamos con la variable c que solo se inserte una vez
                    If (c = 0) Then
                        consulta =
                            New SqlCommand("INSERT INTO Ventas(codventa,codcli,facturado,conreserva)" &
                        " values(" & "'" & numventa & "'" & "," & "'" & tcliente.Text & "'" & "," & "'N'" & "," & "'S'" & ")", Conexion)
                        consulta.ExecuteNonQuery()
                        c = 1
                    End If

                    ' Insertamos la linea de venta introducida
                    consulta =
                        New SqlCommand("INSERT INTO LineasVenta(codventa,numlinea,codprod,descripcion,pvp,cantidad,dtolinea,importe)" &
                         " values(" & "'" & numventa & "'" & "," & "'" & numLinea & "'" &
                         "," & "'" & tcodprod.Text & "'" & "," & "'" & tdescripcion.Text & "'" &
                         "," & tpvp.Text.Replace(".", "").Replace(",", ".") & "," & tcantidad.Text.Replace(",", ".") &
                         "," & tdto.Text.Replace(",", ".") & "," & timporte.Text.Replace(".", "").Replace(",", ".") & ")", Conexion)

                    consulta.ExecuteNonQuery()
                    'MsgBox("Línea guardada")
                    Conexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Conexion.Close()
                End Try

                Try
                    Conexion.Open()
                    ' Insertamos la cabecera de la reserva
                    If (d = 0) Then
                        consulta = New SqlCommand("INSERT INTO RESERVAS(CODRES, CODVENTA, CODCLI)" &
                            " VALUES(" & "'" & treserva.Text & "','" & numventa & "','" & tcliente.Text & "')", Conexion)
                        consulta.ExecuteNonQuery()
                        d = 1
                    End If

                    ' Insertamos la linea de reserva 
                    consulta = New SqlCommand("INSERT INTO LineasReserva(codres,numlinea,codprod,descripcion,pvp,cantidad,dtolinea,importe)" &
                         " values(" & "'" & treserva.Text & "'" & "," & "'" & numLinea & "'" &
                         "," & "'" & tcodprod.Text & "'" & "," & "'" & tdescripcion.Text & "'" &
                         "," & tpvp.Text.Replace(".", "").Replace(",", ".") & "," & tcantidad.Text.Replace(",", ".") &
                         "," & tdto.Text.Replace(",", ".") & "," & timporte.Text.Replace(".", "").Replace(",", ".") & ")", Conexion)
                    consulta.ExecuteNonQuery()
                    ' Cerramos la conexion
                    Conexion.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                    Conexion.Close()
                End Try

                ' Recalculamos el stock de los articulos pedidos

                Try
                    Conexion.Open()
                    If tcodprod.TextLength = 13 Then
                        consulta = New SqlCommand("UPDATE LIBROS set stock = stock - " & _
                                             CInt(tcantidad.Text) & " where isbn = '" & tcodprod.Text & "';", Conexion)
                        consulta.ExecuteNonQuery()
                    End If
                    Conexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
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
                    dg.Rows.Add(numLinea, tcodprod.Text, tdescripcion.Text, tpvp.Text, tcantidad.Text, tdto.Text, timporte.Text)

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

    Private Sub bnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnuevo.Click
        c = 0
        d = 0
        estado = 1
        Dim contador As Integer         ' - Variable que cuenta la cantidad de ventas que hay
        Dim contador2 As Integer        ' - Variable que cuenta la cantidad de reservas que hay
        Dim num As Integer = 1
        tcliente.ReadOnly = False
        treserva.ReadOnly = False
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
        bborrar.Enabled = False
        bbuscar.Enabled = False
        bcancelar.Enabled = True
        Dim position As Integer
        Dim sigue As Boolean = True
        Try ' Abrimos conexion --------------------------------------------------------
            Conexion.Open()
            ' Obtenemos el Nº de venta contando los registros que hay en la BD
            consulta = New SqlCommand("Select count(codventa) from Ventas", Conexion)
            contador = consulta.ExecuteScalar() ' Devuelve un número

            If contador = 0 Then
                numventa = num.ToString
            Else
                While sigue = True
                    consulta = New SqlCommand("Select count(codventa) from Ventas where codventa='" & (contador + 1) & "';", Conexion)
                    position = consulta.ExecuteScalar() ' Devuelve un numero
                    If position = Nothing Then
                        numventa = (contador + 1).ToString
                        tventa.Text = numventa
                        sigue = False
                    Else
                        contador = contador + 1
                    End If
                End While
            End If
            Conexion.Close()
        Catch ex As Exception
            Conexion.Close()
            MsgBox(ex.Message)
            'MsgBox("No se ha podido establecer la conexión")
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

        Dim sigue2 As Boolean = True
        Try
            Conexion.Open()
            ' Obtenemos el nº de reserva contando los registros
            consulta = New SqlCommand("Select count(codres) from Reservas", Conexion)
            contador2 = consulta.ExecuteScalar()

            If contador2 = 0 Then
                treserva.Text = num.ToString
            Else
                While sigue2 = True
                    consulta = New SqlCommand("Select codres from Reservas where codres='" & (contador2 + 1) & "';", Conexion)
                    position = consulta.ExecuteScalar() ' Devuelve un conjunto de registros
                    If position = Nothing Then
                        treserva.Text = (contador2 + 1).ToString
                        sigue2 = False
                    Else
                        contador2 = contador2 + 1
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
            Conexion.Close()
            MsgBox(ex.Message)
            'MsgBox("No se ha podido establecer la conexión")
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
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

            consulta = New SqlCommand("DELETE FROM LINEASVENTA WHERE CODVENTA='" & numventa & "' and NUMLINEA='" & linea & "';", Conexion)
            consulta.ExecuteNonQuery()

            consulta = New SqlCommand("DELETE FROM LINEASRESERVA WHERE CODRESERVA='" & treserva.Text & "' and numlinea='" & linea & "';", Conexion)

            Conexion.Close()
            ' Borramos la fila seleccionada
            dg.Rows.Remove(dg.CurrentRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            Conexion.Close()
        End Try
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
        consulta = New SqlCommand("SELECT SUM(IMPORTE) FROM LINEASRESERVA WHERE CODRES='" &
                                     treserva.Text & "'", Conexion)
        Mireader = consulta.ExecuteReader()
        Mireader.Read()
        limporte.Text = Mireader(0).ToString()
        limporte.Text = Format(CDbl(limporte.Text), "N2")
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

    Private Sub bvertodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bvertodos.Click
        Dim b As New ProductosLibros
        AddHandler b.Closed, AddressOf b_closed
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
        Else
        End If
        tlinea.Text = numLinea.ToString
        tpvp.ReadOnly = False
    End Sub

    Private Sub blimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blimpiar.Click
        tcodprod.Text = ""
        tdescripcion.Text = ""
        tpvp.Text = ""
        tcantidad.Text = ""
        tdto.Text = ""
        timporte.Text = ""
    End Sub

    Private Sub bcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcancelar.Click
        If estado = 1 Then
            ' Inhabilitamos el boton CANCELAR
            bcancelar.Enabled = False
            bbuscar.Enabled = True
            treserva.Text = ""
            tventa.Text = ""
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
        End If
        If estado = 3 Then      ' Proviene de cancelar una modificacion
            '    dg.Rows.Clear()
            '    limpiar()
            '    limpiarlinea()
            '    tventa.Enabled = True
            '    tventa.Text = ""
            '    Reservas_Load(sender, e)
            bimprimir.Enabled = True
            bbuscar.Enabled = True
            baceptar.Enabled = False
            bcancelar.Enabled = False
            bborrar.Enabled = True
        End If

    End Sub

    ' ------- BORRAR CABECERA DEL ALBARÁN -----------------------------------------------------------------------------
    Private Sub BorrarCabeceraAlbaran()
        ' Borramos codventa, codcli y facturado del albaran
        Try
            Conexion.Open()
            consulta = New SqlCommand("Delete from Ventas where codventa ='" & numventa & "';", Conexion)
            consulta.ExecuteNonQuery()
            consulta = New SqlCommand("Delete from Reservas where codres ='" & treserva.Text & "';", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
            consulta = New SqlCommand("Select count(codres) from LineasReserva where codres='" & treserva.Text & "';", Conexion)
            contador = consulta.ExecuteScalar
            Conexion.Close()
            MsgBox("Este reserva contiene " & contador & " lineas de reserva")
        Catch ex As Exception
        End Try

        ' Recorremos cada fila y por cada una, obtenemos el codigo del articulo y la cantidad que se ha pedido
        While i <= contador
            Dim cant As Integer = 0
            Dim codigoproducto As String = ""
            ' Calcula la cantidad de articulos
            Try
                Conexion.Open()
                consulta = New SqlCommand("Select cantidad, codprod from LineasReserva where codres = " & treserva.Text &
                    " and numlinea = " & i & ";", Conexion)
                Mireader = consulta.ExecuteReader()
                Mireader.Read()
                cant = CInt(Mireader("cantidad").ToString)      ' Cantidad de este articulo
                codigoproducto = Mireader("codprod").ToString    ' Codigo de este articulo
                Conexion.Close()
                Mireader.Close()
                MsgBox("ha cogido la cantidad y el producto")
            Catch ex As Exception
                MsgBox(ex.Message)
                Conexion.Close()
            End Try

            ' Recalculamos el stock de cada articulo
            Try
                If Not codigoproducto = "" Then
                    Conexion.Open()
                    If codigoproducto.Length = 13 Then
                        consulta = New SqlCommand("UPDATE LIBROS set stock = stock + " & _
                                             cant & " where isbn = '" & codigoproducto & "';", Conexion)
                    End If
                    consulta.ExecuteNonQuery()
                    Conexion.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Conexion.Close()
            End Try
            i = i + 1
        End While

        ' Borramos las lineas del albaran
        Try
            Conexion.Open()
            consulta = New SqlCommand("Delete from LineasVenta where codventa ='" & numventa & "';", Conexion)
            consulta.ExecuteNonQuery()
            consulta = New SqlCommand("Delete from LineasReserva where codres ='" & treserva.Text & "';", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
                                   " formapago = '2'" &
                                   " where codventa ='" & numventa & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' INTRODUZCO EL PORCENTAJE POR SEPARADO PORQUE ME DIÓ PROBLEMAS
                consulta = New SqlCommand("UPDATE Ventas SET porcentajeiva = " & CInt(ComboBox2.SelectedItem.ToString) &
                                  " where codventa ='" & numventa & "';", Conexion)
                consulta.ExecuteNonQuery()
                'MsgBox("Alta Albarán")

                ' LA CABECERA DE LA RESERVA SE INSERTÓ CON ALGUNOS VALORES AL INSERTAR LINEAS DE ARTICULOS
                ' ACTUALIZAMOS LOS CAMPOS QUE FALTAN EN LA CABECERA
                consulta =
                    New SqlCommand("UPDATE RESERVAS SET fecha = '" & dtp.Text & "'," &
                                   " baseimponible = " & limporte.Text.Replace(".", "").Replace(",", ".") & "," &
                                   " iva = " & liva.Text.Replace(",", ".") & "," &
                                   " importe = " & ltotal.Text.Replace(".", "").Replace(",", ".") & "," &
                                   " entregado = 'N'" &
                                   " where codres ='" & treserva.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' INTRODUZCO EL PORCENTAJE POR SEPARADO PORQUE ME DIÓ PROBLEMAS
                consulta = New SqlCommand("UPDATE RESERVAS SET porcentajeiva = " & CInt(ComboBox2.SelectedItem.ToString) &
                                  " where codres ='" & treserva.Text & "';", Conexion)
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
                bbuscar.Enabled = True
                bborrar.Enabled = True
                'limpiarlinea()
                'limpiar()
                'dg.Rows.Clear()
            Catch ex As Exception
                'MsgBox(ex.Message)
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
                'MsgBox("Ha borrado las antiguas lineasVenta")
            Catch ex As Exception
                MsgBox(ex.Message)
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
                'MsgBox("Ha actualizado las nuevas lineasVenta")
            Catch ex As Exception
                MsgBox(ex.Message)
                Conexion.Close()
            End Try

            Try

                Conexion.Open()
                consulta =
                    New SqlCommand("UPDATE VENTAS SET fecha = '" & dtp.Text & "'," &
                                   " baseimponible = " & limporte.Text.Replace(".", "").Replace(",", ".") & "," &
                                   " iva = " & liva.Text.Replace(",", ".") & "," &
                                   " importe = " & ltotal.Text.Replace(".", "").Replace(",", ".") & "," &
                                   " formapago = '2'" &
                                   " where codventa ='" & tventa.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' INTRODUZCO EL PORCENTAJE POR SEPARADO PORQUE ME DIÓ PROBLEMAS
                consulta = New SqlCommand("UPDATE Ventas SET porcentajeiva = " & CInt(ComboBox2.SelectedItem.ToString) &
                                  " where codventa ='" & tventa.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' Cerramos la conexion
                Conexion.Close()
                'MsgBox("Ha actualizado la cabpie de ventas")
            Catch ex As Exception
                MsgBox(ex.Message)
                Conexion.Close()
            End Try
            MsgBox("Ha actualizado la venta asociada a esta reserva")
            '--------------------------------------------------------

            Try ' Eliminamos las lineas de albaran de la bbdd
                Conexion.Open()
                consulta = New SqlCommand("Delete from LineasReserva where codres='" & treserva.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                Conexion.Close()
                MsgBox("Ha entrado a borrar las lineas de reserva antiguas")
            Catch ex As Exception
                MsgBox(ex.Message)
                Conexion.Close()
            End Try

            Dim j As Integer = 0

            Try ' Añadimos las nuevas lineas de albaran a la bbdd
                n = dg.RowCount
                While j < n
                    numlinea = dg.Rows(j).Cells(0).Value
                    codart = dg.Rows(j).Cells(1).Value.ToString
                    descripcion = dg.Rows(j).Cells(2).Value.ToString
                    pvp = CDbl(dg.Rows(j).Cells(3).Value)
                    cantidad = CInt(dg.Rows(j).Cells(4).Value)
                    dtolinea = CDbl(dg.Rows(j).Cells(5).Value)
                    importe = CDbl(dg.Rows(j).Cells(6).Value)
                    Conexion.Open()
                    consulta = New SqlCommand("Insert into LineasReserva(codres,numlinea,codprod,descripcion,pvp,cantidad,dtolinea,importe) values ('" &
                                              treserva.Text & "','" &
                                              numlinea & "','" &
                                              codart & "','" &
                                              descripcion & "'," & Replace(pvp, ",", ".") & "," & cantidad & "," &
                                              Replace(dtolinea, ",", ".") & "," & Replace(importe, ",", ".") & ")", Conexion)
                    consulta.ExecuteNonQuery()
                    Conexion.Close()
                    j = j + 1
                End While
                'MsgBox("Ha actualizado las nuevas lineasreserva")
            Catch ex As Exception
                MsgBox(ex.Message)
                Conexion.Close()
            End Try

            Try ' Actualizamos el pie del albaran

                Conexion.Open()
                consulta =
                    New SqlCommand("UPDATE RESERVAS SET fecha = '" & dtp.Text & "'," &
                                   " baseimponible = " & limporte.Text.Replace(".", "").Replace(",", ".") & "," &
                                   " iva = " & liva.Text.Replace(",", ".") & "," &
                                   " importe = " & ltotal.Text.Replace(".", "").Replace(",", ".") & "," &
                                   " entregado = 'N'" &
                                   " where codres ='" & treserva.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' INTRODUZCO EL PORCENTAJE POR SEPARADO PORQUE ME DIÓ PROBLEMAS
                consulta = New SqlCommand("UPDATE Reservas SET porcentajeiva = " & CInt(ComboBox2.SelectedItem.ToString) &
                                  " where codres ='" & treserva.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' Cerramos la conexion
                Conexion.Close()
                MsgBox("Ha actualizado la cabecera de la reserva")
            Catch ex As Exception
                MsgBox(ex.Message)
                Conexion.Close()
            End Try
            'MsgBox("Ha actualizado la reserva")
            bimprimir.Enabled = True
            bbuscar.Enabled = True
            baceptar.Enabled = False
            bcancelar.Enabled = False
            bborrar.Enabled = True
        End If

    End Sub

    Private Sub bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsalir.Click
        Me.Close()
    End Sub


    Private Sub bbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscar.Click
        estado = 2
        Dim b1 As New BusquedasReservas
        AddHandler b1.Closed, AddressOf b1_Closed
        b1.Show()
    End Sub

    Private Sub b1_Closed(ByVal sender As Object, ByVal e As System.EventArgs)
        dg.Rows.Clear()
        Try ' Abrimos la conexion
            Conexion.Open()
            ComboIva()
            ' Intentamos buscar en la base de datos el albaran correspondiente
            consulta = New SqlCommand("SELECT * FROM Reservas WHERE codres='" & cres & "';", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            ' Mostramos la cabecera del albaran
            MostrarCabeceraPie()
            ' Mostramos el iva correspondiente
            BuscarItenIva()
            ' Mostramos la forma de pago
            activa2()
            ' Mostramos si el albaran está facturado o no
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

    ' ------- MOSTRAMOS LAS LINEAS DE ARTICULOS DE LA RESERVA ------------------------------------------------------------
    Private Sub MostrarLineasArticulo()
        Dim contadorF As Integer
        Dim n As Integer = 0          ' Variable a usar en el while de las filas 
        Dim i As Integer
        Dim aux As String
        Try
            ' Abrimos la conexion
            Conexion.Open()
            ' Obtenemos la cantidad de lineas que corresponden a esta reserva
            consulta = New SqlCommand("Select count(*) from LineasReserva where codres='" & treserva.Text & "';", Conexion)
            contadorF = consulta.ExecuteScalar()
            ' Buscamos en la base de datos los datos de los articulos correspondientes
            consulta = New SqlCommand("SELECT * FROM LineasReserva WHERE codres='" & treserva.Text & "';", Conexion)
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

    Public Sub activa2()
        Dim entrega As String
        Try
            Conexion.Open()
            consulta = New SqlCommand("SELECT Reservas.entregado FROM Reservas WHERE Reservas.codres='" & cres & "';", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            entrega = Mireader(0).ToString
            If entrega = "S" Then
                bmodificar.Enabled = False
                bborrar.Enabled = False
                cb1.Checked = True
            End If
            If entrega = "N" Then
                bmodificar.Enabled = True
                bborrar.Enabled = True
            End If

            Mireader.Close()
            Conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            Mireader.Close()
            Conexion.Close()
        End Try
        bnuevo.Enabled = True
        bvertodos.Enabled = False
        tcliente.ReadOnly = True
        SoloLectura()
        ComboBox2.Enabled = False
        bcancelar.Enabled = False
        bimprimir.Enabled = True
        bsalir.Enabled = True
    End Sub

    ' -------- MUESTRA LOS DATOS DE LA CABECERA Y EL PIE DE LA RESERVA -------------
    Private Sub MostrarCabeceraPie()
        treserva.Text = Mireader("codres").ToString
        tventa.Text = Mireader("codventa").ToString
        tcliente.Text = Mireader("codcli").ToString
        dtp.Text = Mireader("fecha").ToString

        limporte.Text = Format(CDbl(Mireader("baseimponible").ToString), "N2")
        liva.Text = Format(CDbl(Mireader("iva").ToString), "N2")
        ltotal.Text = Format(CDbl(Mireader("importe").ToString), "N2")
        porcentajeiva = CInt(Mireader("porcentajeiva").ToString)

        Conexion.Close()
        Mireader.Close()

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

    Private Sub bimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bimprimir.Click
        ' Creamos una nueva conexion
        Dim Conexion2 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        ' Creamos un Visor
        Dim visor As New Visor
        ' Creamos un dataset
        Dim dataset As New PapeleriaDataSet
        ' Creamos un Listado para Albaranes
        Dim listado As New Reserva
        ' Creamos un DataAdapter
        Dim da1 As SqlClient.SqlDataAdapter

        ' Creamos las consultas y rellenamos el dataset 
        da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Reservas WHERE Reservas.codres= '" & treserva.Text & "';", Conexion2)
        da1.Fill(dataset, "reservas")
        da1 = New SqlClient.SqlDataAdapter("SELECT  Lineasreserva.* FROM Lineasreserva WHERE Lineasreserva.codres = '" & treserva.Text & "';", Conexion2)
        Try
            da1.Fill(dataset, "lineasreserva")
        Catch ex As System.Data.ConstraintException
            da1.Fill(dataset, "lineasreserva")
        End Try

        da1 = New SqlClient.SqlDataAdapter("SELECT * FROM Clientes WHERE Clientes.codcli = '" & tcliente.Text & "';", Conexion2)
        da1.Fill(dataset, "CLIENTES")
        'da1 = New SqlClient.SqlDataAdapter("SELECT FormasPago.* FROM FormasPago, Ventas WHERE Ventas.formapago = FormasPago.tipo and Reservas.codres= '" & treserva.Text & "';", Conexion2)
        'Try
        '    da1.Fill(dataset, "FORMASPAGO")
        'Catch ex As System.Data.ConstraintException
        '    da1.Fill(dataset, "FORMASPAGO")
        'End Try
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

    Private Sub bborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bborrar.Click
        Dim Conexion2 As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        Dim consulta2 As New SqlCommand
        If MessageBox.Show("Desea borrar la venta?", "AVISO", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                        = DialogResult.Yes Then

            Try ' Volvemos a dejar el stock como estaba
                Conexion.Open()
                consulta = New SqlCommand("Select codprod,cantidad from LineasReserva where codres = '" & treserva.Text & "';", Conexion)
                Mireader = consulta.ExecuteReader()
                Conexion2.Open()
                While Mireader.Read
                    If Mireader("codprod").ToString.Length = 13 Then
                        consulta2 = New SqlCommand("Update Libros set stock=(Select stock from Libros where isbn ='" &
                                Mireader("codprod") & "') + " & Mireader("cantidad") & " where isbn='" & Mireader("codprod") & "';", Conexion2)
                        consulta2.ExecuteNonQuery()
                    End If
                End While
                Mireader.Close()
                Conexion2.Close()
                ' Borramos las lineas del albaran
                consulta = New SqlCommand("Delete from LineasVenta where codventa = '" & numventa & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' Borramos la cabecera y el pie del albaran
                consulta = New SqlCommand("Delete from Ventas where codventa = '" & numventa & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' Borramos las lineas del albaran
                consulta = New SqlCommand("Delete from LineasReserva where codres = '" & treserva.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' Borramos la cabecera y el pie del albaran
                consulta = New SqlCommand("Delete from Reservas where codres = '" & treserva.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                ' Cerramos las conexiones
                Conexion.Close()
                'Limpiamos el datagrid
                While dg.RowCount > 1
                    dg.Rows.Remove(dg.CurrentRow)
                End While
                limpiar()
                limpiarlinea()
                treserva.Text = ""
                treserva.Enabled = True
                BotonesInactivos()
            Catch ex As Exception
                'MsgBox(ex.Message)
                Conexion2.Close()
                Conexion.Close()
            End Try
        End If
    End Sub

    Private Sub bmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmodificar.Click
        estado = 3
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
End Class