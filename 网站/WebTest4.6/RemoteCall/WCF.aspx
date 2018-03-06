<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WCF.aspx.cs" Inherits="WebApplication1.RemoteCall.WCF" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" Text="" ID="SendMessage"></asp:TextBox><asp:Button runat="server" Text="发送" ID="SendBtn" OnClick="SendBtn_Click" />
        </div>
    </form>
</body>
</html>
