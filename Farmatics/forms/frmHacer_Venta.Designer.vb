﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHacer_Venta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHacer_Venta))
        Me.txt_BuscarCodigoID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_Pagar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.txt_productosStock = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_PrecioProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_NombreProducto = New System.Windows.Forms.TextBox()
        Me.txt_tipoProducto = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_NacionalidadCliente = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_BuscarCliente = New System.Windows.Forms.Button()
        Me.txt_DniCliente = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lb_nombreEmpleado = New System.Windows.Forms.Label()
        Me.lb_codigoEmpleado = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_BuscarCodigoID = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Registrar = New System.Windows.Forms.Button()
        Me.txt_TelefonoCLiente = New System.Windows.Forms.TextBox()
        Me.txt_DireccionCliente = New System.Windows.Forms.TextBox()
        Me.txt_NombreCliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gb_DatosVenta = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_MostrarInventario = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.btn_EliminarProducto = New System.Windows.Forms.Button()
        Me.btn_AgregarProducto = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gb_DatosVenta.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_BuscarCodigoID
        '
        Me.txt_BuscarCodigoID.Location = New System.Drawing.Point(148, 83)
        Me.txt_BuscarCodigoID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_BuscarCodigoID.Name = "txt_BuscarCodigoID"
        Me.txt_BuscarCodigoID.Size = New System.Drawing.Size(90, 23)
        Me.txt_BuscarCodigoID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID/CODIGO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(7, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "NOMBRE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(672, -1)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 39)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Facturación"
        '
        'btn_Pagar
        '
        Me.btn_Pagar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Pagar.Location = New System.Drawing.Point(16, 195)
        Me.btn_Pagar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Pagar.Name = "btn_Pagar"
        Me.btn_Pagar.Size = New System.Drawing.Size(84, 33)
        Me.btn_Pagar.TabIndex = 14
        Me.btn_Pagar.Text = "Pagar"
        Me.btn_Pagar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.txt_productosStock)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_PrecioProducto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_NombreProducto)
        Me.GroupBox1.Controls.Add(Me.txt_tipoProducto)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 187)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Venta"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(157, 134)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(39, 23)
        Me.NumericUpDown1.TabIndex = 84
        '
        'txt_productosStock
        '
        Me.txt_productosStock.Enabled = False
        Me.txt_productosStock.Location = New System.Drawing.Point(47, 133)
        Me.txt_productosStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_productosStock.Name = "txt_productosStock"
        Me.txt_productosStock.Size = New System.Drawing.Size(90, 23)
        Me.txt_productosStock.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(62, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "STOCK"
        '
        'txt_PrecioProducto
        '
        Me.txt_PrecioProducto.Enabled = False
        Me.txt_PrecioProducto.Location = New System.Drawing.Point(135, 86)
        Me.txt_PrecioProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_PrecioProducto.Name = "txt_PrecioProducto"
        Me.txt_PrecioProducto.Size = New System.Drawing.Size(90, 23)
        Me.txt_PrecioProducto.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(149, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "PRECIO"
        '
        'txt_NombreProducto
        '
        Me.txt_NombreProducto.Enabled = False
        Me.txt_NombreProducto.Location = New System.Drawing.Point(39, 39)
        Me.txt_NombreProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_NombreProducto.Name = "txt_NombreProducto"
        Me.txt_NombreProducto.Size = New System.Drawing.Size(178, 23)
        Me.txt_NombreProducto.TabIndex = 88
        '
        'txt_tipoProducto
        '
        Me.txt_tipoProducto.Enabled = False
        Me.txt_tipoProducto.Location = New System.Drawing.Point(17, 86)
        Me.txt_tipoProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tipoProducto.Name = "txt_tipoProducto"
        Me.txt_tipoProducto.Size = New System.Drawing.Size(90, 23)
        Me.txt_tipoProducto.TabIndex = 89
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(43, 66)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 16)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "TIPO"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cb_NacionalidadCliente)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.btn_BuscarCliente)
        Me.GroupBox3.Controls.Add(Me.txt_DniCliente)
        Me.GroupBox3.Location = New System.Drawing.Point(81, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(241, 71)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        '
        'cb_NacionalidadCliente
        '
        Me.cb_NacionalidadCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_NacionalidadCliente.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_NacionalidadCliente.FormattingEnabled = True
        Me.cb_NacionalidadCliente.Items.AddRange(New Object() {"E-", "G-", "J-", "V-"})
        Me.cb_NacionalidadCliente.Location = New System.Drawing.Point(6, 35)
        Me.cb_NacionalidadCliente.Name = "cb_NacionalidadCliente"
        Me.cb_NacionalidadCliente.Size = New System.Drawing.Size(46, 24)
        Me.cb_NacionalidadCliente.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(20, 15)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(205, 16)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Documento de idetificación"
        '
        'btn_BuscarCliente
        '
        Me.btn_BuscarCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_BuscarCliente.Location = New System.Drawing.Point(153, 35)
        Me.btn_BuscarCliente.Name = "btn_BuscarCliente"
        Me.btn_BuscarCliente.Size = New System.Drawing.Size(82, 22)
        Me.btn_BuscarCliente.TabIndex = 2
        Me.btn_BuscarCliente.Text = "BUSCAR"
        Me.btn_BuscarCliente.UseVisualStyleBackColor = True
        '
        'txt_DniCliente
        '
        Me.txt_DniCliente.Location = New System.Drawing.Point(59, 35)
        Me.txt_DniCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_DniCliente.Name = "txt_DniCliente"
        Me.txt_DniCliente.Size = New System.Drawing.Size(87, 23)
        Me.txt_DniCliente.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sotware_Farmatics.My.Resources.Resources.logo_farmatic_vec_png
        Me.PictureBox1.Location = New System.Drawing.Point(478, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.lb_nombreEmpleado)
        Me.GroupBox4.Controls.Add(Me.lb_codigoEmpleado)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(597, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(368, 83)
        Me.GroupBox4.TabIndex = 80
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PROMOTOR DE VENTAS"
        '
        'lb_nombreEmpleado
        '
        Me.lb_nombreEmpleado.AutoSize = True
        Me.lb_nombreEmpleado.Location = New System.Drawing.Point(176, 54)
        Me.lb_nombreEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_nombreEmpleado.Name = "lb_nombreEmpleado"
        Me.lb_nombreEmpleado.Size = New System.Drawing.Size(158, 16)
        Me.lb_nombreEmpleado.TabIndex = 16
        Me.lb_nombreEmpleado.Text = "lb_nombreEmpleado"
        '
        'lb_codigoEmpleado
        '
        Me.lb_codigoEmpleado.AutoSize = True
        Me.lb_codigoEmpleado.Location = New System.Drawing.Point(176, 24)
        Me.lb_codigoEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_codigoEmpleado.Name = "lb_codigoEmpleado"
        Me.lb_codigoEmpleado.Size = New System.Drawing.Size(150, 16)
        Me.lb_codigoEmpleado.TabIndex = 15
        Me.lb_codigoEmpleado.Text = "lb_codigoEmpleado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 24)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "CODIGO EMPLEADO :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 54)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "EMPLEADO : "
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Cancelar.Location = New System.Drawing.Point(122, 195)
        Me.btn_Cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(98, 33)
        Me.btn_Cancelar.TabIndex = 82
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.Name = "Total"
        '
        'btn_BuscarCodigoID
        '
        Me.btn_BuscarCodigoID.BackColor = System.Drawing.Color.White
        Me.btn_BuscarCodigoID.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuscarCodigoID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_BuscarCodigoID.Location = New System.Drawing.Point(245, 83)
        Me.btn_BuscarCodigoID.Name = "btn_BuscarCodigoID"
        Me.btn_BuscarCodigoID.Size = New System.Drawing.Size(63, 24)
        Me.btn_BuscarCodigoID.TabIndex = 84
        Me.btn_BuscarCodigoID.Text = "BUSCAR"
        Me.btn_BuscarCodigoID.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox2.Controls.Add(Me.btn_Registrar)
        Me.GroupBox2.Controls.Add(Me.txt_TelefonoCLiente)
        Me.GroupBox2.Controls.Add(Me.txt_DireccionCliente)
        Me.GroupBox2.Controls.Add(Me.txt_NombreCliente)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 107)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DEL CLIENTE"
        '
        'btn_Registrar
        '
        Me.btn_Registrar.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Registrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Registrar.Location = New System.Drawing.Point(311, 57)
        Me.btn_Registrar.Name = "btn_Registrar"
        Me.btn_Registrar.Size = New System.Drawing.Size(86, 22)
        Me.btn_Registrar.TabIndex = 6
        Me.btn_Registrar.Text = "REGISTRAR"
        Me.btn_Registrar.UseVisualStyleBackColor = True
        Me.btn_Registrar.Visible = False
        '
        'txt_TelefonoCLiente
        '
        Me.txt_TelefonoCLiente.Enabled = False
        Me.txt_TelefonoCLiente.Location = New System.Drawing.Point(100, 74)
        Me.txt_TelefonoCLiente.Name = "txt_TelefonoCLiente"
        Me.txt_TelefonoCLiente.Size = New System.Drawing.Size(193, 23)
        Me.txt_TelefonoCLiente.TabIndex = 5
        Me.txt_TelefonoCLiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_DireccionCliente
        '
        Me.txt_DireccionCliente.Enabled = False
        Me.txt_DireccionCliente.Location = New System.Drawing.Point(100, 45)
        Me.txt_DireccionCliente.Name = "txt_DireccionCliente"
        Me.txt_DireccionCliente.Size = New System.Drawing.Size(193, 23)
        Me.txt_DireccionCliente.TabIndex = 4
        Me.txt_DireccionCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_NombreCliente
        '
        Me.txt_NombreCliente.Enabled = False
        Me.txt_NombreCliente.Location = New System.Drawing.Point(100, 16)
        Me.txt_NombreCliente.Name = "txt_NombreCliente"
        Me.txt_NombreCliente.Size = New System.Drawing.Size(193, 23)
        Me.txt_NombreCliente.TabIndex = 3
        Me.txt_NombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 77)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "TELEFONO:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 48)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 16)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "DIRECCIÓN:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 19)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 16)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "NOMBRE:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.Sotware_Farmatics.My.Resources.Resources._035_microscope
        Me.PictureBox2.Location = New System.Drawing.Point(331, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DataGridView1)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(5, 48)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(559, 389)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Lista de Productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Precio, Me.Cantidad, Me.Total2})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(16, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(537, 352)
        Me.DataGridView1.TabIndex = 83
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Total2
        '
        Me.Total2.HeaderText = "Total"
        Me.Total2.Name = "Total2"
        Me.Total2.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.gb_DatosVenta)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(19, 192)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 453)
        Me.Panel1.TabIndex = 83
        '
        'gb_DatosVenta
        '
        Me.gb_DatosVenta.Controls.Add(Me.TextBox6)
        Me.gb_DatosVenta.Controls.Add(Me.Panel2)
        Me.gb_DatosVenta.Controls.Add(Me.txt_BuscarCodigoID)
        Me.gb_DatosVenta.Controls.Add(Me.btn_BuscarCodigoID)
        Me.gb_DatosVenta.Controls.Add(Me.Label3)
        Me.gb_DatosVenta.Enabled = False
        Me.gb_DatosVenta.Location = New System.Drawing.Point(571, 48)
        Me.gb_DatosVenta.Name = "gb_DatosVenta"
        Me.gb_DatosVenta.Size = New System.Drawing.Size(358, 389)
        Me.gb_DatosVenta.TabIndex = 88
        Me.gb_DatosVenta.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Black
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Verdana", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(59, 22)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(249, 49)
        Me.TextBox6.TabIndex = 87
        Me.TextBox6.Text = "0.00"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_MostrarInventario)
        Me.Panel2.Controls.Add(Me.btn_Salir)
        Me.Panel2.Controls.Add(Me.btn_EliminarProducto)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.btn_AgregarProducto)
        Me.Panel2.Controls.Add(Me.btn_Cancelar)
        Me.Panel2.Controls.Add(Me.btn_Pagar)
        Me.Panel2.Location = New System.Drawing.Point(6, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 243)
        Me.Panel2.TabIndex = 38
        '
        'btn_MostrarInventario
        '
        Me.btn_MostrarInventario.BackColor = System.Drawing.Color.White
        Me.btn_MostrarInventario.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MostrarInventario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_MostrarInventario.Location = New System.Drawing.Point(265, 88)
        Me.btn_MostrarInventario.Name = "btn_MostrarInventario"
        Me.btn_MostrarInventario.Size = New System.Drawing.Size(75, 24)
        Me.btn_MostrarInventario.TabIndex = 94
        Me.btn_MostrarInventario.Text = "Inventario"
        Me.btn_MostrarInventario.UseVisualStyleBackColor = False
        '
        'btn_Salir
        '
        Me.btn_Salir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_Salir.Location = New System.Drawing.Point(242, 195)
        Me.btn_Salir.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(98, 33)
        Me.btn_Salir.TabIndex = 83
        Me.btn_Salir.Text = "Salir"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'btn_EliminarProducto
        '
        Me.btn_EliminarProducto.BackColor = System.Drawing.Color.White
        Me.btn_EliminarProducto.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_EliminarProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_EliminarProducto.Location = New System.Drawing.Point(265, 134)
        Me.btn_EliminarProducto.Name = "btn_EliminarProducto"
        Me.btn_EliminarProducto.Size = New System.Drawing.Size(74, 24)
        Me.btn_EliminarProducto.TabIndex = 85
        Me.btn_EliminarProducto.Text = "ELIMINAR"
        Me.btn_EliminarProducto.UseVisualStyleBackColor = False
        '
        'btn_AgregarProducto
        '
        Me.btn_AgregarProducto.BackColor = System.Drawing.Color.White
        Me.btn_AgregarProducto.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgregarProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_AgregarProducto.Location = New System.Drawing.Point(265, 46)
        Me.btn_AgregarProducto.Name = "btn_AgregarProducto"
        Me.btn_AgregarProducto.Size = New System.Drawing.Size(75, 24)
        Me.btn_AgregarProducto.TabIndex = 86
        Me.btn_AgregarProducto.Text = "AGREGAR"
        Me.btn_AgregarProducto.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(944, 26)
        Me.PictureBox3.TabIndex = 89
        Me.PictureBox3.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(149, 115)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "CANTIDAD"
        '
        'frmHacer_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(977, 669)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHacer_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gb_DatosVenta.ResumeLayout(False)
        Me.gb_DatosVenta.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_BuscarCodigoID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_Pagar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_BuscarCliente As System.Windows.Forms.Button
    Friend WithEvents btn_BuscarCodigoID As System.Windows.Forms.Button
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lb_nombreEmpleado As System.Windows.Forms.Label
    Friend WithEvents lb_codigoEmpleado As System.Windows.Forms.Label
    Friend WithEvents txt_DniCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cb_NacionalidadCliente As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_TelefonoCLiente As System.Windows.Forms.TextBox
    Friend WithEvents txt_DireccionCliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_NombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents btn_AgregarProducto As System.Windows.Forms.Button
    Friend WithEvents btn_EliminarProducto As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gb_DatosVenta As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents txt_productosStock As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents txt_PrecioProducto As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_NombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipoProducto As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_MostrarInventario As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btn_Registrar As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
