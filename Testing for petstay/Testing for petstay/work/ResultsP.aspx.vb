Imports System.Data.SqlClient
Imports System.Configuration
Public Class ResultsP
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ds As DataSet = Session("resultsP")

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
            strBuilder.Append("<th class=""results"">Breed</th>")
            strBuilder.Append("<th class=""results"">Location</th>")
            strBuilder.Append("<th class=""results"">Age</th>")
            strBuilder.Append("<th class=""results"">Owner</th>")
            strBuilder.Append("<th class=""results"">Notes</th>")
            strBuilder.Append("<th class=""results"">Entry</th>")
            strBuilder.Append("<th class=""results"">Exit</th>")
            strBuilder.Append("</tr>")


            ' building rows of table with data
            For Each row As DataRow In ds.Tables(0).Rows

                ' date proccessing
                Dim strDateFormat As String = "ddd MMM d, yyyy"

                Dim datDateEn As Date = Date.Parse(row(7).ToString)
                Dim datDateEx As Date = Date.Parse(row(8).ToString)

                ' building tabel

                strBuilder.Append("<tr class=""results"">")
                strBuilder.Append("<td class=""results"">" & row(1) & "</td>")
                strBuilder.Append("<td class=""results"">" & row(2) & "</td>")
                strBuilder.Append("<td class=""results"">" & row(3) & "</td>")
                strBuilder.Append("<td class=""results"">" & row(4) & "</td>")
                strBuilder.Append("<td class=""results"">" & row(5) & "</td>")
                strBuilder.Append("<td class=""results"">" & row(6) & "</td>")
                strBuilder.Append("<td class=""results"">" & datDateEn.ToString(strDateFormat) & "</td>")
                strBuilder.Append("<td class=""results"">" & datDateEx.ToString(strDateFormat) & "</td>")
                strBuilder.Append("</tr>")
            Next
            'close table 
            strBuilder.Append("</table>")


        End If

        plhResultsP.Controls.Add(New LiteralControl(strBuilder.ToString()))
    End Sub



    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Response.Redirect("Search.aspx")
    End Sub
End Class