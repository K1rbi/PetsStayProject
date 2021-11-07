Imports System.Data.SqlClient
Imports System.Configuration
Public Class SuccessP
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim strBuilder As StringBuilder = New StringBuilder

        'building table
        ' [Name],[Breed],[Location],[Age],[Owner],[Notes],[Entry],[Exit]
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


        'data
        Dim ds As DataSet = QueryData()

        For Each row As DataRow In ds.Tables(0).Rows

            ' date processing
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

        strBuilder.Append("</table>")

        plhDataTableP.Controls.Add(New LiteralControl(strBuilder.ToString()))

    End Sub

    Private Function QueryData() As DataSet

        Dim sqlCmd As SqlCommand
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlDA As New SqlDataAdapter
        Dim ds As New DataSet

        Dim strSQL As String = "SElECT * FROM tblPets WHERE [ID] = " & Session("PID")

        Try

            sqlConn.Open()
            sqlCmd = New SqlCommand(strSQL, sqlConn)

            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(ds)

        Catch ex As Exception
            MsgBox("Error, P query data", , "error")

        Finally
            sqlDA.Dispose()
            ds.Dispose()

            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If

        End Try

        Return ds

    End Function


End Class