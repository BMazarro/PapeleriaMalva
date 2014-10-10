Imports System.Data.SqlClient

Public Class ProductosLibros

    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New PapeleriaDataSet

    Dim coda, desa, isbnl, titulol, autorl, editoriall, cursol As String
    Dim stocka, stockl As Integer
    Dim pvpa, pvpl As Double

    Private Sub ProductosLibros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Try
            Conexion.Open()

            consulta = New SqlCommand("Select * from Libros", Conexion)
            ' Rellemos el datareader con los datos
            Mireader = consulta.ExecuteReader()
            ' Leemos el datareader
            While Mireader.Read()
                ' Mostramos los datos de los clientes
                MostrarDatosLibros()
            End While
            Mireader.Close()
        Catch ex As Exception
            MsgBox("No existen productos")

        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub

    Public Sub MostrarDatosLibros()
        isbnl = Mireader("isbn").ToString
        titulol = Mireader("titulo").ToString
        autorl = Mireader("autor").ToString
        editoriall = Mireader("editorial").ToString
        cursol = Mireader("curso").ToString
        stockl = Mireader("stock").ToString
        pvpl = Mireader("pvp").ToString

        dglibros.Rows.Add(isbnl, titulol, autorl, editoriall, cursol, stockl, pvpl)

    End Sub

    Private Sub dglibros_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dglibros.CellClick
        codproducto = dglibros.Item(0, dglibros.CurrentRow.Index).Value.ToString
        titulolibro = dglibros.Item(1, dglibros.CurrentRow.Index).Value.ToString
        autorlibro = dglibros.Item(2, dglibros.CurrentRow.Index).Value.ToString
        editoriallibro = dglibros.Item(3, dglibros.CurrentRow.Index).Value.ToString
        pvplibro = CDbl(dglibros.Item(6, dglibros.CurrentRow.Index).Value)

        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dglibros.Rows.Clear()
        cargarLibroCurso(1)
    End Sub

    Public Sub cargarLibroCurso(ByVal curso As Integer)
        Dim cadena As String
        Try
            Conexion.Open()
            cadena = "Select * from Libros where curso='" & curso & "';"
            consulta = New SqlCommand(cadena, Conexion)
            ' Rellemos el datareader con los datos
            Mireader = consulta.ExecuteReader()
            ' Leemos el datareader
            While Mireader.Read()
                ' Mostramos los datos de los clientes
                MostrarDatosLibros()
            End While
            Mireader.Close()
        Catch ex As Exception
            MsgBox("No ha libros de ese curso")
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dglibros.Rows.Clear()
        cargarLibroCurso(2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dglibros.Rows.Clear()
        cargarLibroCurso(3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        dglibros.Rows.Clear()
        cargarLibroCurso(4)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        dglibros.Rows.Clear()
        cargarLibroCurso(5)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        dglibros.Rows.Clear()
        cargarLibroCurso(6)
    End Sub


    Private Sub bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsalir.Click
        dglibros.Rows.Clear()
        Me.Dispose()
    End Sub
End Class