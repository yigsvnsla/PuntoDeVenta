Public Class LCliente
    Dim idcliente, dni, telefono As Integer
    Dim apellido, nombre, direccion As String

    Public Property _idcliente
        Set(value)
            idcliente = value
        End Set
        Get
            Return idcliente
        End Get
    End Property

    Public Property _dni
        Set(value)
            dni = value
        End Set
        Get
            Return dni
        End Get
    End Property

    Public Property _apellido
        Set(value)
            apellido = value
        End Set
        Get
            Return apellido
        End Get
    End Property

    Public Property _nombre
        Set(value)
            nombre = value
        End Set
        Get
            Return nombre
        End Get
    End Property

    Public Property _direccion
        Set(value)
            direccion = value
        End Set
        Get
            Return direccion
        End Get
    End Property

    Public Property _telefono
        Set(value)
            telefono = value
        End Set
        Get
            Return telefono
        End Get
    End Property

 
End Class
