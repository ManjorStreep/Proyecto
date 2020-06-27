<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerFichasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeAlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarSeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichaTecnicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionDeDesarrolloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.SsTxt_Fecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SsTxt_UsuarioDni = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmr_reloj = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbPerfil = New System.Windows.Forms.GroupBox()
        Me.lb_datocajero3 = New System.Windows.Forms.Label()
        Me.lb_datocajero2 = New System.Windows.Forms.Label()
        Me.lb_datocajero1 = New System.Windows.Forms.Label()
        Me.lb_datocajero0 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pb_profile = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Menu = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gbPerfil.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pb_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeEmpleadosToolStripMenuItem, Me.ControlDeAlmacenToolStripMenuItem, Me.ControlDeClientesToolStripMenuItem, Me.ToolStripSeparator1, Me.CerrarSeToolStripMenuItem, Me.ToolStripSeparator2, Me.SalirToolStripMenuItem, Me.ToolStripSeparator3})
        Me.InicioToolStripMenuItem.Image = CType(resources.GetObject("InicioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'ControlDeEmpleadosToolStripMenuItem
        '
        Me.ControlDeEmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerFichasToolStripMenuItem})
        Me.ControlDeEmpleadosToolStripMenuItem.Image = CType(resources.GetObject("ControlDeEmpleadosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ControlDeEmpleadosToolStripMenuItem.Name = "ControlDeEmpleadosToolStripMenuItem"
        Me.ControlDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ControlDeEmpleadosToolStripMenuItem.Text = "Control de Empleados"
        '
        'VerFichasToolStripMenuItem
        '
        Me.VerFichasToolStripMenuItem.Image = CType(resources.GetObject("VerFichasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VerFichasToolStripMenuItem.Name = "VerFichasToolStripMenuItem"
        Me.VerFichasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerFichasToolStripMenuItem.Text = "Ver Fichas "
        '
        'ControlDeAlmacenToolStripMenuItem
        '
        Me.ControlDeAlmacenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarProductoToolStripMenuItem, Me.ListaDeProductoToolStripMenuItem})
        Me.ControlDeAlmacenToolStripMenuItem.Image = CType(resources.GetObject("ControlDeAlmacenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ControlDeAlmacenToolStripMenuItem.Name = "ControlDeAlmacenToolStripMenuItem"
        Me.ControlDeAlmacenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ControlDeAlmacenToolStripMenuItem.Text = "Control de Productos"
        '
        'GestionarProductoToolStripMenuItem
        '
        Me.GestionarProductoToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._037_pharmacy
        Me.GestionarProductoToolStripMenuItem.Name = "GestionarProductoToolStripMenuItem"
        Me.GestionarProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.GestionarProductoToolStripMenuItem.Text = "Registrar Productos"
        '
        'ListaDeProductoToolStripMenuItem
        '
        Me.ListaDeProductoToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._033_medical_mask
        Me.ListaDeProductoToolStripMenuItem.Name = "ListaDeProductoToolStripMenuItem"
        Me.ListaDeProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ListaDeProductoToolStripMenuItem.Text = "Lista de Producto"
        '
        'ControlDeClientesToolStripMenuItem
        '
        Me.ControlDeClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarClienteToolStripMenuItem, Me.ListaDeClientesToolStripMenuItem})
        Me.ControlDeClientesToolStripMenuItem.Image = CType(resources.GetObject("ControlDeClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ControlDeClientesToolStripMenuItem.Name = "ControlDeClientesToolStripMenuItem"
        Me.ControlDeClientesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ControlDeClientesToolStripMenuItem.Text = "Gestionar Clientes"
        '
        'RegistrarClienteToolStripMenuItem
        '
        Me.RegistrarClienteToolStripMenuItem.Name = "RegistrarClienteToolStripMenuItem"
        Me.RegistrarClienteToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RegistrarClienteToolStripMenuItem.Text = "Registrar Cliente"
        '
        'ListaDeClientesToolStripMenuItem
        '
        Me.ListaDeClientesToolStripMenuItem.Name = "ListaDeClientesToolStripMenuItem"
        Me.ListaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ListaDeClientesToolStripMenuItem.Text = "Lista de Clientes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'CerrarSeToolStripMenuItem
        '
        Me.CerrarSeToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._020_medical_prescription
        Me.CerrarSeToolStripMenuItem.Name = "CerrarSeToolStripMenuItem"
        Me.CerrarSeToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.CerrarSeToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(188, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(188, 6)
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealizarVentaToolStripMenuItem, Me.HistorialDeVentasToolStripMenuItem})
        Me.VentaToolStripMenuItem.Image = CType(resources.GetObject("VentaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'RealizarVentaToolStripMenuItem
        '
        Me.RealizarVentaToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._017_x_ray
        Me.RealizarVentaToolStripMenuItem.Name = "RealizarVentaToolStripMenuItem"
        Me.RealizarVentaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RealizarVentaToolStripMenuItem.Text = "Realizar Venta"
        '
        'HistorialDeVentasToolStripMenuItem
        '
        Me.HistorialDeVentasToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._011_thermometer
        Me.HistorialDeVentasToolStripMenuItem.Name = "HistorialDeVentasToolStripMenuItem"
        Me.HistorialDeVentasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.HistorialDeVentasToolStripMenuItem.Text = "Historial de Ventas"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightGray
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.VentaToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(821, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ProductosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._002_online_appointment
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._009_nurse
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "clientes"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._028_doctor
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmpleadosToolStripMenuItem.Text = "empleados"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._023_dna_structure
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem.Text = "productos"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichaTecnicaToolStripMenuItem, Me.InformacionDeDesarrolloToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._024_test_tubes
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.HerramientasToolStripMenuItem.Text = "Acerca de"
        '
        'FichaTecnicaToolStripMenuItem
        '
        Me.FichaTecnicaToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._039_injection
        Me.FichaTecnicaToolStripMenuItem.Name = "FichaTecnicaToolStripMenuItem"
        Me.FichaTecnicaToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.FichaTecnicaToolStripMenuItem.Text = "Ficha Tecnica"
        '
        'InformacionDeDesarrolloToolStripMenuItem
        '
        Me.InformacionDeDesarrolloToolStripMenuItem.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._040_medical_file
        Me.InformacionDeDesarrolloToolStripMenuItem.Name = "InformacionDeDesarrolloToolStripMenuItem"
        Me.InformacionDeDesarrolloToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.InformacionDeDesarrolloToolStripMenuItem.Text = "Informacion de desarrollo"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightGray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.SsTxt_Fecha, Me.SsTxt_UsuarioDni})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 666)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(821, 24)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "pieMenu1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 18)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'SsTxt_Fecha
        '
        Me.SsTxt_Fecha.ActiveLinkColor = System.Drawing.Color.Black
        Me.SsTxt_Fecha.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SsTxt_Fecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SsTxt_Fecha.Name = "SsTxt_Fecha"
        Me.SsTxt_Fecha.Size = New System.Drawing.Size(73, 19)
        Me.SsTxt_Fecha.Text = "SsTxt_Fecha"
        '
        'SsTxt_UsuarioDni
        '
        Me.SsTxt_UsuarioDni.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SsTxt_UsuarioDni.Name = "SsTxt_UsuarioDni"
        Me.SsTxt_UsuarioDni.Size = New System.Drawing.Size(100, 19)
        Me.SsTxt_UsuarioDni.Text = "SsTxt_UsuarioDni"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.gbPerfil)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(11, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 635)
        Me.Panel1.TabIndex = 82
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources._003_doctor
        Me.PictureBox4.Location = New System.Drawing.Point(14, 65)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(59, 56)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button1)
        Me.GroupBox7.Controls.Add(Me.btn_salir)
        Me.GroupBox7.Location = New System.Drawing.Point(64, 496)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(195, 59)
        Me.GroupBox7.TabIndex = 21
        Me.GroupBox7.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(96, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cerrar Sesión"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(7, 14)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(76, 30)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 110)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(301, 59)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(3, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(297, 32)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ADMINISTRACIÓN"
        '
        'gbPerfil
        '
        Me.gbPerfil.BackColor = System.Drawing.Color.Transparent
        Me.gbPerfil.Controls.Add(Me.lb_datocajero3)
        Me.gbPerfil.Controls.Add(Me.lb_datocajero2)
        Me.gbPerfil.Controls.Add(Me.lb_datocajero1)
        Me.gbPerfil.Controls.Add(Me.lb_datocajero0)
        Me.gbPerfil.Controls.Add(Me.Label4)
        Me.gbPerfil.Controls.Add(Me.Label3)
        Me.gbPerfil.Controls.Add(Me.Label2)
        Me.gbPerfil.Controls.Add(Me.Label1)
        Me.gbPerfil.Controls.Add(Me.PictureBox2)
        Me.gbPerfil.Controls.Add(Me.GroupBox1)
        Me.gbPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbPerfil.Location = New System.Drawing.Point(43, 151)
        Me.gbPerfil.Margin = New System.Windows.Forms.Padding(0)
        Me.gbPerfil.Name = "gbPerfil"
        Me.gbPerfil.Size = New System.Drawing.Size(234, 353)
        Me.gbPerfil.TabIndex = 18
        Me.gbPerfil.TabStop = False
        '
        'lb_datocajero3
        '
        Me.lb_datocajero3.AutoSize = True
        Me.lb_datocajero3.BackColor = System.Drawing.Color.Silver
        Me.lb_datocajero3.Location = New System.Drawing.Point(110, 281)
        Me.lb_datocajero3.Name = "lb_datocajero3"
        Me.lb_datocajero3.Size = New System.Drawing.Size(48, 13)
        Me.lb_datocajero3.TabIndex = 11
        Me.lb_datocajero3.Text = "lb_cargo"
        '
        'lb_datocajero2
        '
        Me.lb_datocajero2.AutoSize = True
        Me.lb_datocajero2.BackColor = System.Drawing.Color.Silver
        Me.lb_datocajero2.Location = New System.Drawing.Point(110, 257)
        Me.lb_datocajero2.Name = "lb_datocajero2"
        Me.lb_datocajero2.Size = New System.Drawing.Size(32, 13)
        Me.lb_datocajero2.TabIndex = 10
        Me.lb_datocajero2.Text = "lb_ID"
        '
        'lb_datocajero1
        '
        Me.lb_datocajero1.AutoSize = True
        Me.lb_datocajero1.BackColor = System.Drawing.Color.Silver
        Me.lb_datocajero1.Location = New System.Drawing.Point(110, 233)
        Me.lb_datocajero1.Name = "lb_datocajero1"
        Me.lb_datocajero1.Size = New System.Drawing.Size(63, 13)
        Me.lb_datocajero1.TabIndex = 9
        Me.lb_datocajero1.Text = "lb_lastname"
        '
        'lb_datocajero0
        '
        Me.lb_datocajero0.AutoSize = True
        Me.lb_datocajero0.BackColor = System.Drawing.Color.Silver
        Me.lb_datocajero0.Location = New System.Drawing.Point(110, 208)
        Me.lb_datocajero0.Name = "lb_datocajero0"
        Me.lb_datocajero0.Size = New System.Drawing.Size(47, 13)
        Me.lb_datocajero0.TabIndex = 8
        Me.lb_datocajero0.Text = "lb_name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(63, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cargo :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(28, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Identificación :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(49, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellidos :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(49, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombres :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Silver
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(20, 192)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 130)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pb_profile)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 157)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'pb_profile
        '
        Me.pb_profile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_profile.BackColor = System.Drawing.Color.Silver
        Me.pb_profile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_profile.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources.profile_2092113_960_720
        Me.pb_profile.Location = New System.Drawing.Point(6, 14)
        Me.pb_profile.Name = "pb_profile"
        Me.pb_profile.Size = New System.Drawing.Size(134, 132)
        Me.pb_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_profile.TabIndex = 3
        Me.pb_profile.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplicationFARMATICS.My.Resources.Resources.logo_farmatic_vec_png
        Me.PictureBox1.Location = New System.Drawing.Point(74, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Panel_Menu
        '
        Me.Panel_Menu.Location = New System.Drawing.Point(346, 41)
        Me.Panel_Menu.Name = "Panel_Menu"
        Me.Panel_Menu.Size = New System.Drawing.Size(459, 617)
        Me.Panel_Menu.TabIndex = 83
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(821, 690)
        Me.Controls.Add(Me.Panel_Menu)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.gbPerfil.ResumeLayout(False)
        Me.gbPerfil.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pb_profile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ControlDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerFichasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeAlmacenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistorialDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FichaTecnicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionDeDesarrolloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SsTxt_UsuarioDni As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ControlDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarSeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents SsTxt_Fecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GestionarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmr_reloj As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbPerfil As System.Windows.Forms.GroupBox
    Friend WithEvents lb_datocajero3 As System.Windows.Forms.Label
    Friend WithEvents lb_datocajero2 As System.Windows.Forms.Label
    Friend WithEvents lb_datocajero1 As System.Windows.Forms.Label
    Friend WithEvents lb_datocajero0 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pb_profile As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel_Menu As System.Windows.Forms.Panel
End Class
