<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Mongodbtest_search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        MongoDB查询测试：<br />
        <br />
        集合名：<asp:TextBox ID="TextBox1" runat="server" Text="test"></asp:TextBox>
        <br />
        <br />
        条件键：<asp:TextBox ID="TextBox2" runat="server" Text="key1"></asp:TextBox>
&nbsp; 条件值：<asp:TextBox ID="TextBox3" runat="server" Text="1"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnSearchData"/>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="返回" Onclick="btnBack"/>
    
        <br />
        <br />
        <asp:TextBox ID="TextBox4" runat="server" Height="50px" Width="650px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
