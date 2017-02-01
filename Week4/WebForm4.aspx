<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Week4.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlStudents" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlStudents_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <asp:GridView ID="gvDisplay" runat="server"></asp:GridView>
    
    </div>
        <br />
        <asp:DetailsView ID="dvDisplay" runat="server" Height="50px" Width="125px">
        </asp:DetailsView>
    </form>
</body>
</html>
