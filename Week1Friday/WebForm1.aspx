<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Week1Friday.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<asp:label runat="server" text="Enter Temperature in Farenheit: "></asp:label>
    &nbsp;
        <asp:TextBox ID="tbxFah" runat="server"></asp:TextBox>
    
    &nbsp;
        <asp:Button ID="btnFahtoCel" runat="server" Text="Fah to Cel" OnClick="btnFahtoCel_Click" />
    
    &nbsp;&nbsp;
        <asp:TextBox ID="tbxResult" runat="server"></asp:TextBox>

        <br />
    
        <asp:DropDownList ID="ddlStates" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlStates_SelectedIndexChanged">
            <asp:ListItem Value="IN">Indiana</asp:ListItem>
            <asp:ListItem Value="CA">California</asp:ListItem>
            <asp:ListItem Value="OH">Ohio</asp:ListItem>
        </asp:DropDownList>
    
        <asp:TextBox ID="tbxState" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>

