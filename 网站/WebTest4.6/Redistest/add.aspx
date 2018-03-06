<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="Redistest_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Redis 数据添加：<br />
        <br />
        键:<asp:TextBox ID="key0" runat="server" Width="107px" OnTextChanged="key0_TextChanged"></asp:TextBox>
&nbsp; 值:<asp:TextBox ID="value0" runat="server" Width="105px"></asp:TextBox>
&nbsp; 生存时间(分钟):<asp:TextBox ID="expiret" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="ServiceStack添加" Onclick="btnRedisadd"/>
    
        &nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="StackExchange添加" />
&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="NServiceKit添加" />
        <br />
    
        <br />
        <br />
        HashSet:<br />
        <br />
        Key:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; Field:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp; Value:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="ServiceStack添加" OnClick="btnRedisHadd"/>
    
    &nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="StackExchange添加" />
&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="NServiceKit添加" />
        <br />
        <br />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="返回" />
    
    </div>
    </form>
</body>
</html>
