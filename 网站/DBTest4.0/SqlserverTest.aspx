<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SqlserverTest.aspx.cs" Inherits="SqlserverTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        MS SqlServer数据库测试：<br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="创建表" Onclick="btnCreate"/>
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="添加" Onclick="btnInsert"/>
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="删除" Onclick="btnDelete"/>
&nbsp;
        <asp:Button ID="Button4" runat="server" Text="编辑" Onclick="btnEdit"/>
&nbsp;
        <asp:Button ID="Button5" runat="server" Text="查找" Onclick="btnSearch"/>
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="返回" Onclick="btnBack"/>
    
    </div>
    </form>
</body>
</html>
