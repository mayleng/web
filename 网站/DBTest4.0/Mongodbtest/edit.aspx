<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="Mongodbtest_edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        MongoDB修改测试：<br />
        <br />
        集合名：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        条件键：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; 条件值：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        修改键：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp; 修改值：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnEditData"/>
    
    </div>
    </form>
</body>
</html>
