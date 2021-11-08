Imports System.Data.SqlClient
Public Class Search
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
        SwapPanels(True, False)

    End Sub

    Protected Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        SwapPanels(False, True)
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

    Protected Function SwapPanels(blnPets As Boolean, blnCustomers As Boolean)
        srcPets.Visible = blnPets
        srcCustomers.Visible = blnCustomers

        Return Nothing
    End Function


End Class