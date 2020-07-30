Public Class FInicio

    Private Sub FInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelContenido(FListadoVentas)
        Timer1.Start()
        lblequipo.Text = (Environment.UserName).ToUpper
        lbldia.Text = Now.Date
    End Sub


    Public Sub PanelContenido(ByVal Formulario As Form)


        Panel1.Controls.Clear()
        Formulario.TopLevel = False
        Formulario.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Formulario.Dock = DockStyle.Fill
        Panel1.Controls.Add(Formulario)
        Formulario.Show()

        For Each cajatexto In Formulario.Controls
            If TypeOf (cajatexto) Is TextBox Then
                cajatexto.Clear()
            End If
        Next


    End Sub

    Private Sub btnclientes_Click(sender As Object, e As EventArgs) Handles btnclientes.Click
        PanelContenido(FListadoClientes)
    End Sub

    Private Sub btnempleados_Click(sender As Object, e As EventArgs) Handles btnempleados.Click
        PanelContenido(FListadoEmpleados)
    End Sub

    Private Sub btnproductos_Click(sender As Object, e As EventArgs) Handles btnproductos.Click
        PanelContenido(FListadoProductos)
    End Sub

    
    Private Sub btnventas_Click(sender As Object, e As EventArgs) Handles btnventas.Click
        PanelContenido(FListadoVentas)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay
        lbldia.Text = Now.Date
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Esta Seguro de salir del Sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje del Sistema") = MsgBoxResult.Yes Then
            End
        End If

    End Sub
End Class