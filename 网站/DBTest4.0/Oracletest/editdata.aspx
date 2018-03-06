<%@ Page Title="编辑" Language="C#" AutoEventWireup="true" CodeFile="editdata.aspx.cs" Inherits="editdata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
           Oracle修改数据测试！<br />
        <br />
        &nbsp;&nbsp;&nbsp;
        表名：<asp:TextBox ID="tb0" runat="server"></asp:TextBox>
    
        <br />
        <br />
        &nbsp;
        条件属性：<asp:TextBox ID="tb1" runat="server"></asp:TextBox>
&nbsp; 条件值：<asp:TextBox ID="tb2" runat="server"></asp:TextBox>
           <br />
        <br />
        &nbsp;&nbsp;&nbsp; 属性: <asp:TextBox ID="tb3" runat="server"></asp:TextBox>
&nbsp; 修改值：<asp:TextBox ID="tb4" runat="server"></asp:TextBox>
           <br />
           <br />
&nbsp;&nbsp; 修改状态： 
           <asp:TextBox ID="TextBox1" runat="server" Height="21px" OnTextChanged="TextBox1_TextChanged" Width="237px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btneditdata"/>
    
    &nbsp;&nbsp;
           <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="返回" />
&nbsp;</div>
    </form>
</body>
</html>
