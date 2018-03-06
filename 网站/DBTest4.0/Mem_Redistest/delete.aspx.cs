using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Enyim.Caching;
using Enyim.Caching.Memcached;
using Enyim.Caching.Configuration;
using ServiceStack.Redis;
using System.Configuration;
public partial class Mem_Redistest_delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //key2.Text = "aa";
        //btnReDelete(sender, e);
    }

    protected void btnMemDelete(object sender, EventArgs e)
    {
        string myConn = ConfigurationManager.AppSettings["BeITMemcacheIP"].ToString();
        MemcachedClientConfiguration config = new MemcachedClientConfiguration();
        config.AddServer(myConn, 11211);
        config.Protocol = MemcachedProtocol.Binary;
        MemcachedClient client = new MemcachedClient(config);

        string keyval = key2.Text;
        if ( client.Remove(keyval))
            Response.Write("<script>window.alert('删除成功！');window.location.href='../Mem_RedisTest.aspx'</script>");
        else
            Response.Write("<script>window.alert('删除失败！');window.location.href='../Mem_RedisTest.aspx'</script>");
    }

    protected void btnReDelete(object sender,EventArgs e)
    {
        RedisNativeClient rclient = new RedisNativeClient("192.168.1.207", 6379);
        string keyval = key2.Text.Trim();
        try
        {
            if (rclient.Exists(keyval) == 1)
            {
                rclient.Del(keyval);
                Response.Write("<script>window.alert('删除成功！');window.location.href='../Mem_RedisTest.aspx'</script>");
            }
            else
                Response.Write("<script>window.alert('Key不存在！');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
        catch
        {
            Response.Write("<script>window.alert('删除失败！');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
    }
}
