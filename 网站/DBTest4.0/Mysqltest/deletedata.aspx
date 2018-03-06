<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deletedata.aspx.cs" Inherits="Mysqltest_deletedata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    MySql删除测试：<br />
        <br />
        表名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        属性：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp; 属性值：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnDleData"/>
    </div>
    </form>
</body>
</html>
