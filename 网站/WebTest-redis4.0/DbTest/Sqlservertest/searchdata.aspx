<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchdata.aspx.cs" Inherits="Sqlservertest_searchdata" %>

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
                <span style="font-size:larger;">SQL Server查询表数据测试：</span>
            </div>
            <div>
                <span>*说明：查询表test数据</span>
            </div>
            <div>
                <span>连接类型：</span>
                <asp:DropDownList runat="server" ID="LinkType">
                    <asp:ListItem>OleDb</asp:ListItem>
                    <asp:ListItem>Odbc</asp:ListItem>
                    <asp:ListItem Selected="True">SqlClient</asp:ListItem>
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
        <asp:DataGrid runat="server" CssClass="DataList" AutoGenerateColumns="True" Id="dtg"></asp:DataGrid>
    </form>
</body>
</html>
