﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insertdata.aspx.cs" Inherits="Mysqltest_insertdata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         MySql添加测试：<br />
        <br />
        表名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        主键：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        属性1：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        属性2：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        属性3：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        属性4：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnInsertData"/>
    
    </div>
    </form>
</body>
</html>
