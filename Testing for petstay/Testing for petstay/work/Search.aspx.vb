Public Class Search
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Unnamed1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddCatagory.SelectedIndexChanged
        If ddCatagory.SelectedValue = "pets" Then
            ' show pets search 

        ElseIf ddCatagory.SelectedValue = "Customers" Then
            'show customers search

        End If
    End Sub



End Class