<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createtable.aspx.cs" Inherits="Mysqltest_createtable" %>

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
            <span style="font-size:larger;">MySql创建表测试：</span>
        </div>
        <div>
            <span>*说明：创建表test，主键：id，列：val。若表已存在，则先删除表后创建</span>
        </div>
        <div>
            <asp:TextBox ID="TextBox7" runat="server" Font-Size="Larger" Width="50%" TextMode="MultiLine"></asp:TextBox>
        </div>        
        <div>
            <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnCreateTable"/>
            <asp:Button ID="Button4" runat="server" OnClick="Button2_Click" Text="返回" />
        </div>
    </div>
    </form>
</body>
</html>
