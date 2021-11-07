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
                            Pick Infomation Catagory
                        </p>
                        <p>
                          <%--   ddl not working in code how it should
                              <asp:DropDownList runat="server" ID="ddCatagory" AutoPostBack="True" OnSelectedIndexChanged="ddCatagory_TextChanged">
                                <asp:ListItem text="----" value="0"></asp:ListItem>
                                <asp:ListItem text="Pets" value="1"></asp:ListItem>
                                <asp:ListItem text="Customers" value="2"></asp:ListItem>
                            </asp:DropDownList>--%>

                            <asp:Button runat="server" Text="Pets" ID="btnPets" Width="118px" />
                            <asp:Button runat="server" Text="Customers" ID="btnCustomers" />
                      </p>
                    </asp:Panel>
                        <asp:Panel ID="srcPets" runat="server" visible="false">
                               <p>
                                   Pets search options
                               </p>
                            <%--:  Name search text - entry of name
                                :  Breed search text - entry of breed
                                : location search ddl - two drop downs
                                : Age search text - 2 digit max
                                : Owner search ddl - imported list of all owners
                                : date search calander , will check both exit and entry --%>
                                Name<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPName" runat="server" Width="300px"></asp:TextBox>
                 <br />
                               <asp:Button ID="BtnPSubmitN" runat="server" Text="Search" Width="150px" />
                 <br />
                 Breed<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPBreed" runat="server" Width="300px"></asp:TextBox>
                 <br />
                               <asp:Button ID="BtnPSubmitB" runat="server" Text="Search" Width="150px" />
                 <br />
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
                               <br />

                            Age<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPAge" runat="server" Width="300px" TextMode="Number"></asp:TextBox>
                               <br />
                               <asp:Button ID="BtnPSubmitA" runat="server" Text="Search" Width="150px" />
                               <br />
                               <br />
                               Owner<sup>*</sup>:<br />
                               <asp:DropDownList ID="ddlPOwner" runat="server" DataSourceID="PetStayData" DataTextField="Name" DataValueField="Id">
                               </asp:DropDownList>
                               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Name], [Id] FROM [tblCustomers] ORDER BY [Name]"></asp:SqlDataSource>
                               <asp:Button ID="BtnPSubmitO" runat="server" Text="Search" Width="150px" />
                               <br />
                               Date<sup>*</sup>:<br />
                 <%--  need fixing  <asp:RegularExpressionValidator ID="revPEntry" runat="server" ControlToValidate="txtPEntery" ErrorMessage="Valid Date Required">Vaild date required</asp:RegularExpressionValidator>--%>
                 <asp:Calendar ID="cldPEntery" runat="server"></asp:Calendar>
                               <asp:Button ID="BtnPSubmitD" runat="server" Text="Search" Width="150px" />
                 <br />

                        </asp:Panel>

                        <asp:panel ID="srcCustomers" runat="server" visible="False">
                            <p>
                                Customer search options
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