<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbnif = New System.Windows.Forms.TextBox()
        Me.tbdireccion = New System.Windows.Forms.TextBox()
        Me.tbcodp = New System.Windows.Forms.TextBox()
        Me.tblocalidad = New System.Windows.Forms.TextBox()
        Me.tbtelefono = New System.Windows.Forms.TextBox()
        Me.tbprovincia = New System.Windows.Forms.TextBox()
        Me.tbemail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbfechauc = New System.Windows.Forms.TextBox()
        Me.tbbanco = New System.Windows.Forms.TextBox()
        Me.tbcuenta = New System.Windows.Forms.TextBox()
        Me.baceptar = New System.Windows.Forms.Button()
        Me.bcancelar = New System.Windows.Forms.Button()
        Me.bsalir = New System.Windows.Forms.Button()
        Me.bnuevo = New System.Windows.Forms.Button()
        Me.bborrar = New System.Windows.Forms.Button()
        Me.bmodifica = New System.Windows.Forms.Button()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbobservaciones = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbcodigo = New System.Windows.Forms.TextBox()
        Me.bretroceso = New System.Windows.Forms.Button()
        Me.bprimer = New System.Windows.Forms.Button()
        Me.bavance = New System.Windows.Forms.Button()
        Me.bultimo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbnombre
        '
        Me.tbnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbnombre.Location = New System.Drawing.Point(196, 27)
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.ReadOnly = True
        Me.tbnombre.Size = New System.Drawing.Size(185, 20)
        Me.tbnombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(387, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NIF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(127, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(282, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "C. Postal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(30, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Localidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(244, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Provincia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(282, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Teléfono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(30, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Email"
        '
        'tbnif
        '
        Me.tbnif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbnif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnif.Location = New System.Drawing.Point(426, 27)
        Me.tbnif.Name = "tbnif"
        Me.tbnif.ReadOnly = True
        Me.tbnif.Size = New System.Drawing.Size(79, 20)
        Me.tbnif.TabIndex = 13
        '
        'tbdireccion
        '
        Me.tbdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbdireccion.Location = New System.Drawing.Point(107, 61)
        Me.tbdireccion.Name = "tbdireccion"
        Me.tbdireccion.ReadOnly = True
        Me.tbdireccion.Size = New System.Drawing.Size(169, 20)
        Me.tbdireccion.TabIndex = 14
        '
        'tbcodp
        '
        Me.tbcodp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcodp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcodp.Location = New System.Drawing.Point(358, 60)
        Me.tbcodp.Name = "tbcodp"
        Me.tbcodp.ReadOnly = True
        Me.tbcodp.Size = New System.Drawing.Size(57, 20)
        Me.tbcodp.TabIndex = 15
        '
        'tblocalidad
        '
        Me.tblocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tblocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblocalidad.Location = New System.Drawing.Point(111, 97)
        Me.tblocalidad.Name = "tblocalidad"
        Me.tblocalidad.ReadOnly = True
        Me.tblocalidad.Size = New System.Drawing.Size(119, 20)
        Me.tblocalidad.TabIndex = 16
        '
        'tbtelefono
        '
        Me.tbtelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbtelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtelefono.Location = New System.Drawing.Point(358, 129)
        Me.tbtelefono.Name = "tbtelefono"
        Me.tbtelefono.ReadOnly = True
        Me.tbtelefono.Size = New System.Drawing.Size(93, 20)
        Me.tbtelefono.TabIndex = 17
        '
        'tbprovincia
        '
        Me.tbprovincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbprovincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbprovincia.Location = New System.Drawing.Point(323, 97)
        Me.tbprovincia.Name = "tbprovincia"
        Me.tbprovincia.ReadOnly = True
        Me.tbprovincia.Size = New System.Drawing.Size(96, 20)
        Me.tbprovincia.TabIndex = 18
        '
        'tbemail
        '
        Me.tbemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbemail.Location = New System.Drawing.Point(78, 130)
        Me.tbemail.Name = "tbemail"
        Me.tbemail.ReadOnly = True
        Me.tbemail.Size = New System.Drawing.Size(198, 20)
        Me.tbemail.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(299, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Fecha Ult.Compra"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(30, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Banco"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(31, 198)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "C/C"
        '
        'tbfechauc
        '
        Me.tbfechauc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbfechauc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbfechauc.Location = New System.Drawing.Point(433, 161)
        Me.tbfechauc.Name = "tbfechauc"
        Me.tbfechauc.ReadOnly = True
        Me.tbfechauc.Size = New System.Drawing.Size(71, 20)
        Me.tbfechauc.TabIndex = 23
        '
        'tbbanco
        '
        Me.tbbanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbbanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbbanco.Location = New System.Drawing.Point(85, 162)
        Me.tbbanco.Name = "tbbanco"
        Me.tbbanco.ReadOnly = True
        Me.tbbanco.Size = New System.Drawing.Size(211, 20)
        Me.tbbanco.TabIndex = 24
        '
        'tbcuenta
        '
        Me.tbcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcuenta.Location = New System.Drawing.Point(70, 197)
        Me.tbcuenta.Name = "tbcuenta"
        Me.tbcuenta.ReadOnly = True
        Me.tbcuenta.Size = New System.Drawing.Size(362, 20)
        Me.tbcuenta.TabIndex = 25
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(255, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 24)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "CLIENTES"
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
        Me.Panel2.Location = New System.Drawing.Point(0, 484)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 110)
        Me.Panel2.TabIndex = 86
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.tbobservaciones)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.tbemail)
        Me.Panel1.Controls.Add(Me.tbcodigo)
        Me.Panel1.Controls.Add(Me.tbcuenta)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.tbbanco)
        Me.Panel1.Controls.Add(Me.tbtelefono)
        Me.Panel1.Controls.Add(Me.tbfechauc)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tbprovincia)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tbnombre)
        Me.Panel1.Controls.Add(Me.tblocalidad)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tbcodp)
        Me.Panel1.Controls.Add(Me.tbnif)
        Me.Panel1.Controls.Add(Me.tbdireccion)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(46, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 386)
        Me.Panel1.TabIndex = 88
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(30, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 16)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Código"
        '
        'tbobservaciones
        '
        Me.tbobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbobservaciones.Location = New System.Drawing.Point(33, 256)
        Me.tbobservaciones.Multiline = True
        Me.tbobservaciones.Name = "tbobservaciones"
        Me.tbobservaciones.ReadOnly = True
        Me.tbobservaciones.Size = New System.Drawing.Size(471, 109)
        Me.tbobservaciones.TabIndex = 74
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(30, 237)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 16)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Observaciones"
        '
        'tbcodigo
        '
        Me.tbcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcodigo.Location = New System.Drawing.Point(91, 27)
        Me.tbcodigo.Name = "tbcodigo"
        Me.tbcodigo.ReadOnly = True
        Me.tbcodigo.Size = New System.Drawing.Size(30, 20)
        Me.tbcodigo.TabIndex = 1
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
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(622, 586)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label14)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Clientes"
        Me.ShowIcon = False
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbnif As System.Windows.Forms.TextBox
    Friend WithEvents tbdireccion As System.Windows.Forms.TextBox
    Friend WithEvents tbcodp As System.Windows.Forms.TextBox
    Friend WithEvents tblocalidad As System.Windows.Forms.TextBox
    Friend WithEvents tbtelefono As System.Windows.Forms.TextBox
    Friend WithEvents tbprovincia As System.Windows.Forms.TextBox
    Friend WithEvents tbemail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbfechauc As System.Windows.Forms.TextBox
    Friend WithEvents tbbanco As System.Windows.Forms.TextBox
    Friend WithEvents tbcuenta As System.Windows.Forms.TextBox
    Friend WithEvents baceptar As System.Windows.Forms.Button
    Friend WithEvents bcancelar As System.Windows.Forms.Button
    Friend WithEvents bsalir As System.Windows.Forms.Button
    Friend WithEvents bnuevo As System.Windows.Forms.Button
    Friend WithEvents bborrar As System.Windows.Forms.Button
    Friend WithEvents bmodifica As System.Windows.Forms.Button
    Friend WithEvents bbuscar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbcodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bultimo As System.Windows.Forms.Button
    Friend WithEvents bavance As System.Windows.Forms.Button
    Friend WithEvents bprimer As System.Windows.Forms.Button
    Friend WithEvents bretroceso As System.Windows.Forms.Button
End Class
