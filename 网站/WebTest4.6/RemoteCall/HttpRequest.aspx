<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HttpRequest.aspx.cs" Inherits="WebApplication1.RemoteCall.HttpRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span>URL</span><asp:TextBox ID="Url" runat="server" Text="http://localhost:8099/Service/MVCServer/api/Test/TestPost"></asp:TextBox>
        </div>
        <div>
            <span>ContentType</span><asp:TextBox ID="ContentType" runat="server"></asp:TextBox>
        </div>
        <div>
            <span>POST</span><asp:TextBox ID="Data" runat="server" Text="message=I send message to http."></asp:TextBox>
        </div>
        <div>
            <asp:Button runat="server" ID="Submit" Text="确定" OnClick="Submit_Click" />
        </div>
        <div>
            <span>Response</span><asp:TextBox ID="Response" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
