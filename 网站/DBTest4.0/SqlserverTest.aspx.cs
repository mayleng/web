using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SqlserverTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate(object sender, EventArgs e)
    {
        Response.Redirect("~/Sqlservertest/createtable.aspx");
    }

    protected void btnInsert(object sender, EventArgs e)
    {
        Response.Redirect("~/Sqlservertest/insertdata.aspx");
    }

    protected void btnDelete(object sender, EventArgs e)
    {
        Response.Redirect("~/Sqlservertest/deletedata.aspx");
    }

    protected void btnEdit(object sender, EventArgs e)
    {
        Response.Redirect("~/Sqlservertest/editdata.aspx");
    }

    protected void btnSearch(object sender, EventArgs e)
    {
        Response.Redirect("~/Sqlservertest/searchdata.aspx");
    }

    protected void btnBack(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}