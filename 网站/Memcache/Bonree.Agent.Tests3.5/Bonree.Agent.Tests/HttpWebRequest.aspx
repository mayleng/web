<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeBehind="BonreeHttpWebRequest.aspx.cs" Inherits="Bonree.Agent.Tests.BonreeHttpWebRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        HttpWebRequest test, System.dll<br />
        <br />
        <asp:TextBox ID="httpWebRequestTb" runat="server" Height="317px" TextMode="MultiLine" Width="570px"></asp:TextBox>
    
        <br />
        <br />
        <asp:Button ID="GetResponseBtn" runat="server" OnClick="GetResponseBtn_Click" Text="GetResponse" />
    
        &nbsp;<asp:Button ID="GetAsync" runat="server" Height="19px" OnClick="GetAsync_Click" Text="GetAsync" Width="142px" style="margin-right: 0px; margin-top: 0px" />
    
        &nbsp;<asp:Button ID="Post" runat="server" Height="19px" OnClick="Post_Click" Text="Post" Width="142px" style="margin-right: 0px; margin-top: 0px" />
    
    </div>
    </form>
</body>
</html>
