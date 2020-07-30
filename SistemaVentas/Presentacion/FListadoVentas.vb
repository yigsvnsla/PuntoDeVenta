Public Class FListadoVentas

    Private Sub FListadoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarVenta()
    End Sub
    Dim valores As New LDetalleVenta
    Dim funciones As New DVenta
    Dim vista As New DataView


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Try
            vista.RowFilter = cbobuscar.Text & " like '" & txtbuscar.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

   
    Public Sub MostrarVenta()
        vista = funciones.MostrarVenta.DefaultView

        Listado.DataSource = funciones.MostrarVenta
        Listado.DataSource = vista


        Listado.Columns(0).Visible = False
        Listado.ClearSelection()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If Listado.SelectedRows.Count > 0 Then
            Try
                Dim ventana As New FComprobante
                ventana.idventa = Convert.ToInt32(Me.Listado.SelectedCells.Item(0).Value)
                ventana.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Seleccione un Registro, Por favor", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
        End If
    End Sub

    Private Sub Listado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Listado.CellDoubleClick
        Try
            Dim ventana As New FComprobante
            ventana.idventa = Convert.ToInt32(Me.Listado.SelectedCells.Item(0).Value)
            ventana.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Try
            FVenta.Show()
            MostrarVenta()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        MostrarVenta()
    End Sub

    Private Sub cbobuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbobuscar.SelectedIndexChanged
        If cbobuscar.SelectedIndex = 0 Then
            txtbuscar.MaxLength = 7
        Else
            txtbuscar.MaxLength = 100
        End If
    End Sub

End Class