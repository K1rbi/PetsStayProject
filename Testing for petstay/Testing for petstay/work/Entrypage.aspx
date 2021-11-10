    <%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Entrypage.aspx.vb" Inherits="Testing_for_petstay.WebForm1" %>
   <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

    <meta name="keywords" content="" />	<!-- add keywords -->
    <meta name="description" content="" />	<!-- add description content -->
    <meta name="author" content="" />		<!-- Add your name to 'author' -->
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <title>Pet Stay</title>

    <!-- Links for css, bootstrap -->
    <link href="bootstrap.min.css" rel="stylesheet" type="text/css" />	<!-- edit the file name -->
    <link href="st_george_custom.css" rel="stylesheet" type="text/css" />	<!-- edit the file name -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>

<body >
    <form id="form1" runat="server">
        <!-- Navigation starts below -->
        <div class="navbar navbar-default" role="navigation">
            <div class="navbar-header">

                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>

                <!-- Logo goes here -->

                <h1> Pet Stay</h1>
            </div> <!-- End of navbar-header -->

            <div class="container">
                <!-- Top links start here -->
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li class="active"><a href="index.aspx">Home</a></li>
                        <li><a href="Entrypage.aspx">Entry</a></li>
                        <li><a href="Search.aspx">Search</a></li>
                        <li><a href="Contact.aspx">Contact</a></li>
                    </ul>
                </div> <!-- End of navbar collapse -->
            </div> <!-- End of navigation container class -->
        </div>

<!-- Navigation ends above -->

<!-- Main content div starts below -->
    <div  class="container">
	    <div class="main">

	        <h1>Infomation Entry</h1>
            <a href="#owner">Onwer </a> <a href="#Pet">Pet </a>
    <div id="owner">
      
            <h2>Onwer</h2>
                  <p></p>
            <asp:Panel ID="pnlOwnerForm" runat="server">
                Name<sup>*</sup>:<br />
                <asp:TextBox ID="txtOName" runat="server" Width="300px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfvONAme" runat="server" BorderStyle="None" Display="Dynamic" ErrorMessage="Name Required" ValidationGroup="AllValidators" ControlToValidate="txtOName">A name is required</asp:RequiredFieldValidator>
                 <br />
                 <br />
                 Phone<sup>*</sup>:<br />
                <asp:TextBox ID="txtOPhone" runat="server" Width="300px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revOPhone" runat="server" ControlToValidate="txtOPhone" ErrorMessage="Valid Phone Required" ValidationExpression="^[0-9]{10}$">Valid Phone Required</asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="rfvOPhone" runat="server" BorderStyle="None" ControlToValidate="txtOPhone" Display="Dynamic" ErrorMessage="Phone Required" ValidationGroup="AllValidators">A Phone number is Required</asp:RequiredFieldValidator>
                <br />
                 <br />
                 Email<sup>*</sup>:<br />
                 <asp:TextBox ID="txtOEmail" runat="server" Width="300px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="rewOEmail" runat="server" ControlToValidate="txtOEmail" ErrorMessage="Valid Email Required" ValidationExpression="(?:[a-z0-9!#$%&amp;'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&amp;'*+/=?^_`{|}~-]+)*|&quot;(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*&quot;)@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])">valid email required</asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="rfvOEmail" runat="server" BorderStyle="None" ControlToValidate="txtOEmail" Display="Dynamic" ErrorMessage="Email Required" ValidationGroup="AllValidators">An email is required</asp:RequiredFieldValidator>
                <br />
                 <br />
                 Notes<sup>*</sup>:<br />
                 <asp:TextBox ID="txtONotes" runat="server" Width="300px" Height="100px" TextMode="MultiLine"></asp:TextBox>
                <br />
                <asp:Button ID="btnOSubmit" runat="server" Text="Submit" Width="150px" />
                <asp:Button ID="btnOClear" runat="server" Text="Clear" Width="153px" />
                </asp:Panel>
         </div>
        <div id="Pet">
            
            <h2>Pet</h2>
                  <p></p>
             <asp:Panel ID="pnlPetForm" runat="server">
                 Name<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPName" runat="server" Width="300px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfvPName" runat="server" BorderStyle="None" ControlToValidate="txtPName" Display="Dynamic" ErrorMessage="Name Required" ValidationGroup="AllValidators">A name is required</asp:RequiredFieldValidator>
                 <br />
                 <br />
                 Breed<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPBreed" runat="server" Width="300px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfvPBreed" runat="server" BorderStyle="None" ControlToValidate="txtPBreed" Display="Dynamic" ErrorMessage="Breed Required" ValidationGroup="AllValidators">A Breed is required</asp:RequiredFieldValidator>
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
                 Age<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPAge" runat="server" Width="300px" TextMode="Number"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfvPAge" runat="server" BorderStyle="None" ControlToValidate="txtPAge" Display="Dynamic" ErrorMessage="Age Required" ValidationGroup="AllValidators">An age is required</asp:RequiredFieldValidator>
                 <br />
                 Owner<sup>*</sup>:<br />
                 <asp:DropDownList ID="ddlPOwner" runat="server" DataSourceID="PetStayData" DataTextField="Name" DataValueField="Id">
                 </asp:DropDownList>
                 <asp:SqlDataSource ID="PetStayData" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Name], [Id] FROM [tblCustomers] ORDER BY [Name]"></asp:SqlDataSource>
                 <br />
                 Notes<sup>*</sup>:<br />
                 <asp:TextBox ID="txtPNotes" runat="server" Width="300px" Height="100px" TextMode="MultiLine"></asp:TextBox>
                 <br />
                 Entry (dd/mm/yyyy)<sup>*</sup>:<br />
                 <%--  need fixing  <asp:RegularExpressionValidator ID="revPEntry" runat="server" ControlToValidate="txtPEntery" ErrorMessage="Valid Date Required">Vaild date required</asp:RegularExpressionValidator>--%>
                 <asp:Calendar ID="cldPEntery" runat="server"></asp:Calendar>
                 <br />
                 Exit (dd/mm/yyyy)*:<br />
                 <asp:Calendar ID="cldPExit" runat="server"></asp:Calendar>
                 <br />
                 <asp:Button ID="btnPSubmit" runat="server" Text="Submit" Width="150px" />
                 
                 <asp:Button ID="btnPClear" runat="server" Text="Clear" Width="153px" />
                 
            </asp:Panel>
          </div>
           
             <br /> <br /> <br /> <br />

             <!-- End Entry form -->
	
	    </div>
        <!-- Main content end  -->
	   
    </div>
        </form>
        <!-- container (around main div) end-->

     <!-- Footer starts below -->
    <%--  <footer class="navbar navbar-inverse navbar-fixed-bottom" role="navigation">
    <div class="container">
        <div class="navbar-text pull-right">
            &copy; Tom &amp; some time in 2021  <!-- edit this -->
        </div>
    </div>--%>




<!-- Link to JavaScipt plugins, needed for things like the dropdown menu to work.  BOTH files are required. -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

<script src="js/bootstrap.min.js"></script>


<p>
    &nbsp;
</p>
 </form>

</body>
</html>