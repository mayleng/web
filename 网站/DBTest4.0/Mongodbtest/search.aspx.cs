using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MongoDB.Bson;
using MongoDB.Driver;

public partial class Mongodbtest_search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearchData(object sender,EventArgs e)
    {
        string collection = TextBox1.Text.Trim();
        string key = TextBox2.Text.Trim(); string val = TextBox3.Text.Trim();
        string Mongoconstr = "mongodb://192.168.1.173:27017";
        IMongoClient monclient = new MongoClient(Mongoconstr);
        IMongoDatabase mondb = monclient.GetDatabase("yucw");
        var coll = mondb.GetCollection<BsonDocument>(collection);
        try
        {
            var filter = Builders<BsonDocument>.Filter.Eq(key, val);
            var document = coll.Find(filter).FirstAsync().Result;
            TextBox4.Text = document.ToString();           
        }
        catch
        {
            Response.Write("<script>window.alert('查询失败！');window.location.href='../MongodbTest.aspx'</script>");
        }
    }

    protected void btnBack(object sender,EventArgs e)
    {
        Response.Redirect("../MongodbTest.aspx");
    }
}