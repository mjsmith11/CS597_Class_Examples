﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HelloWorld.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!--<p>Hello World</p>-->
        <asp:TextBox ID="tbxName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnHello" runat="server" Text="Say Hello" OnClick="btnHello_Click" />
    </div>
    </form>
</body>
</html>
