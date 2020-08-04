Module DatosSistema
    ' Este modulo contiene funciones adicionales encargadas de gestionar datos
    
    ' Esta funcion devuelve la hecha y hora actual
    Public Function obtenerFecha(Optional ByVal Opcion As String = "")
        Dim fechaActual As Date = Date.Now
        Dim horaActual As TimeSpan = Date.Now.TimeOfDay
        ' Este Select Case se encargara de verificar el valor de la variable Opcion
        Select Case Opcion
            ' En caso de que la variable tenga el valor "Fecha", devolvera la fecha actual
            Case "Fecha"
                Return fechaActual.ToString
            ' En caso de que la variable tenga el valor "Hora", devolvera la hora actual
            Case "Hora"
                Return horaActual.ToString
        End Select
        ' Si la variable opcion no coincide con ningun caso, no se hara nada, y retornara
           ' La fecha y hora actuales.
        Return fechaActual + horaActual
    End Function

    ' Esta funcion se encargara de limitar el ingreso de caracteres durante el Evento KeyPress
    ' Solo permitira ingresar caracteres tipo texto, NO NUMERICOS.
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

     ' Esta funcion se encargara de limitar el ingreso de caracteres durante el Evento KeyPress
    ' Solo permitira ingresar caracteres tipo numericos, NO TEXTO.
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

    ' Esta funcion se encarga de adaptar los formularios Padres e Hijos.
    Public Sub adaptadorDePantallas(FormPadre As Form, FormHijo As Form)
        FormPadre.Size = New System.Drawing.Size(FormHijo.Height, FormHijo.Width)

    End Sub

End Module
