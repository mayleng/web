<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="look.aspx.cs" Inherits="Memcachetest_look" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Memcached查找测试：<br />
        <br />
        键：<asp:TextBox ID="key1" runat="server" Text="test"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Enyim.Caching.Memcached查找" Onclick="btnMemLook"/>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Memcached.ClientLibrary查找" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="BeITMemcached查找" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="返回" />
        <br />
    
    </div>
    </form>
</body>
</html>
