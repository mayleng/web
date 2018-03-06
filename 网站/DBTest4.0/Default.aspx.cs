using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnOracle(object sender, EventArgs e)
        {
            Response.Redirect("OracleTest.aspx");
        }

        protected void btnSqlServer(object sender, EventArgs e)
        {
            Response.Redirect("SqlserverTest.aspx");
        }

        protected void btnMySql(object sender, EventArgs e)
        {
            Response.Redirect("MysqlTest.aspx");
        }

        protected void btnMem_Redis(object sender, EventArgs e)
        {
            Response.Redirect("Mem_RedisTest.aspx");
        }

        protected void btnMongoDB(object sender, EventArgs e)
        {
            Response.Redirect("MongodbTest.aspx");
        }

        protected void btnWebService(object sender, EventArgs e)
        {
            Response.Redirect("WsShow.aspx");
        }

        protected void btnThrift(object sender, EventArgs e)
        {
            Response.Redirect("memcache.aspx");
        }

        protected void btnMaMetric(object sender, EventArgs e)
        {
            Response.Redirect("memcache.aspx");
        }

        protected void btnWebApi(object sender, EventArgs e)
        {
            Response.Redirect("WebApi.aspx");
        }

        protected void btnHttpWR(object sender, EventArgs e)
        {
            Response.Redirect("Httpwebrequest.aspx");
        }
}