<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Remoting.aspx.cs" Inherits="WebApplication1.RemoteCall.Remoting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span>地址：</span><asp:TextBox runat="server" ID="Url" Text="localhost:18080/RemotingPersonService"></asp:TextBox>
        </div>
        <div>
            <span>返回：</span><asp:TextBox runat="server" Text="" ID="SendMessage"></asp:TextBox>
        </div>
        <div>
            <asp:Button runat="server" Text="发送" ID="SendBtn" OnClick="SendBtn_Click" />
        </div>
    </form>
</body>
</html>
