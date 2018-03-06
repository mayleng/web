<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemcacheTest.aspx.cs" Inherits="MemcacheTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Memcached操作测试<br />
        <br />
        请选择： 
        <asp:Button ID="Button1" runat="server" Text="添加" Onclick="btnadd"/>
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="查找" Onclick="btnlook"/>
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="运算" Onclick="btnoperate"/>
&nbsp;
        <asp:Button ID="Button4" runat="server" Text="删除" Onclick="btndelte"/>

        &nbsp;
        <asp:Button ID="Button7" runat="server" Text="追加" Onclick="btnpend"/>
        &nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="返回" Onclick="btnback"/>
    </form>
</body>
</html>
