Imports System.Data.SqlClient
Imports System.Configuration
Public Class SearchOwners
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnOSearch_Click(sender As Object, e As EventArgs) Handles btnOSearch.Click
        '' pull owner id and search for it , then display
        'plan , find matching data

        Dim strSQL As String = "SELECT *  FROM tblCustomers WHERE [ID] LIKE @ID"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)

        sqlCmd.Parameters.AddWithValue("ID", ddlOName.SelectedValue)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsO") = ds
        Response.Redirect("ResultsO.aspx")

    End Sub

    Protected Sub btnPets_Click(sender As Object, e As EventArgs) Handles btnPets.Click
        Response.Redirect("SearchPets.aspx")
    End Sub
End Class