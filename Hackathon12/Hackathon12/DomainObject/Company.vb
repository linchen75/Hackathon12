Namespace DomainObject
    Public Class Company
        Private Name As String
        Private Description As String
        Private LogoUrl As String

        Public Sub New(ByVal name As String, ByVal description As String, ByVal logoUrl As String)
            Me.Name = name
            Me.Description = description
            Me.LogoUrl = logoUrl
        End Sub

        Public ReadOnly Property NameProperty() As String
            Get
                Return Name
            End Get
        End Property

        Public ReadOnly Property DescriptionProperty() As String
            Get
                Return Description
            End Get
        End Property

        Public ReadOnly Property LogoUrlProperty() As String
            Get
                Return LogoUrl
            End Get
        End Property
    End Class
End Namespace

