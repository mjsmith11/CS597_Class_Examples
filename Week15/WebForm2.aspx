<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Week15.WebForm2" %>

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
            <asp:UpdatePanel ID="SampleUpdatePanel" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label ID="lblHello" Text="Please click the button for an AJAX demo" runat="server"></asp:Label>
                    <br />
                    <asp:Button runat="server" ID="btnHello" Text="Ok" onClick="btnHello_Click"/>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnProgress" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:UpdateProgress runat="server" ID="PageUpdateProgress">
                <ProgressTemplate>
                    Loading...
                </ProgressTemplate>    
            </asp:UpdateProgress>
            <asp:UpdatePanel runat="server" ID="pnlUpdate">
                <ContentTemplate>
                    <asp:Button runat="server" ID="btnProgress" OnClick="btnProgress_Click" Text="Progress Demo" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:Timer runat="server" ID="updateTimer" Interval="10000" OnTick="updateTimer_Tick"></asp:Timer>
        </div>
    </form>
</body>
</html>
