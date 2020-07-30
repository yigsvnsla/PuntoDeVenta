Public Class Form1
    Dim valores As New LUsuario
    Dim funciones As New DUsuarios
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Opacity = 0.83
    End Sub

    Private Sub btniniciar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click
        Try
            valores._usuario = txtusuario.Text
            valores._contraseña = txtcontraseña.Text


            If funciones.AccederUsuario(valores) Then
                MsgBox("Bienvenido al Sistema", MsgBoxStyle.Information, "Mensaje del Sistema")
                FInicio.Show()
                Me.Hide()

            Else
                MsgBox("Usuario o Contraseña Incorrecta", MsgBoxStyle.Exclamation, "Mensaje del Sistema")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtusuario_Click(sender As Object, e As EventArgs) Handles txtusuario.Click
        validar()
    End Sub


    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

        validar()
    End Sub

    Private Sub txtcontraseña_Click(sender As Object, e As EventArgs) Handles txtcontraseña.Click
        validar()
    End Sub

    Private Sub txtcontraseña_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseña.TextChanged
        validar()
    End Sub

    Private Sub lblusuario_Click(sender As Object, e As EventArgs) Handles lblusuario.Click
        lblusuario.Visible = False
        txtusuario.Focus()
    End Sub

    Private Sub lblcontraseña_Click(sender As Object, e As EventArgs) Handles lblcontraseña.Click
        lblcontraseña.Visible = False
        txtcontraseña.Focus()
    End Sub

    Public Sub validar()

        If Trim(txtcontraseña.Text) = "" Then
            lblcontraseña.Visible = True
        Else
            lblcontraseña.Visible = False
        End If


        If Trim(txtusuario.Text) = "" Then
            lblusuario.Visible = True
        Else
            lblusuario.Visible = False
        End If


    End Sub

    
End Class
