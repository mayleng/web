<%@ Page Title="添加" Language="C#" AutoEventWireup="true" CodeBehind="insertdata.aspx.cs" Inherits="WebApplication1.insertdata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          Oracle增加数据测试！<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        表名： <asp:TextBox ID="tt0" runat="server"></asp:TextBox>
        &nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        主键： <asp:TextBox ID="tt1" runat="server"></asp:TextBox>
          <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        属性1：<asp:TextBox ID="tt2" runat="server"></asp:TextBox>
          <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 添加状态：<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="bt1" runat="server" Text="确定" Onclick="btninsertdata"/>
        &nbsp;&nbsp;&nbsp;
          <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="返回" />
        <br />
    
    </div>
    </form>
</body>
</html>
