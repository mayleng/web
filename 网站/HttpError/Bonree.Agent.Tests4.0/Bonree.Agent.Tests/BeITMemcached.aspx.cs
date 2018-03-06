using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeIT.MemCached;
using System.Threading;
namespace Bonree.Agent.Tests
{
    //make it simple and easy!
    public partial class BeITMemcached : System.Web.UI.Page
    {
        Random Rnd = new Random((int)DateTime.UtcNow.Ticks);
        private static bool IsLoad = false;
        Object _SyncObject = new Object();
        private static int funcIndex = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            lock (_SyncObject)
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
            MemcachedClient.Setup("BeITMemcached", new string[] { "127.0.0.1" });
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.SendReceiveTimeout = 5000;
            cache.ConnectTimeout = 5000;
            cache.MinPoolSize = 1;
            cache.MaxPoolSize = 5;
            
            this.nosqlTb.Text += "MemcacheClient Init End!\r\n";
            return true;
        }

        //BeIt analyse
        //Add -> store
        //Append -> store
        //CheckAndSet -> store
        //SetCounter-> Set -> store
        //Increment-> incrementDecrement
        //Decrement -> incrementDecrement
        //Delete -> delete
        //Exists -> Exists
        //Get-> get
        //GetCounter-> get
        //Gets-> get
        //Prepend-> store
        //Replace -> store
        //Set -> store
        
        public void HandleLogs(string str)
        {
            string testIndex = "测试序号[" + funcIndex + "]:";
            str += "\r\n";
            str = testIndex + str;
            this.nosqlTb.Text += str;
        }

        //1.Add test
        public void AddTest()
        {
            try
            {
                MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
                cache.Add("BeIt", "123");
                HandleLogs("[Cmd=Add]BeIt：" + cache.Get("BeIt").ToString());
            }
            catch(Exception)
            {

            }
            
        }

