Imports Hackathon12.DB
Imports Hackathon12.DomainObject

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        companyList.Text = GetHtml4Companies(New CompanyRepository().GetAll())
    End Sub

    Private Function GetHtml4Companies(ByVal oCompanies As List(Of Company)) As String
        Dim result As New StringBuilder
        result.Append("<div id=""companyList"">")
        For Each oCompany As Company In oCompanies
            result.Append(GetHtml4Company(oCompany))
        Next
        result.Append("</div>")
        Return result.ToString()
    End Function

    Private Function GetHtml4Company(ByVal oCompany As Company) As String
        Dim result As New StringBuilder
        result.Append("<div class=""companyRow"">")
        result.Append("<a href=""joblist.aspx?company=").Append(oCompany.Id).Append("""><h3 class=""companyName"">").Append("<img src=""").Append(oCompany.LogoUrl).Append("""/>").Append(oCompany.Name).Append("</h3></a>")
        result.Append("<div class=""companyDescription"">").Append(oCompany.Description).Append("</div>")
        result.Append("<div class=""companyAction""><a href=""#"" class=""btn btn-xs btn-primary"">Follow</a></div>")
        result.Append("</div>")
        Return result.ToString()
    End Function

End Class