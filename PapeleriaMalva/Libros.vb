Imports System.Data.SqlClient

Public Class Libros
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
    Dim etapa As String

    Private Sub Libros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        baceptar.Enabled = False
        bcancelar.Enabled = False
        Try
            Conexion.Open()
            cadena = "SELECT COUNT(*) FROM LIBROS"
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
            cadena = "SELECT * FROM LIBROS"
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

        Try
            tbisbn.Text = Mireader("ISBN").ToString
            tbtitulo.Text = Mireader("TITULO").ToString
            tbautor1.Text = Mireader("AUTOR").ToString

            tbeditorial.Text = Mireader("EDITORIAL").ToString
            tbpaginas.Text = Mireader("PAGINAS").ToString
            tbcurso.Text = Mireader("CURSO").ToString
            tbstock.Text = Mireader("STOCK").ToString
            tbpvp.Text = Mireader("PVP").ToString
            'LabEtapa.Text = Mireader("ETAPA").ToString
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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

    Private Sub bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsalir.Click
        Me.Close()
    End Sub

    ' BOTON NUEVO LIBRO
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
        tbisbn.Text = ""
        tbtitulo.Text = ""
        tbautor1.Text = ""
        tbstock.Text = ""
        tbeditorial.Text = ""
        tbpaginas.Text = ""
        tbpvp.Text = ""
        tbcurso.Text = ""
    End Sub

    ' BORRAR
    Private Sub bborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bborrar.Click
        Dim res As DialogResult = MessageBox.Show("¿Desea borrar el libro?", "Borrar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If res = Windows.Forms.DialogResult.Yes Then
            Try
                Conexion.Open()
                cadena = "delete from LIBROS where ISBN = '" & tbisbn.Text & "';"
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

    Private Sub bmodifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmodifica.Click
        opcion = 2
        baceptar.Enabled = True
        bcancelar.Enabled = True
        Deshabilitar()
        HabilitarEscritura()
    End Sub

    Private Sub bbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbuscar.Click
        Dim cod As String
        cod = InputBox("Introduzca el isbn del libro", "Buscar")
        Try
            Conexion.Open()
            cadena = "select * from LIBROS where ISBN='" & tbisbn.Text & "';"
            consulta = New SqlClient.SqlCommand(cadena, Conexion)
            Mireader = consulta.ExecuteReader
            Mireader.Read()
        Catch ex As Exception
            MsgBox("Debe introducir un isbn de un libro")
            Conexion.Close()
        End Try
        MostrarDatos()
        Conexion.Close()
        Mireader.Close()
    End Sub

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
        tbisbn.ReadOnly = False
        tbtitulo.ReadOnly = False
        tbautor1.ReadOnly = False
        tbstock.ReadOnly = False
        tbeditorial.ReadOnly = False
        tbpaginas.ReadOnly = False
        tbpvp.ReadOnly = False
        tbcurso.ReadOnly = False
    End Sub

    Private Sub baceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baceptar.Click
        baceptar.Enabled = False
        bcancelar.Enabled = False

        If tbpvp.Text = "" Then tbpvp.Text = 0 Else tbpvp.Text = tbpvp.Text.Replace(",", ".")
        If tbstock.Text = "" Then tbstock.Text = 0

        If IsNumeric(tbisbn.Text) Then
            If (opcion = 1) Then
                Try

                    Conexion.Open()

                    cadena = "insert into libros(isbn, titulo, autor, editorial, paginas, curso, stock, pvp)" &
                              "VALUES(" & "'" & tbisbn.Text & "'" & "," & "'" & tbtitulo.Text & "'" & "," &
                               "'" & tbautor1.Text & "','" & tbeditorial.Text & "','" &
                               tbpaginas.Text & "','" & tbcurso.Text & "'," & tbstock.Text & "," & tbpvp.Text & ");"
                    consulta = New SqlClient.SqlCommand(cadena, Conexion)

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

                    cadena = "update libros set isbn=" & "'" & tbisbn.Text & "'" & "," &
                                    " titulo=" & "'" & tbtitulo.Text & "'" & "," & " autor='" & tbautor1.Text & "'" &
                                    "," & " editorial=" & "'" & tbeditorial.Text & "'" &
                                    "," & " paginas=" & "'" & tbpaginas.Text & "'" &
                                    "," & " curso='" & tbcurso.Text & "'" &
                                    "," & " stock=" & tbstock.Text &
                                    "," & " pvp=" & tbpvp.Text &
                                    " where isbn='" & tbisbn.Text & "';"
                    consulta = New SqlClient.SqlCommand(cadena, Conexion)

                    consulta.ExecuteNonQuery()
                    Conexion.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Conexion.Close()
                End Try
            End If
            opcion = 0
            Habilitar()
        Else
            MsgBox("No es numerico")
            Habilitar()
            Conexion.Close()
        End If

    End Sub
End Class