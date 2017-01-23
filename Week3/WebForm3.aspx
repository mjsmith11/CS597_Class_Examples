<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Week3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="SSN" DataSourceID="sqldsCredits">
            <Columns>
                <asp:BoundField DataField="SSN" HeaderText="SSN" ReadOnly="True" SortExpression="SSN" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" SortExpression="PostalCode" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" SortExpression="BirthDate" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Credits" HeaderText="Credits" SortExpression="Credits" />
                <asp:BoundField DataField="QualityPoints" HeaderText="QualityPoints" SortExpression="QualityPoints" />
                <asp:CheckBoxField DataField="FinancialAid" HeaderText="FinancialAid" SortExpression="FinancialAid" />
                <asp:BoundField DataField="Campus" HeaderText="Campus" SortExpression="Campus" />
                <asp:BoundField DataField="Major" HeaderText="Major" SortExpression="Major" />
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:SqlDataSource ID="sqldsCredits" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Students] WHERE (([Credits] &gt;= ?) AND ([State] = ?))">
            <SelectParameters>
                <asp:Parameter DefaultValue="60" Name="Credits" Type="Int16" />
                <asp:Parameter DefaultValue="FL" Name="State" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
