<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Week5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblSSN" runat="server" Text="SSN"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="tbxSSN" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblFirst" runat="server" Text="First Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxFirst" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLast" runat="server" Text="Last Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxLast" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblMajor" runat="server" Text="Major"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="tbxMajor" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPhone" runat="server" Text="Phone Number"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="tbxPhone" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        <br />
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
