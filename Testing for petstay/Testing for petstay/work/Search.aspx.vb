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


End Class