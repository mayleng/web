<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pend.aspx.cs" Inherits="Redistest_pend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Redis 插值测试：<br />
        <br />
        pend键：<asp:TextBox ID="pendkey" runat="server" Text="test"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="ServiceStack确定" Onclick="btnRePend"/>
    
    &nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="StackExchange确定" />
&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="NServiceKit确定" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="返回" />
    
    </div>
    </form>
</body>
</html>
