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


public partial class searchdata : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnsearchdata(object sender, EventArgs e)
    {
        String tablename = tb0.Text.Trim();
        String prop = tb1.Text.Trim();
        String val = tb2.Text.Trim();

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
        Oraclecmd = "SELECT * FROM " + tablename + " where " + prop + "="+ val;
        try
        {
            cmd = new OracleCommand(Oraclecmd, conn);
            OracleDataReader myreader = cmd.ExecuteReader();
            if (myreader.Read())
            {
                TextBox1.Text = "查询成功！";
                //Response.Write("<script>window.alert('你好！');</script>");
            }                
            else
            {
                TextBox1.Text = "写错啦!";
                throw new Exception("写错啦!");
            }
                
            OracleDataAdapter da = new OracleDataAdapter(Oraclecmd, conn);
            DataSet dataset = new DataSet();
            da.Fill(dataset, tablename);

            dtg.DataSource = dataset.Tables[tablename];
        }
        catch(Exception ex)
        {
            TextBox1.Text = "查询失败！";
            //Response.Write("<script>window.alert('查询失败！');window.location.href='../OracleTest.aspx'</script>");
        }
        finally 
        {
            if (conn != null) 
            {
                conn.Close(); 
            }
            if (cmd!=null)
            {
                cmd.Dispose();
            }
            
        }
        dtg.DataBind();
    }

    protected void btnback(object sender, EventArgs e)
    {
        Response.Redirect("OracleTest.aspx");
    }
    protected void dtg_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}