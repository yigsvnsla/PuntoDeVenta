Public Class LVenta
    Dim idempleado, idcliente As Integer
    Dim nrodocumento, tipodocumento, fechaventa As String

    Public Property _idempleado
        Set(value)
            idempleado = value

        End Set
        Get
            Return idempleado
        End Get
    End Property

    Public Property _idcliente
        Set(value)
            idcliente = value
        End Set
        Get
            Return idcliente
        End Get
    End Property

    Public Property _nrodocumento
        Set(value)
            nrodocumento = value
        End Set
        Get
            Return nrodocumento
        End Get
    End Property

    Public Property _tipodocumento
        Set(value)
            tipodocumento = value
        End Set
        Get
            Return tipodocumento
        End Get
    End Property

    Public Property _fechaventa
        Set(value)
            fechaventa = value
        End Set
        Get
            Return fechaventa
        End Get
    End Property
End Class
