Imports System.Data.OleDb

Public Class Producto
    Inherits Conexion

    Public Property Codigo As Integer
    Public Property Nombre As String
    Public Property Cantidad As Integer
    Public Property Precio As Decimal
    Public Property Prescripcion As Boolean
    Public Property Administracion As String

    Private Property ProductoTabla = "Productos"

    Public Sub New(ByVal codigo As String)
        If Verificacion(ProductoTabla, "CODIGO =" & codigo) Then
            Try
                Conexion.Open()
                Comando = New OleDbCommand("SELECT * FROM " & ProductoTabla & " WHERE CODIGO =" & codigo, Conexion)
                Lector = Comando.ExecuteReader()
                While Lector.Read()
                    Me.Codigo = Lector.Item(0)
                    Me.Nombre = Lector.Item(1)
                    Me.Cantidad = Lector.Item(2)
                    Me.Precio = Convert.ToDecimal(Lector.Item(3))
                    Me.Prescripcion = Convert.ToBoolean(Lector.Item(4))
                    Me.Administracion = Lector.Item(5)
                End While
            Catch ex As Exception
                MsgBox("ERROR Producto: " & ex.Message)
            Finally
                Conexion.Close()
            End Try
        End If

    End Sub

    Public Sub New()

    End Sub

    Public Sub Registrar(ByVal pCodigo As String, ByVal pNombre As String, ByVal pCantidad As Integer, ByVal pPrecio As Decimal, ByVal pPrescripcion As Boolean, ByVal pAdministracion As String)
        If Verificacion(ProductoTabla, "CODIGO =" & pCodigo) Then
            MsgBox("Proucto ya existe")
            Return
        End If
        Try
            Conexion.Open()
            Comando = New OleDbCommand("INSERT INTO " & ProductoTabla & " (CODIGO, NOMBRE, CANTIDAD, PRECIO, PRESCRIPCION, ADMINISTRACION) VALUES (" & pCodigo & ", '" & pNombre & "', " & pCantidad & ", " & pPrecio & ", " & pPrescripcion & ", '" & pAdministracion & "')", Conexion)
            'Ejecutamos el comando
            If Comando.ExecuteNonQuery Then
                MsgBox("Producto registrado con exito")
            Else
                MsgBox("ERROR Registrar: No se ha podido registrar el producto")
            End If
        Catch ex As Exception
            MsgBox("ERROR Registrar: " & ex.Message)
        Finally
            ' Siempre hay que cerrrar la conexion a la base de datos, una vez terminemos de manipularla
            Conexion.Close()
        End Try
    End Sub

    Public Sub Eliminar()
        ' Primero que nada, debemos verificar que esta clase no se encuente vacia, para evitar problemas
        If vacio() Then
            ' Si la clase esta vacia, se detiene aqui el flujo de ejecucion evitando que se ejecute el codigo de abajo
            Return
        End If
        ' Para que se ejecute este codigo sin errores, hay que tener en cuenta que:
        ' La clase no puede estar vacia
        ' Se eliminara este mismo objeto de la base de datos
        Try
            ' Abrimos conexion antes de manipular la base de datos
            Conexion.Open()
            ' Aqui creamos la consulta SQL correspondiente para eliminar un registro, donde se usara como criterio la cedula del empleado
            Comando = New OleDbCommand("DELETE * FROM " & ProductoTabla & " WHERE CODIGO =" & Codigo, Conexion)
            If Comando.ExecuteNonQuery Then
                MsgBox("Producto eliminado con exito")
            Else
                MsgBox("ERROR Eliminar: No se ha podido Eliminar el producto")
            End If
        Catch ex As Exception
            MsgBox("ERROR Eliminar: " & ex.Message)
        Finally
            ' Siempre hay que cerrrar la conexion a la base de datos, una vez terminemos de manipularla
            Conexion.Close()
        End Try
    End Sub

    Public Sub Modificar(ByVal pCodigo As String, ByVal pNombre As String, ByVal pCantidad As Integer, ByVal pPrecio As Decimal, ByVal pPrescripcion As Boolean, ByVal pAdministracion As String)
        ' Primero que nada, debemos verificar que esta clase no se encuente vacia, para evitar problemas
        If vacio() Then
            ' Si la clase esta vacia, se detiene aqui el flujo de ejecucion evitando que se ejecute el codigo de abajo
            Return
        End If

        ' Para que se ejecute este codigo sin errores, hay que tener en cuenta que:
        ' La clase no puede estar vacia
        ' Se eliminara este mismo objeto de la base de datos
        Try
            ' Abrimos conexion antes de manipular la base de datos
            Conexion.Open()
            ' Aqui creamos la consulta SQL correspondite para actualizar la informacion de la base de datos ya existente, y se usa como criterio la cedula del empleado
            Comando = New OleDbCommand("UPDATE " & ProductoTabla & " SET CODIGO = " & pCodigo & ", NOMBRE = '" & pNombre & "', CANTIDAD = " & pCantidad & ", PRECIO = " & pPrecio & ", PRESCRIPCION = " & pPrescripcion & ", ADMINISTRACION = '" & pAdministracion & "'" & " WHERE CODIGO =" & Codigo, Conexion)
            If Comando.ExecuteNonQuery Then
                MsgBox("Producto modificado con exito")
            Else
                MsgBox("ERROR Modificar: No se ha podido Modificar el producto")
            End If
        Catch ex As Exception
            MsgBox("ERROR Modificar: " & ex.Message)
        Finally
            ' Siempre hay que cerrrar la conexion a la base de datos, una vez terminemos de manipularla
            Conexion.Close()
        End Try
    End Sub

    ' Esta funcion devolvera false si no hay datos en la clase
    Public Function vacio()
        If String.IsNullOrEmpty(Nombre) Or Codigo = 0 Or Codigo = Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Esta es una funcion modificada para rellenar los DataGridView
    Overloads Sub Llenar(ByRef datos As DataGridView)
        Llenar(datos, ProductoTabla)
    End Sub
End Class
