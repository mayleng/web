<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create_add.aspx.cs" Inherits="WebApplication1.Mongodbtest2.create_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>        
        MongoDB创建集合&amp;添加测试：<br />
        <br />
        集合名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        键1：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp; 值1：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        键2：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp; 值2：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        键3：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp; 值3：<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnCreate_Add"/>
        &nbsp;
        <asp:Button ID="Button2" runat="server" Text="返回" Onclick="btnBack"/>
    </div>
    </form>
</body>
</html>
