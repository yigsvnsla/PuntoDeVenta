
Public Class FListadoEmpleados

    Private Sub FListadoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarempleados()
    End Sub
    Dim valores As New LEmpleados
    Dim funciones As New DEmpleado
    Dim vista As New DataView

    Dim funcionesusuario As New DUsuarios
    Dim valoresusuario As New LUsuario

  

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        Try
            vista.RowFilter = cbobuscar.Text & " like '" & txtbuscar.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim ventana As New FEmpleado
        ventana.ShowDialog()
        Me.mostrarempleados()
    End Sub
    Public Sub mostrarempleados()
        vista = funciones.MostrarEmpleado.DefaultView

        Listado.DataSource = funciones.MostrarEmpleado
        Listado.DataSource = vista


        Listado.Columns(0).Visible = False
        Listado.Columns(1).Visible = False
        Listado.ClearSelection()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Listado.SelectedRows.Count > 0 Then
            FEmpleado.txtid.Text = Me.Listado.SelectedCells.Item(0).Value
            FEmpleado.idcargo = Convert.ToInt32(Me.Listado.SelectedCells.Item(1).Value)
            FEmpleado.txtnombre.Text = Me.Listado.SelectedCells.Item(3).Value
            FEmpleado.txtapellido.Text = Me.Listado.SelectedCells.Item(4).Value
            FEmpleado.cbosexo.Text = Me.Listado.SelectedCells.Item(5).Value
            FEmpleado.txtdni.Text = Me.Listado.SelectedCells.Item(6).Value
            FEmpleado.txtfechanacimiento.Text = Me.Listado.SelectedCells.Item(7).Value
            FEmpleado.txtdireccion.Text = Me.Listado.SelectedCells.Item(8).Value
            FEmpleado.cboestadocivil.Text = Me.Listado.SelectedCells.Item(9).Value
            FEmpleado.cboestado.Text = Me.Listado.SelectedCells.Item(10).Value

           
            FEmpleado.ShowDialog()
            Me.mostrarempleados()
        Else
            MsgBox("Seleccione un Registro, Por favor", MsgBoxStyle.Exclamation, "Editar Cliente")
        End If
    End Sub

    Private Sub btnasignar_Click(sender As Object, e As EventArgs) Handles btnasignar.Click

        Try
           
            Dim ventana As New FUsuario


            If Listado.SelectedRows.Count > 0 Then

                valoresusuario._idempleado = Convert.ToInt32(Me.Listado.SelectedCells.Item(0).Value)
                If funcionesusuario.VerificarUsuario(valoresusuario) Then
                    MsgBox("Ya Existe un Usuario Creado", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
                    Exit Sub
                End If


                ventana.txtid.Text = Me.Listado.SelectedCells.Item(0).Value
                ventana.txtnya.Text = Me.Listado.SelectedCells.Item(3).Value & " " & Me.Listado.SelectedCells.Item(4).Value
                ventana.txtcargo.Text = Me.Listado.SelectedCells.Item(2).Value
                ventana.txtdni.Text = Me.Listado.SelectedCells.Item(6).Value
                ventana.ShowDialog()
            Else
                MsgBox("Seleccione un Registro, Por favor", MsgBoxStyle.Exclamation, "Asignar Usuario")
            End If
        Catch ex As Exception

        End Try

       
    End Sub

    Private Sub Listado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Listado.CellDoubleClick

        If txtflag.Text = "1" Then
            FVenta.lblidempleado.Text = Me.Listado.SelectedCells.Item(0).Value
            FVenta.txtcargo.Text = Me.Listado.SelectedCells.Item(2).Value
            FVenta.txtnya.Text = Me.Listado.SelectedCells.Item(3).Value & " " & Me.Listado.SelectedCells.Item(4).Value
            Me.txtflag.Text = "0"
            Me.Close()
        End If
       
    End Sub

   
    
End Class