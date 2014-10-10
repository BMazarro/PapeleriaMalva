Imports System.Data.SqlClient

Public Class Compras
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
    Dim importeLinea As Double = 0.0        ' - Variable Global para el importe de linea
    Dim precio As Double = 0.0              ' - Variable Global para el precio de un producto
    Dim descuentoLinea As Double = 0.0      ' - Variable Global para el descuento en linea
    Dim porcentajeiva As Integer            ' - Variable Global para almacenar el porcentaje de Iva
    Dim formapago As Char                   ' - Variable Global para almacenar la Forma de Pago (1|2|3)
    Dim ultimoregistro As Integer = 0
    Dim cadena As String
    Dim contador As Integer = 0
    Dim posicion As Integer = 0

    Private Sub Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ventana = 2
        Me.CenterToScreen()
        ' ----------------------------------------------------------------------------------------------------
        BotonesInactivos()
        bbuscarprov.Enabled = False
        SoloLectura()
        tproveedor.ReadOnly = True
       
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
            cadena = "SELECT COUNT(*) FROM COMPRAS"
            consulta = New SqlCommand(cadena, Conexion)
            ultimoregistro = consulta.ExecuteScalar()   'Obtenemos la cantidad de registros
            Conexion.Close()
            Conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Mireader.Close()
            Conexion.Close()
        End Try
        If Not ultimoregistro = Nothing Then
            CargarEnPosicion(ultimoregistro - 1)
        End If
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        tproveedor.ReadOnly = True
        bbuscar.Enabled = True
    End Sub

    ' CARGA EN LA POSICION INDICADA
    Private Sub CargarEnPosicion(ByVal pos As Integer)
        Try
            Conexion.Open()
            cadena = "SELECT * FROM COMPRAS ORDER BY CODCOMPRA"
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
        bbuscarprov.Enabled = True
        ' Mostrar datos del cliente de este albaran
        MostrarDatosProveedor2()
        ' Mostrar lineas de articulos de este albaran
        MostrarLineasArticulo()

    End Sub

    ' ------- BOTONES INACTIVOS AL INICIO DE LA APLICACION -----------
    Private Sub BotonesInactivos()
        bvertodos.Enabled = False
        blimpiar.Enabled = False
        baceptar.Enabled = False      ' - BOTON ACEPTAR 
        bcancelar.Enabled = False      ' - BOTON CANCELAR
        banadir.Enabled = False         ' - BOTON AÑADIR LINEA DE ALBARAN
        beliminar.Enabled = False         ' - BOTON CANCELAR LINEA DE ALBARAN
        bnomaslineas.Enabled = False        ' - BOTON NO MAS LINEAS DE ALBARAN
        bbuscarprov.Enabled = True     ' - BOTON BUSCAR PROVEEDOR
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
        timporte.ReadOnly = True            ' - TEXTBOX IMPORTE
        tobservaciones.ReadOnly = True            ' - TEXTBOX OBSERVACIONES

    End Sub

    ' ------- BOTONES ACTIVOS DESPUES DE BUSCAR EL CLIENTE -----------
    Private Sub BotonesActivos()
        bvertodos.Enabled = True
        blimpiar.Enabled = False
        baceptar.Enabled = False      ' - BOTON ACEPTAR 
        bcancelar.Enabled = True       ' - BOTON CANCELAR
        banadir.Enabled = False          ' - BOTON AÑADIR LINEA DE ALBARAN
        beliminar.Enabled = False         ' - BOTON CANCELAR LINEA DE ALBARAN
        bnomaslineas.Enabled = False         ' - BOTON NO MAS LINEAS DE ALBARAN
        bbuscarprov.Enabled = False     ' - BOTON BUSCAR CLIENTE
        bsalir.Enabled = False       ' - BOTON SALIR
    End Sub

    ' -------- MODO ESCRITURA PARA LAS LINEAS DE ALBARAN --------
    Private Sub EscrituraLineas()
        tlinea.ReadOnly = True            ' - TEXTBOX LINEA
        tcodprod.ReadOnly = True           ' - TEXTBOX CODIGO ARTICULO
        tdescripcion.ReadOnly = True            ' - TEXTBOX DESCRIPCION
        tpvp.ReadOnly = True            ' - TEXTBOX PVP
        tcantidad.ReadOnly = False           ' - TEXTBOX CANTIDAD
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
        tproveedor.Enabled = True
        tproveedor.Text = ""
        'LabDes.Text = ""
        LabDir.Text = ""
        LabNif.Text = ""
        LabNom.Text = ""
        LabCP.Text = ""
        LabLocalidad.Text = ""
        LabProvincia.Text = ""
        LabTelefono.Text = ""
        'LabTar.Text = ""
        limporte.Text = ""
        liva.Text = ""
        ltotal.Text = ""
        tobservaciones.Text = ""

    End Sub

    ' --------- ACTIVAR CONTROLES 2--------------------------------
    Public Sub activa2()
        bnuevo.Enabled = True
        bvertodos.Enabled = False
        tproveedor.ReadOnly = True
        SoloLectura()
        bbuscarprov.Enabled = False
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        bcancelar.Enabled = False
        bsalir.Enabled = True
    End Sub
    Private Sub bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsalir.Click
        Me.Close()
    End Sub


    Private Sub bnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnuevo.Click
        c = 0
        Dim contador As Integer         ' - Variable que cuenta la cantidad de albaranes que hay dados de alta
        Dim num As Integer = 1
        tproveedor.ReadOnly = False
        tcompra.ReadOnly = False
        ' Ponemos el foco en el codigo del cliente a buscar
        tproveedor.Focus()
        tproveedor.BackColor = Color.Aquamarine
        ' Inicializamos la fecha de hoy
        'Labfe.Text = fecha
        bbuscarprov.Enabled = True
        ' Solo lectura para los textbox's
        SoloLectura()
        ' Limpiamos el DataGrid, las lineas de articulos, y el albaran entero
        dg.Rows.Clear()
        limpiarlinea()
        limpiar()
        ' Desactivar botones
        BotonesInactivos()
        bbuscar.Enabled = False
        bcancelar.Enabled = True
        Dim position As Integer
        Dim sigue As Boolean = True

        Try ' Abrimos conexion --------------------------------------------------------
            Conexion.Open()

            ' Obtenemos el Nº de Albarán contando los registros que hay en la BD
            consulta = New SqlCommand("Select count(codcompra) from Compras", Conexion)
            contador = consulta.ExecuteScalar() ' Devuelve un número
            If contador = 0 Then
                tcompra.Text = num.ToString
            Else
                While sigue = True
                    consulta = New SqlCommand("Select codcompra from Compras where codcompra='" & (contador + 1) & "';", Conexion)
                    position = consulta.ExecuteScalar() ' Devuelve un conjunto de registros
                    If position = Nothing Then
                        tcompra.Text = (contador + 1).ToString
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
            MsgBox(ex.Message)
            'MsgBox("No se ha podido establecer la conexión")
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub

    Private Sub bbuscarprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscarprov.Click
        tcompra.ReadOnly = True
        Dim posicion As Integer
        tproveedor.Focus()    ' Ponemos el foco en el codigo de articulos de las lineas del albaran
        tpvp.Text = Format(pep, "N2")
        Try ' Abrimos la conexion
            Conexion.Open()

            ' Buscamos el codigo introducido y vemos en que posicion se encuentra
            consulta = New SqlCommand("Select codprov from Proveedores where codprov='" &
                                      tproveedor.Text & "';", Conexion)
            posicion = consulta.ExecuteScalar()   'Obtenemos la cantidad de registros que tiene hasta su posicion

            ' Si el valor devuelto no existe entonces volvemos al inicio de la aplicacion
            If posicion = Nothing Then

                If MessageBox.Show("Desea crear uno nuevo?", "El proveedor no existe", _
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                        = DialogResult.Yes Then
                    ' Gestionamos el cierre de la ventana actual y la abertura de la nueva

                    Dim alta As New Proveedores
                    alta.ShowDialog()

                Else
                    tproveedor.Text = ""
                End If

            Else
                ' Seleccionamos los datos del proveedor introducido
                consulta = New SqlCommand("Select * from Proveedores where codprov='" &
                                          tproveedor.Text & "';", Conexion)
                ' Rellemos el datareader con los datos
                Mireader = consulta.ExecuteReader()
                ' Leemos el datareader
                Mireader.Read()
                ' Mostramos los datos del cliente
                MostrarDatosProveedor()
                ' Habilitamos botones de las lineas de albaran
                BotonesActivos()
                ' Habilitamos la escritura en los campos del articulo de las lineas de albaran
                tcodprod.Enabled = True
                tcodprod.ReadOnly = True           ' - TEXTBOX CODIGO ARTICULO

                ' Damos color indicativo al campo codigo articulo ya que el foco no funciona
                tcodprod.BackColor = Color.LightBlue
                tcantidad.BackColor = Color.LightBlue
                dg.ClearSelection()
                Me.dg.Item(1, 0).Selected = True
            End If

            ' - Cerramos la conexion y el datareader
            Conexion.Close()
            Mireader.Close()

        Catch ex As Exception
            MsgBox("No ha introducido ningun código de proveedor")
            Mireader.Close()
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub

    ' -------- MOSTRAR LOS DATOS DEL PROVEEDOR -------------
    Private Sub MostrarDatosProveedor()
        LabNom.Text = Mireader("nombre").ToString
        LabDir.Text = Mireader("direccion").ToString
        LabNif.Text = Mireader("nif").ToString
        LabCP.Text = Mireader("cp").ToString
        LabLocalidad.Text = Mireader("localidad").ToString
        LabProvincia.Text = Mireader("provincia").ToString
        LabTelefono.Text = Mireader("telefono").ToString
    End Sub

    'Private Sub bbuscarprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscarprod.Click
    '    Dim posicion As Integer
    '    tcodprod.ReadOnly = True
    '    tcantidad.ReadOnly = False
    '    ' Calculamos la linea correspondiente
    '    tlinea.Text = numLinea.ToString
    '    tproveedor.Enabled = False
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
        Else
            ' Muestra la descripcion
            tdescripcion.Text = Mireader("descripcion").ToString
            ' Muestra el pvp
            tpvp.Text = Mireader("pvp").ToString
        End If
    End Sub


    Private Sub tcantidad_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcantidad.TextChanged
        If Not tcantidad.Text = "" And IsNumeric(tcantidad.Text) Then
            Dim pvp, cant As Double
            pvp = CDbl(tpvp.Text)
            cant = CDbl(tcantidad.Text)
            importeLinea = pvp * cant
            'Formateamos la salida
            timporte.Text = Format(importeLinea, "N2")
        Else

        End If
    End Sub

    Private Sub InhabilitaEL()
        tlinea.ReadOnly = True            ' - TEXTBOX LINEA
        tcodprod.ReadOnly = True           ' - TEXTBOX CODIGO ARTICULO
        tdescripcion.ReadOnly = True        ' - TEXTBOX DESCRIPCION
        tpvp.ReadOnly = True            ' - TEXTBOX PVP
        tcantidad.ReadOnly = True           ' - TEXTBOX CANTIDAD
        timporte.ReadOnly = True
    End Sub

    Private Sub banadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles banadir.Click
        InhabilitaEL()
        ' Inhabilitamos a partir de ahora el codigo del cliente, ya no se puede cambiar 
        tproveedor.Enabled = False
        ' Inabilitamos la direccion de entrega, ya no se puede cambiar
        If Not tcodprod.Text = "" And Not tcantidad.Text = "" Then
            Try ' Abrimos la conexion
                Conexion.Open()
                ' Añadimos la linea al DataGrid
                dg.Rows.Add(tlinea.Text, tcodprod.Text, tdescripcion.Text, tpvp.Text, tcantidad.Text, timporte.Text)

                ' Insertamos la cabecera. Controlamos con la variable c que solo se inserte una vez
                If (c = 0) Then
                    consulta =
                        New SqlCommand("INSERT INTO Compras(codcompra,codprov)" &
                    " values(" & "'" & tcompra.Text & "'" & "," & "'" & tproveedor.Text & "'" & ")", Conexion)
                    consulta.ExecuteNonQuery()
                    c = 1
                End If

                ' Insertamos la linea introducida
                consulta =
                New SqlCommand("INSERT INTO LineasCompra(codcompra,numlinea,codprod,descripcion,pvp,cantidad,importe)" &
                 " values(" & "'" & tcompra.Text & "'" & "," & "'" & numLinea & "'" &
                 "," & "'" & tcodprod.Text & "'" & "," & "'" & tdescripcion.Text & "'" &
                 "," & tpvp.Text.Replace(".", "").Replace(",", ".") & "," & tcantidad.Text.Replace(".", "").Replace(",", ".") &
                 "," & timporte.Text.Replace(".", "").Replace(",", ".") & ")", Conexion)
                consulta.ExecuteNonQuery()
                'MsgBox("Línea guardada")

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
                    consulta = New SqlCommand("UPDATE LIBROS set stock = stock + " & _
                                         CInt(tcantidad.Text) & " where isbn = '" & tcodprod.Text & "';", Conexion)
                Else
                    consulta = New SqlCommand("UPDATE Articulos set stock = stock + " & _
                                         CInt(tcantidad.Text) & " where codart = '" & tcodprod.Text & "';", Conexion)
                End If

                consulta.ExecuteNonQuery()
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
                consulta = New SqlCommand("UPDATE LIBROS set stock = stock - " & _
                                     CInt(cant) & " where isbn = '" & cod & "';", Conexion)
            Else
                consulta = New SqlCommand("UPDATE Articulos set stock = stock - " & _
                                     CInt(cant) & " where codart = '" & cod & "';", Conexion)
            End If
            consulta.ExecuteNonQuery()

            consulta = New SqlCommand("DELETE FROM LINEASCOMPRA WHERE CODCOMPRA='" & tcompra.Text & "' and NUMLINEA='" & linea & "';", Conexion)
            consulta.ExecuteNonQuery()

            Conexion.Close()
            ' Borramos la fila seleccionada
            dg.Rows.Remove(dg.CurrentRow)
        Catch ex As Exception
            MsgBox(ex.Message)
            Conexion.Close()
        End Try
    End Sub

    Private Sub bnomaslineas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnomaslineas.Click
        CalcularImportes()
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
        timporte.Enabled = False
        ' ----------------------------------------------------------------------------
        ' Inhabilitamos los botones correspondientes a las lineas del albarán
        blimpiar.Enabled = False
        bvertodos.Enabled = False
        banadir.Enabled = False
        beliminar.Enabled = False
        bnomaslineas.Enabled = False
    End Sub

    ' ------- CALCULAR IMPORTES --------------
    Private Sub CalcularImportes()
        Dim a, b As Double
        Dim imponible As Double
        Conexion.Open()
        consulta = New SqlCommand("SELECT SUM(IMPORTE) FROM LINEASCOMPRA WHERE CODCOMPRA='" &
                                     tcompra.Text & "'", Conexion)
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

    Private Sub tproveedor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tproveedor.TextChanged
        bbuscarprov.Enabled = True
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
        ' Inhabilitamos el boton CANCELAR
        bcancelar.Enabled = False
        SoloLectura()
        ' Limpiamos el DataGrid, las lineas de articulos, y el albaran entero
        dg.Rows.Clear()
        limpiarlinea()
        limpiar()

        ' Borramos de la base de datos las lineas de articulo dadas de alta
        BorrarLineasCompra()

        ' Borramos de la base de datos la parte de la cabecera que habiamos dado de alta. 
        ' Habiamos guardado el codigo del albaran, el codigo del cliente y facturado=N
        BorrarCabeceraCompra()

        ' Inicializamos el numero de lineas de articulo a 1
        numLinea = 1
        ' Inicializamos el importetotal a 0
        importetotal = 0
        bbuscar.Enabled = True
    End Sub

    ' ------- BORRAR CABECERA DEL ALBARÁN -----------------------------------------------------------------------------
    Private Sub BorrarCabeceraCompra()
        ' Borramos codventa, codcli y facturado del albaran
        Try
            Conexion.Open()
            consulta = New SqlCommand("Delete from Compras where codcompra ='" & tcompra.Text & "';", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'MsgBox("Datos de la cabecera del albaran borrados de la base de datos")
    End Sub


    ' -------- BORRAR LAS LINEAS DE ARTICULOS -------------------------------
    Private Sub BorrarLineasCompra()

        Dim contador As Integer
        Dim i As Integer = 1

        ' Primero calculamos cuantas lineas tiene este albaran
        Try
            Conexion.Open()
            consulta = New SqlCommand("Select count(codcompra) from LineasCompra where codcompra='" & tcompra.Text & "';", Conexion)
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
                consulta = New SqlCommand("Select cantidad, codprod from LineasCompra where codcompra = " & tcompra.Text &
                    " and numlinea = " & i & ";", Conexion)
                Mireader = consulta.ExecuteReader()
                Mireader.Read()
                cant = CInt(Mireader("cantidad").ToString)      ' Cantidad de este articulo
                codigoproducto = Mireader("codprod").ToString    ' Codigo de este articulo
                Conexion.Close()
                Mireader.Close()
            Catch ex As Exception
                Conexion.Close()
            End Try

            ' Recalculamos el stock de cada articulo
            Try
                If Not codigoproducto = "" Then
                    Conexion.Open()
                    If codigoproducto.Length = 13 Then
                        consulta = New SqlCommand("UPDATE LIBROS set stock = stock - " & _
                                             CInt(tcantidad.Text) & " where isbn = '" & codigoproducto & "';", Conexion)
                    Else
                        consulta = New SqlCommand("UPDATE Articulos set stock = stock - " & _
                                             CInt(tcantidad.Text) & " where codart = '" & codigoproducto & "';", Conexion)
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
            consulta = New SqlCommand("Delete from LineasCompra where codcompra ='" & tcompra.Text & "';", Conexion)
            consulta.ExecuteNonQuery()
            Conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'MsgBox("Datos de lineas de venta borrados de la base de datos")
    End Sub

    Private Sub baceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baceptar.Click
        Dim contador As Integer
        contador = 0
        Dim lin As Integer
        Dim codar, descrip, ctd As String
        Dim import As Double
        Dim pre As Double

        Try
            While contador < dg.Rows.Count - 1 'para cada linea del datagrid

                lin = dg.Rows(contador).Cells(0).Value
                codar = dg.Rows(contador).Cells(1).Value
                descrip = dg.Rows(contador).Cells(2).Value
                pre = CDbl(dg.Rows(contador).Cells(3).Value)
                ctd = CInt(dg.Rows(contador).Cells(4).Value)
                import = CDbl(dg.Rows(contador).Cells(5).Value)
                If Not codar.Length = 13 Then
                    'Actualizamos la fecha de compra
                    Try
                        Conexion.Open()
                        consulta = New SqlCommand("UPDATE ARTICULOS SET FECHAULTC = '" & dtp.Text &
                            "' WHERE codart = '" & codar & "';", Conexion)
                        consulta.ExecuteNonQuery()
                        Conexion.Close()

                    Catch ex As Exception
                    Finally
                        Conexion.Close()
                    End Try
                    'Actualizamos el precio de ultima compra
                    Try
                        Conexion.Open()
                        consulta = New SqlCommand("UPDATE ARTICULOS SET PRECIOULTC = '" & CStr(pre).Replace(".", "").Replace(",", ".") &
                            "' WHERE codart = '" & codar & "';", Conexion)
                        consulta.ExecuteNonQuery()
                        Conexion.Close()

                    Catch ex As Exception
                    Finally
                        Conexion.Close()
                    End Try
                    'Actualizamos el proveedor
                    Try
                        Conexion.Open()
                        consulta = New SqlCommand("UPDATE ARTICULOS SET PROVHAB = '" & tproveedor.Text &
                        "' WHERE codart = '" & codar & "';", Conexion)
                        consulta.ExecuteNonQuery()
                        Conexion.Close()

                    Catch ex As Exception
                    Finally
                        Conexion.Close()
                    End Try

                End If
                contador = contador + 1
            End While



            Try
                ' Abrimos la conexion
                Conexion.Open()
                ' LA CABECERA DEL ALBARAN SE INSERTÓ CON ALGUNOS VALORES AL INSERTAR LINEAS DE ARTICULOS
                ' ACTUALIZAMOS LOS CAMPOS QUE FALTAN EN LA CABECERA
                consulta =
                    New SqlCommand("UPDATE COMPRAS SET fecha = '" & dtp.Text & "'," &
                                       " direccion = '" & LabDir.Text & "'," &
                                       " baseimponible = " & limporte.Text.Replace(".", "").Replace(",", ".") & "," &
                                       " iva = " & liva.Text.Replace(",", ".") & "," &
                                       " total = " & ltotal.Text.Replace(".", "").Replace(",", ".") & "," &
                                       " formapago = '" & CStr(ComboBox1.SelectedIndex + 1) & "'," &
                                       " observaciones ='" & tobservaciones.Text & "'" &
                                       " where codcompra ='" & tcompra.Text & "';", Conexion)
                consulta.ExecuteNonQuery()
                'INTRODUZCO EL PORCENTAJE POR SEPARADO PORQUE ME DIÓ PROBLEMAS
                consulta = New SqlCommand("UPDATE COMPRAS SET porcentajeiva = " & CInt(ComboBox2.SelectedItem.ToString) &
                                  " where codcompra ='" & tcompra.Text & "';", Conexion)
                consulta.ExecuteNonQuery()


                'creamos la sentencia del libro de iva
                consulta = New SqlCommand("INSERT INTO LibroIVA VALUES ('" & tcompra.Text & "','" & dtp.Text & "','" & LabNom.Text &
                    "','" & LabNif.Text & "','" & limporte.Text.Replace(".", "").Replace(",", ".") & "','" &
                    liva.Text.Replace(".", "").Replace(",", ".") & "'," &
                    CInt(ComboBox2.SelectedItem.ToString) & ",'" &
                     ltotal.Text.Replace(".", "").Replace(",", ".") &
                    "','S','C')", Conexion)
                consulta.ExecuteNonQuery()
                ' Cerramos la conexion
                Conexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            
            ' Inhabilitamos los botones ACEPTAR Y CANCELAR
            ' Habilitamos los botones IMPRIMIR Y SALIR 
            bsalir.Enabled = True
            baceptar.Enabled = False
            bcancelar.Enabled = False
            bbuscar.Enabled = True
            'ButtonImp.Enabled = True

            'limpiarlinea()
            'limpiar()
            'dg.Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            Conexion.Close()
        End Try

    End Sub

    Private Sub bvertodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bvertodos.Click
        Dim b As New Productos
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
        timporte.Enabled = True
        tcantidad.ReadOnly = False
    End Sub

    Private Sub b_Closed(ByVal sender As Object, ByVal e As System.EventArgs)
        tcodprod.Text = codproducto.ToString
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
        tlinea.Text = numLinea.ToString
    End Sub

    Private Sub blimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blimpiar.Click
        tcodprod.Text = ""
        tdescripcion.Text = ""
        tpvp.Text = ""
        tcantidad.Text = ""
        timporte.Text = ""
    End Sub

    Private Sub bbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscar.Click
        Dim b3 As New BusquedasCompras
        AddHandler b3.Closed, AddressOf b3_Closed
        b3.Show()
    End Sub

    Private Sub b3_Closed(ByVal sender As Object, ByVal e As System.EventArgs)
        dg.Rows.Clear()
        Try ' Abrimos la conexion
            Conexion.Open()
            ComboIva()
            ComboFormasPago()
            ' Intentamos buscar en la base de datos el albaran correspondiente
            consulta = New SqlCommand("SELECT * FROM Compras WHERE codcompra='" & cco & "';", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            ' Mostramos la cabecera del albaran
            MostrarCabeceraPie()
            ' Mostramos el iva correspondiente
            BuscarItenIva()
            ' Mostramos la forma de pago
            BuscarItenFP()
            activa2()
            ' Mostrar datos del cliente de este albaran
            MostrarDatosProveedor2()
            ' Mostrar lineas de articulos de este albaran
            MostrarLineasArticulo()
            'Cerramos la conexion y el datareader
            Conexion.Close()
            Mireader.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    ' ------- MOSTRAMOS LAS LINEAS DE ARTICULOS DE LA COMPRA ------------------------------------------------------------
    Private Sub MostrarLineasArticulo()
        Dim contadorF As Integer
        Dim n As Integer = 0          ' Variable a usar en el while de las filas 
        Dim i As Integer

        Try
            ' Abrimos la conexion
            Conexion.Open()
            ' Obtenemos la cantidad de lineas que corresponden a este albaran
            consulta = New SqlCommand("Select count(*) from LineasCompra where codcompra='" & tcompra.Text & "';", Conexion)
            contadorF = consulta.ExecuteScalar()
            ' Buscamos en la base de datos los datos de los articulos correspondientes
            consulta = New SqlCommand("SELECT * FROM LineasCompra WHERE codcompra='" & tcompra.Text & "';", Conexion)
            Mireader = consulta.ExecuteReader()

            While Mireader.Read
                dg.Rows.Add()
                dg.Rows(n).Cells(0).Value = Mireader("numlinea").ToString
                dg.Rows(n).Cells(1).Value = Mireader("codprod").ToString
                dg.Rows(n).Cells(2).Value = Mireader("descripcion").ToString
                dg.Rows(n).Cells(3).Value = Format(CDbl(Mireader("pvp").ToString), "N2")
                dg.Rows(n).Cells(4).Value = Mireader("cantidad").ToString
                dg.Rows(n).Cells(5).Value = Format(CDbl(Mireader("importe").ToString), "N2")
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

    ' -------- MUESTRA LOS DATOS DEL PROVEEDOR DE LA COMPRA BUSCADA ------------
    Private Sub MostrarDatosProveedor2()
        Try
            ' Abrimos la conexion
            Conexion.Open()
            ' Buscamos en la base de datos los datos del cliente
            consulta = New SqlCommand("SELECT * FROM Proveedores WHERE codprov='" & tproveedor.Text & "';", Conexion)
            Mireader = consulta.ExecuteReader()
            Mireader.Read()
            ' Campos a mostrar
            LabNom.Text = Mireader("nombre").ToString
            LabDir.Text = Mireader("direccion").ToString
            LabNif.Text = Mireader("nif").ToString
            LabCP.Text = Mireader("cp").ToString
            LabLocalidad.Text = Mireader("localidad").ToString
            LabProvincia.Text = Mireader("provincia").ToString
            LabTelefono.Text = Mireader("telefono").ToString
            ' Cerramos las conexiones
            Conexion.Close()
            Mireader.Close()
            ' -------------------------------------------
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    ' -------- MUESTRA LOS DATOS DE LA CABECERA Y EL PIE DE LA COMPRA -------------
    Private Sub MostrarCabeceraPie()
        tcompra.Text = Mireader("codcompra").ToString
        tproveedor.Text = Mireader("codprov").ToString
        dtp.Text = Mireader("fecha").ToString

        limporte.Text = Format(CDbl(Mireader("baseimponible").ToString), "N2")
        liva.Text = Format(CDbl(Mireader("iva").ToString), "N2")
        ltotal.Text = Format(CDbl(Mireader("total").ToString), "N2")
        porcentajeiva = CInt(Mireader("porcentajeiva").ToString)
        formapago = Mireader("formapago").ToString
        tobservaciones.Text = Mireader("observaciones").ToString

        Conexion.Close()
        Mireader.Close()

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

    
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

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