<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThriftMain.aspx.cs" Inherits="ThrfitWebClient.ThriftMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        welcome to thrit web test main page!
        <br />
        <br />
        <asp:Button ID="TriftBinaryBtn" runat="server" Height="32px" OnClick="ThriftClickEvent" Text="TriftBinary" Width="112px" />
        &nbsp;&nbsp;
        <asp:Button ID="TriftCompactBtn" runat="server" Height="31px" OnClick="ThriftClickEvent" Text="TriftCompact" Width="119px" />
        &nbsp;&nbsp;
        <asp:Button ID="TriftJsonBtn" runat="server" Height="31px" OnClick="ThriftClickEvent" Text="TriftJson" Width="117px" />
        <br />
        <br />
        <asp:Button ID="TriftTTLSSocketBtn" runat="server" Height="32px" OnClick="ThriftClickEvent" Text="TriftTTLSSocket" Width="112px" />
        &nbsp;&nbsp;
        <asp:Button ID="TriftTHttpClientBtn" runat="server" Height="31px" OnClick="ThriftClickEvent" Text="TriftTHttpClient" Width="120px" />
        &nbsp;&nbsp;
        <asp:Button ID="TriftNamePipeBtn" runat="server" Height="31px" OnClick="ThriftClickEvent" Text="TriftNamePipe" Width="115px" style="margin-left: 0px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="resultLb" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="RandomVisitBtn" runat="server" OnClick="RandomVisitBtn_Click" Text="RandomVisit" />
        <br />
    </div>
    </form>
</body>
</html>
