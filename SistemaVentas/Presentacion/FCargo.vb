Public Class FCargo

    Private Sub FCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim valores As New LCargo
    Dim funciones As New DCargo
  

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Trim(txtcargo.Text) <> "" Then
            valores._descripcion = txtcargo.Text

            If funciones.AgregarCargo(valores) Then
                MsgBox("Cargo Agregado Correctamente", MsgBoxStyle.Information, "Registro de Cargo")
                'FProducto.cargarcategorias()
                Me.Close()

            Else
                MsgBox("Cargo No Agregado Correctamente", MsgBoxStyle.Exclamation, "Registro de Cargo")
            End If


        Else
            MsgBox("Ingrese un Cargo Correcto porfavor", MsgBoxStyle.Exclamation, "Registro de Cargo")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class