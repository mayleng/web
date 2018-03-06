<%@ Page Language="C#" AutoEventWireup="true" CodeFile="look.aspx.cs" Inherits="Mem_Redistest_look" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Memcached &amp; Redis 查找测试：<br />
        <br />
        键：<asp:TextBox ID="key1" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Mem查找" Onclick="btnMemLook"/>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Redis查找" Onclick="btnRedisLook"/>
    
        <br />
        <br />
        多键：<asp:TextBox ID="mulget" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Mem多键查找" Onclick="btnMemMullook"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Redis多键查找" Onclick="btnRedisMullook"/>
        <br />
        <br />
        Field:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; Key:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button5" runat="server" Text="RedisHGet" OnClick="btnRedisHlook"/>
        <br />
    
    </div>
    </form>
</body>
</html>
