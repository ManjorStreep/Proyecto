<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventario
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADDISPONIBLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLASIFICACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECIPEDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGODataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.VALORDataGridViewTextBoxColumn, Me.CANTIDADDISPONIBLEDataGridViewTextBoxColumn, Me.CLASIFICACIONDataGridViewTextBoxColumn, Me.RECIPEDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(24, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(640, 457)
        Me.DataGridView1.TabIndex = 0
        '
        'CODIGODataGridViewTextBoxColumn
        '
        Me.CODIGODataGridViewTextBoxColumn.DataPropertyName = "CODIGO"
        Me.CODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.CODIGODataGridViewTextBoxColumn.Name = "CODIGODataGridViewTextBoxColumn"
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        '
        'VALORDataGridViewTextBoxColumn
        '
        Me.VALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR"
        Me.VALORDataGridViewTextBoxColumn.HeaderText = "VALOR"
        Me.VALORDataGridViewTextBoxColumn.Name = "VALORDataGridViewTextBoxColumn"
        '
        'CANTIDADDISPONIBLEDataGridViewTextBoxColumn
        '
        Me.CANTIDADDISPONIBLEDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD_DISPONIBLE"
        Me.CANTIDADDISPONIBLEDataGridViewTextBoxColumn.HeaderText = "CANTIDAD_DISPONIBLE"
        Me.CANTIDADDISPONIBLEDataGridViewTextBoxColumn.Name = "CANTIDADDISPONIBLEDataGridViewTextBoxColumn"
        '
        'CLASIFICACIONDataGridViewTextBoxColumn
        '
        Me.CLASIFICACIONDataGridViewTextBoxColumn.DataPropertyName = "CLASIFICACION"
        Me.CLASIFICACIONDataGridViewTextBoxColumn.HeaderText = "CLASIFICACION"
        Me.CLASIFICACIONDataGridViewTextBoxColumn.Name = "CLASIFICACIONDataGridViewTextBoxColumn"
        '
        'RECIPEDataGridViewCheckBoxColumn
        '
        Me.RECIPEDataGridViewCheckBoxColumn.DataPropertyName = "RECIPE"
        Me.RECIPEDataGridViewCheckBoxColumn.HeaderText = "RECIPE"
        Me.RECIPEDataGridViewCheckBoxColumn.Name = "RECIPEDataGridViewCheckBoxColumn"
        '
        'frmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 529)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmInventario"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODIGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADDISPONIBLEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLASIFICACIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECIPEDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
