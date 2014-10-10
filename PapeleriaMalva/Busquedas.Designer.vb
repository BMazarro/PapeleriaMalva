<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busquedas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Busquedas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tbuscar = New System.Windows.Forms.TextBox()
        Me.baceptar = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.NumVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.import = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Azure
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desea buscar por el código de cliente o por el numero de venta?"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(25, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(102, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'tbuscar
        '
        Me.tbuscar.Location = New System.Drawing.Point(133, 72)
        Me.tbuscar.Name = "tbuscar"
        Me.tbuscar.Size = New System.Drawing.Size(35, 20)
        Me.tbuscar.TabIndex = 2
        '
        'baceptar
        '
        Me.baceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baceptar.Location = New System.Drawing.Point(203, 297)
        Me.baceptar.Name = "baceptar"
        Me.baceptar.Size = New System.Drawing.Size(75, 23)
        Me.baceptar.TabIndex = 3
        Me.baceptar.Text = "ACEPTAR"
        Me.baceptar.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumVenta, Me.fecha, Me.codcliente, Me.nomb, Me.import})
        Me.dg.Location = New System.Drawing.Point(25, 123)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(442, 149)
        Me.dg.TabIndex = 6
        '
        'NumVenta
        '
        Me.NumVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NumVenta.DefaultCellStyle = DataGridViewCellStyle1
        Me.NumVenta.HeaderText = "Nº"
        Me.NumVenta.Name = "NumVenta"
        Me.NumVenta.ReadOnly = True
        Me.NumVenta.Width = 44
        '
        'fecha
        '
        Me.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 62
        '
        'codcliente
        '
        Me.codcliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = Nothing
        Me.codcliente.DefaultCellStyle = DataGridViewCellStyle3
        Me.codcliente.HeaderText = "Cliente"
        Me.codcliente.Name = "codcliente"
        Me.codcliente.ReadOnly = True
        Me.codcliente.Width = 64
        '
        'nomb
        '
        Me.nomb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nomb.HeaderText = "Nombre"
        Me.nomb.Name = "nomb"
        '
        'import
        '
        Me.import.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.import.DefaultCellStyle = DataGridViewCellStyle4
        Me.import.HeaderText = "Importe"
        Me.import.Name = "import"
        Me.import.ReadOnly = True
        Me.import.Width = 67
        '
        'bbuscar
        '
        Me.bbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbuscar.Location = New System.Drawing.Point(174, 72)
        Me.bbuscar.Name = "bbuscar"
        Me.bbuscar.Size = New System.Drawing.Size(75, 23)
        Me.bbuscar.TabIndex = 7
        Me.bbuscar.Text = "BUSCAR"
        Me.bbuscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(450, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Busquedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(491, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bbuscar)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.baceptar)
        Me.Controls.Add(Me.tbuscar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Busquedas"
        Me.ShowIcon = False
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents tbuscar As System.Windows.Forms.TextBox
    Friend WithEvents baceptar As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents bbuscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NumVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codcliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents import As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
