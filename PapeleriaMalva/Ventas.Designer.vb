<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.baceptar = New System.Windows.Forms.Button()
        Me.bfactura = New System.Windows.Forms.Button()
        Me.bimprimir = New System.Windows.Forms.Button()
        Me.bcancelar = New System.Windows.Forms.Button()
        Me.bsalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbnumres = New System.Windows.Forms.TextBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.ltfn = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.llocalidad = New System.Windows.Forms.Label()
        Me.lprovincia = New System.Windows.Forms.Label()
        Me.lcp = New System.Windows.Forms.Label()
        Me.ldireccion = New System.Windows.Forms.Label()
        Me.lnif = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.lnombre = New System.Windows.Forms.Label()
        Me.bbuscarcli = New System.Windows.Forms.Button()
        Me.tcliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tventa = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.blimpiar = New System.Windows.Forms.Button()
        Me.tlinea = New System.Windows.Forms.TextBox()
        Me.tcantidad = New System.Windows.Forms.TextBox()
        Me.tdto = New System.Windows.Forms.TextBox()
        Me.tcodprod = New System.Windows.Forms.TextBox()
        Me.tpvp = New System.Windows.Forms.TextBox()
        Me.timporte = New System.Windows.Forms.TextBox()
        Me.tdescripcion = New System.Windows.Forms.TextBox()
        Me.bnomaslineas = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.banadir = New System.Windows.Forms.Button()
        Me.bvertodos = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.limporte = New System.Windows.Forms.Label()
        Me.liva = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ltotal = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tobservaciones = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bverres = New System.Windows.Forms.Button()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.bmodificar = New System.Windows.Forms.Button()
        Me.bborrar = New System.Windows.Forms.Button()
        Me.bnuevo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bultimo = New System.Windows.Forms.Button()
        Me.bavance = New System.Windows.Forms.Button()
        Me.bprimer = New System.Windows.Forms.Button()
        Me.bretroceso = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.baceptar)
        Me.Panel2.Controls.Add(Me.bfactura)
        Me.Panel2.Controls.Add(Me.bimprimir)
        Me.Panel2.Controls.Add(Me.bcancelar)
        Me.Panel2.Location = New System.Drawing.Point(3, 675)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 77)
        Me.Panel2.TabIndex = 88
        '
        'baceptar
        '
        Me.baceptar.BackColor = System.Drawing.Color.Transparent
        Me.baceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baceptar.ForeColor = System.Drawing.Color.Black
        Me.baceptar.Location = New System.Drawing.Point(235, 31)
        Me.baceptar.Name = "baceptar"
        Me.baceptar.Size = New System.Drawing.Size(100, 31)
        Me.baceptar.TabIndex = 26
        Me.baceptar.Text = "ACEPTAR"
        Me.baceptar.UseVisualStyleBackColor = False
        '
        'bfactura
        '
        Me.bfactura.BackColor = System.Drawing.Color.Transparent
        Me.bfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bfactura.ForeColor = System.Drawing.Color.Black
        Me.bfactura.Location = New System.Drawing.Point(8, 31)
        Me.bfactura.Name = "bfactura"
        Me.bfactura.Size = New System.Drawing.Size(151, 31)
        Me.bfactura.TabIndex = 31
        Me.bfactura.Text = "FACTURA DIRECTA"
        Me.bfactura.UseVisualStyleBackColor = False
        '
        'bimprimir
        '
        Me.bimprimir.BackColor = System.Drawing.Color.Transparent
        Me.bimprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bimprimir.ForeColor = System.Drawing.Color.Black
        Me.bimprimir.Location = New System.Drawing.Point(486, 31)
        Me.bimprimir.Name = "bimprimir"
        Me.bimprimir.Size = New System.Drawing.Size(98, 31)
        Me.bimprimir.TabIndex = 32
        Me.bimprimir.Text = "IMPRIMIR"
        Me.bimprimir.UseVisualStyleBackColor = False
        '
        'bcancelar
        '
        Me.bcancelar.BackColor = System.Drawing.Color.Transparent
        Me.bcancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcancelar.ForeColor = System.Drawing.Color.Black
        Me.bcancelar.Location = New System.Drawing.Point(360, 31)
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
        Me.bsalir.Location = New System.Drawing.Point(13, 706)
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
        Me.Panel1.Controls.Add(Me.tbnumres)
        Me.Panel1.Controls.Add(Me.cb2)
        Me.Panel1.Controls.Add(Me.ltfn)
        Me.Panel1.Controls.Add(Me.cb1)
        Me.Panel1.Controls.Add(Me.llocalidad)
        Me.Panel1.Controls.Add(Me.lprovincia)
        Me.Panel1.Controls.Add(Me.lcp)
        Me.Panel1.Controls.Add(Me.ldireccion)
        Me.Panel1.Controls.Add(Me.lnif)
        Me.Panel1.Controls.Add(Me.dtp)
        Me.Panel1.Controls.Add(Me.lnombre)
        Me.Panel1.Controls.Add(Me.bbuscarcli)
        Me.Panel1.Controls.Add(Me.tcliente)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tventa)
        Me.Panel1.Location = New System.Drawing.Point(27, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(719, 181)
        Me.Panel1.TabIndex = 89
        '
        'tbnumres
        '
        Me.tbnumres.BackColor = System.Drawing.SystemColors.Control
        Me.tbnumres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbnumres.Location = New System.Drawing.Point(164, 117)
        Me.tbnumres.Name = "tbnumres"
        Me.tbnumres.ReadOnly = True
        Me.tbnumres.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbnumres.Size = New System.Drawing.Size(26, 20)
        Me.tbnumres.TabIndex = 116
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2.Location = New System.Drawing.Point(57, 116)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(102, 19)
        Me.cb2.TabIndex = 115
        Me.cb2.Text = "Con reserva"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'ltfn
        '
        Me.ltfn.Location = New System.Drawing.Point(433, 153)
        Me.ltfn.Name = "ltfn"
        Me.ltfn.Size = New System.Drawing.Size(93, 13)
        Me.ltfn.TabIndex = 14
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.Location = New System.Drawing.Point(57, 147)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(90, 19)
        Me.cb1.TabIndex = 114
        Me.cb1.Text = "Facturado"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'llocalidad
        '
        Me.llocalidad.Location = New System.Drawing.Point(433, 128)
        Me.llocalidad.Name = "llocalidad"
        Me.llocalidad.Size = New System.Drawing.Size(112, 13)
        Me.llocalidad.TabIndex = 13
        '
        'lprovincia
        '
        Me.lprovincia.Location = New System.Drawing.Point(551, 128)
        Me.lprovincia.Name = "lprovincia"
        Me.lprovincia.Size = New System.Drawing.Size(118, 13)
        Me.lprovincia.TabIndex = 12
        '
        'lcp
        '
        Me.lcp.Location = New System.Drawing.Point(588, 101)
        Me.lcp.Name = "lcp"
        Me.lcp.Size = New System.Drawing.Size(43, 13)
        Me.lcp.TabIndex = 11
        '
        'ldireccion
        '
        Me.ldireccion.Location = New System.Drawing.Point(433, 101)
        Me.ldireccion.Name = "ldireccion"
        Me.ldireccion.Size = New System.Drawing.Size(148, 13)
        Me.ldireccion.TabIndex = 10
        '
        'lnif
        '
        Me.lnif.Location = New System.Drawing.Point(588, 74)
        Me.lnif.Name = "lnif"
        Me.lnif.Size = New System.Drawing.Size(81, 13)
        Me.lnif.TabIndex = 9
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(115, 74)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(100, 20)
        Me.dtp.TabIndex = 8
        '
        'lnombre
        '
        Me.lnombre.Location = New System.Drawing.Point(433, 74)
        Me.lnombre.Name = "lnombre"
        Me.lnombre.Size = New System.Drawing.Size(148, 13)
        Me.lnombre.TabIndex = 7
        '
        'bbuscarcli
        '
        Me.bbuscarcli.Image = CType(resources.GetObject("bbuscarcli.Image"), System.Drawing.Image)
        Me.bbuscarcli.Location = New System.Drawing.Point(532, 33)
        Me.bbuscarcli.Name = "bbuscarcli"
        Me.bbuscarcli.Size = New System.Drawing.Size(28, 23)
        Me.bbuscarcli.TabIndex = 6
        Me.bbuscarcli.UseVisualStyleBackColor = True
        '
        'tcliente
        '
        Me.tcliente.BackColor = System.Drawing.SystemColors.Control
        Me.tcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tcliente.Location = New System.Drawing.Point(495, 35)
        Me.tcliente.Name = "tcliente"
        Me.tcliente.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tcliente.Size = New System.Drawing.Size(31, 20)
        Me.tcliente.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(433, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nº Venta:"
        '
        'tventa
        '
        Me.tventa.BackColor = System.Drawing.SystemColors.Control
        Me.tventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tventa.Location = New System.Drawing.Point(130, 35)
        Me.tventa.Name = "tventa"
        Me.tventa.ReadOnly = True
        Me.tventa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tventa.Size = New System.Drawing.Size(26, 20)
        Me.tventa.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.blimpiar)
        Me.Panel3.Controls.Add(Me.tlinea)
        Me.Panel3.Controls.Add(Me.tcantidad)
        Me.Panel3.Controls.Add(Me.tdto)
        Me.Panel3.Controls.Add(Me.tcodprod)
        Me.Panel3.Controls.Add(Me.tpvp)
        Me.Panel3.Controls.Add(Me.timporte)
        Me.Panel3.Controls.Add(Me.tdescripcion)
        Me.Panel3.Controls.Add(Me.bnomaslineas)
        Me.Panel3.Controls.Add(Me.beliminar)
        Me.Panel3.Controls.Add(Me.banadir)
        Me.Panel3.Controls.Add(Me.bvertodos)
        Me.Panel3.Controls.Add(Me.dg)
        Me.Panel3.Location = New System.Drawing.Point(12, 252)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(753, 236)
        Me.Panel3.TabIndex = 90
        '
        'blimpiar
        '
        Me.blimpiar.Location = New System.Drawing.Point(669, 197)
        Me.blimpiar.Name = "blimpiar"
        Me.blimpiar.Size = New System.Drawing.Size(75, 23)
        Me.blimpiar.TabIndex = 13
        Me.blimpiar.Text = "Limpiar"
        Me.blimpiar.UseVisualStyleBackColor = True
        '
        'tlinea
        '
        Me.tlinea.BackColor = System.Drawing.SystemColors.Control
        Me.tlinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlinea.Location = New System.Drawing.Point(51, 197)
        Me.tlinea.Name = "tlinea"
        Me.tlinea.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tlinea.Size = New System.Drawing.Size(48, 20)
        Me.tlinea.TabIndex = 6
        '
        'tcantidad
        '
        Me.tcantidad.BackColor = System.Drawing.SystemColors.Control
        Me.tcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tcantidad.Location = New System.Drawing.Point(451, 197)
        Me.tcantidad.Name = "tcantidad"
        Me.tcantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tcantidad.Size = New System.Drawing.Size(74, 20)
        Me.tcantidad.TabIndex = 10
        '
        'tdto
        '
        Me.tdto.BackColor = System.Drawing.SystemColors.Control
        Me.tdto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tdto.Location = New System.Drawing.Point(520, 197)
        Me.tdto.Name = "tdto"
        Me.tdto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tdto.Size = New System.Drawing.Size(77, 20)
        Me.tdto.TabIndex = 11
        '
        'tcodprod
        '
        Me.tcodprod.BackColor = System.Drawing.SystemColors.Control
        Me.tcodprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tcodprod.Location = New System.Drawing.Point(96, 197)
        Me.tcodprod.Name = "tcodprod"
        Me.tcodprod.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tcodprod.Size = New System.Drawing.Size(86, 20)
        Me.tcodprod.TabIndex = 7
        '
        'tpvp
        '
        Me.tpvp.BackColor = System.Drawing.SystemColors.Control
        Me.tpvp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpvp.Location = New System.Drawing.Point(385, 197)
        Me.tpvp.Name = "tpvp"
        Me.tpvp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tpvp.Size = New System.Drawing.Size(66, 20)
        Me.tpvp.TabIndex = 9
        '
        'timporte
        '
        Me.timporte.BackColor = System.Drawing.SystemColors.Control
        Me.timporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timporte.Location = New System.Drawing.Point(595, 197)
        Me.timporte.Name = "timporte"
        Me.timporte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.timporte.Size = New System.Drawing.Size(68, 20)
        Me.timporte.TabIndex = 12
        '
        'tdescripcion
        '
        Me.tdescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.tdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tdescripcion.Location = New System.Drawing.Point(179, 197)
        Me.tdescripcion.Name = "tdescripcion"
        Me.tdescripcion.Size = New System.Drawing.Size(210, 20)
        Me.tdescripcion.TabIndex = 8
        '
        'bnomaslineas
        '
        Me.bnomaslineas.Image = CType(resources.GetObject("bnomaslineas.Image"), System.Drawing.Image)
        Me.bnomaslineas.Location = New System.Drawing.Point(671, 150)
        Me.bnomaslineas.Name = "bnomaslineas"
        Me.bnomaslineas.Size = New System.Drawing.Size(33, 28)
        Me.bnomaslineas.TabIndex = 5
        Me.bnomaslineas.UseVisualStyleBackColor = True
        '
        'beliminar
        '
        Me.beliminar.Image = CType(resources.GetObject("beliminar.Image"), System.Drawing.Image)
        Me.beliminar.Location = New System.Drawing.Point(670, 110)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(34, 34)
        Me.beliminar.TabIndex = 4
        Me.beliminar.UseVisualStyleBackColor = True
        '
        'banadir
        '
        Me.banadir.Image = CType(resources.GetObject("banadir.Image"), System.Drawing.Image)
        Me.banadir.Location = New System.Drawing.Point(669, 71)
        Me.banadir.Name = "banadir"
        Me.banadir.Size = New System.Drawing.Size(35, 33)
        Me.banadir.TabIndex = 3
        Me.banadir.UseVisualStyleBackColor = True
        '
        'bvertodos
        '
        Me.bvertodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bvertodos.Image = CType(resources.GetObject("bvertodos.Image"), System.Drawing.Image)
        Me.bvertodos.Location = New System.Drawing.Point(10, 194)
        Me.bvertodos.Name = "bvertodos"
        Me.bvertodos.Size = New System.Drawing.Size(35, 23)
        Me.bvertodos.TabIndex = 2
        Me.bvertodos.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Linea, Me.codVenta, Me.descripcion, Me.PVP, Me.Cantidad, Me.Dto, Me.Importe})
        Me.dg.Location = New System.Drawing.Point(15, 28)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(648, 150)
        Me.dg.TabIndex = 0
        '
        'Linea
        '
        Me.Linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linea.DefaultCellStyle = DataGridViewCellStyle7
        Me.Linea.HeaderText = "Linea"
        Me.Linea.Name = "Linea"
        Me.Linea.ReadOnly = True
        Me.Linea.Width = 58
        '
        'codVenta
        '
        Me.codVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.codVenta.DefaultCellStyle = DataGridViewCellStyle8
        Me.codVenta.HeaderText = "Código"
        Me.codVenta.Name = "codVenta"
        Me.codVenta.ReadOnly = True
        Me.codVenta.Width = 65
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'PVP
        '
        Me.PVP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.PVP.DefaultCellStyle = DataGridViewCellStyle9
        Me.PVP.HeaderText = "PVP"
        Me.PVP.Name = "PVP"
        Me.PVP.ReadOnly = True
        Me.PVP.Width = 53
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle10
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 74
        '
        'Dto
        '
        Me.Dto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Dto.DefaultCellStyle = DataGridViewCellStyle11
        Me.Dto.HeaderText = "Dto.Linea"
        Me.Dto.Name = "Dto"
        Me.Dto.ReadOnly = True
        Me.Dto.Width = 78
        '
        'Importe
        '
        Me.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle12
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(327, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 25)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "VENTAS"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(204, 521)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 92
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(79, 526)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 16)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Forma de Pago:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(540, 529)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 100
        Me.Label16.Text = "BASE IMP."
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(516, 553)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(38, 21)
        Me.ComboBox2.TabIndex = 101
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(577, 556)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "IVA"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(544, 604)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 18)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "TOTAL"
        '
        'limporte
        '
        Me.limporte.Location = New System.Drawing.Point(605, 529)
        Me.limporte.Name = "limporte"
        Me.limporte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.limporte.Size = New System.Drawing.Size(58, 13)
        Me.limporte.TabIndex = 104
        '
        'liva
        '
        Me.liva.Location = New System.Drawing.Point(605, 556)
        Me.liva.Name = "liva"
        Me.liva.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.liva.Size = New System.Drawing.Size(58, 13)
        Me.liva.TabIndex = 106
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(907, 750)
        Me.ShapeContainer1.TabIndex = 107
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 507
        Me.LineShape1.X2 = 706
        Me.LineShape1.Y1 = 590
        Me.LineShape1.Y2 = 590
        '
        'ltotal
        '
        Me.ltotal.Location = New System.Drawing.Point(605, 608)
        Me.ltotal.Name = "ltotal"
        Me.ltotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ltotal.Size = New System.Drawing.Size(58, 12)
        Me.ltotal.TabIndex = 108
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(669, 604)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 18)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = "€"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(82, 556)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 16)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "Observaciones"
        '
        'tobservaciones
        '
        Me.tobservaciones.BackColor = System.Drawing.SystemColors.Control
        Me.tobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tobservaciones.Location = New System.Drawing.Point(85, 575)
        Me.tobservaciones.Multiline = True
        Me.tobservaciones.Name = "tobservaciones"
        Me.tobservaciones.Size = New System.Drawing.Size(225, 57)
        Me.tobservaciones.TabIndex = 111
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.bverres)
        Me.Panel4.Controls.Add(Me.bbuscar)
        Me.Panel4.Controls.Add(Me.bmodificar)
        Me.Panel4.Controls.Add(Me.bborrar)
        Me.Panel4.Controls.Add(Me.bnuevo)
        Me.Panel4.Controls.Add(Me.bsalir)
        Me.Panel4.Location = New System.Drawing.Point(771, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(138, 756)
        Me.Panel4.TabIndex = 112
        '
        'bverres
        '
        Me.bverres.BackColor = System.Drawing.Color.Transparent
        Me.bverres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bverres.ForeColor = System.Drawing.Color.Black
        Me.bverres.Location = New System.Drawing.Point(15, 462)
        Me.bverres.Name = "bverres"
        Me.bverres.Size = New System.Drawing.Size(100, 64)
        Me.bverres.TabIndex = 31
        Me.bverres.Text = "RESERVAS"
        Me.bverres.UseVisualStyleBackColor = False
        '
        'bbuscar
        '
        Me.bbuscar.BackColor = System.Drawing.Color.Transparent
        Me.bbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbuscar.ForeColor = System.Drawing.Color.Black
        Me.bbuscar.Location = New System.Drawing.Point(15, 365)
        Me.bbuscar.Name = "bbuscar"
        Me.bbuscar.Size = New System.Drawing.Size(100, 64)
        Me.bbuscar.TabIndex = 3
        Me.bbuscar.Text = "BUSCAR"
        Me.bbuscar.UseVisualStyleBackColor = False
        '
        'bmodificar
        '
        Me.bmodificar.BackColor = System.Drawing.Color.Transparent
        Me.bmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bmodificar.ForeColor = System.Drawing.Color.Black
        Me.bmodificar.Location = New System.Drawing.Point(15, 272)
        Me.bmodificar.Name = "bmodificar"
        Me.bmodificar.Size = New System.Drawing.Size(100, 64)
        Me.bmodificar.TabIndex = 2
        Me.bmodificar.Text = "MODIFICAR"
        Me.bmodificar.UseVisualStyleBackColor = False
        '
        'bborrar
        '
        Me.bborrar.BackColor = System.Drawing.Color.Transparent
        Me.bborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bborrar.ForeColor = System.Drawing.Color.Black
        Me.bborrar.Location = New System.Drawing.Point(15, 172)
        Me.bborrar.Name = "bborrar"
        Me.bborrar.Size = New System.Drawing.Size(100, 64)
        Me.bborrar.TabIndex = 1
        Me.bborrar.Text = "BORRAR"
        Me.bborrar.UseVisualStyleBackColor = False
        '
        'bnuevo
        '
        Me.bnuevo.BackColor = System.Drawing.Color.Transparent
        Me.bnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnuevo.ForeColor = System.Drawing.Color.Black
        Me.bnuevo.Location = New System.Drawing.Point(15, 80)
        Me.bnuevo.Name = "bnuevo"
        Me.bnuevo.Size = New System.Drawing.Size(100, 63)
        Me.bnuevo.TabIndex = 0
        Me.bnuevo.Text = "NUEVO"
        Me.bnuevo.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(557, 553)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 18)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "%"
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
        Me.GroupBox2.Location = New System.Drawing.Point(332, 632)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 55)
        Me.GroupBox2.TabIndex = 127
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
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 23)
        Me.Label5.TabIndex = 128
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.tobservaciones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.ltotal)
        Me.Controls.Add(Me.liva)
        Me.Controls.Add(Me.limporte)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Ventas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents baceptar As System.Windows.Forms.Button
    Friend WithEvents bfactura As System.Windows.Forms.Button
    Friend WithEvents bimprimir As System.Windows.Forms.Button
    Friend WithEvents bcancelar As System.Windows.Forms.Button
    Friend WithEvents bsalir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ltfn As System.Windows.Forms.Label
    Friend WithEvents llocalidad As System.Windows.Forms.Label
    Friend WithEvents lprovincia As System.Windows.Forms.Label
    Friend WithEvents lcp As System.Windows.Forms.Label
    Friend WithEvents ldireccion As System.Windows.Forms.Label
    Friend WithEvents lnif As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents lnombre As System.Windows.Forms.Label
    Friend WithEvents bbuscarcli As System.Windows.Forms.Button
    Friend WithEvents tcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tventa As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents timporte As System.Windows.Forms.TextBox
    Friend WithEvents tdto As System.Windows.Forms.TextBox
    Friend WithEvents tcantidad As System.Windows.Forms.TextBox
    Friend WithEvents tpvp As System.Windows.Forms.TextBox
    Friend WithEvents tdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents tcodprod As System.Windows.Forms.TextBox
    Friend WithEvents tlinea As System.Windows.Forms.TextBox
    Friend WithEvents bnomaslineas As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents banadir As System.Windows.Forms.Button
    Friend WithEvents bvertodos As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents limporte As System.Windows.Forms.Label
    Friend WithEvents liva As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ltotal As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents blimpiar As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents bbuscar As System.Windows.Forms.Button
    Friend WithEvents bmodificar As System.Windows.Forms.Button
    Friend WithEvents bborrar As System.Windows.Forms.Button
    Friend WithEvents bnuevo As System.Windows.Forms.Button
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents tbnumres As System.Windows.Forms.TextBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents Linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PVP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bverres As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bultimo As System.Windows.Forms.Button
    Friend WithEvents bavance As System.Windows.Forms.Button
    Friend WithEvents bprimer As System.Windows.Forms.Button
    Friend WithEvents bretroceso As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
