<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Week6.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbxUsername" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblUsernameError" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblPassword0" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbxPassword0" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPassword1" runat="server" Text="Re-enter Password"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="tbxPassword1" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Button ID="btnCreate" Text="Create Account" runat="server" OnClick="btnCreate_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
