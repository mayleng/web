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


public partial class deletedata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btndeletedata(object sender, EventArgs e)
    {
        String tablename = t0.Text.Trim();
        String key = t1.Text.Trim();
        String keyval = t2.Text.Trim();

        //String oracleConStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.61)(PORT=1521))(CONNECT_DATA=(SID=whbonree)));User ID=ljl;Password=bonree;";
        OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OraConStr"].ConnectionString.ToString());
        conn.Open();

        String Oraclecmd = "select * from hujing." + tablename;//"select * from ljl." + "'" + tablename + "'";
        OracleCommand cmd = new OracleCommand(Oraclecmd, conn);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            TextBox1.Text = "该表不存在！ " + ex.Message;
            //Response.Write("<script>window.alert('该表不存在！');window.location.href='../OracleTest.aspx'</script>");
        }
        Oraclecmd = "delete from " + tablename + " where " + key + "=" + keyval;
        cmd = new OracleCommand(Oraclecmd, conn);
        try
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                TextBox1.Text = "删除成功！";
                //Response.Write("<script>window.alert('删除成功！');window.location.href='../OracleTest.aspx'</script>");
            }
            else
            {
                TextBox1.Text = "删除失败！";
                //Response.Write("<script>window.alert('删除失败！');window.location.href='../OracleTest.aspx'</script>");
            }
        }
        catch(Exception ex)
        {
            TextBox1.Text = "删除失败！"+ex.Message;
            //Response.Write("<script>window.alert('删除失败！');window.location.href='OracleTest.aspx'</script>");
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
    protected void Button3_Click(object sender, EventArgs e)
    {
        String tablename = t0.Text.Trim();
        OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OraConStr"].ConnectionString.ToString());
        conn.Open();

        String Oraclecmd = "select * from hujing." + tablename;//"select * from ljl." + "'" + tablename + "'";
        OracleCommand cmd = new OracleCommand(Oraclecmd, conn);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            TextBox2.Text = "该表不存在！ " + ex.Message;
            //Response.Write("<script>window.alert('该表不存在！');window.location.href='../OracleTest.aspx'</script>");
        }
        Oraclecmd = "drop table " + tablename;
        cmd = new OracleCommand(Oraclecmd, conn);
        try
        {
            cmd.ExecuteNonQuery();
            TextBox2.Text = "删除成功！";
        }
        catch (Exception ex)
        {
            TextBox2.Text = "删除失败！" + ex.Message;
            //Response.Write("<script>window.alert('删除失败！');window.location.href='OracleTest.aspx'</script>");
        }
        finally
        { 
            conn.Close();
            cmd.Dispose();
        }   
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}