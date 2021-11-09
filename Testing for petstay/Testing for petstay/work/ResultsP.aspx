<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ResultsP.aspx.vb" Inherits="Testing_for_petstay.ResultsP" %>
<%Response.WriteFile("Header_Nav.html") %>
<style>
table {
    text-align: left;
    border: 3px solid black;
    border-collapse: collapse;
}

tr {
    margin-top: 12px;
    margin-bottom: 12px;
    height: 24px;
}

th {
    height: 36px;
    vertical-align: middle;
    padding: 10px;
    border-bottom: 1px solid black;
    border-right: 1px solid black;
    background-color: #010c22;
    color: #ffffffff;
}

tr :nth-child(even) {
    background-color: rgb(128, 128, 230);
}

tr :nth-child(odd) {
    background-color: #ffffffff;
}

td {
    padding: 10px;
    border-bottom: 1px solid black;
    border-right: 1px solid black;
}</style>
        <form id="form1" runat="server">
        <div class="container">
            <div class="main">

                <h1>Results have been found</h1>
                <p>
                
                </p>

               <asp:PlaceHolder ID="plhResultsP" runat="server">
               </asp:PlaceHolder> 


            <p>
                <asp:Button runat="server" Text="Back to Search" ID="btnSearch" />


            </p>
</form>

<%Response.WriteFile("Footer.html") %>