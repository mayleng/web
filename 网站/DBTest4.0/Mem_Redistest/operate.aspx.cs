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

public partial class Mem_Redistest_operate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnMemOperate(object sender, EventArgs e)
    {
        string myConn = ConfigurationManager.AppSettings["BeITMemcacheIP"].ToString();
        MemcachedClientConfiguration config = new MemcachedClientConfiguration();
        config.AddServer(myConn, 11211);
        config.Protocol = MemcachedProtocol.Binary;
        MemcachedClient client = new MemcachedClient(config);

        string keyval = key3.Text.Trim();
        ulong number = ulong.Parse(num.Text.Trim());
        string selflag = Select1.Value;
        ulong renum;

        if (selflag.Equals("+"))
        {
            renum = client.Increment(keyval, 10, number);
            Response.Write("<script>window.alert('" + renum + "');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
        else if(selflag.Equals("-"))
        {
            renum = client.Decrement(keyval, 10, number);
            Response.Write("<script>window.alert('" + renum + "');window.location.href='../Mem_RedisTest.aspx'</script>");
        }
    }

    protected void btnReOperate(object sender,EventArgs e)
    {
        RedisNativeClient rclient = new RedisNativeClient("192.168.1.207", 6379);
        try
        {
            string keyval = key3.Text.Trim();
            int number = int.Parse(num.Text.Trim());
            string selflag = Select1.Value;
            long renum;

            if (selflag.Equals("+"))
            {
                // int.Parse(rclient.Get(key));
                //Int64 re = 0;
                byte[] valueGet = rclient.Get(keyval);
                //if(valueGet == null || 
                //    valueGet.Length <= 0
                //    || valueGet.Length > 8)
                //{
                //    return;
                //}

                //byte[] total = new byte[8];
                //for (int i = 0; i < 8; i++ )
                //{
                //    total[i] = 0;
                //}
                
                //for (int i = 0; i < valueGet.Length; i++)
                //{
                //    total[i] = valueGet[i];
                //}

                //re = System.BitConverter.ToInt64(total, 0);

                renum = rclient.IncrBy(keyval, number);
                Response.Write("<script>window.alert('" + renum + "');window.location.href='../Mem_RedisTest.aspx'</script>");
            }
            else if (selflag.Equals("-"))
            {
                renum = rclient.DecrBy(keyval, number);
                Response.Write("<script>window.alert('" + renum + "');window.location.href=../Mem_RedisTest.aspx'</script>");
            }
        }
        catch(Exception ex)
        {
            Response.Write("<script>window.alert('" + ex.Message + "');window.location.href=../Mem_RedisTest.aspx'</script>");
        }
        
    }
}
