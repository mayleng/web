<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TestWebService.WebForm1" Async="true"%>

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
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="97px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="104px"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="105px" BackColor="Aqua"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox3_TextChanged" Width="105px" BackColor="#99FF99"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" Width="60px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="GetSupportProvince" Width="138px" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Multi" Width="60px" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Divide" Width="60px" />
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="OneWay" Width="114px" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="AsyncCallback" Width="120px" />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="AsyncWaitOne" Width="112px" style="height: 21px" />
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="AsyncCompleteEvent" Width="140px" />
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="AsyncPollComplete" Width="130px" style="height: 21px" />
        </p>
        <p>
            <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="SiteName" Width="140px" style="margin-top: 0px" />
        </p>
    </form>
</body>
</html>
