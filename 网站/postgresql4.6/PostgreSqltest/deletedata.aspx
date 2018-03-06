<%@ Page Title="删除" Language="C#" AutoEventWireup="true" CodeBehind="deletedata.aspx.cs" Inherits="WebApplication1.postgresqltest_deletedata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        PostgreSql删除数据测试！<br />
        <br />
        表名：<asp:TextBox ID="t0" runat="server"></asp:TextBox>
    
        <br />
        <br />
        属性：<asp:TextBox ID="t1" runat="server"></asp:TextBox>
        &nbsp; 属性值：<asp:TextBox ID="t2" runat="server"></asp:TextBox>
        <br />
        <br />
        删除数据状态：&nbsp; 
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="215px"></asp:TextBox>
        <br />
        <br />
&nbsp;删除表状态：&nbsp;&nbsp; 
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="208px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="删除数据" Onclick="btndeletedata"/>
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="删除表" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="返回" />
    </div>
    </form>
</body>
</html>
