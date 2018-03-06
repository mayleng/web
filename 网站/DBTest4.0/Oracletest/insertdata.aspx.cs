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

public partial class insertdata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btninsertdata(object sender, EventArgs e)
    {
        String tablename = tt0.Text.Trim();
        String key = tt1.Text.Trim();
        String prop1 = tt2.Text.Trim();
        

        //String oracleConStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.61)(PORT=1521))(CONNECT_DATA=(SID=whbonree)));User ID=ljl;Password=bonree;";
        OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OraConStr"].ConnectionString.ToString());
        conn.Open();
        String Oraclecmd = "select * from hujing." + tablename;
        OracleCommand cmd = new OracleCommand(Oraclecmd, conn);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch
        {
            TextBox1.Text = "该表不存在！";
            conn.Close();
            cmd.Dispose();
            return;
            //Response.Write("<script>window.alert('该表不存在！');window.location.href='../OracleTest.aspx'</script>");
        }
        Oraclecmd = "insert into " + tablename +" values(" + key + "," + prop1  + ")";
        cmd = new OracleCommand(Oraclecmd, conn);
        try
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                TextBox1.Text = "添加成功！";
                //Response.Write("<script>window.alert('添加成功！');window.location.href='../OracleTest.aspx'</script>");
            }
            else
            {
                TextBox1.Text = "添加失败！";
                //Response.Write("<script>window.alert('添加失败！');window.location.href='../OracleTest.aspx'</script>");
            }
        }
        catch(Exception ex)
        {
            TextBox1.Text = "添加失败！ "+ex.Message;
            //Response.Write("<script>window.alert('添加失败！');window.location.href='../OracleTest.aspx'</script>");
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("../OracleTest.aspx");
    }
}