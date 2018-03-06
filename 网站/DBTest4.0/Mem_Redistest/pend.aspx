<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pend.aspx.cs" Inherits="Mem_Redistest_pend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Memcached &amp; Redis 插值测试：<br />
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
        <asp:Button ID="Button1" runat="server" Text="Mem确定" Onclick="btnMemPend"/>
    
    &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Redis确定" Onclick="btnRePend"/>
    
    </div>
    </form>
</body>
</html>
