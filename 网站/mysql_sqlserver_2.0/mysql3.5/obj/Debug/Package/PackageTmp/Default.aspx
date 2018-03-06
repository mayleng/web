<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="mysql3._5._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
        .auto-style2 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        MySql测试：<br />
        <br />
        <span class="auto-style2">
        <br />
        创建：<br />
        <br />
        表名：</span><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="MySql创建" />
        &nbsp;
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Sql创建" />
        <br />
        <br />
        <br />
        添加：<br />
        <br />
        表名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp; 主键：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="MySql添加" />
        &nbsp;
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Sql添加" />
        <br />
        <br />
        <br />
        编辑：<br />
        <br />
        表名：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp; 属性：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp; 属性值：<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="MySql编辑" />
        &nbsp;
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Sql编辑" />
        <br />
        <br />
        <br />
        查询：<br />
        <br />
        表名：<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp; 属性：<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp; 属性值：<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="MySql查询" />
        &nbsp;
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Sql查询" />
        <br />
        <br />
        <br />
        删除：<br />
        <br />
        表名：<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="MySql删除表" />
&nbsp;
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Sql删除表" />
&nbsp; 属性：<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp; 属性值：<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="MySql删除" />
        &nbsp;
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Sql删除" />
        <br />
        <br />
        <br />
        <br />
    <asp:DataGrid runat="server" CssClass="DataList" AutoGenerateColumns="True" Id="DGT" ></asp:DataGrid>
    </form>
</body>
</html>
