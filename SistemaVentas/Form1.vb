Public Class Form1
    ' declaramos dos variables que trabajaran en conjunto 
    ' valores se encargara de almacenar los datos ingresados
    Dim valores As New LUsuario
    ' fuciones se encargara de verificar y agregar 
    Dim funciones As New DUsuarios
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Opacity = 0.83
    End Sub

    Private Sub btniniciar_Click(sender As Object, e As EventArgs) Handles btniniciar.Click
        Try

            ' se almacena los datos de los TexBox en la variable valores
            valores._usuario = txtusuario.Text
            valores._contraseña = txtcontraseña.Text

            ' Con los datos almacenados, se llama la funcion AccederUsuario, la cual recibe por parametro la variable usuario que es un LUsuario
            If funciones.AccederUsuario(valores) Then
                ' Si los datos ingresados son correctos, prcedemos a abrir el Formulario de inicio "FInicio"
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


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
