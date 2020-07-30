Module DatosSistema

    Public Function obtenerFecha(Optional ByVal Opcion As String = "")
        Dim fechaActual As Date = Date.Now
        Dim horaActual As TimeSpan = Date.Now.TimeOfDay
        Select Case Opcion
            Case "Fecha"
                Return fechaActual.ToString
            Case "Hora"
                Return horaActual.ToString
        End Select
        Return fechaActual + horaActual
    End Function
    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Public Sub adaptadorDePantallas(FormPadre As Form, FormHijo As Form)
        FormPadre.Size = New System.Drawing.Size(FormHijo.Height, FormHijo.Width)

    End Sub

End Module
