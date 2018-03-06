<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="look.aspx.cs" Inherits="Redistest_look" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Redis 查找测试：<br />
        <br />
        键：<asp:TextBox ID="key1" runat="server" Text="test"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="ServiceStack查找" Onclick="btnRedisLook"/>
    
        &nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="StackExchange查找" />
&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="NServiceKit查找" />
    
        <br />
        <br />
        多键：<asp:TextBox ID="mulget" runat="server" Text="test"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" Text="ServiceStack查找" Onclick="btnRedisMullook"/>
        &nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="StackExchange查找" />
&nbsp;&nbsp;
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="NServiceKit查找" />
        <br />
        <br />
        Field:<asp:TextBox ID="TextBox1" runat="server" Text="testField"></asp:TextBox>
&nbsp; Key:<asp:TextBox ID="TextBox2" runat="server" Text="test"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button5" runat="server" Text="ServiceStackHGet" OnClick="btnRedisHlook"/>
        &nbsp;&nbsp;
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="StackExchangeHGet" />
&nbsp;&nbsp;
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="NServiceKitHGet" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="返回" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
