using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using MySql.Data.MySqlClient;
public partial class Mysqltest_searchdata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearchData(object sender,EventArgs e)
    {
        string tablename = TextBox1.Text.Trim();
        string prop = TextBox2.Text.Trim();
        string val = TextBox3.Text.Trim();

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
        MySqlcommand = "SELECT * FROM " + tablename + " WHERE " + prop + '=' + val;
        try
        {
            cmd = new MySqlCommand(MySqlcommand, MySqlconn);
            MySqlDataReader myreader = cmd.ExecuteReader();
            if (myreader.Read())
                Response.Write("<script>window.alert('你好！');</script>");
            else
                throw new Exception("写错啦!");
            myreader.Close();
            MySqlDataAdapter da = new MySqlDataAdapter(MySqlcommand, MySqlconn);
            DataSet dataset = new DataSet();
            da.Fill(dataset, tablename);
            dtg.DataSource = dataset.Tables[tablename];
        }
        catch
        {
            Response.Write("<script>window.alert('查询失败！');window.location.href='../MysqlTest.aspx'</script>");
        }
        finally
        {
            if (MySqlconn != null)
            {
                MySqlconn.Close();
            }
        }
        dtg.DataBind();
    }

    protected void btnBack(object sender, EventArgs e)
    {
        Response.Redirect("../MysqlTest.aspx");
    }
}