Module Estructuras
    Public Structure Empleado
        Public Nombre As String
        Public Apellido As String
        Public Cedula As Integer
        Public Telefono As Integer
        Public Correo As String
        Public Direccion As String
        Public Sexo As String
        Public Cargo As String
        Public FechaIngreso As DateTime

        Public Sub New(ByVal datos As List(Of String))
            Nombre = datos.Item(1)
            Apellido = datos.Item(2)
            Cedula = Integer.Parse(datos.Item(3))
            Telefono = Integer.Parse(datos.Item(4))
            Correo = datos.Item(5)
            Direccion = datos.Item(6)
            Sexo = datos.Item(7)
            Cargo = datos.Item(8)
            FechaIngreso = Convert.ToDateTime(datos.Item(9))
        End Sub
    End Structure

    Public Usuario As Empleado


End Module
