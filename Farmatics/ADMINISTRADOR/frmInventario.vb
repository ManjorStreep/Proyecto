Public Class frmInventario

    Dim producto As Producto

    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' instanciamos la variable producto como un nuevo objeto tipo producto, pero vacio
        producto = New Producto()
        ' lo instanciamos vacio para poder usar su metodo Llenar y asi darle la informacion de todos los productos al DataGridView
        producto.Llenar(DataGridView1)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Cuando se de dobleclick a algun registro del DataGridView se ejecutara esto
        ' Se envia al frmHacer_Venta el producto que ha sido clickeado 
        frmHacer_Venta.producto = New Producto(DataGridView1.CurrentRow.Cells(0).Value)
        ' Luego imprimimos el producto enviado al frmHacer_Venta
        frmHacer_Venta.ImprimirProducto(producto.Codigo)

        ' Y de ultimo cerramos este formulario
        Me.Close()
    End Sub
End Class