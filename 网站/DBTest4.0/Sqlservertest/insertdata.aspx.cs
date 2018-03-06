using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class Sqlservertest_insertdata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertData(object sender,EventArgs e)
    {
        string tablename = TextBox1.Text.Trim();
        string key = TextBox2.Text.Trim();
        string prop1 = TextBox3.Text.Trim();
        string prop2 = TextBox4.Text.Trim();
        string prop3 = TextBox5.Text.Trim();
        string prop4 = TextBox6.Text.Trim();

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
        Sqlcommand = "insert into " + '"' + tablename + '"' + " values(" + key + ",'" + prop1 + "','" + prop2 + "'," + prop3 + ',' + prop4 + ')';
        cmd = new SqlCommand(Sqlcommand, Sqlconn);
        try
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Write("<script>window.alert('添加成功！');window.location.href='../SqlserverTest.aspx'</script>");
            }
            else
            {
                Response.Write("<script>window.alert('添加失败！');window.location.href='../SqlserverTest.aspx'</script>");
            }
        }
        catch
        {
            Response.Write("<script>window.alert('添加失败！');window.location.href='../SqlserverTest.aspx'</script>");
        }
        finally
        { Sqlconn.Close(); }
    }
}