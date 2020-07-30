
Public Class FCategoria
    Dim valores As New LCategoria
    Dim funciones As New DCategoria
    Private Sub FCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Trim(txtcategoria.Text) <> "" Then
            valores._descripcion = txtcategoria.Text

            If funciones.AgregarCategoria(valores) Then
                MsgBox("Categoria Agregada Correctamente", MsgBoxStyle.Information, "Registro de Categoria")
                'FProducto.cargarcategorias()
                Me.Close()

            Else
                MsgBox("Categoria No Agregada Correctamente", MsgBoxStyle.Exclamation, "Registro de Categoria")
            End If


        Else
            MsgBox("Ingrese un Categoria Correcta porfavor", MsgBoxStyle.Exclamation, "Registro de Categoria")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class