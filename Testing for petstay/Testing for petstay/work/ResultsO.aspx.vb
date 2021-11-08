Imports System.Data.SqlClient
Imports System.Configuration
Public Class ResultsO
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' sauce dataset 
        Dim ds As DataSet = Session("resultsO")

        Call DisplayTable(ds)
    End Sub

    Private Sub DisplayTable(ds As DataSet)


        Dim strBuilder As StringBuilder = New StringBuilder
        'check amount of records 




        If ds.Tables.Count = 0 Or ds.Tables(0).Rows.Count < 1 Then
            strBuilder.Append("<h2>No infomation was found with search</h2>")
        Else



            'building table
            ' ([Name],[Phone],[Email],[Notes]--%>
            strBuilder.Append("<table class=""results"">")
            strBuilder.Append("<tr class=""results"">")
            strBuilder.Append("<th class=""results"">Name</th>")
            strBuilder.Append("<th class=""results"">Phone</th>")
            strBuilder.Append("<th class=""results"">Email</th>")
            strBuilder.Append("<th class=""results"">Notes</th>")
            strBuilder.Append("</tr>")

            ' building rows of table with data
            For Each row As DataRow In ds.Tables(0).Rows

                strBuilder.Append("<tr class=""results"">")
                strBuilder.Append("<td class=""results"">" & row(1) & "</td>")
                strBuilder.Append("<td class=""results"">" & row(2) & "</td>")
                strBuilder.Append("<td class=""results"">" & row(3) & "</td>")
                strBuilder.Append("<td class=""results"">" & row(4) & "</td>")
                strBuilder.Append("</tr>")
            Next
            'close table 
            strBuilder.Append("</table>")


        End If

        plhResultsO.Controls.Add(New LiteralControl(strBuilder.ToString()))
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Response.Redirect("Search.aspx")
    End Sub







    '<!-- old code from success page
    '    Dim strBuilder As StringBuilder = New StringBuilder

    '        'building table
    '        ' ([Name],[Phone],[Email],[Notes]--%>
    '        strBuilder.Append("<table class=""results"">")
    '        strBuilder.Append("<tr class=""results"">")
    '        strBuilder.Append("<th class=""results"">Name</th>")
    '        strBuilder.Append("<th class=""results"">Phone</th>")
    '        strBuilder.Append("<th class=""results"">Email</th>")
    '        strBuilder.Append("<th class=""results"">Notes</th>")
    '        strBuilder.Append("</tr>")

    '        'sql statement
    '        Dim strSQL As String = "SElECT * FROM tblCustomers WHERE [ID] = " & Session("resultsO")
    '    Dim sqlCmd As New SqlCommand()
    '        sqlCmd.CommandText = strSQL

    '        'data
    '        Dim ds As DataSet = QueryDataTest(sqlCmd)

    '    For Each row As DataRow In ds.Tables(0).Rows

    '            strBuilder.Append("<tr class=""results"">")
    '            strBuilder.Append("<td class=""results"">" & row(1) & "</td>")
    '            strBuilder.Append("<td class=""results"">" & row(2) & "</td>")
    '            strBuilder.Append("<td class=""results"">" & row(3) & "</td>")
    '            strBuilder.Append("<td class=""results"">" & row(4) & "</td>")
    '            strBuilder.Append("</tr>")
    '        Next

    '        strBuilder.Append("</table>")

    '        plhResultsO.Controls.Add(New LiteralControl(strBuilder.ToString()))
    '--!>

End Class


