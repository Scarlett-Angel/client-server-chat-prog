Public Class user
    Private theusername As String
    Private thehidden As Boolean
    Private thesocket As Integer

    Sub New(ByVal username As String, ByVal hidden As Boolean, ByVal socket As Integer)
        theusername = username
        thehidden = hidden
        thesocket = socket
    End Sub

    Public Property username As String
        Get
            Return theusername
        End Get
        Set(ByVal username As String)
            theusername = username
        End Set
    End Property

    Property hidden As Boolean
        Get
            Return thehidden
        End Get
        Set(ByVal hidden As Boolean)
            thehidden = hidden
        End Set
    End Property
    Property socket As Integer
        Get
            Return thesocket
        End Get
        Set(ByVal socket As Integer)
            thesocket = socket
        End Set
    End Property
End Class
