Public Class AlumnosNE
    Public Class AlumnoNe
        ' definicion de las clases tipadas
        Private _legajo As String
        Private _apellido As String
        Private _nombre As String
        Private _fecnac As Date?
        Private _cuota As Double
        Private _dni As String
        Public Property Legajo()
            Get
                Return _legajo
            End Get
            Set(ByVal value)
                _legajo = value
            End Set
        End Property
        Public Property Apellido()
            Get
                Return _apellido
            End Get
            Set(ByVal value)
                _apellido = value
            End Set
        End Property
        Public Property Nombre()
            Get
                Return _nombre
            End Get
            Set(ByVal value)
                _nombre = value
            End Set
        End Property
        Public Property fechanacim() As Date?
            Get
                Return _fecnac
            End Get
            Set(ByVal value As Date?)
                _fecnac = value
            End Set
        End Property
        Public Property cuota() As Double
            Get
                Return _cuota
            End Get
            Set(value As Double)
                _cuota = value
            End Set
        End Property
        Public Property DNI()
            Get
                Return _dni
            End Get
            Set(ByVal value)
                _dni = value
            End Set
        End Property

    End Class

End Class
