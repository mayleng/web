<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostgreSqlTest.aspx.cs" Inherits="WebApplication1.PostgreSqlTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="创建表" />
&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="添加" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="查找" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="删除" />
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="返回" />
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
