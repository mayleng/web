using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MysqlTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate(object sender, EventArgs e)
    {
        Response.Redirect("~/Mysqltest/createtable.aspx");
    }

    protected void btnInsert(object sender, EventArgs e)
    {
        Response.Redirect("~/Mysqltest/insertdata.aspx");
    }

    protected void btnDelete(object sender, EventArgs e)
    {
        Response.Redirect("~/Mysqltest/deletedata.aspx");
    }

    protected void btnEdit(object sender, EventArgs e)
    {
        Response.Redirect("~/Mysqltest/editdata.aspx");
    }

    protected void btnSearch(object sender, EventArgs e)
    {
        Response.Redirect("~/Mysqltest/searchdata.aspx");
    }

    protected void btnBack(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}