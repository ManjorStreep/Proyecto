Imports System.Text

Module Estructuras
    Public Structure Empleado

        Public Nombre As String
        Public Apellido As String
        Public Cedula As Integer
        Public Telefono As Long
        Public Correo As String
        Public Direccion As String
        Public Sexo As String
        Public Cargo As String
        Public FechaIngreso As DateTime
        Public Clave As String
        Dim DatosCompletos As List(Of String)


        Public Sub New(ByVal datos As List(Of String))
            Nombre = datos.Item(1)
            Apellido = datos.Item(2)
            Cedula = Integer.Parse(datos.Item(3))
            Telefono = Long.Parse(datos.Item(4))
            Correo = datos.Item(5)
            Direccion = datos.Item(6)
            Sexo = datos.Item(7)
            Cargo = datos.Item(8)
            FechaIngreso = Convert.ToDateTime(datos.Item(9))
            Clave = datos.Item(10)
            DatosCompletos = datos
        End Sub

        Public Function ObtenerDatos()
            Dim regresar As String
            Dim Constructor As New StringBuilder()

            For Each valor As String In DatosCompletos
                Constructor.Append("'" & valor & "', ")
            Next

            regresar = "(" & Constructor.ToString().Remove(Constructor.ToString().LastIndexOf(", ")) & ")"

            Return regresar
        End Function

        Public Function Vacio()
            If DatosCompletos.Count < 1 Then
                Return True
            Else
                Return False
            End If
        End Function
    End Structure




End Module
