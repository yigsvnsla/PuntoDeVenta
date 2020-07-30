Public Class LDetalleVenta
    Dim iddetalleventa, idproducto, idventa, cantidad As Integer
    Dim preciounitario As Decimal
    Public Property _iddetalleventa
        Set(value)
            iddetalleventa = value
        End Set
        Get
            Return iddetalleventa
        End Get
    End Property
    Public Property _idproducto
        Set(value)
            idproducto = value
        End Set
        Get
            Return idproducto
        End Get
    End Property
    Public Property _idventa
        Set(value)
            idventa = value
        End Set
        Get
            Return idventa
        End Get
    End Property

    Public Property _cantidad
        Set(value)
            cantidad = value
        End Set
        Get
            Return cantidad
        End Get
    End Property

    Public Property _preciounitario
        Set(value)
            preciounitario = value
        End Set
        Get
            Return preciounitario
        End Get
    End Property
End Class
