Public Class DipendenteViewModel

    Private _Nome As String
    Public Property Nome() As String
        Get
            Return _Nome
        End Get
        Set(ByVal value As String)
            _Nome = value
        End Set
    End Property

    Private _Cognome As String
    Public Property Cognome() As String
        Get
            Return _Cognome
        End Get
        Set(ByVal value As String)
            _Cognome = value
        End Set
    End Property


End Class
