<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Week2Friday.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblHours" runat="server" Text="Enter Number of Hours"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxHours" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPayRate" runat="server" Text="Select Type of Employee"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlPayRate" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbxAnswer" runat="server" ReadOnly="true"></asp:TextBox>
    </div>
    </form>
</body>
</html>
