﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MongodbTest2.aspx.cs" Inherits="WebApplication1.MongodbTest2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        MongoDB Legacy数据库测试：<br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="创建&amp;添加" Onclick="btnCreate_Add"/>
        &nbsp;
        <asp:Button ID="Button2" runat="server" Text="删除" Onclick="btnDelete"/>
        &nbsp;
        <asp:Button ID="Button3" runat="server" Text="修改" Onclick="btnEdit"/>
        &nbsp;
        <asp:Button ID="Button4" runat="server" Text="查询" Onclick="btnSearch"/>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="返回" Onclick="btnBack"/>
    </div>
    </form>
</body>
</html>
