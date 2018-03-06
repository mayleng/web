using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

using Enyim.Caching;
using Enyim.Caching.Memcached;
using Enyim.Caching.Configuration;

public partial class Mem_RedisTest:System.Web.UI.Page
{
    public static int number = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //number++;
        //number = number % 2;
        //switch (number)
        //{
        //    case 0: btnadd(sender, e); break;
        //    case 1: btnlook(sender, e); break;
        //    //case 2: btndelte(sender, e); break;
        //    //case 2: btnpend(sender, e); break;
        //    default: break;
        //}
        

    }
        protected void btnadd(object sender, EventArgs e)
        {
            Response.Redirect("~/Mem_Redistest/add.aspx");
        }

        protected void btnlook(object sender, EventArgs e)
        {
            Response.Redirect("~/Mem_Redistest/look.aspx");
        }

        protected void btndelte(object sender, EventArgs e)
        {
            Response.Redirect("~/Mem_Redistest/delete.aspx");
        }

        protected void btnoperate(object sender, EventArgs e)
        {
            Response.Redirect("~/Mem_Redistest/operate.aspx");
        }

        protected void btnpend(object sender, EventArgs e)
        {
            Response.Redirect("~/Mem_Redistest/pend.aspx");
        }
        protected void btnback(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
}