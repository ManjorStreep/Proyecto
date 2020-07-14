Public Class frmInventario

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatabaseDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DatabaseDataSet.Productos)

    End Sub

    ' Para seleccionar producto se debe dar dobleclick

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Cada vez que se de dobleclick se agregara el producto seleccionado al carrito y se cerrara esta ventana
        frmHacer_Venta.SeleccionarProducto(DataGridView1.CurrentRow.Cells(0).Value)
        Me.Close()
    End Sub

End Class