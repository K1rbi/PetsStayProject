Imports System.Data.SqlClient
Imports System.Configuration
Public Class SearchPets2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Function IntCheck()
        Dim cat As Integer = ddlCat.SelectedValue

        '0=Name , 1=Breed , 2=Location , 3=Age , 4=Owner , 5=Date
        Try

            If cat = 0 Then
                NameSearch()
            ElseIf cat = 1 Then
                BreedSearch()
            ElseIf cat = 2 Then
                LocationSearch()
            ElseIf cat = 3 Then
                AgeSearch()
            ElseIf cat = 4 Then
                OwnerSearch()
            ElseIf cat = 5 Then
                DateSearch()
            Else
                MsgBox("error within if for cat")
            End If
        Catch

        End Try

        Return Nothing
    End Function

    Private Sub NameSearch()
        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Name] Like CONCAT ('%',@name,'%')"
            'Dim sqlCMD As New  
            Dim sqlCmd As New SqlCommand(strSQL)

        'Entering value in sql statement
        sqlCmd.Parameters.AddWithValue("@name", txtPName.Text)

        'creating and shearing data set 
        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds

        ' send to new Results page 
        Response.Redirect("ResultsP.aspx")

    End Sub

    Private Sub BreedSearch()
        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Breed] LIKE CONCAT ('%',@Breed,'%')"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)


        'Entering value in sql statement
        sqlCmd.Parameters.AddWithValue("@Breed", txtPBreed.Text)


        'creating and shearing data set 
        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds

        ' send to new Results page 
        Response.Redirect("ResultsP.aspx")

    End Sub

    Private Sub LocationSearch()

        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Location] LIKE CONCAT ('%',@Loc,'%')"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)

        'Combineing location 
        Dim loc As String = ddlPLocationNum.Text & ddlPLocationLetter.Text
        sqlCmd.Parameters.AddWithValue("@Loc", loc)

        'Creating data set 
        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")

    End Sub

    Private Sub AgeSearch()
        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Age] LIKE CONCAT ('%',@Age,'%')"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)
        sqlCmd.Parameters.AddWithValue("@Age", txtPAge.Text)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")
    End Sub

    Private Sub OwnerSearch()
        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Owner] LIKE CONCAT ('%',@Owner,'%')"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)
        sqlCmd.Parameters.AddWithValue("@Owner", ddlPOwner.SelectedValue)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")
    End Sub

    Private Sub DateSearch()
        ' strSQL will need to refernce to colums exit and entry and display both , done to make it easy when searching 

        ' mock up not final 

        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Entry] OR [Exit] LIKE @Date"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)

        ' need to make this pull date ( curntly dont rember if it is suaced in right order 
        Dim Pdate As Date = CldDate.SelectedDate

        MsgBox(Pdate)
        sqlCmd.Parameters.AddWithValue("@Date", Pdate)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")


    End Sub

    Protected Sub bntSearch_Click(sender As Object, e As EventArgs) Handles bntSearch.Click
        IntCheck()

    End Sub
End Class