<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editdata.aspx.cs" Inherits="Mysqltest_editdata" %>

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
            <span style="font-size:larger;">MySql修改表数据测试：</span>
        </div>
        <div><span>*说明：修改表test，将id=1的数据，val值修改为2</span></div>
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
