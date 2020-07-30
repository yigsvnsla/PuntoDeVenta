Public Class LProductos
    Dim idproducto, idcategoria, stock As Integer
    Dim nombre, descripcion As String
    Dim preciocompra, precioventa As Decimal
    Dim fechavencimiento As String

    Public Property _idproducto
        Set(value)
            idproducto = value
        End Set
        Get
            Return idproducto
        End Get
    End Property

    Public Property _idcategoria
        Set(value)
            idcategoria = value
        End Set
        Get
            Return idcategoria
        End Get
    End Property

    Public Property _stock
        Set(value)
            stock = value
        End Set
        Get
            Return stock
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

    Public Property _descripcion
        Set(value)
            descripcion = value

        End Set
        Get
            Return descripcion
        End Get
    End Property

    Public Property _precioventa
        Set(value)
            precioventa = value
        End Set
        Get
            Return precioventa
        End Get
    End Property

    Public Property _preciocompra
        Set(value)
            preciocompra = value
        End Set
        Get
            Return preciocompra
        End Get
    End Property

    Public Property _fechavencimiento
        Set(value)
            fechavencimiento = value
        End Set
        Get
            Return fechavencimiento
        End Get
    End Property
End Class
