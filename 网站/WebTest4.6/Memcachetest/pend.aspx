<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pend.aspx.cs" Inherits="Memcachetest_pend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Memcached 插值测试：<br />
        <br />
        pend键：<asp:TextBox ID="pendkey" runat="server"></asp:TextBox>
        <br />
        <br />
        <select id="Sele" runat="server">
            <option>Append</option>
            <option>Prepend</option>
        </select>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Enyim.Caching.Memcached确定" Onclick="btnMemPend"/>
    
    &nbsp;&nbsp;<br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Memcached.ClientLibrary确定" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="BeITMemcached确定" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="返回" />
    
    </div>
    </form>
</body>
</html>
