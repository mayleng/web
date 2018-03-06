using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

using Enyim.Caching;
using Enyim.Caching.Memcached;
using Enyim.Caching.Configuration;
using ServiceStack.Redis;
using System.Configuration;

public partial class Mem_Redistest_look : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //key1.Text="aa";
        //mulget.Text = "aa;aa";
        //Random rand=new Random();
        //int chooce=rand.Next(2);
        //switch(chooce)
        //{
        //    case 0:btnRedisLook(sender,e);break;
        //    case 1:btnRedisMullook(sender,e);break;
        //    default:break;
        //}
    }
    public string MemMulGet(MemcachedClient mc)
    {
        string keys = mulget.Text;
        string[] keysval = keys.Split(';');
        string vals = "";
        foreach(string singlekey in keysval)
        {
            object o = new object();
            if(mc.TryGet(singlekey,out o))
            {
                vals = vals + o.ToString()+';';
            }
            else
            {
                vals = vals+"ERROR!;";
            }
        }
        return vals;
    }

    public string ReMulGet(RedisNativeClient rc)
    {
        string keys = mulget.Text;
        string[] keysval = keys.Split(';');
        string vals = "";
        foreach (string singlekey in keysval)
        {
            try
            {
                if (rc.Exists(singlekey) == 1)
                {
                    vals = vals + rc.Get(singlekey) + ';';
                }
                else
                {
                    vals = vals + "ERROR!;";
                }
            }
            catch
            {
                vals = vals + "ERROR!";
            }
        }
        return vals;
    }


    protected void btnMemLook(object sender, EventArgs e)
    {
        string myConn = ConfigurationManager.AppSettings["BeITMemcacheIP"].ToString();
        MemcachedClientConfiguration config = new MemcachedClientConfiguration();
        config.AddServer(myConn, 11211);
        config.Protocol = MemcachedProtocol.Binary;
        MemcachedClient client = new MemcachedClient(config);

        string keyval = key1.Text.Trim();
        Object obj=new Object();
        var getr=client.ExecuteGet(keyval);
        if (client.TryGet(keyval,out obj))
            Response.Write("<script>window.alert('" + obj + "');window.location.href='../Mem_RedisTest.aspx'</script>");
        else
            Response.Write("<script>window.alert('Key值不存在！');window.location.href='../Mem_RedisTest.aspx'</script>");
    }

    protected void btnMemMullook(object sender,EventArgs e)
    {
        MemcachedClientConfiguration config = new MemcachedClientConfiguration();
        config.AddServer("192.168.1.64", 11211);
        config.Protocol = MemcachedProtocol.Binary;
        MemcachedClient client = new MemcachedClient(config);
        string values=MemMulGet(client);
        Response.Write("<script>window.alert('" + values + "');window.location.href='../Mem_RedisTest.aspx'</script>");
    }

    protected void btnRedisLook(object sender,EventArgs e)
    {
        RedisNativeClient rclient = new RedisNativeClient("192.168.1.207", 6379);
        string keyval = key1.Text.Trim();
        if(rclient.Exists(keyval)==0)
            Response.Write("<script>window.alert('Key值不存在！');window.location.href='../Mem_RedisTest.aspx'</script>");
        else if (rclient.Exists(keyval) == 1)
        {
            byte[] re = rclient.Get(keyval);
            string result = "";
            foreach (byte r in re)
                result = result + Convert.ToString(r);
            Response.Write("<script>window.alert('" + result + "');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
        else
            Response.Write("<script>window.alert('ERROR!');window.location.href='../Mem_RedisTest.aspx'</script>");
    }

    protected void btnRedisMullook(object sender,EventArgs e)
    {

        RedisNativeClient rclient = new RedisNativeClient("192.168.1.207", 6379);
        string keys = mulget.Text;
        string[] keysval = keys.Split(';');
        string result = "";
        byte[][] results = rclient.MGet(keysval);
        try
        {
            foreach (byte[] re in results)
                foreach (byte r in re)
                    result = result + Convert.ToString(r) + ';';
            Response.Write("<script>window.alert('" + result + "');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
        catch
        {
            Response.Write("<script>window.alert('查询失败!');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
    }

    protected void btnRedisHlook(object sender, EventArgs e)
    {

        RedisNativeClient rclient = new RedisNativeClient("192.168.1.207", 6379);
        string key = TextBox2.Text.Trim();
        byte[] keys = System.Text.Encoding.Default.GetBytes(key);
        string field = TextBox1.Text.Trim();
        string result = "";
        byte[] results = rclient.HGet(field, keys);
        try
        {
            result=System.Text.Encoding.Default.GetString(results);
            Response.Write("<script>window.alert('" + result + "');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
        catch
        {
            Response.Write("<script>window.alert('查询失败!');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
    }
}
