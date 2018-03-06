using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "->Hello World";
        }

        [WebMethod]
        public int Sum(int a, int b)
        {
           
            SqlConnection con = new SqlConnection();

            // con.ConnectionString = "server=505-03;database=ttt;user=sa;pwd=123";
            con.ConnectionString = "server=192.168.1.184;database=test;uid=sa;pwd=yangyy";
            con.Open();

            /*
            SqlDataAdapter 对象。 用于填充DataSet （数据集）。
            SqlDataReader 对象。 从数据库中读取流..
            后面要做增删改查还需要用到 DataSet 对象。
            */

            String Mysqlcmd = "select * from dbo.a";
            SqlCommand cmd = new SqlCommand(Mysqlcmd, con);
            cmd.ExecuteNonQuery();//执行SQL语句           
            con.Close();//关闭数据库
            return a + b;
        }

        [WebMethod]
        public int Sub(int a, int b)
        {
            return a - b;
        }

        [WebMethod]
        public double Mult(double a, double b)
        {
            return a * b;
        }

        [WebMethod]
        public double Div(double a, double b)
        {
            return a / b;
        }

        [WebMethod]
        [System.Web.Services.Protocols.SoapDocumentMethod(OneWay=true)]
        public void SetPlayerName(string strName)
        {
            Application["PlayerName"] = strName;
        }

        [WebMethod]
        public string GetPlayerName()
        {
            return Convert.ToString(Application["PlayerName"]);
        }  
    }
}
