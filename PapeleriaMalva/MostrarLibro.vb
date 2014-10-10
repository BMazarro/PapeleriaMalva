Imports System.Data.SqlClient

Public Class MostrarLibro

    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim ds As New PapeleriaDataSet

    Private Sub MostrarLibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        trep.ReadOnly = True
        tsop.ReadOnly = True
        ttotal.ReadOnly = True
        Me.CenterToScreen()
        ' Borramos las tablas
        dg1.Rows.Clear()
        dg2.Rows.Clear()

        ' Cargamos los datos en la tabla Repercutidos (corresponden a las Ventas)
        Try
            Conexion.Open()
            consulta = New SqlCommand("Select codfact, fecha, nombre, nif, bases, porcentajeiva,totalfactura,tipo2 from LibroIva where tipo = 'R'", Conexion)
            Mireader = consulta.ExecuteReader() ' Devuelve un conjunto de registros
            While Mireader.Read
                dg1.Rows.Add(Mireader.GetValue(0), Format(Mireader.GetValue(1), "d"), Mireader.GetValue(2), Mireader.GetValue(3), Mireader.GetValue(4), Mireader.GetValue(5), Mireader.GetValue(6), Mireader.GetValue(7))
            End While
            Mireader.Close()
            Conexion.Close()
        Catch ex As Exception
            Conexion.Close()
        End Try

        ' Cargamos los datos en la tabla Soportados (corresponden a las compras)
        Try
            Conexion.Open()
            consulta = New SqlCommand("Select codfact, fecha, nombre, nif, bases,porcentajeiva, totalfactura from LibroIva where tipo = 'S'", Conexion)
            Mireader = consulta.ExecuteReader() ' Devuelve un conjunto de registros
            While Mireader.Read
                dg2.Rows.Add(Mireader.GetValue(0), Format(Mireader.GetValue(1), "d"), Mireader.GetValue(2), Mireader.GetValue(3), Mireader.GetValue(4), Mireader.GetValue(5), Mireader.GetValue(6))
            End While
            Mireader.Close()
            Conexion.Close()
        Catch ex As Exception
            Conexion.Close()
        End Try
    End Sub


    Private Sub bsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim importetotal As Double = 0.0
        For i = 0 To dg1.RowCount - 1
            importetotal = importetotal + dg1.Item(6, i).Value
        Next
        trep.Text = importetotal

        For j = 0 To dg2.RowCount - 1
            importetotal = importetotal + dg2.Item(6, j).Value
        Next
        tsop.Text = importetotal

        ttotal.Text = CDbl(trep.Text) - CDbl(tsop.Text)


    End Sub
End Class