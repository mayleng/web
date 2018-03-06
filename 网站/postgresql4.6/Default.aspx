<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <div class="jumbotron">
        <h1>测试网站！</h1>
            <p>&nbsp;</p>
    </div>
        
    请选择：<asp:Button ID="Button1" runat="server" Height="35px" Text="Oracle" Width="85px" Onclick="btnOracle"/>
        &nbsp;<asp:Button ID="Button2" runat="server" Height="35px" Text="SqlServer" Width="104px" Onclick="btnSqlServer"/>
        &nbsp;<asp:Button ID="Button3" runat="server" Height="35px" Text="MySql" Width="85px" Onclick="btnMySql"/>
        &nbsp;
        <asp:Button ID="Button9" runat="server" Height="35px" OnClick="Button9_Click" Text="PostgresSql" />
&nbsp; <asp:Button ID="Button4" runat="server" Height="35px" Text="Memcache" Width="111px" Onclick="btnMem_Redis"/>
        &nbsp;<asp:Button ID="Button8" runat="server" Height="35px" OnClick="Button8_Click" Text="Redis" Width="76px" />
&nbsp; <asp:Button ID="Button5" runat="server" Height="35px" Text="Mongodb" Width="111px" Onclick="btnMongoDB"/>
        &nbsp;<asp:Button ID="Button6" runat="server" Height="35px" Text="WebApi" Onclick="btnWebApi" Width="95px"/>
        &nbsp;<asp:Button ID="Button10" runat="server" Height="35px" OnClick="Button10_Click" Text="MSMQ" />
&nbsp;
        <asp:Button ID="Button7" runat="server" Height="35px" OnClick="Button7_Click" Text="Entity Framework" />
        <br />
    <br/>
            
    </asp:Content>