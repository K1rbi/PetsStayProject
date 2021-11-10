<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SearchPets2.aspx.vb" Inherits="Testing_for_petstay.SearchPets2" %>

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
                    
                    <div class="top">
                        <p>
                            Change catagory
                        <p>
                     <a class="Button" href="SearchOwners.aspx"> Owners </a>
   
                            <p>
                                   Pets search options
                               </p>
                  </div>
                  <div class="Body">
                                Name<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPName" runat="server" Width="300px"></asp:TextBox>
                 <br />
                 <br />
                 Breed<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPBreed" runat="server" Width="300px"></asp:TextBox>
                 <br />
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
                               <br />

                            Age<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPAge" runat="server" Width="300px" TextMode="Number"></asp:TextBox>
                               <br />
                               <br />
                               <br />
                               Owner<sup>*</sup>:<br />
                               <asp:DropDownList ID="ddlPOwner" runat="server" DataSourceID="OwnerData" DataTextField="Name" DataValueField="Id">
                               </asp:DropDownList>
                                <asp:SqlDataSource ID="OwnerData" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Name], [Id] FROM [tblCustomers]"></asp:SqlDataSource>
                                <br />
                               <br />
                               Date<sup>*</sup>:<br />
                               <asp:Calendar ID="CldDate" runat="server"></asp:Calendar>
                               <br />
                               <br />
                               Search Group<br />
                               <asp:DropDownList ID="ddlCat" runat="server">
                                   <asp:ListItem Value="0">Name</asp:ListItem>
                                   <asp:ListItem Value="1">Breed</asp:ListItem>
                                   <asp:ListItem Value="2">Location</asp:ListItem>
                                   <asp:ListItem Value="3">Age</asp:ListItem>
                                   <asp:ListItem Value="4">Owner</asp:ListItem>
                                   <asp:ListItem Value="5">Date</asp:ListItem>
                               </asp:DropDownList>
                               <asp:Button ID="bntSearch" runat="server" Text="Search" Width="100px"/>
                           <input type="button" runat="server" id="btn" value="Save" onserverclick="IntCheck()" />
                       </div>
                </form>
            </div>
        </div>


<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

<script src="js/bootstrap.min.js"></script>



<p>
    &nbsp;
</p>
 </form>

</body>
</html>