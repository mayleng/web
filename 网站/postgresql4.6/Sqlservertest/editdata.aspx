<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editdata.aspx.cs" Inherits="Sqlservertest_editdata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        MS SqlServer编辑测试：<br />
        <br />
        表名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        条件属性：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp; 条件值：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        修改属性：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp; 修改值：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnEditData"/>
    
    </div>
    </form>
</body>
</html>
