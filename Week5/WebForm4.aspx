<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Week5.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="tbxUsername" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
