<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deletedata.aspx.cs" Inherits="Mysqltest_deletedata" %>

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
            <span style="font-size:larger;">MySql删除表测试：</span>
        </div>
        <div><span>*说明：删除表test</span></div>
        <div>
            <asp:TextBox ID="SQLText" runat="server" Font-Size="Larger" Width="50%" TextMode="MultiLine"></asp:TextBox>
        </div>        
        <div>
            <asp:Button ID="SubmitBtn" runat="server" Text="确定" Onclick="btnDleData"/>
            <asp:Button ID="BackupBtn" runat="server" OnClick="Button2_Click" Text="返回" />
        </div>
    </div>
    </form>
</body>
</html>
