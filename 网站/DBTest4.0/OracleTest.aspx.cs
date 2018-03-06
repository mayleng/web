using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OracleTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    
    protected void btnCreateTable(object sender, EventArgs e)
    {
        Response.Redirect("~/Oracletest/createtable.aspx");
    }

    protected void btnAddData(object sender, EventArgs e)
    {
        Response.Redirect("~/Oracletest/insertdata.aspx");
    }

    protected void btnDeleteData(object sender, EventArgs e)
    {
        Response.Redirect("~/Oracletest/deletedata.aspx");
    }

    protected void btnEditData(object sender, EventArgs e)
    {
        Response.Redirect("~/Oracletest/editdata.aspx");
    }

    protected void btnSearchData(object sender, EventArgs e)
    {
        Response.Redirect("~/Oracletest/searchdata.aspx");
    }

    protected void btnBackD(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}