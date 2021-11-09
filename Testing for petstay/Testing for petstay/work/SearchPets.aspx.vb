Imports System.Data.SqlClient
Imports System.Configuration
Public Class SearchPets
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnPSubmitN_Click(sender As Object, e As EventArgs) Handles BtnPSubmitN.Click
        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Name] LIKE CONCAT ('%',@name,'%')"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)

        sqlCmd.Parameters.AddWithValue("@name", txtPName.Text)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")
    End Sub

    Protected Sub BtnPSubmitB_Click(sender As Object, e As EventArgs) Handles BtnPSubmitB.Click
        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Breed] LIKE CONCAT ('%',@Breed,'%')"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)

        sqlCmd.Parameters.AddWithValue("@Breed", txtPBreed.Text)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")
    End Sub

    Protected Sub BtnPSubmitL_Click(sender As Object, e As EventArgs) Handles BtnPSubmitL.Click
        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Location] LIKE CONCAT ('%',@Loc,'%')"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)
        Dim loc As String = ddlPLocationNum.Text & ddlPLocationLetter.Text
        sqlCmd.Parameters.AddWithValue("@Loc", loc)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")
    End Sub

    Protected Sub BtnPSubmitA_Click(sender As Object, e As EventArgs) Handles BtnPSubmitA.Click
        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Age] LIKE CONCAT ('%',@Age,'%')"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)
        sqlCmd.Parameters.AddWithValue("@Age", txtPAge.Text)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")
    End Sub

    Protected Sub BtnPSubmitO_Click(sender As Object, e As EventArgs) Handles BtnPSubmitO.Click
        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Owner] LIKE CONCAT ('%',@Owner,'%')"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)
        sqlCmd.Parameters.AddWithValue("@Owner", ddlPOwner.SelectedValue)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")
    End Sub

    Protected Sub BtnPSubmitD_Click(sender As Object, e As EventArgs) Handles BtnPSubmitD.Click
        ' strSQL will need to refernce to colums exit and entry and display both , done to make it easy when searching 

        ' mock up not final 
        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Entry] OR [Exit] LIKE @Date"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)

        ' need to make this pull date ( curntly dont rember if it is suaced in right order 
        Dim Pdate As Date

        sqlCmd.Parameters.AddWithValue("@Date", Pdate)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")

    End Sub

    Protected Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Response.Redirect("SearchOwners.aspx")
    End Sub
End Class