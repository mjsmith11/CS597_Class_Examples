<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Week4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="tbxMajor" runat="server"></asp:TextBox>
    
        <br /><asp:Button ID="tbxSearch" runat="server" Text="Search" OnClick="tbxSearch_Click" />
    
        <asp:GridView ID="gvDisplay" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
