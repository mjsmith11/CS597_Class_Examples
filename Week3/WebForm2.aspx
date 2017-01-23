<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Week3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="tbxMajor" runat="server"></asp:TextBox>
        <asp:Button ID="btnCalculate" runat="server" Text="Search" />
        <!--The button triggers a refresh, thus no event handler is required to update the GridView-->
        <br />
        <br />
    
        <asp:GridView ID="gvDisplay" runat="server" AutoGenerateColumns="False" DataSourceID="sqldsMajor">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Major" HeaderText="Major" SortExpression="Major" />
                <asp:BoundField DataField="Credits" HeaderText="Credits" SortExpression="Credits" />
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:SqlDataSource ID="sqldsMajor" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [FirstName], [LastName], [Gender], [Major], [Credits] FROM [Students] WHERE ([Major] = ?)">
            <SelectParameters>
                <asp:ControlParameter ControlID="tbxMajor" Name="Major" PropertyName="Text" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
