Imports System.Data.SqlClient

Public Class Clientes

    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim cadena As String
    '----------------------------------------------------------------------------------------------------------
    Dim contador As Integer = 0
    Dim posicion As Integer = 0
    Dim ultimoregistro As Integer = 0
    Dim opcion As Integer = 0
    Dim fecha As Date = Date.Now

    ' -------------- SALIR ---------------------------------------------------------------------------------
    Private Sub bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsalir.Click
        Me.Close()
    End Sub

    '-------------- INICIO ----------------------------------------------------------------------------------
    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        baceptar.Enabled = False
        bcancelar.Enabled = False

        'MessageBox.Show("Conectado")
        Try
            Conexion.Open()
            cadena = "SELECT COUNT(*) FROM CLIENTES"
            consulta = New SqlCommand(cadena, Conexion)
            ultimoregistro = consulta.ExecuteScalar()   'Obtenemos la cantidad de registros
            Conexion.Close()
        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión")
            Conexion.Close()
        End Try
        If Not ultimoregistro = Nothing Then
            CargarEnPosicion(0)
        End If

        'MessageBox.Show("El numero de registros es: " & ultimoregistro)

    End Sub

    ' CARGA EN LA POSICION INDICADA
    Private Sub CargarEnPosicion(ByVal pos As Integer)
        Try
            Conexion.Open()
            cadena = "SELECT * FROM CLIENTES ORDER BY CODCLI"
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

    ' MUESTRA LOS DATOS
    Private Sub MostrarDatos()
        Dim tuf As Date
        Try
            tbcodigo.Text = Mireader("CODCLI").ToString
            tbnombre.Text = Mireader("NOMBRE").ToString
            tbnif.Text = Mireader("NIF").ToString
            tbdireccion.Text = Mireader("DIRECCION").ToString
            tbcodp.Text = Mireader("CP").ToString
            tblocalidad.Text = Mireader("LOCALIDAD").ToString
            tbprovincia.Text = Mireader("PROVINCIA").ToString
            tbtelefono.Text = Mireader("TELEFONO").ToString
            tbemail.Text = Mireader("EMAIL").ToString
            tbbanco.Text = Mireader("BANCO").ToString
            tbcuenta.Text = Mireader("CUENTA").ToString
            tbobservaciones.Text = Mireader("OBSERVACIONES").ToString
            If Not Mireader("FECHAULTCOMPRA").ToString = "" Or Not Mireader("FECHAULTCOMPRA").ToString = Nothing Then
                tuf = CDate(Mireader("FECHAULTCOMPRA").ToString)
                tbfechauc.Text = Format(tuf, "d")
            Else
                tbfechauc.Text = ""
            End If
        Catch ex As Exception
            Conexion.Close()
        End Try
    End Sub

    ' IR UNA POSICION ADELANTE
    Private Sub bavance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bavance.Click
        If ((posicion + 1) >= ultimoregistro) Then
            'MsgBox("No hay más registros")
        End If
        If ((posicion + 1) < ultimoregistro) Then
            CargarEnPosicion(posicion + 1)
        End If
    End Sub

    ' IR UNA POSICION ATRAS
    Private Sub bretroceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bretroceso.Click
        If ((posicion - 1) < 0) Then
            'MsgBox("No hay más registros")
        End If
        If ((posicion - 1) >= 0) Then
            CargarEnPosicion(posicion - 1)
        End If
    End Sub

    ' IR A POSICION FINAL
    Private Sub bultimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bultimo.Click
        CargarEnPosicion(ultimoregistro - 1)
    End Sub

    ' IR A POSICION INICIAL
    Private Sub bprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bprimer.Click
        CargarEnPosicion(0)
    End Sub

    ' BOTON NUEVO CLIENTE
    Private Sub bnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnuevo.Click
        opcion = 1
        baceptar.Enabled = True
        bcancelar.Enabled = True
        Limpiar()
        Deshabilitar()
        posicion = ultimoregistro
        HabilitarEscritura()
    End Sub


    ' ACEPTAR CAMBIOS
    Private Sub baceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baceptar.Click
        baceptar.Enabled = False
        bcancelar.Enabled = False

        If IsNumeric(tbcodigo.Text) And Not tbnombre.Text.Equals("") Then
            If (opcion = 1) Then
                Try
                    Conexion.Open()
                    If tbfechauc.Text = "" Then
                        cadena = "Insert into Clientes(codcli, nombre, nif, direccion, cp, localidad, provincia, telefono, email, fechaultcompra, banco, cuenta, observaciones)" &
                                   "VALUES(" & "'" & tbcodigo.Text & "'" & "," & "'" & tbnombre.Text & "'" & "," &
                                   "'" & tbnif.Text & "'" & "," & "'" & tbdireccion.Text & "'" & "," &
                                   "'" & tbcodp.Text & "'" & "," & "'" & tblocalidad.Text & "'" & "," &
                                   "'" & tbprovincia.Text & "'" & "," & "'" & tbtelefono.Text & "'" & "," &
                                   "'" & tbemail.Text & "'" & "," &
                                   " NULL " & "," &
                                   "'" & tbbanco.Text & "'" & "," & "'" & tbcuenta.Text & "'" & ", '" & tbobservaciones.Text & "');"
                        consulta = New SqlClient.SqlCommand(cadena, Conexion)

                    Else
                        cadena = "insert into Clientes(codcli, nombre, nif, direccion, cp, localidad, provincia, telefono, email, fechaultcompra, banco, cuenta, observaciones)" &
                                  "VALUES(" & "'" & tbcodigo.Text & "'" & "," & "'" & tbnombre.Text & "'" & "," &
                                   "'" & tbnif.Text & "'" & "," & "'" & tbdireccion.Text & "'" & "," &
                                   "'" & tbcodp.Text & "'" & "," & "'" & tblocalidad.Text & "'" & "," &
                                   "'" & tbprovincia.Text & "'" & "," & "'" & tbtelefono.Text & "'" & "," &
                                   "'" & tbemail.Text & "'" & ",'" &
                                   tbfechauc.Text & "'," &
                                   "'" & tbbanco.Text & "'" & "," & "'" & tbcuenta.Text & "'" & ", '" & tbobservaciones.Text & "');"
                        consulta = New SqlClient.SqlCommand(cadena, Conexion)

                    End If

                    consulta.ExecuteNonQuery()
                    ultimoregistro = ultimoregistro + 1
                    Conexion.Close()
                    CargarEnPosicion(posicion)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Conexion.Close()
                End Try

            ElseIf (opcion = 2) Then
                Try
                    Conexion.Open()
                    If (tbfechauc.Text = "") Then
                        cadena = "update Clientes set codcli=" & "'" & tbcodigo.Text & "'" & "," &
                                    " nombre=" & "'" & tbnombre.Text & "'" & "," & " nif=" & "'" & tbnif.Text & "'" & "," & " direccion=" & "'" & tbdireccion.Text & "'" &
                                    "," & " cp=" & "'" & tbcodp.Text & "'" & "," & " localidad=" &
                                    "'" & tblocalidad.Text & "'" & "," & " provincia=" & "'" & tbprovincia.Text & "'" &
                                    "," & " telefono=" & "'" & tbtelefono.Text & "'" & "," & " email=" & "'" & tbemail.Text & "'" &
                                    "," & " fechaultcompra= NULL " &
                                    "," & " banco=" & "'" & tbbanco.Text & "'" & "," & " cuenta=" & "'" & tbcuenta.Text & "'" &
                                    "," & " observaciones='" & tbobservaciones.Text & "'" &
                                    " where codcli='" & tbcodigo.Text & "';"
                        consulta = New SqlClient.SqlCommand(cadena, Conexion)
                    Else
                        cadena = "update Clientes set codcli=" & "'" & tbcodigo.Text & "'" & "," &
                                    " nombre=" & "'" & tbnombre.Text & "'" & "," & " nif=" & "'" & tbnif.Text & "'" & "," & " direccion=" & "'" & tbdireccion.Text & "'" &
                                    "," & " cp=" & "'" & tbcodp.Text & "'" & "," & " localidad=" &
                                    "'" & tblocalidad.Text & "'" & "," & " provincia=" & "'" & tbprovincia.Text & "'" &
                                    "," & " telefono=" & "'" & tbtelefono.Text & "'" & "," & " email=" & "'" & tbemail.Text & "'" &
                                    "," & " fechaultcompra='" & tbfechauc.Text & "'" &
                                    "," & " banco=" & "'" & tbbanco.Text & "'" & "," & " cuenta=" & "'" & tbcuenta.Text & "'" &
                                    "," & " observaciones='" & tbobservaciones.Text & "'" &
                                    " where codcli='" & tbcodigo.Text & "';"
                        consulta = New SqlClient.SqlCommand(cadena, Conexion)
                    End If
                    consulta.ExecuteNonQuery()
                    Conexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Conexion.Close()
                End Try
            Else
                MsgBox("Debe añadir uno nuevo o pulsar modificar para poder aceptar cambios")
            End If
            opcion = 0
            Habilitar()
        Else
            MsgBox("El código del cliente y el nombre son obligatorios")
            Habilitar()
            Conexion.Close()
        End If
    End Sub

    ' HABILITAR
    Private Sub Habilitar()
        bnuevo.Enabled = True
        bborrar.Enabled = True
        bmodifica.Enabled = True
        bbuscar.Enabled = True
        bavance.Enabled = True
        bprimer.Enabled = True
        bultimo.Enabled = True
        bretroceso.Enabled = True
        bsalir.Enabled = True
    End Sub

    ' DESHABILITAR 
    Public Sub Deshabilitar()
        bmodifica.Enabled = False
        bbuscar.Enabled = False
        bavance.Enabled = False
        bborrar.Enabled = False
        bretroceso.Enabled = False
        bprimer.Enabled = False
        bultimo.Enabled = False
        bsalir.Enabled = False
        bnuevo.Enabled = False
    End Sub

    ' LIMPIAR
    Private Sub Limpiar()
        tbcodigo.Text = ""
        tbnombre.Text = ""
        tbnif.Text = ""
        tbdireccion.Text = ""
        tbcodp.Text = ""
        tblocalidad.Text = ""
        tbprovincia.Text = ""
        tbtelefono.Text = ""
        tbemail.Text = ""
        tbfechauc.Text = ""
        tbbanco.Text = ""
        tbcuenta.Text = ""
        tbobservaciones.Text = ""
    End Sub

    ' BORRAR
    Private Sub bborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bborrar.Click
        Dim res As DialogResult = MessageBox.Show("¿Desea borrar el cliente?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If res = Windows.Forms.DialogResult.Yes Then
            Try
                Conexion.Open()
                cadena = "delete from Clientes where codcli = '" & tbcodigo.Text & "';"
                consulta = New SqlCommand(cadena, Conexion)
                consulta.ExecuteNonQuery()
                ultimoregistro = ultimoregistro - 1
                Conexion.Close()
                If (posicion = ultimoregistro) Then
                    CargarEnPosicion(0)
                End If
                If (posicion <> ultimoregistro) Then
                    CargarEnPosicion(posicion)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Conexion.Close()
            End Try
        End If
    End Sub

    ' MODIFICAR
    Private Sub bmodifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmodifica.Click
        opcion = 2
        baceptar.Enabled = True
        bcancelar.Enabled = True
        Deshabilitar()
        HabilitarEscritura()
    End Sub

    ' BUSCAR
    Private Sub bbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscar.Click
        Dim cod As String
        cod = InputBox("Introduzca el codigo del cliente", "Buscar")
        Try
            Conexion.Open()
            cadena = "select * from Clientes where codcli='" & cod & "';"
            consulta = New SqlClient.SqlCommand(cadena, Conexion)
            Mireader = consulta.ExecuteReader
            Mireader.Read()
        Catch ex As Exception
            MsgBox("Debe introducir un codigo de cliente")
            Conexion.Close()
        End Try
        MostrarDatos()
        Conexion.Close()
        Mireader.Close()
    End Sub

    ' BOTON CANCELAR
    Private Sub bcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcancelar.Click
        baceptar.Enabled = False
        bcancelar.Enabled = False
        Habilitar()
        If opcion = 1 Then
            CargarEnPosicion(0)
        Else
            CargarEnPosicion(posicion)
        End If
    End Sub

    Public Sub HabilitarEscritura()
        tbcodigo.ReadOnly = False
        tbnombre.ReadOnly = False
        tbnif.ReadOnly = False
        tbdireccion.ReadOnly = False
        tbfechauc.ReadOnly = False
        tbbanco.ReadOnly = False
        tbcuenta.ReadOnly = False
        tbobservaciones.ReadOnly = False
        tbcodp.ReadOnly = False
        tblocalidad.ReadOnly = False
        tbprovincia.ReadOnly = False
        tbtelefono.ReadOnly = False
        tbemail.ReadOnly = False
    End Sub

End Class