Imports System.Data.SqlClient
Imports System.Configuration
Public Class Search
    Inherits System.Web.UI.Page

    Dim blnPets As Boolean
    Dim blnCustomer As Boolean

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim url As String
        Dim nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString())

        If IsPostBack = True Then
            '    Dim nameValues = HttpUtility.ParseQueryString(Request.QueryString.ToString())

            If nameValues.AllKeys.Contains("__VIEWSTATE") Then '__EVENTTARGET
                'nameValues.Remove("__VIEWSTATE")
                'nameValues.Remove("__VIEWSTATEGENERATOR")
                'nameValues.Remove("__EVENTVALIDATION")
                Dim updatedQueryString As String = "?"
                url = "/work/Search"

                If nameValues("btnPets") = "Pets" Then
                    updatedQueryString &= "btnPets=Pets"
                Else
                    updatedQueryString &= "btnCustomer=Customer"
                End If


                Response.Redirect(url & updatedQueryString)

            End If
        End If

        If nameValues.Count = 0 Then
            blnCustomer = False
            blnPets = False
        ElseIf nameValues("btnPets") = "Pets" Then
            blnPets = True
            blnCustomer = False
        Else
            blnPets = False
            blnCustomer = True
        End If

        SwapPanels()

    End Sub

    'ddl not working how it should
    'Protected Sub ddCatagory_TextChanged(sender As Object, e As EventArgs) Handles ddCatagory.TextChanged
    '    MsgBox(ddCatagory.SelectedItem)

    '    If ddCatagory.SelectedItem.Value = 1 Then
    '        ' show pets search 
    '        srcPets.Visible = True
    '    ElseIf ddCatagory.SelectedItem.Value = 2 Then
    '        'show customers search
    '        srcCustomers.Visible = True
    '    End If
    'End Sub


    Protected Sub btnPets_Click(sender As Object, e As EventArgs) Handles btnPets.Click
        SwapPanels()

    End Sub

    Protected Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        SwapPanels()
        '        srcPets.Visible = False
        '        srcCustomers.Visible = True

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

    Protected Function SwapPanels()
        srcPets.Visible = blnPets
        srcCustomers.Visible = blnCustomer

        Return Nothing
    End Function

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
End Class