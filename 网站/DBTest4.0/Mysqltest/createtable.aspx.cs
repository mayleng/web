using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;

public partial class Mysqltest_createtable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreateTable(object sender,EventArgs e)
    {
        string tablename = TextBox0.Text.Trim();
        string key = TextBox1.Text.Trim();
        string prop1 = TextBox2.Text.Trim();
        string prop2 = TextBox3.Text.Trim();
        string prop3 = TextBox4.Text.Trim();
        string prop4 = TextBox5.Text.Trim();

        MySqlConnection MySqlconn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString.ToString());
        //MySqlconn.ConnectionString = "server=192.168.1.63;database=yucw;uid=root;pwd=Abc888";
        MySqlconn.Open();

        string MySqlcommand = "create table " + tablename + '(' + key + " int primary key,"
                                                        + prop1 + " varchar(30) not null,"
                                                        + prop2 + " varchar(20) not null,"
                                                        + prop3 + " int,"
                                                        + prop4 + " int)";
        MySqlCommand cmd = new MySqlCommand(MySqlcommand, MySqlconn);
        
        try
        {
            int i = cmd.ExecuteNonQuery();
            if (i == 0)
            {
                Response.Write("<script>window.alert('创建表成功！');window.location.href='../MysqlTest.aspx'</script>");
            }
        }
        catch
        {
            Response.Write("<script>window.alert('创建表失败！');window.location.href='../MysqlTest.aspx'</script>");
        }
        finally
        { MySqlconn.Close(); }
    }
}