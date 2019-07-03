Public Class Funciones
    Private _Col1 As String
    Private _Col2 As String

    Public Property Col1 As String
        Get
            Return _Col1
        End Get
        Set(value As String)
            _Col1 = value
        End Set
    End Property

    Public Property Col2 As String
        Get
            Return _Col2
        End Get
        Set(value As String)
            _Col2 = value
        End Set
    End Property
End Class
