using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MongoDB.Bson;
using MongoDB.Driver;
public partial class Mongodbtest_create_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCreate_Add(object sender, EventArgs e)
    {
        string collection = TextBox1.Text.Trim();
        string key1 = TextBox2.Text.Trim(); string val1 = TextBox3.Text.Trim();
        string key2 = TextBox4.Text.Trim(); string val2 = TextBox5.Text.Trim();
        string key3 = TextBox6.Text.Trim(); string val3 = TextBox7.Text.Trim();
        string key4 = TextBox8.Text.Trim(); string val4 = TextBox9.Text.Trim();
        string key5 = TextBox10.Text.Trim(); string val5 = TextBox11.Text.Trim();

        string Mongoconstr = "mongodb://192.168.1.173:27017";
        IMongoClient monclient = new MongoClient(Mongoconstr);
        IMongoDatabase mondb = monclient.GetDatabase("yucw");
        try
        {
            var document = new BsonDocument
                            {
                                {key1,val1},
                                {key2,val2},
                                {key3,val3},
                                {key4,val4},
                                {key5,val5}
                            };
            var coll = mondb.GetCollection<BsonDocument>(collection);
            coll.InsertOne(document);
            Response.Write("<script>window.alert('操作成功！');window.location.href='../MongodbTest.aspx'</script>");
        }
        catch
        {
            Response.Write("<script>window.alert('操作失败！');window.location.href='../MongodbTest.aspx'</script>");
        }
        
    }
}