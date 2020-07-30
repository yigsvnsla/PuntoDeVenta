'Importamos la librerías
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Threading
'---------------------------------------------------------------------------------------------'
Public Class fLogin
    Dim valores As New LUsuario
    Dim funciones As New DUsuarios
    '---------------------------------------------------------------------------------------------'
    'Añadiendo funcion de arrastrar o mover el formulario / Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    '---------------------------------------------------------------------------------------------'
    'Componentes del Formulario 
    '---------------------------------------------------------------------------------------------'
    Private Sub PanelCabezera_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelCabezera.MouseDown
        'Creamos el evento MouseDown del panel barra de título e invocamos los métodos anteriores, de la siguiente manera.
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        'También podemos mover el formulario de cualquier parte o en caso que no uses una barra de título, de la misma forma, creas el evento MouseDown del formulario e invocas los métodos.
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Sub validandoCampo(ByRef Objeto As Object, ByVal largo As Integer)
        If DirectCast(Objeto, TextBox).Text.Length > 0 And DirectCast(Objeto, TextBox).Text.Length < largo Then
            'Me.ErrorProvider1.SetError(Objeto, "")
        Else
            Me.ErrorProvider1.SetError(Objeto, "ingrese un dato en esete campo") 'mensage de error
        End If
    End Sub
    'Private Sub btniniciar_Paint(sender As Object, e As PaintEventArgs) Handles btniniciar.Paint
    '    'metodo para darle estilo y forma a el control "btnLogin" mediante metodos de dibujado
    '    Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
    '    Dim myRectangle As Rectangle = btniniciar.ClientRectangle
    '    myRectangle.Inflate(0, 30)
    '    buttonPath.AddEllipse(myRectangle)
    '    btniniciar.Region = New Region(buttonPath)
    'End Sub

    'Private Sub btnsalir_Paint(sender As Object, e As PaintEventArgs) Handles btnsalir.Paint
    '    'metodo para darle estilo y forma a el control "btnLogin" mediante metodos de dibujado
    '    Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
    '    Dim myRectangle As Rectangle = btniniciar.ClientRectangle
    '    myRectangle.Inflate(0, 30)
    '    buttonPath.AddEllipse(myRectangle)
    '    btniniciar.Region = New Region(buttonPath)
    'End Sub
    '/-----------------------------------------------------------------------------------------------------------------/'
    '/- validando campos -/'
    '/-----------------------------------------------------------------------------------------------------------------/'
    Private Sub txtUser_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtusuario.Validating
        validandoCampo(sender, 9)
    End Sub

    Private Sub txtPass_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcontraseña.Validating
        validandoCampo(sender, 10)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized ' minimiza la ventana
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Me.Close()
        End
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
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

End Class
