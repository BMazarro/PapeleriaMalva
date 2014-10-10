<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedasCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedasCompras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.NumCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fech = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codproveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.impor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baceptar = New System.Windows.Forms.Button()
        Me.tbuscar = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Button1.Location = New System.Drawing.Point(444, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 38)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bbuscar
        '
        Me.bbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbuscar.Location = New System.Drawing.Point(173, 67)
        Me.bbuscar.Name = "bbuscar"
        Me.bbuscar.Size = New System.Drawing.Size(75, 23)
        Me.bbuscar.TabIndex = 14
        Me.bbuscar.Text = "BUSCAR"
        Me.bbuscar.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumCompra, Me.fech, Me.codproveedor, Me.no, Me.impor})
        Me.dg.Location = New System.Drawing.Point(24, 118)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(449, 149)
        Me.dg.TabIndex = 13
        '
        'NumCompra
        '
        Me.NumCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NumCompra.DefaultCellStyle = DataGridViewCellStyle1
        Me.NumCompra.HeaderText = "Nº"
        Me.NumCompra.Name = "NumCompra"
        Me.NumCompra.ReadOnly = True
        Me.NumCompra.Width = 44
        '
        'fech
        '
        Me.fech.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.fech.DefaultCellStyle = DataGridViewCellStyle2
        Me.fech.HeaderText = "Fecha"
        Me.fech.Name = "fech"
        Me.fech.ReadOnly = True
        Me.fech.Width = 62
        '
        'codproveedor
        '
        Me.codproveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.NullValue = Nothing
        Me.codproveedor.DefaultCellStyle = DataGridViewCellStyle3
        Me.codproveedor.HeaderText = "Proveedor"
        Me.codproveedor.Name = "codproveedor"
        Me.codproveedor.ReadOnly = True
        Me.codproveedor.Width = 81
        '
        'no
        '
        Me.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.no.HeaderText = "Nombre"
        Me.no.Name = "no"
        '
        'impor
        '
        Me.impor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.impor.DefaultCellStyle = DataGridViewCellStyle4
        Me.impor.HeaderText = "Importe"
        Me.impor.Name = "impor"
        Me.impor.ReadOnly = True
        Me.impor.Width = 67
        '
        'baceptar
        '
        Me.baceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baceptar.Location = New System.Drawing.Point(201, 293)
        Me.baceptar.Name = "baceptar"
        Me.baceptar.Size = New System.Drawing.Size(75, 23)
        Me.baceptar.TabIndex = 12
        Me.baceptar.Text = "ACEPTAR"
        Me.baceptar.UseVisualStyleBackColor = True
        '
        'tbuscar
        '
        Me.tbuscar.Location = New System.Drawing.Point(132, 67)
        Me.tbuscar.Name = "tbuscar"
        Me.tbuscar.Size = New System.Drawing.Size(35, 20)
        Me.tbuscar.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(24, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(102, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Azure
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Desea buscar por el código del proveedor o por el numero de compra?"
        '
        'BusquedasCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(483, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bbuscar)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.baceptar)
        Me.Controls.Add(Me.tbuscar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "BusquedasCompras"
        Me.ShowIcon = False
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bbuscar As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents baceptar As System.Windows.Forms.Button
    Friend WithEvents tbuscar As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fech As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codproveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents impor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
