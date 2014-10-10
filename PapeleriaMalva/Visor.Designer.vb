<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrViewer
        '
        Me.CrViewer.ActiveViewIndex = -1
        Me.CrViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrViewer.Name = "CrViewer"
        Me.CrViewer.ShowParameterPanelButton = False
        Me.CrViewer.Size = New System.Drawing.Size(527, 457)
        Me.CrViewer.TabIndex = 0
        '
        'Visor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 457)
        Me.Controls.Add(Me.CrViewer)
        Me.Name = "Visor"
        Me.Text = "Visor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
