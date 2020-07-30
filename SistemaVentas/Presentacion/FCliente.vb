Public Class FCliente
    Dim valores As New LCliente
    Dim funciones As New DCliente
    Private Sub FCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub AgregarCliente()
        Try
            valores._nombre = txtNombre.Text
            valores._apellido = txtApellido.Text
            valores._direccion = txtDireccion.Text
            valores._telefono = Convert.ToInt32(txtTelefono.Text)
            valores._dni = Convert.ToInt32(txtDni.Text)

            If funciones.AgregarCliente(valores) Then
                MsgBox("Cliente Agregado Correctamente", MsgBoxStyle.Information, "Registro Clientes")
            Else
                MsgBox("Cliente No Agregado Correctamente", MsgBoxStyle.Exclamation, "Registro Clientes")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub EditarCliente()
        Try
            valores._idcliente = txtId.Text
            valores._nombre = txtNombre.Text
            valores._apellido = txtApellido.Text
            valores._direccion = txtDireccion.Text
            valores._telefono = Convert.ToInt32(txtTelefono.Text)
            valores._dni = Convert.ToInt32(txtDni.Text)

            If funciones.EditarCliente(valores) Then
                MsgBox("Cliente Editado Correctamente", MsgBoxStyle.Information, "Registro Clientes")
            Else

                MsgBox("Cliente No Editado Correctamente", MsgBoxStyle.Exclamation, "Registro Clientes")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtApellido.Text = "" Or txtNombre.Text = "" Or txtDireccion.Text = "" Or txtDni.Text = "" Or txtTelefono.Text = "" Then
            MsgBox("Complete Todos Los Datos Porfavor", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtId.Text <> "" Then
            If MsgBox("¿Desesa Guardar los Cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.No Then
                Exit Sub
            End If
            EditarCliente()
        Else
            AgregarCliente()
        End If

        txtId.Clear()
        FListadoClientes.mostrarcliente()
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class