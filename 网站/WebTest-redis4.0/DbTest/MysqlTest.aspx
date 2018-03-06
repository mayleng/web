<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MysqlTest.aspx.cs" Inherits="MysqlTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        MySql数据库测试：<br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="21px" Text="创建表" Width="62px" Onclick="btnCreate"/>
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="插入数据" Onclick="btnInsert"/>
        &nbsp;
        <asp:Button ID="Button6" runat="server" Text="查询数据" Onclick="btnSearch"/>
&nbsp;
        <asp:Button ID="Button5" runat="server" Text="编辑数据" Onclick="btnEdit"/>
        &nbsp;
        <asp:Button ID="Button4" runat="server" Text="删除表" Onclick="btnDelete"/>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="返回" Onclick="btnBack"/>
    
    </div>
    </form>
</body>
</html>
