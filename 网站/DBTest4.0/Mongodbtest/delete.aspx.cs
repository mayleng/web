using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MongoDB.Bson;
using MongoDB.Driver;

public partial class Mongodbtest_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDeleData(object sender,EventArgs e)
    {
        string collection = TextBox3.Text.Trim();
        string key = TextBox1.Text.Trim();
        string val = TextBox2.Text.Trim();
        string Mongoconstr = "mongodb://192.168.1.173:27017";
        IMongoClient monclient = new MongoClient(Mongoconstr);
        IMongoDatabase mondb = monclient.GetDatabase("yucw");
        var coll = mondb.GetCollection<BsonDocument>(collection);
        try
        {
            var filter = Builders<BsonDocument>.Filter.Eq(key, val);
            coll.FindOneAndDelete(filter);
            Response.Write("<script>window.alert('操作成功！');window.location.href='../MongodbTest.aspx'</script>");
        }
        catch
        {
            Response.Write("<script>window.alert('操作失败！');window.location.href='../MongodbTest.aspx'</script>");
        }
    }
}