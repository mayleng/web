<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="WcfTest.aspx.cs" Inherits="WcfClient.WcfTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="31px" OnTextChanged="TextBox1_TextChanged" Width="256px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="35px" OnClick="Button1_Click" Text="测试WCF服务" Width="99px" />
            <asp:Button ID="Button2" runat="server" Height="35px" OnClick="Button2_Click" Text="测试WCF数据契约" Width="134px" />
            <asp:Button ID="Button3" runat="server" Height="35px" OnClick="Button3_Click" Text="异步WCF（没有回调）" Width="134px" />
            <asp:Button ID="Button4" runat="server" Height="35px" OnClick="Button4_Click" Text="异步WCF（有回调）" Width="134px" />
            <asp:Button ID="Button5" runat="server" Height="35px" OnClick="Button5_Click" Text="AsyncInvoke" Width="134px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
