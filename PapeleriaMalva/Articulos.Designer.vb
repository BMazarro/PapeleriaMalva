<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Articulos))
        Me.tbpvp = New System.Windows.Forms.TextBox()
        Me.tbprov = New System.Windows.Forms.TextBox()
        Me.tbfechauc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbpreciouc = New System.Windows.Forms.TextBox()
        Me.tbstock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbdesc = New System.Windows.Forms.TextBox()
        Me.tbcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbobservaciones = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bmodifica = New System.Windows.Forms.Button()
        Me.bborrar = New System.Windows.Forms.Button()
        Me.bnuevo = New System.Windows.Forms.Button()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.bcancelar = New System.Windows.Forms.Button()
        Me.bsalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bultimo = New System.Windows.Forms.Button()
        Me.bprimer = New System.Windows.Forms.Button()
        Me.bavance = New System.Windows.Forms.Button()
        Me.bretroceso = New System.Windows.Forms.Button()
        Me.baceptar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpvp
        '
        Me.tbpvp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpvp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpvp.Location = New System.Drawing.Point(445, 192)
        Me.tbpvp.Name = "tbpvp"
        Me.tbpvp.ReadOnly = True
        Me.tbpvp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbpvp.Size = New System.Drawing.Size(45, 20)
        Me.tbpvp.TabIndex = 49
        '
        'tbprov
        '
        Me.tbprov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbprov.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbprov.Location = New System.Drawing.Point(452, 22)
        Me.tbprov.Name = "tbprov"
        Me.tbprov.ReadOnly = True
        Me.tbprov.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbprov.Size = New System.Drawing.Size(38, 20)
        Me.tbprov.TabIndex = 48
        '
        'tbfechauc
        '
        Me.tbfechauc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbfechauc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbfechauc.Location = New System.Drawing.Point(419, 154)
        Me.tbfechauc.Name = "tbfechauc"
        Me.tbfechauc.ReadOnly = True
        Me.tbfechauc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbfechauc.Size = New System.Drawing.Size(71, 20)
        Me.tbfechauc.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(321, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 16)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Precio C. Actual"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(328, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 16)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Proveedor Hab."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(328, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Fecha Ult.C"
        '
        'tbpreciouc
        '
        Me.tbpreciouc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpreciouc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpreciouc.Location = New System.Drawing.Point(174, 192)
        Me.tbpreciouc.Name = "tbpreciouc"
        Me.tbpreciouc.ReadOnly = True
        Me.tbpreciouc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbpreciouc.Size = New System.Drawing.Size(42, 20)
        Me.tbpreciouc.TabIndex = 43
        '
        'tbstock
        '
        Me.tbstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbstock.Location = New System.Drawing.Point(83, 154)
        Me.tbstock.Name = "tbstock"
        Me.tbstock.ReadOnly = True
        Me.tbstock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbstock.Size = New System.Drawing.Size(38, 20)
        Me.tbstock.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(30, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Precio Ult. Compra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(30, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(30, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Descripción"
        '
        'tbdesc
        '
        Me.tbdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbdesc.Location = New System.Drawing.Point(33, 76)
        Me.tbdesc.Multiline = True
        Me.tbdesc.Name = "tbdesc"
        Me.tbdesc.ReadOnly = True
        Me.tbdesc.Size = New System.Drawing.Size(457, 64)
        Me.tbdesc.TabIndex = 28
        '
        'tbcodigo
        '
        Me.tbcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcodigo.Location = New System.Drawing.Point(94, 21)
        Me.tbcodigo.Name = "tbcodigo"
        Me.tbcodigo.ReadOnly = True
        Me.tbcodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbcodigo.Size = New System.Drawing.Size(39, 20)
        Me.tbcodigo.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Código"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(250, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 24)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "ARTICULOS"
        '
        'tbobservaciones
        '
        Me.tbobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbobservaciones.Location = New System.Drawing.Point(33, 285)
        Me.tbobservaciones.Multiline = True
        Me.tbobservaciones.Name = "tbobservaciones"
        Me.tbobservaciones.ReadOnly = True
        Me.tbobservaciones.Size = New System.Drawing.Size(457, 80)
        Me.tbobservaciones.TabIndex = 74
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(30, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 16)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Observaciones"
        '
        'bmodifica
        '
        Me.bmodifica.BackColor = System.Drawing.Color.Transparent
        Me.bmodifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bmodifica.ForeColor = System.Drawing.Color.Black
        Me.bmodifica.Location = New System.Drawing.Point(118, 67)
        Me.bmodifica.Name = "bmodifica"
        Me.bmodifica.Size = New System.Drawing.Size(100, 31)
        Me.bmodifica.TabIndex = 77
        Me.bmodifica.Text = "MODIFICAR"
        Me.bmodifica.UseVisualStyleBackColor = False
        '
        'bborrar
        '
        Me.bborrar.BackColor = System.Drawing.Color.Transparent
        Me.bborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bborrar.ForeColor = System.Drawing.Color.Black
        Me.bborrar.Location = New System.Drawing.Point(12, 67)
        Me.bborrar.Name = "bborrar"
        Me.bborrar.Size = New System.Drawing.Size(100, 31)
        Me.bborrar.TabIndex = 76
        Me.bborrar.Text = "BORRAR"
        Me.bborrar.UseVisualStyleBackColor = False
        '
        'bnuevo
        '
        Me.bnuevo.BackColor = System.Drawing.Color.Transparent
        Me.bnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnuevo.ForeColor = System.Drawing.Color.Black
        Me.bnuevo.Location = New System.Drawing.Point(12, 14)
        Me.bnuevo.Name = "bnuevo"
        Me.bnuevo.Size = New System.Drawing.Size(100, 31)
        Me.bnuevo.TabIndex = 75
        Me.bnuevo.Text = "NUEVO"
        Me.bnuevo.UseVisualStyleBackColor = False
        '
        'bbuscar
        '
        Me.bbuscar.BackColor = System.Drawing.Color.Transparent
        Me.bbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbuscar.ForeColor = System.Drawing.Color.Black
        Me.bbuscar.Location = New System.Drawing.Point(118, 14)
        Me.bbuscar.Name = "bbuscar"
        Me.bbuscar.Size = New System.Drawing.Size(100, 31)
        Me.bbuscar.TabIndex = 78
        Me.bbuscar.Text = "BUSCAR"
        Me.bbuscar.UseVisualStyleBackColor = False
        '
        'bcancelar
        '
        Me.bcancelar.BackColor = System.Drawing.Color.Transparent
        Me.bcancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcancelar.ForeColor = System.Drawing.Color.Black
        Me.bcancelar.Location = New System.Drawing.Point(520, 14)
        Me.bcancelar.Name = "bcancelar"
        Me.bcancelar.Size = New System.Drawing.Size(100, 31)
        Me.bcancelar.TabIndex = 80
        Me.bcancelar.Text = "CANCELAR"
        Me.bcancelar.UseVisualStyleBackColor = False
        '
        'bsalir
        '
        Me.bsalir.BackColor = System.Drawing.Color.Transparent
        Me.bsalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsalir.ForeColor = System.Drawing.Color.Black
        Me.bsalir.Location = New System.Drawing.Point(521, 67)
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(100, 31)
        Me.bsalir.TabIndex = 81
        Me.bsalir.Text = "SALIR"
        Me.bsalir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.bultimo)
        Me.GroupBox1.Controls.Add(Me.bprimer)
        Me.GroupBox1.Controls.Add(Me.bavance)
        Me.GroupBox1.Controls.Add(Me.bretroceso)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(232, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 55)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        '
        'bultimo
        '
        Me.bultimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bultimo.ForeColor = System.Drawing.Color.Black
        Me.bultimo.Location = New System.Drawing.Point(119, 19)
        Me.bultimo.Name = "bultimo"
        Me.bultimo.Size = New System.Drawing.Size(41, 23)
        Me.bultimo.TabIndex = 39
        Me.bultimo.Text = ">>"
        Me.bultimo.UseVisualStyleBackColor = True
        '
        'bprimer
        '
        Me.bprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bprimer.ForeColor = System.Drawing.Color.Black
        Me.bprimer.Location = New System.Drawing.Point(6, 19)
        Me.bprimer.Name = "bprimer"
        Me.bprimer.Size = New System.Drawing.Size(41, 23)
        Me.bprimer.TabIndex = 35
        Me.bprimer.Text = "<<"
        Me.bprimer.UseVisualStyleBackColor = True
        '
        'bavance
        '
        Me.bavance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bavance.ForeColor = System.Drawing.Color.Black
        Me.bavance.Location = New System.Drawing.Point(84, 19)
        Me.bavance.Name = "bavance"
        Me.bavance.Size = New System.Drawing.Size(29, 23)
        Me.bavance.TabIndex = 38
        Me.bavance.Text = ">"
        Me.bavance.UseVisualStyleBackColor = True
        '
        'bretroceso
        '
        Me.bretroceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.baceptar.Location = New System.Drawing.Point(415, 14)
        Me.baceptar.Name = "baceptar"
        Me.baceptar.Size = New System.Drawing.Size(100, 31)
        Me.baceptar.TabIndex = 83
        Me.baceptar.Text = "ACEPTAR"
        Me.baceptar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.bsalir)
        Me.Panel2.Controls.Add(Me.baceptar)
        Me.Panel2.Controls.Add(Me.bcancelar)
        Me.Panel2.Controls.Add(Me.bnuevo)
        Me.Panel2.Controls.Add(Me.bmodifica)
        Me.Panel2.Controls.Add(Me.bbuscar)
        Me.Panel2.Controls.Add(Me.bborrar)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 488)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 110)
        Me.Panel2.TabIndex = 85
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbcodigo)
        Me.Panel1.Controls.Add(Me.tbobservaciones)
        Me.Panel1.Controls.Add(Me.tbdesc)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tbpvp)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tbprov)
        Me.Panel1.Controls.Add(Me.tbstock)
        Me.Panel1.Controls.Add(Me.tbfechauc)
        Me.Panel1.Controls.Add(Me.tbpreciouc)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(50, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 386)
        Me.Panel1.TabIndex = 87
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(626, 590)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Articulos"
        Me.ShowIcon = False
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbpvp As System.Windows.Forms.TextBox
    Friend WithEvents tbprov As System.Windows.Forms.TextBox
    Friend WithEvents tbfechauc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbpreciouc As System.Windows.Forms.TextBox
    Friend WithEvents tbstock As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbdesc As System.Windows.Forms.TextBox
    Friend WithEvents tbcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents bmodifica As System.Windows.Forms.Button
    Friend WithEvents bborrar As System.Windows.Forms.Button
    Friend WithEvents bnuevo As System.Windows.Forms.Button
    Friend WithEvents bbuscar As System.Windows.Forms.Button
    Friend WithEvents bcancelar As System.Windows.Forms.Button
    Friend WithEvents bsalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bultimo As System.Windows.Forms.Button
    Friend WithEvents bprimer As System.Windows.Forms.Button
    Friend WithEvents bavance As System.Windows.Forms.Button
    Friend WithEvents bretroceso As System.Windows.Forms.Button
    Friend WithEvents baceptar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
