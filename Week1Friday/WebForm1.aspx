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
    <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Value="0">Freshman</asp:ListItem>
            <asp:ListItem Value="1">Sophomore</asp:ListItem>
            <asp:ListItem Value="2">Junior</asp:ListItem>
            <asp:ListItem Value="3">Senior</asp:ListItem>
            <asp:ListItem Value="4">Graduate</asp:ListItem>
        </asp:RadioButtonList>
    
        <br />
        <br />
        <asp:CheckBoxList ID="cbxlToppings" runat="server">
            <asp:ListItem Value="0">Sausage</asp:ListItem>
            <asp:ListItem Value="1">Peppers</asp:ListItem>
            <asp:ListItem Value="2">Pepperoni</asp:ListItem>
            <asp:ListItem Value="3">Onions</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="btnToppings" runat="server" OnClick="btnToppings_Click" Text="Submit" />
        <br /><br />
        <asp:ListBox ID="lbxToppings" runat="server" SelectionMode="Multiple">
            <asp:ListItem Value="0">Sausage</asp:ListItem>
            <asp:ListItem Value="1">Peppers</asp:ListItem>
            <asp:ListItem Value="2">Pepperoni</asp:ListItem>
            <asp:ListItem Value="3">Onions</asp:ListItem>
        </asp:ListBox>
    
        <br />
        <asp:Button ID="btnlbxToppings" runat="server" OnClick="btnlbxToppings_Click" Text="Submit" />
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="ShortMonth" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
    
    </div>
    </form>
</body>
</html>

