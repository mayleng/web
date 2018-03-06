<%@ Page Language="C#" AutoEventWireup="true" CodeFile="delete.aspx.cs" Inherits="Mongodbtest_delete" %>

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
        集合名：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        键：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; 值：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnDeleData"/>
    
    </div>
    </form>
</body>
</html>
