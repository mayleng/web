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

public partial class Mem_Redistest_pend : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //pendkey.Text = "aa";
        //btnRePend(sender, e);
    }

    protected void btnMemPend(object sender,EventArgs e)
    {
        string myConn = ConfigurationManager.AppSettings["BeITMemcacheIP"].ToString();
        MemcachedClientConfiguration config = new MemcachedClientConfiguration();
        config.AddServer(myConn, 11211);
        config.Protocol = MemcachedProtocol.Binary;
        MemcachedClient client = new MemcachedClient(config);
        string pkey=pendkey.Text.Trim();
        string select = Sele.Value;
        //string pdata=penddata.Text.Trim();
        byte[] b={49,50,51};
        ArraySegment<byte> pend=new ArraySegment<byte>(b);

        if (select.Equals("Prepend"))
        {
            if (client.Prepend(pkey, pend))
                Response.Write("<script>window.alert('向前追加数据成功！');window.location.href='../Mem_RedisTest.aspx'</script>");
            else
                Response.Write("<script>window.alert('向前追加数据失败！');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
        else if(select.Equals("Append"))
        {
            if (client.Append(pkey, pend))
                Response.Write("<script>window.alert('追加数据成功！');window.location.href='../Mem_RedisTest.aspx'</script>");
            else
                Response.Write("<script>window.alert('追加数据失败！');window.location.href='../Mem_RedisTest.aspx'</script>");
        }

    }

    protected void btnRePend(object sender,EventArgs e)
    {
        RedisNativeClient rclient = new RedisNativeClient("192.168.1.207", 6379);
        string pkey = pendkey.Text.Trim();
        string select = Sele.Value;
        byte[] b = { 49, 50, 51 };
        if (select.Equals("Prepend"))
        {
                Response.Write("<script>window.alert('Redis无法向前追加数据！');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
        else if (select.Equals("Append"))
        {
            try
            {
                if (rclient.Exists(pkey) == 1)
                {
                    rclient.Append(pkey, b);
                    Response.Write("<script>window.alert('追加数据成功！');window.location.href='../Mem_RedisTest.aspx'</script>");
                }
                else
                    Response.Write("<script>window.alert('追加数据失败！');window.location.href='../Mem_RedisTest.aspx'</script>");
            }
            catch
            {
                Response.Write("<script>window.alert('追加数据失败！');window.location.href='../Mem_RedisTest.aspx'</script>");
            }
        }
    }
}
