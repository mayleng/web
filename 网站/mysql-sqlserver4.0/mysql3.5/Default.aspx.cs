using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace mysql3._5
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region MySql
        protected void Button1_Click(object sender, EventArgs e)
        {
            string tablename = TextBox1.Text.Trim();

            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Mysqlcmd = "create table " + tablename + " (number int primary key, name varchar(30) not null)";
            MySqlCommand cmd = new MySqlCommand(Mysqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("<script>window.alert('创建表成功！');window.location.href='Default.aspx'</script>");
                //else
                //    Response.Write("<script>window.alert('创建表失败！');window.location.href='Default.aspx'</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>window.alert('创建表失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string tablename = TextBox2.Text.Trim();
            string key = TextBox3.Text.Trim();

            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Mysqlcmd = "select * from " + tablename;
            MySqlCommand cmd = new MySqlCommand(Mysqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('该表不存在！');window.location.href='Default.aspx'</script>");
            }

            Mysqlcmd = "insert into " + tablename + " values(" + key + ", 'a')";
            cmd = new MySqlCommand(Mysqlcmd, conn);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Response.Write("<script>window.alert('添加成功！');window.location.href='Default.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('添加失败！');window.location.href='Default.aspx'</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('添加失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string tablename = TextBox4.Text.Trim();
            string prop = TextBox5.Text.Trim();
            string value = TextBox6.Text.Trim();

            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Mysqlcmd = "select * from " + tablename;
            MySqlCommand cmd = new MySqlCommand(Mysqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('该表不存在！');window.location.href='Default.aspx'</script>");
            }
            string value1 = value + "a";
            Mysqlcmd = "update " + tablename + " set `" + prop + "`='" + value1 + "'" + " where `" + prop + "`='" + value + "'";//"update " + tablename + " set class =" + " where " + prop + "=" + value;//
            Response.Write(Mysqlcmd);
            cmd = new MySqlCommand(Mysqlcmd, conn);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Response.Write("<script>window.alert('编辑成功！');window.location.href='Default.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('编辑失败！');window.location.href='Default.aspx'</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('编辑失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string tablename = TextBox7.Text.Trim();
            string prop = TextBox8.Text.Trim();
            string value = TextBox9.Text.Trim();

            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Mysqlcmd = "select * from " + tablename;
            MySqlCommand cmd = new MySqlCommand(Mysqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('该表不存在！');window.location.href='Default.aspx'</script>");
            }

            Mysqlcmd = "SELECT * FROM " + tablename + " WHERE `" + prop + "`='" + value+"'";
            cmd = new MySqlCommand(Mysqlcmd, conn);
            
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    Response.Write("<script>window.alert('查询成功！');</script>");
                reader.Close();
                MySqlDataAdapter da = new MySqlDataAdapter(Mysqlcmd, conn);
                DataSet dataset = new DataSet();
                da.Fill(dataset, tablename);
                DGT.DataSource = dataset.Tables[tablename];
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('查询失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            {
                conn.Close();
            }
            DGT.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string tablename = TextBox10.Text.Trim();

            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Mysqlcmd = "select * from " + tablename;
            MySqlCommand cmd = new MySqlCommand(Mysqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('该表不存在！');window.location.href='Default.aspx'</script>");
            }

            Mysqlcmd = "drop table " + tablename;
            cmd = new MySqlCommand(Mysqlcmd, conn);
            try
            {
                if (cmd.ExecuteNonQuery() >= 0)
                {
                    Response.Write("<script>window.alert('删除成功！');window.location.href='Default.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('删除失败！');window.location.href='Default.aspx'</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('删除失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            { conn.Close(); }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string tablename = TextBox10.Text.Trim();
            string key = TextBox11.Text.Trim();
            string value = TextBox12.Text.Trim();

            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Mysqlcmd = "select * from " + tablename;
            MySqlCommand cmd = new MySqlCommand(Mysqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('该表不存在！');window.location.href='Default.aspx'</script>");
            }

            Mysqlcmd = "delete from " + tablename + " where `" + key + "`='" + value+"'";
            cmd = new MySqlCommand(Mysqlcmd, conn);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Response.Write("<script>window.alert('删除成功！');window.location.href='Default.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('删除失败！');window.location.href='Default.aspx'</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('删除失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            { conn.Close(); }
        }
        #endregion

        #region SqlServer
        protected void Button7_Click(object sender, EventArgs e)
        {
            string tablename = TextBox1.Text.Trim();

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Sqlcmd = "create table " + tablename + " (number int primary key, name varchar(30) not null)";
            SqlCommand cmd = new SqlCommand(Sqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("<script>window.alert('创建表成功！');window.location.href='Default.aspx'</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('创建表失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string tablename = TextBox2.Text.Trim();
            string key = TextBox3.Text.Trim();

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Sqlcmd = "select * from " + tablename;
            SqlCommand cmd = new SqlCommand(Sqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('该表不存在！');window.location.href='Default.aspx'</script>");
            }

            Sqlcmd = "insert into " + tablename + " values(" + key + ", 'a')";
            cmd = new SqlCommand(Sqlcmd, conn);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Response.Write("<script>window.alert('添加成功！');window.location.href='Default.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('添加失败！');window.location.href='Default.aspx'</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('添加失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            string tablename = TextBox4.Text.Trim();
            string prop = TextBox5.Text.Trim();
            string value = TextBox6.Text.Trim();

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Sqlcmd = "select * from " + tablename;
            SqlCommand cmd = new SqlCommand(Sqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Response.Write("<script>window.alert('该表不存在！');window.location.href='Default.aspx'</script>");
            }
            string value1 = value + "a";
            Sqlcmd = "update " + tablename + " set " + prop + "='" + value1 + "'" + " where " + prop + "='" + value + "'";
            //Sqlcmd = "update " + tablename + " set class = f" + " where " + prop + "=" + value;
            cmd = new SqlCommand(Sqlcmd, conn);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Response.Write("<script>window.alert('编辑成功！');window.location.href='Default.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('编辑失败！');window.location.href='Default.aspx'</script>");
                }
            }
            catch
            {
                Response.Write("<script>window.alert('编辑失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            string tablename = TextBox7.Text.Trim();
            string prop = TextBox8.Text.Trim();
            string value = TextBox9.Text.Trim();

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Sqlcmd = "select * from " + tablename;
            SqlCommand cmd = new SqlCommand(Sqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Response.Write("<script>window.alert('该表不存在！');window.location.href='Default.aspx'</script>");
            }

            Sqlcmd = "SELECT * FROM " + tablename + " WHERE " + prop + "='" + value+"'";
            cmd = new SqlCommand(Sqlcmd, conn);

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    Response.Write("<script>window.alert('查询成功！');</script>");
                reader.Close();
                SqlDataAdapter da = new SqlDataAdapter(Sqlcmd, conn);
                DataSet dataset = new DataSet();
                da.Fill(dataset, tablename);
                DGT.DataSource = dataset.Tables[tablename];
            }
            catch
            {
                Response.Write("<script>window.alert('查询失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            {
                conn.Close();
            }
            DGT.DataBind();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            string tablename = TextBox10.Text.Trim();

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Sqlcmd = "select * from " + tablename;
            SqlCommand cmd = new SqlCommand(Sqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Response.Write("<script>window.alert('该表不存在！');window.location.href='Default.aspx'</script>");
            }

            Sqlcmd = "drop table " + tablename;
            cmd = new SqlCommand(Sqlcmd, conn);
            try
            {
                cmd.ExecuteNonQuery();
                Response.Write("<script>window.alert('删除成功！');window.location.href='Default.aspx'</script>");
               
            }
            catch
            {
                Response.Write("<script>window.alert('删除失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            { conn.Close(); }
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            string tablename = TextBox10.Text.Trim();
            string key = TextBox11.Text.Trim();
            string value = TextBox12.Text.Trim();

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Sqlcmd = "select * from " + tablename;
            SqlCommand cmd = new SqlCommand(Sqlcmd, conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Response.Write("<script>window.alert('该表不存在！');window.location.href='Default.aspx'</script>");
            }

            Sqlcmd = "delete from " + tablename + " where " + key + "='" + value+"'";
            cmd = new SqlCommand(Sqlcmd, conn);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Response.Write("<script>window.alert('删除成功！');window.location.href='Default.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('删除失败！');window.location.href='Default.aspx'</script>");
                }
            }
            catch
            {
                Response.Write("<script>window.alert('删除失败！');window.location.href='Default.aspx'</script>");
            }
            finally
            { conn.Close(); }
        }
        #endregion

    }
}