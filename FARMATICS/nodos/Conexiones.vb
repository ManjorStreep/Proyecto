Imports System.Data.OleDb
Imports System.Text
Module Conexiones

    ' Declaracion de variables a usar en el modulo.
    Public Conexion As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.IO.Directory.GetCurrentDirectory() & "\Database.mdb;")
    Public Comando As OleDbCommand
    Public Lector As OleDbDataReader
    Public Adaptador As OleDbDataAdapter


    Public Sub RegistrarDatos(ByVal texto As String, ByVal valores As List(Of String))
        Dim inicioConsulta As String = "INSERT INTO " & texto & " "
        Dim complementoConsulta As String = "Nombre de tabla equivocada"
        Dim constructor As New StringBuilder()
        For Each datos As String In valores
            constructor.Append("'" & datos & "'").Append(",")
        Next
        Dim datosFinalizados = constructor.ToString().Remove(constructor.ToString().LastIndexOf(", "))
        Select Case texto
            Case "Clientes"
                complementoConsulta = "(NOMBRE, APELLIDO, CEDULA, TELEFONO, DIRECCION)"
            Case "Productos"
                complementoConsulta = "(NOMBRE, APELLIDO, CEDULA, TELEFONO, DIRECCION)"
            Case "Trabajadores"
                complementoConsulta = "(NOMBRE, APELLIDO, CEDULA, TELEFONO, DIRECCION)"
            Case "Historial"
                complementoConsulta = "(NOMBRE, APELLIDO, CEDULA, TELEFONO, DIRECCION)"
        End Select
        Dim Consulta As String = inicioConsulta & complementoConsulta & " values (" & datosFinalizados & ");"

        Conexion.Open()

        Comando = New OleDbCommand(Consulta, Conexion)

        Try
            Comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conexion.Close()
    End Sub

    ' Metodo para Obtener una lista de la base de datos y pasarlos a un datagridview
    Public Sub ObtenerTabla(ByVal nombreTabla As String, ByVal tabla As DataGridView)
        Conexion.Open()
        Dim datos As New DataSet
        Adaptador = New OleDbDataAdapter("Select * from " & nombreTabla, Conexion)
        Adaptador.Fill(datos, nombreTabla)
        tabla.DataSource = datos
        tabla.DataMember = nombreTabla
        Conexion.Close()
    End Sub

    Public Function ObtenerDatos(ByVal nombreTabla As String, ByVal were As String)
        Conexion.Open()
        Dim Consulta As String = "SELECT * FROM " & nombreTabla & " " & were
        Comando = New OleDbCommand(Consulta, Conexion)
        Lector = Comando.ExecuteReader()
        Dim datos As New List(Of String)

        While Lector.Read()
            For i As Integer = 0 To Lector.FieldCount - 1
                datos.Add(Lector(i))
            Next
        End While
        Lector.Close()
        Conexion.Close()
        Return datos
    End Function

    Public Sub EliminarDatos(ByVal tabla As String, ByVal where As String)
        Conexion.Open()
        Dim Consulta As String = "DELETE * FROM " & tabla & " " & where
        MsgBox(Consulta)
        Comando = New OleDbCommand(Consulta, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()
    End Sub


End Module
