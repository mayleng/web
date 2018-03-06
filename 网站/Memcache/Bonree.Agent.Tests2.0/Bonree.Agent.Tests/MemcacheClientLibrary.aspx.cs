using Memcached.ClientLibrary;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Collections;

namespace Bonree.Agent.Tests
{
    public partial class MemcacheMain : System.Web.UI.Page
    {
        Random Rnd = new Random((int)DateTime.UtcNow.Ticks);
        private static bool IsLoad = false;
        Object _SyncObject = new Object();
        private static int funcIndex = 1;

        //随机进行MemcacheClient的访问
        protected void Page_Load(object sender, EventArgs e)
        {
            lock(_SyncObject)
            {
                if (!IsLoad)
                {
                    IsLoad = true;
                    lock (_SyncObject)
                    {
                        MemcacheClientInit();
                    }
                }
            }

            try
            {
                TestMemcache();
            }
            catch(Exception ex)
            {

            }
            

        }

        public bool MemcacheClientInit()
        {
            this.nosqlTb.Text += "MemcacheClient Init Started!\r\n";
            
            string[] serverlist = { "127.0.0.1:11211", "90.0.12.120:11211" };

            //初始化池
            SockIOPool pool = SockIOPool.GetInstance();
            pool.SetServers(serverlist);

            pool.InitConnections = 3;
            pool.MinConnections = 3;
            pool.MaxConnections = 5;

            pool.SocketConnectTimeout = 1000;
            pool.SocketTimeout = 3000;

            pool.MaintenanceSleep = 30;
            pool.Failover = true;

            pool.Nagle = false;
            pool.Initialize();
            this.nosqlTb.Text += "MemcacheClient Init End!\r\n";
            return true;
        }

        public void TestMemcache()
        {
            this.nosqlTb.Text = "";
            switch (funcIndex)
            {
                case 1:
                    {
                        TestSet();
                        break;
                    }
                case 2:
                    {
                        TestDelete();
                        break;
                    }
                case 3:
                    {
                        TestGet();
                        break;
                    }
                case 4:
                    {
                        TestStoreCounter();
                        break;
                    }
                case 5:
                    {
                        TestGetCounter();
                        break;
                    }
                case 6:
                    {
                        TestIncrement();
                        break;
                    }
                case 7:
                    {
                        TestDecrement();
                        break;
                    }
                case 8:
                    {
                        GetMultipleArray();
                        break;
                    }
                case 9:
                    {
                        GetMultiple();
                        break;
                    }
                default:
                    break;
            }

            lock (_SyncObject)
            {
                funcIndex++;
                if (funcIndex >= 10)
                {
                    funcIndex = 1;
                }
            }
        }

        public void TestSet()
        {
            try
            {
                lock (_SyncObject)
                {
                    MemcachedClient mc = new MemcachedClient();
                    mc.EnableCompression = false;
                    mc.Add("SetTest", "123");
                    //Test Set
                    mc.Set("SetTest", "public bool Set(string key, object value, DateTime expiry, int hashCode)");
                    if (mc.KeyExists("SetTest"))
                    {
                        HandleLogs("[Cmd=Set]SetTest的值是：" + mc.Get("SetTest").ToString());
                    }
                }
            }
            catch(Exception)
            {

            }
            
        }

        public void TestDelete()
        {
            //Test Delete
            MemcachedClient mc = new MemcachedClient();
            if (mc.KeyExists("SetTest"))
            {
                mc.Delete("SetTest", null, DateTime.MaxValue);
                if (!mc.KeyExists("SetTest"))
                {
                    HandleLogs("[Cmd=Delete]Key为SetTest的值已经被删除");
                }
            }
        }

        public void TestGet()
        {
            MemcachedClient mc = new MemcachedClient();
            mc.Add("Get", "Get A Cmd=Get");
            if (mc.KeyExists("Get"))
            {
                Object o = mc.Get("Get");
                if(o != null)
                {
                    HandleLogs("[Cmd=Get]Get的值是：" + o.ToString());
                    mc.Delete("Get");
                }
            }

        }


        public void TestStoreCounter()
        {
            MemcachedClient mc = new MemcachedClient();
            long counter = Rnd.Next(1, 10000);
            mc.StoreCounter("number", counter);
            HandleLogs("[Cmd=StoreCounter]StoreCounter的值是：" + mc.GetCounter("number").ToString());  
        }

        public void TestGetCounter()
        {
            MemcachedClient mc = new MemcachedClient();
            mc.Increment("number", 3, 123);
            HandleLogs("[Cmd=GetCounter]GetCounter的值是：" + mc.GetCounter("number").ToString());  
        }

        public void TestIncrement()
        {
            MemcachedClient mc = new MemcachedClient();
            //Test Increment
            mc.Increment("number", 7, 123);
            HandleLogs("[Cmd=Increment]Increment的值是：" + mc.GetCounter("number").ToString());
        }


        public void TestDecrement()
        {
            MemcachedClient mc = new MemcachedClient();
            mc.Decrement("number", 19, 123);
            HandleLogs("[Cmd=Decrement]Decrement的值是：" + mc.GetCounter("number").ToString());
            mc.Delete("number");
        }

        public void GetMultipleArray()
        {
            MemcachedClient mc = new MemcachedClient();
            mc.Set("GetMultiple1", "GetMultipleValue1");
            mc.Set("GetMultiple2", "GetMultipleValue2");
            string[] keys = { "GetMultiple1", "GetMultiple2" };
            object[] obj = mc.GetMultipleArray(keys);
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] != null)
                    HandleLogs("[Cmd=GetMultipleArray]GetMultipleArray value的值是：" + obj[i].ToString());
            }
        }

        public void GetMultiple()
        {
            MemcachedClient mc = new MemcachedClient();
            string[] keys = { "GetMultiple1", "GetMultiple2" };
            Hashtable info = mc.GetMultiple(keys);
            foreach (DictionaryEntry each in info)
            {
                if (each.Value != null)
                    HandleLogs("[Cmd=GetMultiple]GetMultiple value的值是：" + each.Value.ToString());
            }
            mc.Delete("GetMultiple1");
            mc.Delete("GetMultiple2");
        }



        public void HandleLogs(string str)
        {
            string testIndex = "测试序号[" + funcIndex + "]:";
            str += "\r\n";
            str = testIndex + str;
            this.nosqlTb.Text += str;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("BeITMemcached.aspx");
        }

        protected void OnEnyimMemcachedClicked(object sender, EventArgs e)
        {
            Response.Redirect("EnyimCachingMemcached.aspx");

        }


    }
}