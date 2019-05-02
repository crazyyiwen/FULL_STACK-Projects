<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPageNew.aspx.cs" Inherits="TropicalServer.LoginPageNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
    </style>
</head>
<body style="border:solid; border-color:#FEB90B; margin:5px; padding:0px;">
    <form   runat="server" method="post" action="LoginGenericHandler.ashx">
        <img src="../Images/Header.png" />
        <input type="hidden" name="viewstate" value="hidden" />
        <div  runat="server" style="background-color:#F7862F; margin-top: 157px; margin-left: 350px;height: 255px; width: 437px;" align="center">
            <div style="text-align:left; " >
                <asp:Label ID="LoginTitle" runat="server" Text="MOBILE CUSTOMERORDER  TRACKING" Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" ForeColor="White" ></asp:Label>
            </div>
            <div style="background-color:#FEB90B; height: 161px; width: 437px; margin-top: 9px;" title="Remember My ID">
                <asp:Label ID="lbusername" runat="server" Style="text-align:left;" Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" ForeColor="White" AssociatedControlID="LoginID">Login ID：</asp:Label>
                <!--autocomplete="off" Login ID will not remember the ID in TextBox -->
                 <asp:TextBox ID="LoginID" runat="server" OnTextChanged="LoginID_TextChanged" Width="188px" autocomplete="off"></asp:TextBox><br />
                <asp:Label ID="lbpsw" runat="server" Style="text-align:left;" Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" ForeColor="White" AssociatedControlID="Password">Password：
                </asp:Label>
                <asp:TextBox ID="Password" runat="server" TextMode="Password" style="margin-left: 0px" Width="186px" OnTextChanged="Password_TextChanged">
                </asp:TextBox><br />
                <p>
                    <asp:CheckBox ID="CheckBox1" runat="server" TextAlign="Left" AutoPostBack="True" BorderStyle="None" Font-Bold="True" Font-Size="9pt" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Remember my ID" Font-Names="Calibri" ForeColor="White" />&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnLogin" runat="server" Text="Login" onclick="BtnLogin_Click" BackColor="Black" Font-Bold="True" Font-Names="Calibri" ForeColor="White"/>  
                </p>   
            </div>
            <br />
            <asp:Label ID="ForgetUsername" runat="server" Text="Forget Username" Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" ForeColor="White"></asp:Label>&nbsp;
            <asp:Label ID="ForgetPassword" runat="server" Text="Forget Password" Font-Bold="True" Font-Names="Calibri" Font-Size="9pt" ForeColor="White"></asp:Label>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
