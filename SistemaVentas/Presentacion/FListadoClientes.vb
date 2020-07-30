Imports System.Data.SqlClient
Public Class FListadoClientes
    Dim valores As New LCliente
    Dim funciones As New DCliente
    Dim vista As New DataView

    Private Sub FListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarcliente()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Try
                vista.RowFilter = cbobuscar.Text & " like '" & txtbuscar.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ventana As New FCliente
        ventana.ShowDialog()
        mostrarcliente()

    End Sub
    Public Sub mostrarcliente()
        vista = funciones.MostrarClientes.DefaultView

        Listado.DataSource = funciones.MostrarClientes
        Listado.DataSource = vista


        Listado.Columns(0).Visible = False
        Listado.ClearSelection()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Listado.SelectedRows.Count > 0 Then
            FCliente.txtId.Text = Me.Listado.SelectedCells.Item(0).Value
            FCliente.txtNombre.Text = Me.Listado.SelectedCells.Item(1).Value
            FCliente.txtApellido.Text = Me.Listado.SelectedCells.Item(2).Value
            FCliente.txtDireccion.Text = Me.Listado.SelectedCells.Item(3).Value
            FCliente.txtTelefono.Text = Me.Listado.SelectedCells.Item(4).Value
            FCliente.txtDni.Text = Me.Listado.SelectedCells.Item(5).Value
            FCliente.ShowDialog()
            mostrarcliente()
        Else
            MsgBox("Seleccione un Registro, Por favor", MsgBoxStyle.Exclamation, "Editar Cliente")
        End If
    End Sub

    Private Sub Listado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Listado.CellDoubleClick
        If txtflag.Text = "1" Then
            FVenta.lblidcliente.Text = Me.Listado.SelectedCells.Item(0).Value
            FVenta.txtdoc.Text = Me.Listado.SelectedCells.Item(5).Value
            FVenta.txtcliente.Text = Me.Listado.SelectedCells.Item(1).Value & " " & Me.Listado.SelectedCells.Item(2).Value
            txtflag.Text = "0"
            Me.Close()
        End If
    End Sub
End Class