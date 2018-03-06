<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemcacheClientLibrary.aspx.cs" Inherits="Bonree.Agent.Tests.MemcacheMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        MemcacheClient.dll test<br />
        <asp:TextBox ID="nosqlTb" runat="server" Height="319px" TextMode="MultiLine" Width="468px"></asp:TextBox>
    
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="BeITMemcached" />
    
    &nbsp;<asp:Button ID="Button2" runat="server" OnClick="OnEnyimMemcachedClicked" Text="EnyimMemcached" />
    
    </div>
    </form>
</body>
</html>
