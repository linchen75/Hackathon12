Imports Hackathon12.DB
Imports Hackathon12.DomainObject

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oCompanies As List(Of Company) = New CompanyRepository().GetAll()
        For Each oCompany As Company In oCompanies
            Console.WriteLine(oCompany.NameProperty)
        Next
    End Sub

End Class