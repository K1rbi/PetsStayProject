<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ResultsO.aspx.vb" Inherits="Testing_for_petstay.ResultsO" %>
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
        <div class="container">
            <div class="main">

                <h1>Results have been found</h1>
                <p>
                   Bellow are the found results
                </p>

               <asp:PlaceHolder ID="plhResultsO" runat="server">
               </asp:PlaceHolder> 

            </div>

        </div>
<%Response.WriteFile("Footer.html") %>