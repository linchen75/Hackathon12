Namespace DomainObject
    Public Class Company
        Public Sub New(ByVal ID As Integer, ByVal name As String, ByVal desc As String, ByVal logoUrl As String)
            Me.ID = ID
            Me.Name = name
            Me.Description = desc
            Me.LogoUrl = logoUrl
        End Sub

        Public Property Id() As Integer
        Public Property Name() As String
        Public Property Description() As String
        Public Property LogoUrl() As String
    End Class
End Namespace

