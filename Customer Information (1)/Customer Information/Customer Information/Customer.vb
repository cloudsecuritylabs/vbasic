Public Class Customer
    Inherits Person
    Private intCustomerNumber As Integer
    Private blnMailingList As Boolean
    Private srtComments As String

    Public Property CustomerNumber() As Integer
        Get
            Return intCustomerNumber
        End Get
        Set(ByVal value As Integer)
            intCustomerNumber = value
        End Set
    End Property



    Public Property mailingList() As Boolean
        Get
            Return blnMailingList
        End Get
        Set(ByVal value As Boolean)
            blnMailingList = value
        End Set
    End Property


    Public Property Comments() As String
        Get
            Return srtComments
        End Get
        Set(ByVal value As String)
            srtComments = value
        End Set
    End Property

End Class
