<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebService.aspx.cs" Inherits="WebApplication1.RemoteCall.WebService" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" ID="Submit" Text="调用" OnClick="Submit_Click" />
        </div>
        <div>
            <span>Response by sync</span><asp:TextBox ID="Response" runat="server"></asp:TextBox>
        </div>
        <div>
            <span>Response by async</span><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
