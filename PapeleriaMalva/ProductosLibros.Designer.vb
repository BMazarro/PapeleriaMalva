<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductosLibros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductosLibros))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dglibros = New System.Windows.Forms.DataGridView()
        Me.isbn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.autor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editorial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocklibros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pvplib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsalir = New System.Windows.Forms.Button()
        CType(Me.dglibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Azure
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Seleccione algún elemento de la tabla.."
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.CadetBlue
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(492, 85)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(30, 32)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.CadetBlue
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(456, 85)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 32)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.CadetBlue
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(420, 85)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 32)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.CadetBlue
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(384, 85)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 32)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CadetBlue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(348, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(312, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Libros"
        '
        'dglibros
        '
        Me.dglibros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dglibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dglibros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.isbn, Me.titulo, Me.autor, Me.editorial, Me.curso, Me.stocklibros, Me.pvplib})
        Me.dglibros.Location = New System.Drawing.Point(32, 129)
        Me.dglibros.Name = "dglibros"
        Me.dglibros.ReadOnly = True
        Me.dglibros.Size = New System.Drawing.Size(789, 354)
        Me.dglibros.TabIndex = 12
        '
        'isbn
        '
        Me.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.isbn.HeaderText = "ISBN"
        Me.isbn.Name = "isbn"
        Me.isbn.ReadOnly = True
        Me.isbn.Width = 57
        '
        'titulo
        '
        Me.titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.titulo.HeaderText = "Titulo"
        Me.titulo.Name = "titulo"
        Me.titulo.ReadOnly = True
        '
        'autor
        '
        Me.autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.autor.HeaderText = "Autor"
        Me.autor.Name = "autor"
        Me.autor.ReadOnly = True
        '
        'editorial
        '
        Me.editorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.editorial.HeaderText = "Editorial"
        Me.editorial.Name = "editorial"
        Me.editorial.ReadOnly = True
        '
        'curso
        '
        Me.curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.curso.HeaderText = "Curso"
        Me.curso.Name = "curso"
        Me.curso.ReadOnly = True
        Me.curso.Width = 59
        '
        'stocklibros
        '
        Me.stocklibros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.stocklibros.HeaderText = "Stock"
        Me.stocklibros.Name = "stocklibros"
        Me.stocklibros.ReadOnly = True
        Me.stocklibros.Width = 60
        '
        'pvplib
        '
        Me.pvplib.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.pvplib.HeaderText = "PVP"
        Me.pvplib.Name = "pvplib"
        Me.pvplib.ReadOnly = True
        Me.pvplib.Width = 53
        '
        'bsalir
        '
        Me.bsalir.BackColor = System.Drawing.Color.Transparent
        Me.bsalir.BackgroundImage = CType(resources.GetObject("bsalir.BackgroundImage"), System.Drawing.Image)
        Me.bsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bsalir.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.bsalir.FlatAppearance.BorderSize = 0
        Me.bsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.bsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.bsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsalir.Location = New System.Drawing.Point(786, 12)
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(35, 38)
        Me.bsalir.TabIndex = 20
        Me.bsalir.UseVisualStyleBackColor = False
        '
        'ProductosLibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(837, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.bsalir)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dglibros)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ProductosLibros"
        Me.ShowIcon = False
        CType(Me.dglibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dglibros As System.Windows.Forms.DataGridView
    Friend WithEvents isbn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents autor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents editorial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents curso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stocklibros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pvplib As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsalir As System.Windows.Forms.Button
End Class
