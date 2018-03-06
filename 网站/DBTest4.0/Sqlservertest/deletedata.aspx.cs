using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class Sqlservertest_deletedata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDleData(object sender,EventArgs e)
    {
        string tablename = TextBox1.Text.Trim();
        string key = TextBox2.Text.Trim();
        string keyval = TextBox3.Text.Trim();

        SqlConnection Sqlconn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString.ToString());
        //Sqlconn.ConnectionString = "server=192.168.1.41;database=yucw;uid=sa;pwd=Abc88888";
        if (Sqlconn.State == ConnectionState.Closed)
        { Sqlconn.Open(); }

        string Sqlcommand = "select * from dbo." + '"' + tablename + '"';
        SqlCommand cmd = new SqlCommand(Sqlcommand, Sqlconn);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch
        {
            Response.Write("<script>window.alert('该表不存在！');window.location.href='../SqlserverTest.aspx'</script>");
        }
        Sqlcommand = "delete from " + '"' + tablename + '"' + " where " + '"' + key + '"' + '=' + keyval;
        cmd = new SqlCommand(Sqlcommand, Sqlconn);
        try
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("<script>window.alert('删除成功！');window.location.href='../SqlserverTest.aspx'</script>");
            }
            else
            {
                Response.Write("<script>window.alert('删除失败！');window.location.href='../SqlserverTest.aspx'</script>");
            }
        }
        catch
        {
            Response.Write("<script>window.alert('删除失败！');window.location.href='../SqlserverTest.aspx'</script>");
        }
        finally
        { Sqlconn.Close(); }
    }
}