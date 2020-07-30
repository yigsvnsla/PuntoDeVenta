Public Class FListadoProductos
    Dim valores As New LProductos
    Dim funciones As New DProductos
    Dim vista As New DataView
    Private Sub FListadoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarproductos()
    End Sub


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Try
            vista.RowFilter = cbobuscar.Text & " like '" & txtbuscar.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ventana As New FProducto
        ventana.ShowDialog()
        mostrarproductos()

    End Sub
    Public Sub mostrarproductos()
        vista = funciones.MostrarProductos.DefaultView

        Listado.DataSource = funciones.MostrarProductos
        Listado.DataSource = vista


        Listado.Columns(0).Visible = False
        Listado.Columns(1).Visible = False
        Listado.ClearSelection()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If Listado.Rows.Count = 0 Then
                MsgBox("No existen Registros Aún", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                Return
            End If

            If Listado.SelectedRows.Count > 0 Then

                FProducto.cargarcategorias()

                FProducto.txtid.Text = Me.Listado.SelectedCells.Item(0).Value
                FProducto.idcategoria = Convert.ToInt32(Me.Listado.SelectedCells.Item(1).Value)
                FProducto.txtnombre.Text = Me.Listado.SelectedCells.Item(2).Value
                FProducto.txtdescripcion.Text = Me.Listado.SelectedCells.Item(4).Value
                FProducto.txtstock.Text = Me.Listado.SelectedCells.Item(5).Value
                FProducto.txtpreciocompra.Text = Me.Listado.SelectedCells.Item(6).Value
                FProducto.txtprecioventa.Text = Me.Listado.SelectedCells.Item(7).Value
                FProducto.txtfechavencimiento.Text = Me.Listado.SelectedCells.Item(8).Value

                FProducto.ShowDialog()
                mostrarproductos()
            Else
                MsgBox("Seleccione un Registro, Por favor", MsgBoxStyle.Exclamation, "Editar Producto")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub Listado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Listado.CellDoubleClick
        If lblflag.Text = "1" Then
            FVenta.lblidproducto.Text = Me.Listado.SelectedCells.Item(0).Value
            FVenta.txtproducto.Text = Me.Listado.SelectedCells.Item(2).Value
            FVenta.txtdescripcion.Text = Me.Listado.SelectedCells.Item(4).Value
            FVenta.txtstock.Text = Me.Listado.SelectedCells.Item(5).Value
            FVenta.txtprecio.Text = Me.Listado.SelectedCells.Item(7).Value
            lblflag.Text = "0"
            Me.Close()
        End If
    End Sub
End Class