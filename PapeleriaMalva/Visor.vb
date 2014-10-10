Public Class Visor

    Private Sub Visor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CrViewer.RefreshReport()
    End Sub

    Private Sub CrViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrViewer.Load

    End Sub
End Class