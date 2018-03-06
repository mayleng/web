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
using ServiceStack.Text;
using System.Configuration;

public partial class Mem_Redistest_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //key0.Text = "aa";
        //value0.Text = "22";
        //expiret.Text = "4";
        //btnRedisadd(sender, e);
    }

    protected void btnMemadd(object sender, EventArgs e)
    {
        string myConn = ConfigurationManager.AppSettings["BeITMemcacheIP"].ToString();
        MemcachedClientConfiguration config = new MemcachedClientConfiguration();
        config.AddServer(myConn, 11211);
        config.Protocol = MemcachedProtocol.Binary;
        MemcachedClient client = new MemcachedClient(config);

        string keyval = key0.Text.Trim();
        object val = value0.Text.Trim();
        double extime = double.Parse(expiret.Text.Trim());
        var result=client.ExecuteStore(StoreMode.Set,keyval,val,DateTime.Now.AddMinutes(extime));
        if (!result.Success)
        {
            if (result.Exception != null)
            {
                throw new Exception(String.Format("Message:{0}, key:{1}",
                            result.Message,
                            keyval),
                            result.Exception);
                //Response.Write("<script>window.alert('添加成功！');window.location.href='memcachedtest.aspx'</script>");
            }
            else
            {
                throw new Exception(
                            String.Format("Message:{0}, Code:{1}, Key:{2}",
                            result.Message,
                            result.StatusCode,
                            keyval));
                //Response.Write("<script>window.alert('添加失败！');window.location.href='memcachedtest.aspx'</script>");
            }
        }
        else
            Response.Write("<script>window.alert('添加成功！');window.location.href='../Mem_RedisTest.aspx'</script>");
    }

    protected void btnRedisadd(object sender,EventArgs e)
    {
        RedisNativeClient rclient = new RedisNativeClient("192.168.1.207", 6379);
        string keyval = key0.Text.Trim();
        string val = value0.Text.Trim();
        byte[] value = System.Text.Encoding.Default.GetBytes(val);
        int extime = int.Parse(expiret.Text.Trim());
        try
        {
            var result = rclient.Set(keyval, value,false ,extime*60,long.Parse(expiret.Text.Trim()));

            if (result)
            {
                Response.Write("<script>window.alert('添加成功！');window.location.href='../Mem_RedisTest.aspx'</script>");
            }
            else
            {
                Response.Write("<script>window.alert('添加失败！');window.location.href='../Mem_RedisTest.aspx'</script>");
            }
        }
        catch
        {
            Response.Write("<script>window.alert('添加失败！');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
    }

    protected void btnRedisHadd(object sender, EventArgs e)
    {
        RedisNativeClient rclient = new RedisNativeClient("192.168.1.207", 6379);
        string keyval = TextBox1.Text.Trim();
        string field = TextBox2.Text.Trim();
        string val = TextBox3.Text.Trim();
        byte[] key = System.Text.Encoding.Default.GetBytes(keyval);
        byte[] value = System.Text.Encoding.Default.GetBytes(val);
        try
        {
            rclient.HSet(field, key, value);
            Response.Write("<script>window.alert('添加成功！');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
        catch
        {
            Response.Write("<script>window.alert('添加失败！');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
    }
    protected void key0_TextChanged(object sender, EventArgs e)
    {

    }
}
