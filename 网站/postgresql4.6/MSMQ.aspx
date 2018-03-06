<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MSMQ.aspx.cs" Inherits="WebApplication1.RemoteCall.MSMQ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="SendText"></asp:TextBox><asp:Button runat="server" ID="SendBtn" Text="Send" OnClick="SendBtn_Click" />
        </div>
        <div>
            <asp:TextBox runat="server" ID="ReceiveText"></asp:TextBox><asp:Button runat="server" ID="ReceiveBtn" Text="Receive" OnClick="ReceiveBtn_Click" />
        </div>
    </form>
</body>
</html>
