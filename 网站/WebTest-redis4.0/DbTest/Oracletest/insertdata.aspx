﻿<%@ Page Title="添加" Language="C#" AutoEventWireup="true" CodeBehind="insertdata.aspx.cs" Inherits="WebApplication1.insertdata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>    
            <div>
                <span style="font-size:larger;">Oracle表插入记录测试：</span>
            </div>
            <div>
                <span>*说明：表test插入数据，插入id=1,val=1的数据</span>
            </div>
            <div>
                <span>连接类型：</span>
                <asp:DropDownList runat="server" ID="LinkType">
                    <asp:ListItem>OracleClient</asp:ListItem>
                    <asp:ListItem>Oracle.DataAccess</asp:ListItem>
                    <asp:ListItem Selected="True">Oracle.ManagedDataAccess</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div>
                <asp:TextBox ID="SQLText" runat="server" Font-Size="Larger" Width="50%" TextMode="MultiLine"></asp:TextBox>
            </div>        
            <div>
                <asp:Button ID="SubmitBtn" runat="server" Text="确定" OnClick="SubmitBtn_Click"/>
                <asp:Button ID="BackupBtn" runat="server" Text="返回" OnClick="BackupBtn_Click" />
            </div>
        </div>
    </form>
</body>
</html>
