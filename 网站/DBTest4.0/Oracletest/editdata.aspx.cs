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


public partial class editdata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btneditdata(object sender, EventArgs e)
    {
        String tablename = tb0.Text.Trim();
        String key = tb1.Text.Trim();
        String keyval = tb2.Text.Trim();
        String prop = tb3.Text.Trim();
        String updateval = tb4.Text.Trim();

        //String oracleConStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.61)(PORT=1521))(CONNECT_DATA=(SID=whbonree)));User ID=ljl;Password=bonree;";
        OracleConnection conn = new OracleConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OraConStr"].ConnectionString.ToString());
        conn.Open();

        String Oraclecmd = "select * from hujing." + tablename;
        OracleCommand cmd = new OracleCommand(Oraclecmd, conn);
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            TextBox1.Text = "该表不存在！" + ex.Message;
            conn.Close();
            cmd.Dispose();
            return;
            //Response.Write("<script>window.alert('该表不存在！');window.location.href='../OracleTest.aspx'</script>");
        }
        Oraclecmd = "update " + tablename + " set " + prop + "=" + updateval + " where " + key + "=" + keyval;
        cmd = new OracleCommand(Oraclecmd, conn);
        try
        {
            if (cmd.ExecuteNonQuery() > 0)
            {
                TextBox1.Text = "编辑成功！";
                //Response.Write("<script>window.alert('编辑成功！');window.location.href='../OracleTest.aspx'</script>");
            }
            else
            {
                TextBox1.Text = "编辑失败！";
                //Response.Write("<script>window.alert('编辑失败！');window.location.href='../OracleTest.aspx'</script>");
            }
        }
        catch (Exception ex)
        {
            TextBox1.Text = "编辑失败！ "+ex.Message;
            //Response.Write("<script>window.alert('编辑失败！');window.location.href='OracleTest.aspx'</script>");
        }
        conn.Close();
        cmd.Dispose();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("../OracleTest.aspx");
    }
}