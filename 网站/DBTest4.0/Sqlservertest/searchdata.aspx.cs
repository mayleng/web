using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class Sqlservertest_searchdata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearchData(object sender,EventArgs e)
    {
        string tablename = TextBox1.Text.Trim();
        string prop = TextBox2.Text.Trim();
        string val = TextBox3.Text.Trim();

        SqlConnection Sqlconn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString.ToString()
                                                    + ";MultipleActiveResultSets=true");
        //Sqlconn.ConnectionString = "server=192.168.1.41;database=yucw;uid=sa;pwd=Abc88888;MultipleActiveResultSets=true";
        if (Sqlconn.State == ConnectionState.Closed)
        { Sqlconn.Open(); }

        string Sqlcommand = "select * from dbo." + '"' + tablename + '"';
        SqlCommand cmd = new SqlCommand(Sqlcommand, Sqlconn);
        //try
        //{
            cmd.ExecuteNonQuery();
        //}
        //catch
        //{
        //    Response.Write("<script>window.alert('该表不存在！');window.location.href='../SqlserverTest.aspx'</script>");
        //}
        Sqlcommand = "SELECT * FROM " + '"' + tablename + '"' + " WHERE " + '"' + prop + '"' + '=' + val;
        try
        {
            cmd = new SqlCommand(Sqlcommand, Sqlconn);
            SqlDataReader myreader = cmd.ExecuteReader();
            if (myreader.Read())
                Response.Write("<script>window.alert('你好！');</script>");
            else
                throw new Exception("写错啦!");
            SqlDataAdapter da = new SqlDataAdapter(Sqlcommand, Sqlconn);
            DataSet dataset = new DataSet();
            da.Fill(dataset, tablename);
            dtg.DataSource = dataset.Tables[tablename];
        }
        catch
        {
            Response.Write("<script>window.alert('查询失败！');window.location.href='../SqlserverTest.aspx'</script>");
        }
        finally
        {
            if (Sqlconn != null)
            {
                Sqlconn.Close();
            }
        }
        dtg.DataBind();
    }

    protected void btnBack(object sender, EventArgs e)
    {
        Response.Redirect("../SqlserverTest.aspx");
    }
}