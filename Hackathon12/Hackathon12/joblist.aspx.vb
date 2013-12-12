Imports Hackathon12.DB
Imports Hackathon12.DomainObject

Public Class joblist
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim iCompanyId As Integer = Request.QueryString("company")
        jobList.Text = GetHtml4CompanyDetail(iCompanyId)
    End Sub

    Private Function GetHtml4CompanyDetail(ByVal iCompanyId As Integer) As String
        Dim result As New StringBuilder
        result.Append("<div id=""companyList"">")
        result.Append(New CompanyRepository().GetCompanyDetail(iCompanyId))
        result.Append("</div>")
        Return result.ToString()
    End Function

    Private Function GetHtml4Jobs(ByVal oJobs As List(Of Job)) As String
        Dim result As New StringBuilder
        result.Append("<div id=""companyList"">")
        For Each oJob As Job In oJobs
            result.Append(GetHtml4Job(oJob))
        Next
        result.Append("</div>")
        Return result.ToString()
    End Function

    Private Function GetHtml4Job(ByVal oJob As Job) As String
        Dim result As New StringBuilder
        result.Append("<div class=""companyRow"">")
        result.Append("<h4 class=""companyName"">").Append(oJob.Name).Append("</h4>")
        result.Append("<div class=""companyDescription"">").Append(oJob.Description).Append("</div>")
        result.Append("</div>")
        Return result.ToString()
    End Function
End Class