<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SearchPets.aspx.vb" Inherits="Testing_for_petstay.SearchPets" %>
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

*{-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box}*,:after,:before{color:#000!important;text-shadow:none!important;background:0 0!important;-webkit-box-shadow:none!important;box-shadow:none!important}

</style>
        <div class="container">
            <div class="main">
                <h1>Search</h1>
            
                <form id="frmMain" runat="server">
                    
                    <asp:Panel ID="pnlSearch" runat="server">
                        <p>
                            Change catagory
                        </p>
                        <p>
                          <%--   ddl not working in code how it should
                              <asp:DropDownList runat="server" ID="ddCatagory" AutoPostBack="True" OnSelectedIndexChanged="ddCatagory_TextChanged">
                                <asp:ListItem text="----" value="0"></asp:ListItem>
                                <asp:ListItem text="Pets" value="1"></asp:ListItem>
                                <asp:ListItem text="Customers" value="2"></asp:ListItem>
                            </asp:DropDownList>--%>

                            <%-- <asp:Button runat="server" Text="Customers" ID="btnCustomers" AutoPostBack="true" /> --%>
                     <a class="Button" href="SearchOwners.aspx"> Owners </a>

                            </p>
                </asp:Panel>
                        <asp:Panel ID="srcPets" runat="server" visible="True">
                               <p>
                                   Pets search options
                               </p>
                        <div class="one">
                                Name<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPName" runat="server" Width="300px"></asp:TextBox>
                 <br />
                               <asp:Button ID="BtnPSubmitN" runat="server" Text="Search" Width="150px" />
                </div>
                 <br />
                <div class="two">
                 Breed<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPBreed" runat="server" Width="300px"></asp:TextBox>
                 <br />
                               <asp:Button ID="BtnPSubmitB" runat="server" Text="Search" Width="150px" />
                 </div>
                 <br />

                <div class="one">
                 Location<sup>*</sup>:<br />
                 <asp:DropDownList ID="ddlPLocationLetter" runat="server" Height="16px" Width="73px">
                     <asp:ListItem>A</asp:ListItem>
                     <asp:ListItem>B</asp:ListItem>
                     <asp:ListItem>C</asp:ListItem>
                     <asp:ListItem>D</asp:ListItem>
                 </asp:DropDownList>
                 <asp:DropDownList ID="ddlPLocationNum" runat="server" Height="16px" Width="75px">
                     <asp:ListItem>1</asp:ListItem>
                     <asp:ListItem>2</asp:ListItem>
                     <asp:ListItem>3</asp:ListItem>
                     <asp:ListItem>4</asp:ListItem>
                     <asp:ListItem>5</asp:ListItem>
                     <asp:ListItem>6</asp:ListItem>
                     <asp:ListItem>7</asp:ListItem>
                     <asp:ListItem>8</asp:ListItem>
                     <asp:ListItem>9</asp:ListItem>
                     <asp:ListItem>10</asp:ListItem>
                     <asp:ListItem>11</asp:ListItem>
                     <asp:ListItem>12</asp:ListItem>
                 </asp:DropDownList>

                               <br />
                               <asp:Button ID="BtnPSubmitL" runat="server" Text="Search" Width="150px" />
                    </div>
                               <br />
                    <div class="two">
                            Age<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPAge" runat="server" Width="300px" TextMode="Number"></asp:TextBox>
                               <br />
                               <asp:Button ID="BtnPSubmitA" runat="server" Text="Search" Width="150px" />
                               <br />
                        </div>
                               <br />

                        <div class="one">
                               Owner<sup>*</sup>:<br />
                               <asp:DropDownList ID="ddlPOwner" runat="server" DataSourceID="OwnerData" DataTextField="Name" DataValueField="Id">
                               </asp:DropDownList>
                                <asp:SqlDataSource ID="OwnerData" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Name], [Id] FROM [tblCustomers]"></asp:SqlDataSource>
                                <br />
                                <asp:Button ID="BtnPSubmitO" runat="server" Text="Search" Width="150px" />
                            </div>
                               <br />
                            <div class="two">
                               Date<sup>*</sup>:( dd/mm/yyyy)<br />
                
                                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
                
                               <asp:Calendar ID="cldPDate" runat="server" Height="235px" Width="303px"></asp:Calendar>
                
                               <asp:Button ID="BtnPSubmitD" runat="server" Text="Search" Width="150px" />
                                </div>
                               <br />
                 <br />

                       </asp:Panel> 
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