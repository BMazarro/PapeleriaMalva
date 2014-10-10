<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compras))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.baceptar = New System.Windows.Forms.Button()
        Me.bcancelar = New System.Windows.Forms.Button()
        Me.bsalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bvertodos = New System.Windows.Forms.Button()
        Me.blimpiar = New System.Windows.Forms.Button()
        Me.tlinea = New System.Windows.Forms.TextBox()
        Me.tcantidad = New System.Windows.Forms.TextBox()
        Me.tcodprod = New System.Windows.Forms.TextBox()
        Me.tpvp = New System.Windows.Forms.TextBox()
        Me.timporte = New System.Windows.Forms.TextBox()
        Me.tdescripcion = New System.Windows.Forms.TextBox()
        Me.bnomaslineas = New System.Windows.Forms.Button()
        Me.beliminar = New System.Windows.Forms.Button()
        Me.banadir = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabTelefono = New System.Windows.Forms.Label()
        Me.LabLocalidad = New System.Windows.Forms.Label()
        Me.LabProvincia = New System.Windows.Forms.Label()
        Me.LabCP = New System.Windows.Forms.Label()
        Me.LabDir = New System.Windows.Forms.Label()
        Me.LabNif = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.LabNom = New System.Windows.Forms.Label()
        Me.bbuscarprov = New System.Windows.Forms.Button()
        Me.tproveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcompra = New System.Windows.Forms.TextBox()
        Me.tobservaciones = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.bnuevo = New System.Windows.Forms.Button()
        Me.ltotal = New System.Windows.Forms.Label()
        Me.liva = New System.Windows.Forms.Label()
        Me.limporte = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.bultimo = New System.Windows.Forms.Button()
        Me.bavance = New System.Windows.Forms.Button()
        Me.bprimer = New System.Windows.Forms.Button()
        Me.bretroceso = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.baceptar)
        Me.Panel2.Controls.Add(Me.bcancelar)
        Me.Panel2.Location = New System.Drawing.Point(0, 677)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 76)
        Me.Panel2.TabIndex = 89
        '
        'baceptar
        '
        Me.baceptar.BackColor = System.Drawing.Color.Transparent
        Me.baceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.baceptar.ForeColor = System.Drawing.Color.Black
        Me.baceptar.Location = New System.Drawing.Point(277, 30)
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
        Me.bcancelar.Location = New System.Drawing.Point(446, 30)
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
        Me.bsalir.Location = New System.Drawing.Point(15, 693)
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(100, 31)
        Me.bsalir.TabIndex = 30
        Me.bsalir.Text = "SALIR"
        Me.bsalir.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(325, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 25)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "COMPRAS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.bvertodos)
        Me.Panel3.Controls.Add(Me.blimpiar)
        Me.Panel3.Controls.Add(Me.tlinea)
        Me.Panel3.Controls.Add(Me.tcantidad)
        Me.Panel3.Controls.Add(Me.tcodprod)
        Me.Panel3.Controls.Add(Me.tpvp)
        Me.Panel3.Controls.Add(Me.timporte)
        Me.Panel3.Controls.Add(Me.tdescripcion)
        Me.Panel3.Controls.Add(Me.bnomaslineas)
        Me.Panel3.Controls.Add(Me.beliminar)
        Me.Panel3.Controls.Add(Me.banadir)
        Me.Panel3.Controls.Add(Me.dg)
        Me.Panel3.Location = New System.Drawing.Point(12, 261)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(753, 236)
        Me.Panel3.TabIndex = 93
        '
        'bvertodos
        '
        Me.bvertodos.Image = CType(resources.GetObject("bvertodos.Image"), System.Drawing.Image)
        Me.bvertodos.Location = New System.Drawing.Point(9, 194)
        Me.bvertodos.Name = "bvertodos"
        Me.bvertodos.Size = New System.Drawing.Size(39, 23)
        Me.bvertodos.TabIndex = 24
        Me.bvertodos.UseVisualStyleBackColor = True
        '
        'blimpiar
        '
        Me.blimpiar.Location = New System.Drawing.Point(674, 194)
        Me.blimpiar.Name = "blimpiar"
        Me.blimpiar.Size = New System.Drawing.Size(75, 23)
        Me.blimpiar.TabIndex = 23
        Me.blimpiar.Text = "Limpiar"
        Me.blimpiar.UseVisualStyleBackColor = True
        '
        'tlinea
        '
        Me.tlinea.BackColor = System.Drawing.SystemColors.Control
        Me.tlinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlinea.Location = New System.Drawing.Point(54, 197)
        Me.tlinea.Name = "tlinea"
        Me.tlinea.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tlinea.Size = New System.Drawing.Size(48, 20)
        Me.tlinea.TabIndex = 16
        '
        'tcantidad
        '
        Me.tcantidad.BackColor = System.Drawing.SystemColors.Control
        Me.tcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tcantidad.Location = New System.Drawing.Point(533, 197)
        Me.tcantidad.Name = "tcantidad"
        Me.tcantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tcantidad.Size = New System.Drawing.Size(64, 20)
        Me.tcantidad.TabIndex = 20
        '
        'tcodprod
        '
        Me.tcodprod.BackColor = System.Drawing.SystemColors.Control
        Me.tcodprod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tcodprod.Location = New System.Drawing.Point(99, 197)
        Me.tcodprod.Name = "tcodprod"
        Me.tcodprod.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tcodprod.Size = New System.Drawing.Size(86, 20)
        Me.tcodprod.TabIndex = 17
        '
        'tpvp
        '
        Me.tpvp.BackColor = System.Drawing.SystemColors.Control
        Me.tpvp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tpvp.Location = New System.Drawing.Point(467, 197)
        Me.tpvp.Name = "tpvp"
        Me.tpvp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tpvp.Size = New System.Drawing.Size(66, 20)
        Me.tpvp.TabIndex = 19
        '
        'timporte
        '
        Me.timporte.BackColor = System.Drawing.SystemColors.Control
        Me.timporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timporte.Location = New System.Drawing.Point(600, 197)
        Me.timporte.Name = "timporte"
        Me.timporte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.timporte.Size = New System.Drawing.Size(63, 20)
        Me.timporte.TabIndex = 22
        '
        'tdescripcion
        '
        Me.tdescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.tdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tdescripcion.Location = New System.Drawing.Point(182, 197)
        Me.tdescripcion.Name = "tdescripcion"
        Me.tdescripcion.Size = New System.Drawing.Size(289, 20)
        Me.tdescripcion.TabIndex = 18
        '
        'bnomaslineas
        '
        Me.bnomaslineas.Image = CType(resources.GetObject("bnomaslineas.Image"), System.Drawing.Image)
        Me.bnomaslineas.Location = New System.Drawing.Point(674, 150)
        Me.bnomaslineas.Name = "bnomaslineas"
        Me.bnomaslineas.Size = New System.Drawing.Size(33, 28)
        Me.bnomaslineas.TabIndex = 15
        Me.bnomaslineas.UseVisualStyleBackColor = True
        '
        'beliminar
        '
        Me.beliminar.Image = CType(resources.GetObject("beliminar.Image"), System.Drawing.Image)
        Me.beliminar.Location = New System.Drawing.Point(673, 110)
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(34, 34)
        Me.beliminar.TabIndex = 14
        Me.beliminar.UseVisualStyleBackColor = True
        '
        'banadir
        '
        Me.banadir.Image = CType(resources.GetObject("banadir.Image"), System.Drawing.Image)
        Me.banadir.Location = New System.Drawing.Point(672, 71)
        Me.banadir.Name = "banadir"
        Me.banadir.Size = New System.Drawing.Size(35, 33)
        Me.banadir.TabIndex = 13
        Me.banadir.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Linea, Me.codVenta, Me.descripcion, Me.PVP, Me.Cantidad, Me.Importe})
        Me.dg.Location = New System.Drawing.Point(15, 28)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.Size = New System.Drawing.Size(648, 150)
        Me.dg.TabIndex = 0
        '
        'Linea
        '
        Me.Linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Linea.DefaultCellStyle = DataGridViewCellStyle1
        Me.Linea.HeaderText = "Linea"
        Me.Linea.Name = "Linea"
        Me.Linea.ReadOnly = True
        Me.Linea.Width = 58
        '
        'codVenta
        '
        Me.codVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.codVenta.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PVP.DefaultCellStyle = DataGridViewCellStyle3
        Me.PVP.HeaderText = "PVP"
        Me.PVP.Name = "PVP"
        Me.PVP.ReadOnly = True
        Me.PVP.Width = 53
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 74
        '
        'Importe
        '
        Me.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle5
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        Me.Importe.Width = 67
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabTelefono)
        Me.Panel1.Controls.Add(Me.LabLocalidad)
        Me.Panel1.Controls.Add(Me.LabProvincia)
        Me.Panel1.Controls.Add(Me.LabCP)
        Me.Panel1.Controls.Add(Me.LabDir)
        Me.Panel1.Controls.Add(Me.LabNif)
        Me.Panel1.Controls.Add(Me.dtp)
        Me.Panel1.Controls.Add(Me.LabNom)
        Me.Panel1.Controls.Add(Me.bbuscarprov)
        Me.Panel1.Controls.Add(Me.tproveedor)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tcompra)
        Me.Panel1.Location = New System.Drawing.Point(31, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(719, 181)
        Me.Panel1.TabIndex = 92
        '
        'LabTelefono
        '
        Me.LabTelefono.AutoSize = True
        Me.LabTelefono.Location = New System.Drawing.Point(433, 153)
        Me.LabTelefono.Name = "LabTelefono"
        Me.LabTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LabTelefono.TabIndex = 14
        Me.LabTelefono.Text = "Telefono"
        '
        'LabLocalidad
        '
        Me.LabLocalidad.AutoSize = True
        Me.LabLocalidad.Location = New System.Drawing.Point(433, 128)
        Me.LabLocalidad.Name = "LabLocalidad"
        Me.LabLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LabLocalidad.TabIndex = 13
        Me.LabLocalidad.Text = "Localidad"
        '
        'LabProvincia
        '
        Me.LabProvincia.AutoSize = True
        Me.LabProvincia.Location = New System.Drawing.Point(551, 128)
        Me.LabProvincia.Name = "LabProvincia"
        Me.LabProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LabProvincia.TabIndex = 12
        Me.LabProvincia.Text = "Provincia"
        '
        'LabCP
        '
        Me.LabCP.AutoSize = True
        Me.LabCP.Location = New System.Drawing.Point(588, 101)
        Me.LabCP.Name = "LabCP"
        Me.LabCP.Size = New System.Drawing.Size(43, 13)
        Me.LabCP.TabIndex = 11
        Me.LabCP.Text = "CPostal"
        '
        'LabDir
        '
        Me.LabDir.AutoSize = True
        Me.LabDir.Location = New System.Drawing.Point(433, 101)
        Me.LabDir.Name = "LabDir"
        Me.LabDir.Size = New System.Drawing.Size(52, 13)
        Me.LabDir.TabIndex = 10
        Me.LabDir.Text = "Direccion"
        '
        'LabNif
        '
        Me.LabNif.AutoSize = True
        Me.LabNif.Location = New System.Drawing.Point(551, 74)
        Me.LabNif.Name = "LabNif"
        Me.LabNif.Size = New System.Drawing.Size(24, 13)
        Me.LabNif.TabIndex = 9
        Me.LabNif.Text = "NIF"
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(115, 74)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(100, 20)
        Me.dtp.TabIndex = 8
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.Location = New System.Drawing.Point(433, 74)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(44, 13)
        Me.LabNom.TabIndex = 7
        Me.LabNom.Text = "Nombre"
        '
        'bbuscarprov
        '
        Me.bbuscarprov.Image = CType(resources.GetObject("bbuscarprov.Image"), System.Drawing.Image)
        Me.bbuscarprov.Location = New System.Drawing.Point(554, 32)
        Me.bbuscarprov.Name = "bbuscarprov"
        Me.bbuscarprov.Size = New System.Drawing.Size(28, 23)
        Me.bbuscarprov.TabIndex = 6
        Me.bbuscarprov.UseVisualStyleBackColor = True
        '
        'tproveedor
        '
        Me.tproveedor.BackColor = System.Drawing.SystemColors.Control
        Me.tproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tproveedor.Location = New System.Drawing.Point(520, 32)
        Me.tproveedor.Name = "tproveedor"
        Me.tproveedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tproveedor.Size = New System.Drawing.Size(28, 20)
        Me.tproveedor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(433, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Proveedor:"
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
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nº Compra:"
        '
        'tcompra
        '
        Me.tcompra.BackColor = System.Drawing.SystemColors.Control
        Me.tcompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tcompra.Location = New System.Drawing.Point(144, 35)
        Me.tcompra.Name = "tcompra"
        Me.tcompra.ReadOnly = True
        Me.tcompra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tcompra.Size = New System.Drawing.Size(36, 20)
        Me.tcompra.TabIndex = 0
        '
        'tobservaciones
        '
        Me.tobservaciones.BackColor = System.Drawing.SystemColors.Control
        Me.tobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tobservaciones.Location = New System.Drawing.Point(67, 585)
        Me.tobservaciones.Multiline = True
        Me.tobservaciones.Name = "tobservaciones"
        Me.tobservaciones.Size = New System.Drawing.Size(249, 56)
        Me.tobservaciones.TabIndex = 115
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(64, 566)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 16)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Observaciones"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(61, 539)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 16)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "Forma de Pago:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(186, 534)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 112
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.bbuscar)
        Me.Panel4.Controls.Add(Me.bnuevo)
        Me.Panel4.Controls.Add(Me.bsalir)
        Me.Panel4.Location = New System.Drawing.Point(769, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(138, 753)
        Me.Panel4.TabIndex = 127
        '
        'bbuscar
        '
        Me.bbuscar.BackColor = System.Drawing.Color.Transparent
        Me.bbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbuscar.Location = New System.Drawing.Point(15, 182)
        Me.bbuscar.Name = "bbuscar"
        Me.bbuscar.Size = New System.Drawing.Size(100, 63)
        Me.bbuscar.TabIndex = 31
        Me.bbuscar.Text = "BUSCAR"
        Me.bbuscar.UseVisualStyleBackColor = False
        '
        'bnuevo
        '
        Me.bnuevo.BackColor = System.Drawing.Color.Transparent
        Me.bnuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnuevo.Location = New System.Drawing.Point(15, 80)
        Me.bnuevo.Name = "bnuevo"
        Me.bnuevo.Size = New System.Drawing.Size(100, 63)
        Me.bnuevo.TabIndex = 0
        Me.bnuevo.Text = "NUEVO"
        Me.bnuevo.UseVisualStyleBackColor = False
        '
        'ltotal
        '
        Me.ltotal.Location = New System.Drawing.Point(614, 613)
        Me.ltotal.Name = "ltotal"
        Me.ltotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ltotal.Size = New System.Drawing.Size(58, 12)
        Me.ltotal.TabIndex = 134
        '
        'liva
        '
        Me.liva.Location = New System.Drawing.Point(614, 561)
        Me.liva.Name = "liva"
        Me.liva.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.liva.Size = New System.Drawing.Size(58, 13)
        Me.liva.TabIndex = 133
        '
        'limporte
        '
        Me.limporte.Location = New System.Drawing.Point(614, 534)
        Me.limporte.Name = "limporte"
        Me.limporte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.limporte.Size = New System.Drawing.Size(58, 13)
        Me.limporte.TabIndex = 132
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(553, 609)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 18)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "TOTAL"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(586, 561)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 130
        Me.Label15.Text = "IVA"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(518, 558)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(38, 21)
        Me.ComboBox2.TabIndex = 129
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(549, 534)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 128
        Me.Label16.Text = "BASE IMP."
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 518
        Me.LineShape1.X2 = 699
        Me.LineShape1.Y1 = 592
        Me.LineShape1.Y2 = 592
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(907, 750)
        Me.ShapeContainer1.TabIndex = 135
        Me.ShapeContainer1.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(681, 609)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 18)
        Me.Label22.TabIndex = 136
        Me.Label22.Text = "€"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(562, 558)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 18)
        Me.Label6.TabIndex = 137
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
        Me.GroupBox2.Location = New System.Drawing.Point(330, 646)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 55)
        Me.GroupBox2.TabIndex = 138
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
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.ltotal)
        Me.Controls.Add(Me.liva)
        Me.Controls.Add(Me.limporte)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.tobservaciones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Compras"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents baceptar As System.Windows.Forms.Button
    Friend WithEvents bcancelar As System.Windows.Forms.Button
    Friend WithEvents bsalir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabTelefono As System.Windows.Forms.Label
    Friend WithEvents LabLocalidad As System.Windows.Forms.Label
    Friend WithEvents LabProvincia As System.Windows.Forms.Label
    Friend WithEvents LabCP As System.Windows.Forms.Label
    Friend WithEvents LabDir As System.Windows.Forms.Label
    Friend WithEvents LabNif As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabNom As System.Windows.Forms.Label
    Friend WithEvents bbuscarprov As System.Windows.Forms.Button
    Friend WithEvents tproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tcompra As System.Windows.Forms.TextBox
    Friend WithEvents tobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bnomaslineas As System.Windows.Forms.Button
    Friend WithEvents beliminar As System.Windows.Forms.Button
    Friend WithEvents banadir As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents bnuevo As System.Windows.Forms.Button
    Friend WithEvents tlinea As System.Windows.Forms.TextBox
    Friend WithEvents tcantidad As System.Windows.Forms.TextBox
    Friend WithEvents tcodprod As System.Windows.Forms.TextBox
    Friend WithEvents tpvp As System.Windows.Forms.TextBox
    Friend WithEvents timporte As System.Windows.Forms.TextBox
    Friend WithEvents tdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents blimpiar As System.Windows.Forms.Button
    Friend WithEvents bvertodos As System.Windows.Forms.Button
    Friend WithEvents ltotal As System.Windows.Forms.Label
    Friend WithEvents liva As System.Windows.Forms.Label
    Friend WithEvents limporte As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents bbuscar As System.Windows.Forms.Button
    Friend WithEvents Linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PVP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bultimo As System.Windows.Forms.Button
    Friend WithEvents bavance As System.Windows.Forms.Button
    Friend WithEvents bprimer As System.Windows.Forms.Button
    Friend WithEvents bretroceso As System.Windows.Forms.Button
End Class
