<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createtable.aspx.cs" Inherits="Sqlservertest_createtable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        MS SqlServer创建表测试：<br />
        连接类型：<asp:DropDownList runat="server" ID="LinkType">
            <asp:ListItem>OleDb</asp:ListItem>
            <asp:ListItem>Odbc</asp:ListItem>
            <asp:ListItem Selected="True">SqlClient</asp:ListItem>
        </asp:DropDownList>
        <br />
        表名：<asp:TextBox ID="TextBox0" runat="server"></asp:TextBox>
        <br />
        主键：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        属性1：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        属性2：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        属性3：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        属性4：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox6" runat="server" Width="461px"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox7" runat="server" Width="461px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnCreateTable"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="自动填写" />
    
    </div>
    </form>
</body>
</html>
