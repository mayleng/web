using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MongodbTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Add(object sender, EventArgs e)
    {
        Response.Redirect("~/Mongodbtest/create_add.aspx");
    }

    protected void btnDelete(object sender, EventArgs e)
    {
        Response.Redirect("~/Mongodbtest/delete.aspx");
    }

    protected void btnEdit(object sender, EventArgs e)
    {
        Response.Redirect("~/Mongodbtest/edit.aspx");
    }

    protected void btnSearch(object sender, EventArgs e)
    {
        Response.Redirect("~/Mongodbtest/search.aspx");
    }

    protected void btnBack(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}