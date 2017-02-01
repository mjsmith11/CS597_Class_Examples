<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Week4.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlStates" runat="server">
        </asp:DropDownList>
        &nbsp;&nbsp;
        <asp:DropDownList ID="ddlMajors" runat="server">
        </asp:DropDownList>
        &nbsp;&nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
    
    </div>
    </form>
</body>
</html>
