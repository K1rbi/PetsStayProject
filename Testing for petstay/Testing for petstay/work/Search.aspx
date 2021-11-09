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

                            <asp:Button runat="server" Text="Pets" ID="btnPets" Width="118px" AutoPostBack="true" />
                            <asp:Button runat="server" Text="Customers" ID="btnCustomers" AutoPostBack="true" />
                      </p>
                    </asp:Panel>
                
                    <!--Panel end bak-->

                    
                </form>
            </div>
        </div>


<%--<%Response.WriteFile("Footer.html") 
    glitch with pull right not working , making it cover needed visuals%>--%>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>

<script src="js/bootstrap.min.js"></script>

<script language="text/javascript">  
   
    function __doPostBack(eventTarget, eventArgument) {  
        if (!theForm.onsubmit || (theForm.onsubmit() != false)) {  
        theForm.__EVENTTARGET.value = eventTarget;  
        theForm.__EVENTARGUMENT.value = eventArgument;  
        theForm.submit();  
    }  
</script>  


<p>
    &nbsp;
</p>
 </form>

</body>
</html>