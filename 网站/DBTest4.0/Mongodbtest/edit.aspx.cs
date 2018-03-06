using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MongoDB.Driver;
using MongoDB.Bson;

public partial class Mongodbtest_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEditData(object sender,EventArgs e)
    {
        string collection = TextBox5.Text.Trim();
        string key1 = TextBox1.Text.Trim(); string val1 = TextBox2.Text.Trim();
        string key2 = TextBox3.Text.Trim(); string val2 = TextBox4.Text.Trim();
       

        string Mongoconstr = "mongodb://192.168.1.173:27017";
        IMongoClient monclient = new MongoClient(Mongoconstr);
        IMongoDatabase mondb = monclient.GetDatabase("yucw");
        var coll = mondb.GetCollection<BsonDocument>(collection);
        try
        {
            var filter = Builders<BsonDocument>.Filter.Eq(key1, val1);
            var update = Builders<BsonDocument>.Update.Set(key2, val2);
            coll.UpdateOne(filter,update);
            Response.Write("<script>window.alert('操作成功！');window.location.href='../MongodbTest.aspx'</script>");
        }
        catch
        {
            Response.Write("<script>window.alert('操作失败！');window.location.href='../MongodbTest.aspx'</script>");
        }
    }
}