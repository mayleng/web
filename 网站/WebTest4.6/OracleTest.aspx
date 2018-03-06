<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OracleTest.aspx.cs" Inherits="WebApplication1.OracleTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Oracle数据库测试：<br />
        <br />
        <asp:Button ID="Button0" runat="server" Text="创建表" Onclick="btnCreateTable"/>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="添加" Onclick="btnAddData"/>
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="删除" Onclick="btnDeleteData"/>
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="编辑" Onclick="btnEditData"/>
&nbsp;
        <asp:Button ID="Button4" runat="server" Text="查找" Onclick="btnSearchData"/>
    
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="返回" Onclick="btnBackD"/>
    
    </div>
    </form>
</body>
</html>
