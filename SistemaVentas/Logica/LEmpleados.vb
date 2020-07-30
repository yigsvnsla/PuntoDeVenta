Public Class LEmpleados
    Dim idempleado, idcargo, dni As Integer
    Dim nombre, apellidos, sexo, fechanacimiento, direccion, estadocivil, estado As String
    Public Property _idempleado
        Set(value)
            idempleado = value
        End Set
        Get
            Return idempleado
        End Get
    End Property

    Public Property _idcargo
        Set(value)
            idcargo = value
        End Set
        Get
            Return idcargo
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
    Public Property _nombre
        Set(value)
            nombre = value
        End Set
        Get
            Return nombre
        End Get
    End Property

    Public Property _apellidos
        Set(value)
            apellidos = value
        End Set
        Get
            Return apellidos
        End Get
    End Property

    Public Property _sexo
        Set(value)
            sexo = value
        End Set
        Get
            Return sexo
        End Get
    End Property
    Public Property _fechanacimiento
        Set(value)
            fechanacimiento = value
        End Set
        Get
            Return fechanacimiento
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
    Public Property _estadocivil
        Set(value)
            estadocivil = value
        End Set
        Get
            Return estadocivil
        End Get
    End Property

    Public Property _estado
        Set(value)
            estado = value
        End Set
        Get
            Return estado
        End Get
    End Property

End Class
