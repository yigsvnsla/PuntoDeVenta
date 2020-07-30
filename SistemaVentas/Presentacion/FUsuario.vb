Public Class FUsuario
    Dim valores As New LUsuario
    Dim funciones As New DUsuarios
    Private Sub chkver_CheckedChanged(sender As Object, e As EventArgs) Handles chkver.CheckedChanged
        If chkver.CheckState = CheckState.Checked Then
            txtcontraseña.PasswordChar = ""
        Else
            txtcontraseña.PasswordChar = "•"
        End If
    End Sub

    Private Sub btbgrabar_Click(sender As Object, e As EventArgs) Handles btbgrabar.Click

        If Trim(txtusuario.Text) = "" Or Trim(txtcontraseña.Text) = "" Then
            MsgBox("Ingrese todos los datos porfavor", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            Return
        End If

        Try
            valores._idempleado = Convert.ToInt32(txtid.Text)
            valores._usuario = txtusuario.Text
            valores._contraseña = txtcontraseña.Text

            If funciones.AgregarUsuario(valores) Then
                MsgBox("Usuario Agregado Correctamente", MsgBoxStyle.Information, "Registro de Usuario")

            Else
                MsgBox("Usuario No Agregado Correctamente", MsgBoxStyle.Information, "Registro de Usuario")
            End If

            txtusuario.Text = ""
            txtcontraseña.Text = ""
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class