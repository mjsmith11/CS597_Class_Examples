<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Week3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlStates" runat="server" DataSourceID="sqldsStates" DataTextField="State" DataValueField="State" AutoPostBack="True">
        </asp:DropDownList>
    
        <br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="sqldsStateSearch">
        </asp:GridView>
    
    </div>
        <asp:SqlDataSource ID="sqldsStates" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT [State] FROM [Students]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="sqldsStateSearch" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Students] WHERE ([State] = ?)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlStates" Name="State" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
