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

        ' need to make this pull date ( curntly dont rember if it is suaced in right order 
        Dim DTest As New Date
        Dim Pdate As Date = cldPDate.SelectedDate
        ' mock up not final 

        Dim DF As New Date
        Dim provider As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InvariantCulture
        Dim TempD() As String = txtDate.Text.Split("/")

        ' if date has is missing 2 digit first add a zero to the front then crompress
        If Len(TempD(0)) = 1 Then

            TempD(0) = "0" & TempD(0)
        End If
        If Len(TempD(1)) = 1 Then

            TempD(1) = "0" & TempD(1)
        End If

        txtDate.Text = TempD(0) & "/" & TempD(1) & "/" & TempD(2)

        'Dim TempDF As String = String.Join("/", TempD)

        ' checks if date is empty ( caused by bug ) then replaces date with data from text box 
        If Pdate = DTest Then
            DF = Date.ParseExact(txtDate.Text, "dd/MM/yyyy", provider)
        Else
            DF = Pdate
        End If

        Dim strSQL As String = "SELECT *  FROM tblPets WHERE [Entry] OR [Exit] LIKE @Date"
        'Dim sqlCMD As New  
        Dim sqlCmd As New SqlCommand(strSQL)

        ' testing for problems with saucing date 



        sqlCmd.Parameters.AddWithValue("@Date", DF)

        Dim ds As DataSet = QueryDataTest(sqlCmd)
        Session("resultsP") = ds
        Response.Redirect("ResultsP.aspx")

    End Sub



    'Protected Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
    '    Response.Redirect("SearchOwners.aspx")
    'End Sub
End Class