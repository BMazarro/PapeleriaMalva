Imports System.Data.SqlClient

Public Class Principal

    Dim Conexion As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DAM2_1314\Beatriz\PapeleriaMalva\Papeleria.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim consulta As New SqlCommand
    Dim Mireader As SqlDataReader
    Dim mivisor As New Visor

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub MantenimientoClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoClientesToolStripMenuItem.Click
        Dim b As New Clientes
        b.ShowDialog()
    End Sub

    Private Sub ListadoClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Dim informeclientes As New CrClientes
        Dim ds As New ClienteDataSet
        Dim consulta As String = "Select * from Clientes order by nombre"
        Dim da As New SqlClient.SqlDataAdapter(consulta, Conexion)

        Try
            Conexion.Open()
            da.Fill(ds, "Clientes")
            'mivisor.CrViewer.ReportSource = informeclientes
            'informeclientes.SetDataSource(ds)
            mivisor.ShowDialog()
            Conexion.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        leerDatosEmpresa()
    End Sub

    Private Sub MantenimientoProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoProveedoresToolStripMenuItem.Click
        Dim b As New Proveedores
        b.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub MantenimientoLibrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoLibrosToolStripMenuItem.Click
        Dim b As New Libros
        b.ShowDialog()
    End Sub

    Private Sub MantenimientoArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoArticulosToolStripMenuItem.Click
        Dim b As New Articulos
        b.showDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bclientes.Click
        Dim b As New Clientes
        b.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butilidades.Click
        Dim b As New utilidades
        b.ShowDialog()
    End Sub

    Private Sub bcompras_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles bcompras.MouseLeave
        bcompras.Size = New Size(218, 246)
    End Sub

    Private Sub bcompras_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bcompras.MouseMove
        bcompras.Size = New Size(208, 236)
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles bventas.MouseLeave
        bventas.Size = New Size(240, 128)
    End Sub

    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bventas.MouseMove
        bventas.Size = New Size(230, 118)
    End Sub

    Private Sub barticulos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles barticulos.MouseLeave
        barticulos.Size = New Size(178, 128)
    End Sub

    Private Sub barticulos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barticulos.MouseMove
        barticulos.Size = New Size(168, 118)
    End Sub

    Private Sub bclientes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles bclientes.MouseLeave
        bclientes.Size = New Size(157, 165)
    End Sub

    Private Sub bclientes_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bclientes.MouseMove
        bclientes.Size = New Size(147, 155)
    End Sub

    Private Sub butilidades_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles butilidades.MouseLeave
        butilidades.Size = New Size(149, 136)
    End Sub

    Private Sub butilidades_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles butilidades.MouseMove
        butilidades.Size = New Size(139, 126)
    End Sub

    Private Sub blibros_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles blibros.MouseLeave
        blibros.Size = New Size(151, 183)
    End Sub

    Private Sub blibros_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles blibros.MouseMove
        blibros.Size = New Size(141, 173)
    End Sub

    Private Sub breservas_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles breservas.MouseLeave
        breservas.Size = New Size(240, 108)
    End Sub

    Private Sub breservas_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles breservas.MouseMove
        breservas.Size = New Size(230, 98)
    End Sub


    Private Sub blistados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bventas.Click
        Dim b As New Ventas
        b.ShowDialog()
    End Sub

    Private Sub barticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barticulos.Click
        Dim b As New Articulos
        b.ShowDialog()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Dim b As New ConfiguracionEmpresa
        b.ShowDialog()
    End Sub

    Private Sub blibros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles blibros.Click
        Dim b As New Libros
        b.ShowDialog()
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        Dim b As New Ventas
        b.ShowDialog()
    End Sub

    Private Sub NuevaCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaCompraToolStripMenuItem.Click
        Dim b As New Compras
        b.ShowDialog()
    End Sub

    Private Sub NuevaReservaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaReservaToolStripMenuItem.Click
        Dim b As New Reservas
        b.ShowDialog()
    End Sub

    Private Sub breservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles breservas.Click
        Dim b As New Reservas
        b.ShowDialog()
    End Sub

    Private Sub DevolucionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionesToolStripMenuItem1.Click
        Dim b As New Devoluciones
        b.ShowDialog()
    End Sub

    Private Sub bcompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcompras.Click
        Dim b As New Compras
        b.ShowDialog()
    End Sub

    Private Sub FacturarCajaDiariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturarCajaDiariaToolStripMenuItem.Click
        Dim b As New FacturarCaja
        b.ShowDialog()
    End Sub

    Private Sub ImprimirFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirFacturasToolStripMenuItem.Click
        Dim b As New ImprimirFacturas
        b.showDialog()
    End Sub

    Private Sub MostrarLibroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarLibroToolStripMenuItem.Click
        Dim b As New MostrarLibro
        b.showDialog()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim b As New Acercade
        b.showDialog()
    End Sub

    Private Sub ListadoAlfClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoAlfClientesToolStripMenuItem.Click
        Dim informeclientes As New CrClientes
        Dim ds As New PapeleriaDataSet
        Dim consulta As String = "Select * from Clientes order by nombre"
        Dim da As New SqlClient.SqlDataAdapter(consulta, Conexion)

        Try
            Conexion.Open()
            da.Fill(ds, "Clientes")
            mivisor.CrViewer.ReportSource = informeclientes
            informeclientes.SetDataSource(ds)
            mivisor.ShowDialog()
            Conexion.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class
