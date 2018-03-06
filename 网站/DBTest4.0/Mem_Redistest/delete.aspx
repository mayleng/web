<%@ Page Language="C#" AutoEventWireup="true" CodeFile="delete.aspx.cs" Inherits="Mem_Redistest_delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Memcached &amp; Redis 删除测试：<br />
        <br />
        键：<asp:TextBox ID="key2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Mem删除" Onclick="btnMemDelete"/>
    
    &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Redis删除" Onclick="btnReDelete"/>
    
    </div>
    </form>
</body>
</html>
