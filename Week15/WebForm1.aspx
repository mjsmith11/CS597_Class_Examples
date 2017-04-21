<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Week15.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="SampleScriptManager" runat="server" />
            <br />
            <!--if I cause an event inside this, only controls involved in here are posted-->
            <asp:UpdatePanel ID="SampleUpdatePanel" runat="server">
                <ContentTemplate>
                    <asp:Label ID="lblHello" Text="Please click the button for an AJAX demo" runat="server"></asp:Label>
                    <br />
                    <asp:Button runat="server" ID="btnHello" Text="Ok" onClick="btnHello_Click"/>
                </ContentTemplate>
            </asp:UpdatePanel>

                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" Text="Please click the button for an AJAX demo" runat="server"></asp:Label>
                    <br />
                    <asp:Button runat="server" ID="Button1" Text="Ok" onClick="btnHello_Click"/>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
