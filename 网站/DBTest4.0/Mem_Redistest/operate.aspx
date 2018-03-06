<%@ Page Language="C#" AutoEventWireup="true" CodeFile="operate.aspx.cs" Inherits="Mem_Redistest_operate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Memcached &amp; Redis Incr/Decr测试：<br />
        <br />
        键：<asp:TextBox ID="key3" runat="server"></asp:TextBox>
&nbsp;<select id="Select1" runat="server">
            <option>+</option>
            <option>-</option>
        </select>
        <asp:TextBox ID="num" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Mem确定" Onclick="btnMemOperate"/>
    
    &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Redis确定" Onclick="btnReOperate"/>
    
    </div>
    </form>
</body>
</html>
