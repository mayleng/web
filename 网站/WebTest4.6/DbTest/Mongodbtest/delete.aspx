<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="Mongodbtest_delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        MongoDB删除测试：<br />
        <br />
        集合名：<asp:TextBox ID="TextBox3" runat="server" Text="test"></asp:TextBox>
        <br />
        <br />
        键：<asp:TextBox ID="TextBox1" runat="server" Text="key1"></asp:TextBox>
&nbsp; 值：<asp:TextBox ID="TextBox2" runat="server" Text="1"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnDeleData"/>
        <asp:Button ID="Back" runat="server" Text="返回" OnClick="Back_Click" />
    </div>
    </form>
</body>
</html>
