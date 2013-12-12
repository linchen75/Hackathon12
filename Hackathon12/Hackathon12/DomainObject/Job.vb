Namespace DomainObject

    Public Class Job
        Public Property CompanyId() As Integer
        Public Property JobId() As Integer
        Public Property Name() As String
        Public Property Description() As String

        Public Sub New(ByVal companyId As Integer, ByVal jobId As Integer, ByVal name As String, ByVal description As String)
            Me.CompanyId = companyId
            Me.JobId = jobId
            Me.Name = name
            Me.Description = description
        End Sub
    End Class

End Namespace
