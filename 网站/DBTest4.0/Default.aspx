<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <div class="jumbotron">
        <h1>测试网站！</h1>
            <p>&nbsp;</p>
    </div>
        
    请选择：<asp:Button ID="Button1" runat="server" Height="35px" Text="Oracle" Width="85px" Onclick="btnOracle"/>
&nbsp;<asp:Button ID="Button2" runat="server" Height="35px" Text="SqlServer" Width="104px" Onclick="btnSqlServer"/>
        &nbsp;<asp:Button ID="Button3" runat="server" Height="35px" Text="MySql" Width="85px" Onclick="btnMySql"/>
        &nbsp;<asp:Button ID="Button4" runat="server" Height="35px" Text="Mem&amp;Redis" Width="111px" Onclick="btnMem_Redis"/>
        &nbsp;<asp:Button ID="Button6" runat="server" Height="35px" Text="WebApi" Onclick="btnWebApi" Width="95px"/>
        <br />
    <br/>
            
    </asp:Content>