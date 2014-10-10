<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.MantenimientoProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CrearEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.MantenimientoLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturarCajaDiariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaDiariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bclientes = New System.Windows.Forms.Button()
        Me.blibros = New System.Windows.Forms.Button()
        Me.bventas = New System.Windows.Forms.Button()
        Me.breservas = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.barticulos = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.butilidades = New System.Windows.Forms.Button()
        Me.bcompras = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ListadoAlfClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoAlfProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ArticulosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ReservasToolStripMenuItem, Me.DevolucionesToolStripMenuItem, Me.FacturaciónToolStripMenuItem, Me.CajaDiariaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1241, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoClientesToolStripMenuItem, Me.ListadoAlfClientesToolStripMenuItem, Me.ToolStripSeparator8, Me.MantenimientoProveedoresToolStripMenuItem, Me.ListadoAlfProveedoresToolStripMenuItem, Me.ToolStripSeparator10, Me.EmpresaToolStripMenuItem, Me.ToolStripSeparator3, Me.CrearEmpresaToolStripMenuItem, Me.ToolStripSeparator5, Me.BackupToolStripMenuItem, Me.ToolStripSeparator6, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'MantenimientoClientesToolStripMenuItem
        '
        Me.MantenimientoClientesToolStripMenuItem.Name = "MantenimientoClientesToolStripMenuItem"
        Me.MantenimientoClientesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.MantenimientoClientesToolStripMenuItem.Text = "Clientes"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(198, 6)
        '
        'MantenimientoProveedoresToolStripMenuItem
        '
        Me.MantenimientoProveedoresToolStripMenuItem.Name = "MantenimientoProveedoresToolStripMenuItem"
        Me.MantenimientoProveedoresToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.MantenimientoProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(198, 6)
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.EmpresaToolStripMenuItem.Text = "Configuración Empresa"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(198, 6)
        '
        'CrearEmpresaToolStripMenuItem
        '
        Me.CrearEmpresaToolStripMenuItem.Name = "CrearEmpresaToolStripMenuItem"
        Me.CrearEmpresaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CrearEmpresaToolStripMenuItem.Text = "Crear Empresa"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(198, 6)
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.BackupToolStripMenuItem.Text = "Backup"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(198, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoArticulosToolStripMenuItem, Me.ListadoArticulosToolStripMenuItem, Me.ToolStripSeparator7, Me.MantenimientoLibrosToolStripMenuItem, Me.ListadoLibrosToolStripMenuItem})
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'MantenimientoArticulosToolStripMenuItem
        '
        Me.MantenimientoArticulosToolStripMenuItem.Name = "MantenimientoArticulosToolStripMenuItem"
        Me.MantenimientoArticulosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MantenimientoArticulosToolStripMenuItem.Text = "Articulos"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(159, 6)
        '
        'MantenimientoLibrosToolStripMenuItem
        '
        Me.MantenimientoLibrosToolStripMenuItem.Name = "MantenimientoLibrosToolStripMenuItem"
        Me.MantenimientoLibrosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MantenimientoLibrosToolStripMenuItem.Text = "Libros"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevaVentaToolStripMenuItem.Text = "Ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaCompraToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'NuevaCompraToolStripMenuItem
        '
        Me.NuevaCompraToolStripMenuItem.Name = "NuevaCompraToolStripMenuItem"
        Me.NuevaCompraToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevaCompraToolStripMenuItem.Text = "Compras"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaReservaToolStripMenuItem})
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'NuevaReservaToolStripMenuItem
        '
        Me.NuevaReservaToolStripMenuItem.Name = "NuevaReservaToolStripMenuItem"
        Me.NuevaReservaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevaReservaToolStripMenuItem.Text = "Reservas"
        '
        'DevolucionesToolStripMenuItem
        '
        Me.DevolucionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DevolucionesToolStripMenuItem1})
        Me.DevolucionesToolStripMenuItem.Name = "DevolucionesToolStripMenuItem"
        Me.DevolucionesToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.DevolucionesToolStripMenuItem.Text = "Devoluciones"
        '
        'DevolucionesToolStripMenuItem1
        '
        Me.DevolucionesToolStripMenuItem1.Name = "DevolucionesToolStripMenuItem1"
        Me.DevolucionesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DevolucionesToolStripMenuItem1.Text = "Devoluciones"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturarCajaDiariaToolStripMenuItem, Me.ToolStripSeparator4, Me.ImprimirFacturasToolStripMenuItem})
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.FacturaciónToolStripMenuItem.Text = "Facturación"
        '
        'FacturarCajaDiariaToolStripMenuItem
        '
        Me.FacturarCajaDiariaToolStripMenuItem.Name = "FacturarCajaDiariaToolStripMenuItem"
        Me.FacturarCajaDiariaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FacturarCajaDiariaToolStripMenuItem.Text = "Facturar Caja Diaria"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(173, 6)
        '
        'ImprimirFacturasToolStripMenuItem
        '
        Me.ImprimirFacturasToolStripMenuItem.Name = "ImprimirFacturasToolStripMenuItem"
        Me.ImprimirFacturasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ImprimirFacturasToolStripMenuItem.Text = "Imprimir Facturas"
        '
        'CajaDiariaToolStripMenuItem
        '
        Me.CajaDiariaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarLibroToolStripMenuItem})
        Me.CajaDiariaToolStripMenuItem.Name = "CajaDiariaToolStripMenuItem"
        Me.CajaDiariaToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.CajaDiariaToolStripMenuItem.Text = "Libro de IVA"
        '
        'MostrarLibroToolStripMenuItem
        '
        Me.MostrarLibroToolStripMenuItem.Name = "MostrarLibroToolStripMenuItem"
        Me.MostrarLibroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MostrarLibroToolStripMenuItem.Text = "Mostrar Libro"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de "
        '
        'bclientes
        '
        Me.bclientes.BackColor = System.Drawing.Color.Transparent
        Me.bclientes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bclientes.FlatAppearance.BorderSize = 0
        Me.bclientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bclientes.Image = CType(resources.GetObject("bclientes.Image"), System.Drawing.Image)
        Me.bclientes.Location = New System.Drawing.Point(49, 280)
        Me.bclientes.Name = "bclientes"
        Me.bclientes.Size = New System.Drawing.Size(157, 165)
        Me.bclientes.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.bclientes, "Clientes")
        Me.bclientes.UseVisualStyleBackColor = False
        '
        'blibros
        '
        Me.blibros.BackColor = System.Drawing.Color.Transparent
        Me.blibros.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.blibros.FlatAppearance.BorderSize = 0
        Me.blibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.blibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.blibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.blibros.ForeColor = System.Drawing.SystemColors.Control
        Me.blibros.Image = CType(resources.GetObject("blibros.Image"), System.Drawing.Image)
        Me.blibros.Location = New System.Drawing.Point(49, 59)
        Me.blibros.Name = "blibros"
        Me.blibros.Size = New System.Drawing.Size(151, 183)
        Me.blibros.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.blibros, "Libros de Texto")
        Me.blibros.UseVisualStyleBackColor = False
        '
        'bventas
        '
        Me.bventas.BackColor = System.Drawing.Color.Transparent
        Me.bventas.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bventas.FlatAppearance.BorderSize = 0
        Me.bventas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bventas.Image = CType(resources.GetObject("bventas.Image"), System.Drawing.Image)
        Me.bventas.Location = New System.Drawing.Point(15, 474)
        Me.bventas.Name = "bventas"
        Me.bventas.Size = New System.Drawing.Size(240, 128)
        Me.bventas.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.bventas, "Ventas")
        Me.bventas.UseVisualStyleBackColor = False
        '
        'breservas
        '
        Me.breservas.BackColor = System.Drawing.Color.Transparent
        Me.breservas.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.breservas.FlatAppearance.BorderSize = 0
        Me.breservas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.breservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.breservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.breservas.Image = CType(resources.GetObject("breservas.Image"), System.Drawing.Image)
        Me.breservas.Location = New System.Drawing.Point(15, 629)
        Me.breservas.Name = "breservas"
        Me.breservas.Size = New System.Drawing.Size(240, 140)
        Me.breservas.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.breservas, "Reservas")
        Me.breservas.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(263, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(686, 60)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'barticulos
        '
        Me.barticulos.BackColor = System.Drawing.Color.Transparent
        Me.barticulos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.barticulos.FlatAppearance.BorderSize = 0
        Me.barticulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.barticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.barticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.barticulos.Image = CType(resources.GetObject("barticulos.Image"), System.Drawing.Image)
        Me.barticulos.Location = New System.Drawing.Point(981, 119)
        Me.barticulos.Name = "barticulos"
        Me.barticulos.Size = New System.Drawing.Size(226, 142)
        Me.barticulos.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.barticulos, "Artículos")
        Me.barticulos.UseVisualStyleBackColor = False
        '
        'butilidades
        '
        Me.butilidades.BackColor = System.Drawing.Color.Transparent
        Me.butilidades.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.butilidades.FlatAppearance.BorderSize = 0
        Me.butilidades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.butilidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.butilidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butilidades.Image = CType(resources.GetObject("butilidades.Image"), System.Drawing.Image)
        Me.butilidades.Location = New System.Drawing.Point(1011, 291)
        Me.butilidades.Name = "butilidades"
        Me.butilidades.Size = New System.Drawing.Size(167, 143)
        Me.butilidades.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.butilidades, "Utilidades")
        Me.butilidades.UseVisualStyleBackColor = False
        '
        'bcompras
        '
        Me.bcompras.BackColor = System.Drawing.Color.Transparent
        Me.bcompras.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.bcompras.FlatAppearance.BorderSize = 0
        Me.bcompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bcompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bcompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bcompras.ForeColor = System.Drawing.SystemColors.Control
        Me.bcompras.Image = CType(resources.GetObject("bcompras.Image"), System.Drawing.Image)
        Me.bcompras.Location = New System.Drawing.Point(981, 463)
        Me.bcompras.Name = "bcompras"
        Me.bcompras.Size = New System.Drawing.Size(218, 246)
        Me.bcompras.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.bcompras, "Compras")
        Me.bcompras.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(368, 165)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(518, 559)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'ListadoAlfClientesToolStripMenuItem
        '
        Me.ListadoAlfClientesToolStripMenuItem.Name = "ListadoAlfClientesToolStripMenuItem"
        Me.ListadoAlfClientesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ListadoAlfClientesToolStripMenuItem.Text = "Listado Alf. Clientes"
        '
        'ListadoAlfProveedoresToolStripMenuItem
        '
        Me.ListadoAlfProveedoresToolStripMenuItem.Name = "ListadoAlfProveedoresToolStripMenuItem"
        Me.ListadoAlfProveedoresToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ListadoAlfProveedoresToolStripMenuItem.Text = "Listado Alf. Proveedores"
        '
        'ListadoArticulosToolStripMenuItem
        '
        Me.ListadoArticulosToolStripMenuItem.Name = "ListadoArticulosToolStripMenuItem"
        Me.ListadoArticulosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ListadoArticulosToolStripMenuItem.Text = "Listado Articulos"
        '
        'ListadoLibrosToolStripMenuItem
        '
        Me.ListadoLibrosToolStripMenuItem.Name = "ListadoLibrosToolStripMenuItem"
        Me.ListadoLibrosToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ListadoLibrosToolStripMenuItem.Text = "Listado Libros"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1241, 790)
        Me.ControlBox = False
        Me.Controls.Add(Me.bcompras)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.butilidades)
        Me.Controls.Add(Me.barticulos)
        Me.Controls.Add(Me.breservas)
        Me.Controls.Add(Me.bventas)
        Me.Controls.Add(Me.blibros)
        Me.Controls.Add(Me.bclientes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Papeleria Malva"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoLibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaReservaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bclientes As System.Windows.Forms.Button
    Friend WithEvents blibros As System.Windows.Forms.Button
    Friend WithEvents bventas As System.Windows.Forms.Button
    Friend WithEvents breservas As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents barticulos As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents butilidades As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CajaDiariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrearEmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FacturarCajaDiariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MostrarLibroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bcompras As System.Windows.Forms.Button
    Friend WithEvents ListadoAlfClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoAlfProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoLibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
