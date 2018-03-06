<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="Memcachetest_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Memcached数据添加：<br />
        <br />
        键:<asp:TextBox ID="key0" runat="server" Width="107px"></asp:TextBox>
&nbsp; 值:<asp:TextBox ID="value0" runat="server" Width="105px"></asp:TextBox>
&nbsp; 生存时间(分钟):<asp:TextBox ID="expiret" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Enyim.Caching.Memcached添加" Onclick="btnMemadd"/>
    
    &nbsp;&nbsp;<br />
        &nbsp;&nbsp;
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Memcached.ClientLibrary添加" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="BeITMemcached添加" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="返回" />
    
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