        //2.Append test
        public void AppendTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Append("BeIt", " baz");
            HandleLogs("[Cmd=Append]BeIt：" + cache.Get("BeIt").ToString());
        }

        //3.CheckAndSet test
        public void CheckAndSetTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Set("castest", "a");
            //Trying to CAS key castest with the wrong unique
            HandleLogs("[Cmd=CheckAndSet]castest：" + cache.CheckAndSet("castest", "a", 0));

        }

        //4.SetCounter test
        public void SetCounterTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.SetCounter("mycounter", 9000);
            ulong? counter = cache.GetCounter("mycounter");
            if (counter.HasValue)
            {
                HandleLogs("[Cmd=SetCounter]mycounter：" + counter.Value.ToString());
            }
        }

        //5.Increment the counter test
        public void IncrementTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            ulong? counter = cache.Increment("mycounter", 1);
            if (counter.HasValue)
            {
                HandleLogs("[Cmd=Increment]mycounter：" + counter.Value.ToString());
            }
        }

        //6.Decrement the counter test
        public void DecrementTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            ulong? counter = cache.Decrement("mycounter", 9000);
            if (counter.HasValue)
            {
                HandleLogs("[Cmd=Decrement]mycounter：" + counter.Value.ToString());
            }
        }

        //7.Delete test
        public void DeleteTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Delete("castest");
            HandleLogs("[Cmd=Delete]castest：" + cache.CheckAndSet("castest", "a", 0));
        }

        //8.Exists test
        public void ExistsTest()
        {
            HandleLogs("[Cmd=Exists]castest：" + MemcachedClient.Exists("castest"));
        }

        //9.Get test
        public void GetTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Set("liyanze", "Work harder, play happier!", 4711);
            HandleLogs("[Cmd=Get]liyanze：" + cache.Get("liyanze"));
        }

        //10.GetCounter test
        public void GetCounterTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.SetCounter("mycounter", 1213);
            ulong? counter = cache.GetCounter("mycounter");
            if (counter.HasValue)
            {
                HandleLogs("[Cmd=GetCounter]mycounter：" + counter.Value.ToString());
            }
        }

        //11.Gets test
        public void GetsTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            ulong unique = 0;
            cache.Gets("liyanze", out unique);
            HandleLogs("[Cmd=Gets]Getting cas unique for key liyanze：" + unique.ToString());
        }

        //12.Prepend test
        public void PrependTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Prepend("BeIt", "foo prepend");
            HandleLogs("[Cmd=Prepend]BeIt：" + cache.Get("BeIt").ToString());
        }

        //13.Replace test
        public void ReplaceTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Replace("BeIt", "replaced");
            HandleLogs("[Cmd=Replace]BeIt：" + cache.Get("BeIt").ToString());
        }

        //14.Set test
        public void SetTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Set("BeIt", "happy");
            HandleLogs("[Cmd=Set]BeIt：" + cache.Get("BeIt").ToString());
        }

        //15.get mutiple keys,同时获取多个key的value
        public void GetMutipleKeys()
        {
            //Get several values at once
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            object[] result = cache.Get(new string[] { "myinteger", "BeIt" });
            object res0 = result[0];
            string res0Str = "null";
            if (null != res0)
            {
                res0Str = res0.ToString();
            }
            HandleLogs("[Cmd=Get]myinteger：" + res0Str + ",+ BeIt：" + result[1].ToString());
            
        }

        //16.Gets,同时获取多个key的unique
        public void GetsMutipleKeys()
        {
            //Get several values at once
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            
            ulong[] unique = new ulong[2] { 0, 0 };
            object[] result = cache.Gets(new string[] { "myinteger", "BeIt" }, out unique);
            HandleLogs("[Cmd=Gets] GetsMutipleKeys myinteger unique：" + unique[0].ToString() + ",+ BeIt unique：" + unique[1].ToString());
        }

        //17.GetCounter 传递多个key值
        public void GetCounterMutiplekeys()
        {
            //Get several values at once
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.SetCounter("mycounter2", 365);
            ulong?[] result = cache.GetCounter(new string[] { "mycounter", "mycounter2" });
            HandleLogs("[Cmd=Gets]GetCounterMutiplekeys mycounter：" + result[0].ToString() + ",+ mycounter2：" + result[1].ToString());
        }

        public void TestMemcache()
        {
            this.nosqlTb.Text = "";
            switch (funcIndex)
            {
                case 1:
                    {
                        AddTest();
                        break;
                    }
                case 2:
                    {
                        AppendTest();
                        break;
                    }
                case 3:
                    {
                        CheckAndSetTest();
                        break;
                    }
                case 4:
                    {
                        SetCounterTest();
                        break;
                    }
                case 5:
                    {
                        IncrementTest();
                        break;
                    }
                case 6:
                    {
                        DecrementTest();
                        break;
                    }
                case 7:
                    {
                        DeleteTest();
                        break;
                    }
                case 8:
                    {
                        ExistsTest();
                        break;
                    }
                case 9:
                    {
                        GetTest();
                        break;
                    }
                case 10:
                    {
                        GetCounterTest();
                        break;
                    }
                case 11:
                    {
                        GetsTest();
                        break;
                    }
                case 12:
                    {
                        PrependTest();
                        break;
                    }
                case 13:
                    {
                        ReplaceTest();
                        break;
                    }
                case 14:
                    {
                        SetTest();
                        break;
                    }
                case 15:
                    {
                        GetMutipleKeys();
                        break;
                    }
                case 16:
                    {
                        GetsMutipleKeys();
                        break;
                    }
                case 17:
                    {
                        GetCounterMutiplekeys();
                        break;
                    }
                default:
                    break;
            }

            lock (_SyncObject)
            {
                funcIndex++;
                if (funcIndex >= 18)
                {
                    funcIndex = 1;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MemcacheClientLibrary.aspx");
        }

        protected void OnEnyimMemcachedClicked(object sender, EventArgs e)
        {
            Response.Redirect("EnyimCachingMemcached.aspx");
        }
    }
}