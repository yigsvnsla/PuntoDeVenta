Public Class LUsuario
    Dim idempleado As Integer
    Dim usuario, contraseña As String

    Public Property _idempleado
        Set(value)
            idempleado = value
        End Set
        Get
            Return idempleado
        End Get
    End Property
    Public Property _usuario
        Set(value)
            usuario = value
        End Set
        Get
            Return usuario
        End Get
    End Property

    Public Property _contraseña
        Set(value)
            contraseña = value
        End Set
        Get
            Return contraseña
        End Get
    End Property
End Class
