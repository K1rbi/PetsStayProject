<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Search.aspx.vb" Inherits="Testing_for_petstay.Search" %>
<%Response.WriteFile("Header_Nav.html") %>
<style>
    div.one{
        background-color: rgb(128, 128, 230);
        border: 1px solid #010c22;
        padding-top: 15px;
    }

    div.two{
         background-color: #ffffff;
        border: 1px solid #010c22;
        padding-top: 15px;
    }


</style>
        <div class="container">
            <div class="main">
                <h1>Search</h1>
                <form id="frmMain" runat="server">
                    
                    <asp:Panel ID="pnlSearch" runat="server">
                        <p>
                            Pets/ Customers
                            <asp:DropDownList runat="server" ID="ddCatagory" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged">
                                <asp:ListItem>Pets</asp:ListItem>
                                <asp:ListItem>Customers</asp:ListItem>
                            </asp:DropDownList>
                        </p>

                        <asp:panel ID="srcPets" runat="server">
                               
                        </asp:panel>

                        <asp:panel ID="srcCustomers" runat="server">

                        </asp:panel>

                    </asp:Panel>


                    
                </form>
            </div>
        </div>
<%Response.WriteFile("Footer.html") %>