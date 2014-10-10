Imports System.Data.SqlClient

Public Class Articulos

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



    Private Sub Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        baceptar.Enabled = False
        bcancelar.Enabled = False
        Try
            Conexion.Open()
            cadena = "SELECT COUNT(*) FROM ARTICULOS"
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

    End Sub

    ' CARGA EN LA POSICION INDICADA
    Private Sub CargarEnPosicion(ByVal pos As Integer)
        Try
            Conexion.Open()
            cadena = "SELECT * FROM ARTICULOS ORDER BY CODART"
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
            tbcodigo.Text = Mireader("CODART").ToString
            tbdesc.Text = Mireader("DESCRIPCION").ToString
            tbprov.Text = Mireader("PROVHAB").ToString
            
            tbstock.Text = Mireader("STOCK").ToString
            tbpreciouc.Text = Mireader("PRECIOULTC").ToString

            tbpvp.Text = Mireader("PVP").ToString
            tbobservaciones.Text = Mireader("OBSERVACIONES").ToString
            If Not Mireader("FECHAULTC").ToString = "" Or Not Mireader("FECHAULTC").ToString = Nothing Then
                tuf = CDate(Mireader("FECHAULTC").ToString)
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
        tbprov.Text = ""
        tbdesc.Text = ""
        tbstock.Text = ""
        tbfechauc.Text = ""
        tbpreciouc.Text = ""
        tbpvp.Text = ""
        tbobservaciones.Text = ""
    End Sub

    ' BORRAR
    Private Sub bborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bborrar.Click
        Dim res As DialogResult = MessageBox.Show("¿Desea borrar el articulo?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If res = Windows.Forms.DialogResult.Yes Then
            Try
                Conexion.Open()
                cadena = "delete from Articulos where codart = '" & tbcodigo.Text & "';"
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
        cod = InputBox("Introduzca el codigo del articulo", "Buscar")
        Try
            Conexion.Open()
            cadena = "select * from Articulos where codart='" & cod & "';"
            consulta = New SqlClient.SqlCommand(cadena, Conexion)
            Mireader = consulta.ExecuteReader
            Mireader.Read()
        Catch ex As Exception
            MsgBox("Debe introducir un codigo de articulo")
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

    Private Sub bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsalir.Click
        Me.Close()
    End Sub

    Public Sub HabilitarEscritura()
        tbcodigo.ReadOnly = False
        tbprov.ReadOnly = False
        tbdesc.ReadOnly = False
        tbstock.ReadOnly = False
        tbfechauc.ReadOnly = False
        tbpreciouc.ReadOnly = False
        tbpvp.ReadOnly = False
        tbobservaciones.ReadOnly = False
    End Sub

    ' ACEPTAR CAMBIOS
    Private Sub baceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baceptar.Click
        baceptar.Enabled = False
        bcancelar.Enabled = False

        If tbpreciouc.Text = "" Then tbpreciouc.Text = 0 Else tbpreciouc.Text = tbpreciouc.Text.Replace(",", ".")
        If tbpvp.Text = "" Then tbpvp.Text = 0 Else tbpvp.Text = tbpvp.Text.Replace(",", ".")
        If tbstock.Text = "" Then tbstock.Text = 0

        If IsNumeric(tbcodigo.Text) Then
            If (opcion = 1) Then
                Try

                    Conexion.Open()
                    If tbfechauc.Text = "" Then
                        cadena = "Insert into Articulos(codart, descripcion, stock, precioultc, fechaultc, provhab, pvp, observaciones)" &
                                   "VALUES(" & "'" & tbcodigo.Text & "'" & "," & "'" & tbdesc.Text & "'" & "," &
                                   tbstock.Text & "," & tbpreciouc.Text & "," &
                                   " NULL " & "," &
                                   "'" & tbprov.Text & "'" & "," & tbpvp.Text & ",'" & tbobservaciones.Text & "');"
                        consulta = New SqlClient.SqlCommand(cadena, Conexion)

                    Else
                        cadena = "insert into Articulos(codart, descripcion, stock, precioultc, fechaultc, provhab, pvp, observaciones)" &
                                  "VALUES(" & "'" & tbcodigo.Text & "'" & "," & "'" & tbdesc.Text & "'" & "," &
                                   tbstock.Text & "," & tbpreciouc.Text & ",'" &
                                   tbfechauc.Text & "'," &
                                   "'" & tbprov.Text & "'" & "," & tbpvp.Text & ",'" & tbobservaciones.Text & "');"
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
                        cadena = "update Articulos set codart=" & "'" & tbcodigo.Text & "'" & "," &
                                    " descripcion=" & "'" & tbdesc.Text & "'" & "," & " stock=" & tbstock.Text & "," & " precioultc=" & tbpreciouc.Text &
                                    "," & " fechaultc= NULL " &
                                    "," & " provhab=" & "'" & tbprov.Text & "'" &
                                    "," & " pvp=" & tbpvp.Text &
                                    " where codart='" & tbcodigo.Text & "';"
                        consulta = New SqlClient.SqlCommand(cadena, Conexion)
                    Else
                        cadena = "update Articulos set codart=" & "'" & tbcodigo.Text & "'" & "," &
                                    " descripcion=" & "'" & tbdesc.Text & "'" & "," & " stock=" & tbstock.Text & "," & " precioultc=" & tbpreciouc.Text &
                                    "," & " fechaultc=" & "'" & tbfechauc.Text & "'" &
                                    "," & " provhab=" & "'" & tbprov.Text & "'" &
                                    "," & " pvp=" & tbpvp.Text &
                                    " where codart='" & tbcodigo.Text & "';"
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
            MsgBox("El código del articulos es obligatorio")
            Habilitar()
            Conexion.Close()
        End If
    End Sub

    
End Class