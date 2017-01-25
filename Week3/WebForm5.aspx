<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Week3.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="tbxLastName" runat="server"></asp:TextBox>
    
        <asp:Button ID="btnSearch" runat="server" Text="Search" />
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="sqldsLastName">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="sqldsLastName" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [FirstName], [LastName] FROM [Students] WHERE ([LastName] LIKE '%' + ? + '%')">
            <SelectParameters>
                <asp:ControlParameter ControlID="tbxLastName" Name="LastName" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
