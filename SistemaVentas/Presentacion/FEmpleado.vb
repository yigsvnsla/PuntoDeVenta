
Public Class FEmpleado
    Public idcargo As Integer
    Dim valores As New LEmpleados
    Dim funciones As New DEmpleado
    Dim funcionesca As New DCargo
    Private Sub FEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcargos()
    End Sub

    Public Sub AgregarEmpleado()
        Try
            valores._idcargo = Convert.ToInt32(cbocargo.SelectedValue.ToString)
            valores._nombre = txtnombre.Text
            valores._apellidos = txtapellido.Text
            valores._sexo = cbosexo.Text
            valores._dni = Convert.ToInt32(txtdni.Text)
            valores._fechanacimiento = txtfechanacimiento.Text
            valores._direccion = txtdireccion.Text
            valores._estadocivil = cboestadocivil.Text
            valores._estado = cboestado.Text


            If funciones.AgregarEmpleado(valores) Then
                MsgBox("Empleado Agregado Correctamente", MsgBoxStyle.Information, "Registro Empleado")
            Else
                MsgBox("Empleado No Agregado Correctamente", MsgBoxStyle.Exclamation, "Registro Empleado")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub EditarEmpleado()
        Try

            valores._idempleado = Convert.ToInt32(txtid.Text)
            valores._idcargo = Convert.ToInt32(cbocargo.SelectedValue.ToString)
            valores._nombre = txtnombre.Text
            valores._apellidos = txtapellido.Text
            valores._sexo = cbosexo.Text
            valores._dni = Convert.ToInt32(txtdni.Text)
            valores._fechanacimiento = txtfechanacimiento.Text
            valores._direccion = txtdireccion.Text
            valores._estadocivil = cboestadocivil.Text
            valores._estado = cboestado.Text


            If funciones.EditarEmpleado(valores) Then
                MsgBox("Empleado Editado Correctamente", MsgBoxStyle.Information, "Registro Empleado")
            Else

                MsgBox("Empleado No Editado Correctamente", MsgBoxStyle.Exclamation, "Registro Empleado")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtapellido.Text = "" Or txtnombre.Text = "" Or txtdireccion.Text = "" Or txtdni.Text = "" Then
            MsgBox("Complete Todos Los Datos Porfavor", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Exit Sub
        End If

        If txtid.Text <> "" Then
            If MsgBox("¿Desesa Guardar los Cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.No Then
                Exit Sub
            End If
            EditarEmpleado()
        Else
            AgregarEmpleado()
        End If

        txtid.Clear()
        FListadoEmpleados.mostrarempleados()
        Me.Close()
    End Sub
    Public Sub cargarcargos()
        Try
            cbocargo.DataSource = funcionesca.MostrarCargo

            cbocargo.DisplayMember = "descripcion"
            cbocargo.ValueMember = "idcargo"

            If idcargo <> 0 Then
                cbocargo.SelectedValue = idcargo
            End If
            idcargo = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btncargo_Click(sender As Object, e As EventArgs) Handles btncargo.Click
        Dim ventana As New FCargo
        ventana.ShowDialog()
        cargarcargos()
    End Sub
End Class