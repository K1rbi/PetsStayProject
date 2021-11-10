<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SuccessO.aspx.vb" Inherits="Testing_for_petstay.Success" %>

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
    color:black;
    background-color: #ffffffff;
}

td {
    padding: 10px;
    border-bottom: 1px solid black;
    border-right: 1px solid black;
}</style>
        <div class="container">
            <div class="main">

                <h1>Success the infomation has been entered</h1>
                <p>
                    success
                </p>

               <asp:PlaceHolder ID="plhDataTableO" runat="server">
               </asp:PlaceHolder> 

            </div>

        </div>
<%Response.WriteFile("Footer.html") %>