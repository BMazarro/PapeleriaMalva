Public Class ConfiguracionEmpresa

    Private Sub ConfiguracionEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'TODO: esta línea de código carga datos en la tabla 'PapeleriaDataSet1.IVA' Puede moverla o quitarla según sea necesario.
        Me.IVATableAdapter.Fill(Me.PapeleriaDataSet1.IVA)
        'TODO: esta línea de código carga datos en la tabla 'PapeleriaDataSet1.FORMASPAGO' Puede moverla o quitarla según sea necesario.
        Me.FORMASPAGOTableAdapter.Fill(Me.PapeleriaDataSet1.FORMASPAGO)
        'TODO: esta línea de código carga datos en la tabla 'PapeleriaDataSet1.EMPRESA' Puede moverla o quitarla según sea necesario.
        Me.EMPRESATableAdapter.Fill(Me.PapeleriaDataSet1.EMPRESA)

    End Sub

    ' BOTON GUARDAR DATOS PERSONALES DE LA EMPRESA
    Private Sub GuardarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton.Click
        Me.Validate()
        Me.EMPRESABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PapeleriaDataSet1)
    End Sub

    ' BOTON GUARDAR FORMAS DE PAGO
    Private Sub GuardarToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton1.Click
        Me.Validate()
        Me.FORMASPAGOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PapeleriaDataSet1)
    End Sub

    ' BOTON GUARDAR TIPOS DE IVA
    Private Sub GuardarToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripButton2.Click
        Me.Validate()
        Me.IVABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PapeleriaDataSet1)
    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub
End Class