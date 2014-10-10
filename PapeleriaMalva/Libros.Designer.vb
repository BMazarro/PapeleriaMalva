<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Libros))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bultimo = New System.Windows.Forms.Button()
        Me.bavance = New System.Windows.Forms.Button()
        Me.bprimer = New System.Windows.Forms.Button()
        Me.bretroceso = New System.Windows.Forms.Button()
        Me.baceptar = New System.Windows.Forms.Button()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.bmodifica = New System.Windows.Forms.Button()
        Me.bnuevo = New System.Windows.Forms.Button()
        Me.bborrar = New System.Windows.Forms.Button()
        Me.bcancelar = New System.Windows.Forms.Button()
        Me.bsalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbpvp = New System.Windows.Forms.TextBox()
        Me.tbstock = New System.Windows.Forms.TextBox()
        Me.tbcurso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbisbn = New System.Windows.Forms.TextBox()
        Me.tbtitulo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbpaginas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbautor1 = New System.Windows.Forms.TextBox()
        Me.tbeditorial = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabEtapa = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.baceptar)
        Me.Panel2.Controls.Add(Me.bbuscar)
        Me.Panel2.Controls.Add(Me.bmodifica)
        Me.Panel2.Controls.Add(Me.bnuevo)
        Me.Panel2.Controls.Add(Me.bborrar)
        Me.Panel2.Controls.Add(Me.bcancelar)
        Me.Panel2.Controls.Add(Me.bsalir)
        Me.Panel2.Location = New System.Drawing.Point(0, 482)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 110)
        Me.Panel2.TabIndex = 87
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.bultimo)
        Me.GroupBox2.Controls.Add(Me.bavance)
        Me.GroupBox2.Controls.Add(Me.bprimer)
        Me.GroupBox2.Controls.Add(Me.bretroceso)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(230, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 55)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        '
        'bultimo
        '
        Me.bultimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bultimo.ForeColor = System.Drawing.Color.Black
        Me.bultimo.Location = New System.Drawing.Point(119, 20)
        Me.bultimo.Name = "bultimo"
        Me.bultimo.Size = New System.Drawing.Size(41, 23)
        Me.bultimo.TabIndex = 39
        Me.bultimo.Text = ">>"
        Me.bultimo.UseVisualStyleBackColor = True
        '
        'bavance
        '
        Me.bavance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bavance.ForeColor = System.Drawing.Color.Black
        Me.bavance.Location = New System.Drawing.Point(84, 20)
        Me.bavance.Name = "bavance"
        Me.bavance.Size = New System.Drawing.Size(29, 23)
        Me.bavance.TabIndex = 38
        Me.bavance.Text = ">"
        Me.bavance.UseVisualStyleBackColor = True
        '
        'bprimer
        '
        Me.bprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bprimer.ForeColor = System.Drawing.Color.Black
        Me.bprimer.Location = New System.Drawing.Point(6, 19)
        Me.bprimer.Name = "bprimer"
        Me.bprimer.Size = New System.Drawing.Size(41, 23)
        Me.bprimer.TabIndex = 35
        Me.bprimer.Text = "<<"
        Me.bprimer.UseVisualStyleBackColor = True
        '
        'bretroceso
        '
        Me.bretroceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bretroceso.ForeColor = System.Drawing.Color.Black
        Me.bretroceso.Location = New System.Drawing.Point(49, 19)
        Me.bretroceso.Name = "bretroceso"
        Me.bretroceso.Size = New System.Drawing.Size(29, 23)
        Me.bretroceso.TabIndex = 36
        Me.bretroceso.Text = "<"
        Me.bretroceso.UseVisualStyleBackColor = True
        '
        'baceptar
        '
        Me.baceptar.BackColor = System.Drawing.Color.Transparent
        Me.baceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baceptar.ForeColor = System.Drawing.Color.Black
        Me.baceptar.Location = New System.Drawing.Point(414, 14)
        Me.baceptar.Name = "baceptar"
        Me.baceptar.Size = New System.Drawing.Size(100, 31)
        Me.baceptar.TabIndex = 26
        Me.baceptar.Text = "ACEPTAR"
        Me.baceptar.UseVisualStyleBackColor = False
        '
        'bbuscar
        '
        Me.bbuscar.BackColor = System.Drawing.Color.Transparent
        Me.bbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbuscar.ForeColor = System.Drawing.Color.Black
        Me.bbuscar.Location = New System.Drawing.Point(119, 14)
        Me.bbuscar.Name = "bbuscar"
        Me.bbuscar.Size = New System.Drawing.Size(99, 31)
        Me.bbuscar.TabIndex = 34
        Me.bbuscar.Text = "BUSCAR"
        Me.bbuscar.UseVisualStyleBackColor = False
        '
        'bmodifica
        '
        Me.bmodifica.BackColor = System.Drawing.Color.Transparent
        Me.bmodifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bmodifica.ForeColor = System.Drawing.Color.Black
        Me.bmodifica.Location = New System.Drawing.Point(119, 67)
        Me.bmodifica.Name = "bmodifica"
        Me.bmodifica.Size = New System.Drawing.Size(99, 31)
        Me.bmodifica.TabIndex = 33
        Me.bmodifica.Text = "MODIFICAR"
        Me.bmodifica.UseVisualStyleBackColor = False
        '
        'bnuevo
        '
        Me.bnuevo.BackColor = System.Drawing.Color.Transparent
        Me.bnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnuevo.ForeColor = System.Drawing.Color.Black
        Me.bnuevo.Location = New System.Drawing.Point(11, 14)
        Me.bnuevo.Name = "bnuevo"
        Me.bnuevo.Size = New System.Drawing.Size(100, 31)
        Me.bnuevo.TabIndex = 31
        Me.bnuevo.Text = "NUEVO"
        Me.bnuevo.UseVisualStyleBackColor = False
        '
        'bborrar
        '
        Me.bborrar.BackColor = System.Drawing.Color.Transparent
        Me.bborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bborrar.ForeColor = System.Drawing.Color.Black
        Me.bborrar.Location = New System.Drawing.Point(13, 67)
        Me.bborrar.Name = "bborrar"
        Me.bborrar.Size = New System.Drawing.Size(98, 31)
        Me.bborrar.TabIndex = 32
        Me.bborrar.Text = "BORRAR"
        Me.bborrar.UseVisualStyleBackColor = False
        '
        'bcancelar
        '
        Me.bcancelar.BackColor = System.Drawing.Color.Transparent
        Me.bcancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcancelar.ForeColor = System.Drawing.Color.Black
        Me.bcancelar.Location = New System.Drawing.Point(518, 14)
        Me.bcancelar.Name = "bcancelar"
        Me.bcancelar.Size = New System.Drawing.Size(100, 31)
        Me.bcancelar.TabIndex = 27
        Me.bcancelar.Text = "CANCELAR"
        Me.bcancelar.UseVisualStyleBackColor = False
        '
        'bsalir
        '
        Me.bsalir.BackColor = System.Drawing.Color.Transparent
        Me.bsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsalir.ForeColor = System.Drawing.Color.Black
        Me.bsalir.Location = New System.Drawing.Point(518, 67)
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(100, 31)
        Me.bsalir.TabIndex = 30
        Me.bsalir.Text = "SALIR"
        Me.bsalir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabEtapa)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbpvp)
        Me.Panel1.Controls.Add(Me.tbstock)
        Me.Panel1.Controls.Add(Me.tbcurso)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbisbn)
        Me.Panel1.Controls.Add(Me.tbtitulo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tbpaginas)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tbautor1)
        Me.Panel1.Controls.Add(Me.tbeditorial)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(52, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 386)
        Me.Panel1.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(412, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "PVP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Stock"
        '
        'tbpvp
        '
        Me.tbpvp.BackColor = System.Drawing.SystemColors.Control
        Me.tbpvp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpvp.Location = New System.Drawing.Point(456, 308)
        Me.tbpvp.Name = "tbpvp"
        Me.tbpvp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbpvp.Size = New System.Drawing.Size(34, 20)
        Me.tbpvp.TabIndex = 52
        '
        'tbstock
        '
        Me.tbstock.BackColor = System.Drawing.SystemColors.Control
        Me.tbstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbstock.Location = New System.Drawing.Point(323, 308)
        Me.tbstock.Name = "tbstock"
        Me.tbstock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbstock.Size = New System.Drawing.Size(38, 20)
        Me.tbstock.TabIndex = 51
        '
        'tbcurso
        '
        Me.tbcurso.BackColor = System.Drawing.SystemColors.Control
        Me.tbcurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcurso.Location = New System.Drawing.Point(85, 308)
        Me.tbcurso.Name = "tbcurso"
        Me.tbcurso.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbcurso.Size = New System.Drawing.Size(25, 20)
        Me.tbcurso.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "ISBN"
        '
        'tbisbn
        '
        Me.tbisbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbisbn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbisbn.Location = New System.Drawing.Point(79, 22)
        Me.tbisbn.Name = "tbisbn"
        Me.tbisbn.ReadOnly = True
        Me.tbisbn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbisbn.Size = New System.Drawing.Size(96, 20)
        Me.tbisbn.TabIndex = 27
        '
        'tbtitulo
        '
        Me.tbtitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbtitulo.Location = New System.Drawing.Point(33, 76)
        Me.tbtitulo.Multiline = True
        Me.tbtitulo.Name = "tbtitulo"
        Me.tbtitulo.ReadOnly = True
        Me.tbtitulo.Size = New System.Drawing.Size(457, 45)
        Me.tbtitulo.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(30, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Título"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(30, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Autor / Autores"
        '
        'tbpaginas
        '
        Me.tbpaginas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpaginas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpaginas.Location = New System.Drawing.Point(456, 259)
        Me.tbpaginas.Name = "tbpaginas"
        Me.tbpaginas.ReadOnly = True
        Me.tbpaginas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbpaginas.Size = New System.Drawing.Size(34, 20)
        Me.tbpaginas.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(30, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Editorial"
        '
        'tbautor1
        '
        Me.tbautor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbautor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbautor1.Location = New System.Drawing.Point(146, 138)
        Me.tbautor1.Multiline = True
        Me.tbautor1.Name = "tbautor1"
        Me.tbautor1.ReadOnly = True
        Me.tbautor1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbautor1.Size = New System.Drawing.Size(244, 86)
        Me.tbautor1.TabIndex = 41
        '
        'tbeditorial
        '
        Me.tbeditorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbeditorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbeditorial.Location = New System.Drawing.Point(101, 259)
        Me.tbeditorial.Name = "tbeditorial"
        Me.tbeditorial.ReadOnly = True
        Me.tbeditorial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbeditorial.Size = New System.Drawing.Size(244, 20)
        Me.tbeditorial.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(385, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 16)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Páginas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(30, 308)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Curso"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(275, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 24)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "LIBROS"
        '
        'LabEtapa
        '
        Me.LabEtapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabEtapa.Location = New System.Drawing.Point(126, 309)
        Me.LabEtapa.Name = "LabEtapa"
        Me.LabEtapa.Size = New System.Drawing.Size(129, 19)
        Me.LabEtapa.TabIndex = 55
        '
        'Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(630, 594)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Libros"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bultimo As System.Windows.Forms.Button
    Friend WithEvents bavance As System.Windows.Forms.Button
    Friend WithEvents bprimer As System.Windows.Forms.Button
    Friend WithEvents bretroceso As System.Windows.Forms.Button
    Friend WithEvents baceptar As System.Windows.Forms.Button
    Friend WithEvents bbuscar As System.Windows.Forms.Button
    Friend WithEvents bmodifica As System.Windows.Forms.Button
    Friend WithEvents bnuevo As System.Windows.Forms.Button
    Friend WithEvents bborrar As System.Windows.Forms.Button
    Friend WithEvents bcancelar As System.Windows.Forms.Button
    Friend WithEvents bsalir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbisbn As System.Windows.Forms.TextBox
    Friend WithEvents tbtitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbpaginas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbautor1 As System.Windows.Forms.TextBox
    Friend WithEvents tbeditorial As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbpvp As System.Windows.Forms.TextBox
    Friend WithEvents tbstock As System.Windows.Forms.TextBox
    Friend WithEvents tbcurso As System.Windows.Forms.TextBox
    Friend WithEvents LabEtapa As System.Windows.Forms.Label
End Class
