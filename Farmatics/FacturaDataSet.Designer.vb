﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''<summary>
'''Represents a strongly typed in-memory cache of data.
'''</summary>
<Global.System.Serializable(),  _
 Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 Global.System.Xml.Serialization.XmlRootAttribute("FacturaDataSet"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class FacturaDataSet
    Inherits Global.System.Data.DataSet
    
    Private tableProducto As ProductoDataTable

    Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Public Sub New()
        MyBase.New()
        Me.BeginInit()
        Me.InitClass()
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit()
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, False)
        If (Me.IsBinarySerialized(info, context) = True) Then
            Me.InitVars(False)
            Dim schemaChangedHandler1 As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)), String)
        If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet()
            ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Producto")) Is Nothing) Then
                MyBase.Tables.Add(New ProductoDataTable(ds.Tables("Producto")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars()
        Else
            Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), _
     Global.System.ComponentModel.Browsable(False), _
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
    Public ReadOnly Property Producto() As ProductoDataTable
        Get
            Return Me.tableProducto
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), _
     Global.System.ComponentModel.BrowsableAttribute(True), _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)> _
    Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set(value As Global.System.Data.SchemaSerializationMode)
            Me._schemaSerializationMode = value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit()
        Me.InitClass()
        Me.EndInit()
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Public Overrides Function Clone() As Global.System.Data.DataSet
        Dim cln As FacturaDataSet = CType(MyBase.Clone, FacturaDataSet)
        cln.InitVars()
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset()
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet()
            ds.ReadXml(reader)
            If (Not (ds.Tables("Producto")) Is Nothing) Then
                MyBase.Tables.Add(New ProductoDataTable(ds.Tables("Producto")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars()
        Else
            Me.ReadXml(reader)
            Me.InitVars()
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
        Dim stream As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
        Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Friend Overloads Sub InitVars()
        Me.InitVars(True)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableProducto = CType(MyBase.Tables("Producto"), ProductoDataTable)
        If (initTable = True) Then
            If (Not (Me.tableProducto) Is Nothing) Then
                Me.tableProducto.InitVars()
            End If
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Private Sub InitClass()
        Me.DataSetName = "FacturaDataSet"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/FacturaDataSet.xsd"
        Me.EnforceConstraints = True
        Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableProducto = New ProductoDataTable()
        MyBase.Tables.Add(Me.tableProducto)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Private Function ShouldSerializeProducto() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars()
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
        Dim ds As FacturaDataSet = New FacturaDataSet()
        Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
        Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
        Dim any As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
        If xs.Contains(dsSchema.TargetNamespace) Then
            Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
            Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
            Try
                Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                dsSchema.Write(s1)
                Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                Do While schemas.MoveNext
                    schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                    s2.SetLength(0)
                    schema.Write(s2)
                    If (s1.Length = s2.Length) Then
                        s1.Position = 0
                        s2.Position = 0

                        Do While ((s1.Position <> s1.Length) _
                                    AndAlso (s1.ReadByte = s2.ReadByte))


                        Loop
                        If (s1.Position = s1.Length) Then
                            Return type
                        End If
                    End If

                Loop
            Finally
                If (Not (s1) Is Nothing) Then
                    s1.Close()
                End If
                If (Not (s2) Is Nothing) Then
                    s2.Close()
                End If
            End Try
        End If
        xs.Add(dsSchema)
        Return type
    End Function

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Public Delegate Sub ProductoRowChangeEventHandler(ByVal sender As Object, ByVal e As ProductoRowChangeEvent)

    '''<summary>
    '''Represents the strongly named DataTable class.
    '''</summary>
    <Global.System.Serializable(), _
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
    Partial Public Class ProductoDataTable
        Inherits Global.System.Data.TypedTableBase(Of ProductoRow)

        Private columnCodigo As Global.System.Data.DataColumn

        Private columnNombre As Global.System.Data.DataColumn

        Private columnPrecio As Global.System.Data.DataColumn

        Private columnCantidad As Global.System.Data.DataColumn

        Private columnTotal As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            MyBase.New()
            Me.TableName = "Producto"
            Me.BeginInit()
            Me.InitClass()
            Me.EndInit()
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New()
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars()
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property CodigoColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnCodigo
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property NombreColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnNombre
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property PrecioColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnPrecio
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property CantidadColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnCantidad
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property TotalColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnTotal
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), _
         Global.System.ComponentModel.Browsable(False)> _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Default Public ReadOnly Property Item(ByVal index As Integer) As ProductoRow
            Get
                Return CType(Me.Rows(index), ProductoRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Event ProductoRowChanging As ProductoRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Event ProductoRowChanged As ProductoRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Event ProductoRowDeleting As ProductoRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Event ProductoRowDeleted As ProductoRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Overloads Sub AddProductoRow(ByVal row As ProductoRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Overloads Function AddProductoRow(ByVal Codigo As String, ByVal Nombre As String, ByVal Precio As String, ByVal Cantidad As String, ByVal Total As String) As ProductoRow
            Dim rowProductoRow As ProductoRow = CType(Me.NewRow, ProductoRow)
            Dim columnValuesArray() As Object = New Object() {Codigo, Nombre, Precio, Cantidad, Total}
            rowProductoRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowProductoRow)
            Return rowProductoRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As ProductoDataTable = CType(MyBase.Clone, ProductoDataTable)
            cln.InitVars()
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New ProductoDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Sub InitVars()
            Me.columnCodigo = MyBase.Columns("Codigo")
            Me.columnNombre = MyBase.Columns("Nombre")
            Me.columnPrecio = MyBase.Columns("Precio")
            Me.columnCantidad = MyBase.Columns("Cantidad")
            Me.columnTotal = MyBase.Columns("Total")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitClass()
            Me.columnCodigo = New Global.System.Data.DataColumn("Codigo", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCodigo)
            Me.columnNombre = New Global.System.Data.DataColumn("Nombre", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnNombre)
            Me.columnPrecio = New Global.System.Data.DataColumn("Precio", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnPrecio)
            Me.columnCantidad = New Global.System.Data.DataColumn("Cantidad", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnCantidad)
            Me.columnTotal = New Global.System.Data.DataColumn("Total", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnTotal)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function NewProductoRow() As ProductoRow
            Return CType(Me.NewRow, ProductoRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New ProductoRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(ProductoRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ProductoRowChangedEvent) Is Nothing) Then
                RaiseEvent ProductoRowChanged(Me, New ProductoRowChangeEvent(CType(e.Row, ProductoRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ProductoRowChangingEvent) Is Nothing) Then
                RaiseEvent ProductoRowChanging(Me, New ProductoRowChangeEvent(CType(e.Row, ProductoRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ProductoRowDeletedEvent) Is Nothing) Then
                RaiseEvent ProductoRowDeleted(Me, New ProductoRowChangeEvent(CType(e.Row, ProductoRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ProductoRowDeletingEvent) Is Nothing) Then
                RaiseEvent ProductoRowDeleting(Me, New ProductoRowChangeEvent(CType(e.Row, ProductoRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub RemoveProductoRow(ByVal row As ProductoRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As FacturaDataSet = New FacturaDataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "ProductoDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close()
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close()
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    '''<summary>
    '''Represents strongly named DataRow class.
    '''</summary>
    Partial Public Class ProductoRow
        Inherits Global.System.Data.DataRow

        Private tableProducto As ProductoDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableProducto = CType(Me.Table, ProductoDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property Codigo() As String
            Get
                Try
                    Return CType(Me(Me.tableProducto.CodigoColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'Codigo' de la tabla 'Producto' es DBNull.", e)
                End Try
            End Get
            Set(value As String)
                Me(Me.tableProducto.CodigoColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property Nombre() As String
            Get
                Try
                    Return CType(Me(Me.tableProducto.NombreColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'Nombre' de la tabla 'Producto' es DBNull.", e)
                End Try
            End Get
            Set(value As String)
                Me(Me.tableProducto.NombreColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property Precio() As String
            Get
                Try
                    Return CType(Me(Me.tableProducto.PrecioColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'Precio' de la tabla 'Producto' es DBNull.", e)
                End Try
            End Get
            Set(value As String)
                Me(Me.tableProducto.PrecioColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property Cantidad() As String
            Get
                Try
                    Return CType(Me(Me.tableProducto.CantidadColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'Cantidad' de la tabla 'Producto' es DBNull.", e)
                End Try
            End Get
            Set(value As String)
                Me(Me.tableProducto.CantidadColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property Total() As String
            Get
                Try
                    Return CType(Me(Me.tableProducto.TotalColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("El valor de la columna 'Total' de la tabla 'Producto' es DBNull.", e)
                End Try
            End Get
            Set(value As String)
                Me(Me.tableProducto.TotalColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function IsCodigoNull() As Boolean
            Return Me.IsNull(Me.tableProducto.CodigoColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub SetCodigoNull()
            Me(Me.tableProducto.CodigoColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function IsNombreNull() As Boolean
            Return Me.IsNull(Me.tableProducto.NombreColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub SetNombreNull()
            Me(Me.tableProducto.NombreColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function IsPrecioNull() As Boolean
            Return Me.IsNull(Me.tableProducto.PrecioColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub SetPrecioNull()
            Me(Me.tableProducto.PrecioColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function IsCantidadNull() As Boolean
            Return Me.IsNull(Me.tableProducto.CantidadColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub SetCantidadNull()
            Me(Me.tableProducto.CantidadColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function IsTotalNull() As Boolean
            Return Me.IsNull(Me.tableProducto.TotalColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub SetTotalNull()
            Me(Me.tableProducto.TotalColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    '''<summary>
    '''Row event argument class
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Public Class ProductoRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As ProductoRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New(ByVal row As ProductoRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New()
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property Row() As ProductoRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
