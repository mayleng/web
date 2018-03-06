<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="operate.aspx.cs" Inherits="Redistest_operate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Redis Incr/Decr测试：<br />
        <br />
        键：<asp:TextBox ID="key3" runat="server"></asp:TextBox>
&nbsp;<select id="Select1" runat="server">
            <option>+</option>
            <option>-</option>
        </select>
        <asp:TextBox ID="num" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="ServiceStack确定" Onclick="btnReOperate"/>
    
        　　<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="StackExchange确定" />
        　　<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="NServiceKit确定" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="返回" />
    
    </div>
    </form>
</body>
</html>
