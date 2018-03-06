using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

public partial class Sqlservertest_createtable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnAutoFill(object sender,EventArgs e)
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

        SqlConnection Sqlconn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString.ToString());
        //Sqlconn.ConnectionString = "server=192.168.1.41;database=yucw;uid=sa;pwd=Abc88888";
        if(Sqlconn.State==ConnectionState.Closed)
        { Sqlconn.Open(); }

        string Sqlcommand = "create table " + tablename + '(' + key + " int primary key,"
                                                        + prop1 + " varchar(30) not null,"
                                                        + prop2 + " varchar(20) not null,"
                                                        + prop3 + " int,"
                                                        + prop4 + " int)";
        SqlCommand cmd = new SqlCommand(Sqlcommand,Sqlconn);
        int i = 0;
        try
        {
            i = cmd.ExecuteNonQuery();
            if (i == -1)
            {
                Response.Write("<script>window.alert('创建表成功！');window.location.href='../SqlserverTest.aspx'</script>");
            }
        }
        catch
        {
            Response.Write("<script>window.alert('创建表失败！');window.location.href='../SqlserverTest.aspx'</script>");
        }
        finally
        { Sqlconn.Close(); }
    }
}