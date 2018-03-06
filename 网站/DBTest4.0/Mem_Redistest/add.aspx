<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="Mem_Redistest_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Memcached &amp; Redis 数据添加：<br />
        <br />
        键:<asp:TextBox ID="key0" runat="server" Width="107px" OnTextChanged="key0_TextChanged"></asp:TextBox>
&nbsp; 值:<asp:TextBox ID="value0" runat="server" Width="105px"></asp:TextBox>
&nbsp; 生存时间(分钟):<asp:TextBox ID="expiret" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Mem添加" Onclick="btnMemadd"/>
    
    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Redis添加" Onclick="btnRedisadd"/>
    
        <br />
        <br />
        HashSet:<br />
        <br />
        Key:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; Field:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp; Value:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="RedisHset" OnClick="btnRedisHadd"/>
    
    </div>
    </form>
</body>
</html>
