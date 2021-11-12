<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SearchOwners.aspx.vb" Inherits="Testing_for_petstay.SearchOwners" %>

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

  a.Button {
  font: bold 15px Arial;
  text-decoration: none;
  background-color: #EEEEEE;
  color: #333333;
  padding: 5px 14px 5px 14px;
  border-top: 1px solid #CCCCCC;
  border-right: 1px solid #333333;
  border-bottom: 1px solid #333333;
  border-left: 1px solid #CCCCCC;
}
</style>
        <div class="container">
            <div class="main">
                <h1>Search</h1>
            
                <form id="frmMain" runat="server">
                    
                    <asp:Panel ID="pnlSearch" runat="server">
                        <p>
                            Change category
                        </p>
                        <p>
                          <%--   ddl not working in code how it should
                              <asp:DropDownList runat="server" ID="ddCatagory" AutoPostBack="True" OnSelectedIndexChanged="ddCatagory_TextChanged">
                                <asp:ListItem text="----" value="0"></asp:ListItem>
                                <asp:ListItem text="Pets" value="1"></asp:ListItem>
                                <asp:ListItem text="Customers" value="2"></asp:ListItem>
                            </asp:DropDownList>--%>

                         <%--    <asp:Button runat="server" Text="Pets" ID="btnPets" Width="118px" AutoPostBack="true" />--%>
                   <a class="Button" href="SearchPets.aspx"> Pets </a>
                            </p>
                    </asp:Panel>
                        <asp:panel ID="srcCustomers" runat="server" visible="True">
                            <p>
                                Customer search by name
                            </p>
                    
                            Customer<sup>*</sup>:<br />
                 <asp:DropDownList ID="ddlOName" runat="server" DataSourceID="PetStayData" DataTextField="Name" DataValueField="Id">
                 </asp:DropDownList>
                 <asp:SqlDataSource ID="PetStayData" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Name], [Id] FROM [tblCustomers] ORDER BY [Name]"></asp:SqlDataSource>
                 <br />
                            <asp:Button ID="btnOSearch" runat="server" Text="Search" Width="150px" />
                        </asp:panel>

                    <!--Panel end bak-->

                    
                </form>
            </div>
        </div>


<%--<%Response.WriteFile("Footer.html") 
    glitch with pull right not working , making it cover needed visuals%>--%>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

<script src="js/bootstrap.min.js"></script>

<p>
    &nbsp;
</p>
 </form>

</body>
</html>