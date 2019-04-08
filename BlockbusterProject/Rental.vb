Public Class Rental

    Property title As String
    Property releaseDate As String
    Property qtyTotal As Integer
    Property qtyOnHand As Integer
    Property rating As String
    Property damaged As Boolean

    Public Sub New()
        Me.title = "-1"
        Me.releaseDate = "-1"
        Me.qtyTotal = -1
        Me.qtyOnHand = -1
        Me.rating = -1
        Me.damaged = False
    End Sub

    Public Sub New(args() As String)
        Me.title = args(1)
        Me.releaseDate = args(2)
        Me.qtyTotal = Convert.ToInt32(args(3))
        Me.qtyOnHand = Convert.ToInt32(args(4))
        Me.rating = args(5)
        Me.damaged = args(6)
    End Sub

End Class
