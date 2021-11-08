Imports System.Data.SqlClient
Imports System.Configuration
Public Class ResultsO
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strBuilder As StringBuilder = New StringBuilder

        'building table
        ' ([Name],[Phone],[Email],[Notes]--%>
        strBuilder.Append("<table class=""results"">")
        strBuilder.Append("<tr class=""results"">")
        strBuilder.Append("<th class=""results"">Name</th>")
        strBuilder.Append("<th class=""results"">Phone</th>")
        strBuilder.Append("<th class=""results"">Email</th>")
        strBuilder.Append("<th class=""results"">Notes</th>")
        strBuilder.Append("</tr>")

        'sql statement
        Dim strSQL As String = "SElECT * FROM tblCustomers WHERE [ID] = " & Session("resultsO")
        Dim sqlCmd As New SqlCommand()
        sqlCmd.CommandText = strSQL

        'data
        Dim ds As DataSet = QueryDataTest(sqlCmd)

        For Each row As DataRow In ds.Tables(0).Rows

            strBuilder.Append("<tr class=""results"">")
            strBuilder.Append("<td class=""results"">" & row(1) & "</td>")
            strBuilder.Append("<td class=""results"">" & row(2) & "</td>")
            strBuilder.Append("<td class=""results"">" & row(3) & "</td>")
            strBuilder.Append("<td class=""results"">" & row(4) & "</td>")
            strBuilder.Append("</tr>")
        Next

        strBuilder.Append("</table>")

        plhResultsO.Controls.Add(New LiteralControl(strBuilder.ToString()))

    End Sub

End Class