using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;

public partial class Mysqltest_editdata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEditData(object sender,EventArgs e)
    {
        string tablename = TextBox1.Text.Trim();
        string key = TextBox2.Text.Trim();
        string keyval = TextBox3.Text.Trim();
        string uprop = TextBox4.Text.Trim();
        string uval = TextBox5.Text.Trim();

        MySqlConnection MySqlconn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString.ToString());
        //MySqlconn.ConnectionString = "server=192.168.1.63;database=yucw;uid=root;pwd=Abc888";
        MySqlconn.Open();

        string MySqlcommand = "select * from yucw." + tablename;
        MySqlCommand cmd = new MySqlCommand(MySqlcommand, MySqlconn);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch
        {
            Response.Write("<script>window.alert('该表不存在！');window.location.href='../MysqlTest.aspx'</script>");
        }
        MySqlcommand = "update " + tablename + " set " + uprop + '=' + uval + " where " + key + '=' + keyval;
        cmd = new MySqlCommand(MySqlcommand, MySqlconn);
        try
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("<script>window.alert('编辑成功！');window.location.href='../MysqlTest.aspx'</script>");
            }
            else
            {
                Response.Write("<script>window.alert('编辑失败！');window.location.href='../MysqlTest.aspx'</script>");
            }
        }
        catch
        {
            Response.Write("<script>window.alert('编辑失败！');window.location.href='OracleTest.aspx'</script>");
        }
        finally
        { MySqlconn.Close(); }
    }
}