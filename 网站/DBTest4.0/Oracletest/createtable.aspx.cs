using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Web.Configuration;
using System.Text;

public partial class Oracletest_createtable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate(object sender, EventArgs e)
    {
        String tablename = t0.Text.Trim();
        String key = t1.Text.Trim();
        String prop1 = t2.Text.Trim();
        

        //String oracleConStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.61)(PORT=1521))(CONNECT_DATA=(SID=whbonree)));User ID=ljl;Password=bonree;";
        OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OraConStr"].ConnectionString.ToString());
        conn.Open();

        String Oraclecmd = "create table " + tablename + "(" + key + " " + "int primary key,"
                                                  + prop1 + " " + "int"
                                                   + ")";
        OracleCommand cmd = new OracleCommand(Oraclecmd, conn);
        try
        {
            if (cmd.ExecuteNonQuery() == -1)
            {
                TextBox1.Text = "创建表成功";
            }                

        }
        catch(Exception ex)
        {            
            TextBox1.Text = "创建表失败 " + ex.Message;
            //Response.Write("<script>window.alert('创建表失败！');window.location.href='../OracleTest.aspx'</script>");
        }
        finally
        { 
            conn.Close();
            cmd.Dispose();
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("../OracleTest.aspx");
    }
}