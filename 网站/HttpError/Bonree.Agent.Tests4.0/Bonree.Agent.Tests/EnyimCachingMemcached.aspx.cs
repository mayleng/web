using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bonree.Agent.Tests
{
    public partial class EnyimCachingMemcached : System.Web.UI.Page
    {
        Random Rnd = new Random((int)DateTime.UtcNow.Ticks);
        Object _SyncObject = new Object();
        private static int funcIndex = 1;
        public delegate void MemcacheTestDelegate();
        private static bool IsLoad = false;
        private static List<MemcacheTestDelegate> allDelegates = new List<MemcacheTestDelegate>();
        public static string strRes = "";
        //每次刷新都会调用
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

            Test();
            this.nosqlTb.Text = strRes;
        }

        public void Test()
        {
            if (funcIndex >= 1)
            {
                allDelegates[funcIndex - 1]();
            }
            
            lock (_SyncObject)
            {
                funcIndex++;
                if (funcIndex > allDelegates.Count)
                {
                    funcIndex = 1;
                }
            }
        }

        public void MemcacheClientInit()
        {
            allDelegates.Add(StoreTest);
            allDelegates.Add(GetTest);
            allDelegates.Add(AppendTest);
            allDelegates.Add(IncrementTest);
            allDelegates.Add(DecrementTest);
            allDelegates.Add(GetWithCasTest);
            allDelegates.Add(PrependTest);
            allDelegates.Add(RemoveTest);
            allDelegates.Add(MutilGetTest);
            allDelegates.Add(TryGetTest);
            allDelegates.Add(MultiGetWithCasTest);
            allDelegates.Add(ExecuteMutiGetTest);
        }

        protected MemcachedClient GetClient()
        {
            MemcachedClientConfiguration config = new MemcachedClientConfiguration();
            config.AddServer("127.0.0.1", 11211);
            config.Protocol = MemcachedProtocol.Binary;
            MemcachedClient client = new MemcachedClient(config);
            //client.FlushAll();

            return client;
        }

        public void HandleLogs(string str)
        {
            string testIndex = "测试序号[" + funcIndex + "]:";
            str += "\r\n";
            str = testIndex + str;
            
            strRes = str;
        }

        //store test
        public void StoreTest()
        {
            MemcachedClient client = GetClient();
            client.Store(StoreMode.Set, "StoreTest", "Done");
            HandleLogs("[Cmd=Store]StoreTest：" + client.Get("StoreTest").ToString());
        }


        //get test
        public void GetTest()
        {
            MemcachedClient client = GetClient();
            client.Store(StoreMode.Set, "GetTest", "Done");
            HandleLogs("[Cmd=Get]TestGet：" + client.Get("GetTest").ToString());
        }

        //append test
        public void AppendTest()
        {
            MemcachedClient client = GetClient();
            var r1 = client.Cas(StoreMode.Set, "CasAppend", "foo");
            var r2 = client.Append("CasAppend", r1.Cas, new System.ArraySegment<byte>(new byte[] { (byte)'l' }));
            HandleLogs("[Cmd=Append]CasAppend：" + client.Get("CasAppend").ToString());
        }

        //cas test
        public void CasTest()
        {
            MemcachedClient client = GetClient();
            var r1 = client.Cas(StoreMode.Set, "TestCas", "Done");
            HandleLogs("[Cmd=Cas]TestCas：" + client.Get("TestCas").ToString());
        }
        
        //test Increment Test
        public void IncrementTest()
        {
            MemcachedClient client = GetClient();
            client.Store(StoreMode.Set, "VALUE", "100");
            client.Increment("VALUE", 0, 2);
            HandleLogs("[Cmd=Increment]VALUE：" + client.Get("VALUE").ToString());
  
        }

        //test Decrement test
        public void DecrementTest()
        {
            MemcachedClient client = GetClient();
            client.Store(StoreMode.Set, "VALUE", "100");
            client.Decrement("VALUE", 0, 50);
            HandleLogs("[Cmd=Decrement]VALUE：" + client.Get("VALUE").ToString());
        }

        //test GetWithCas
        public void GetWithCasTest()
        {
            MemcachedClient client = GetClient();
            var r1 = client.Store(StoreMode.Set, "GetWithCasTest", "Done");
            var r2 = client.GetWithCas<string>("GetWithCasTest");
            HandleLogs("[Cmd=GetWithCas]CasResult：" + r2.StatusCode);
        }

        //test Prepend
        public void PrependTest()
        {
            MemcachedClient client = GetClient();
            var r1 = client.Cas(StoreMode.Set, "CasPrepend", "ool");
            var r2 = client.Prepend("CasPrepend", r1.Cas, new System.ArraySegment<byte>(new byte[] { (byte)'f' }));
            HandleLogs("[Cmd=Prepend]CasPrepend：" + client.Get("CasPrepend").ToString());
        }

        // test remove
        public void RemoveTest()
        {
            MemcachedClient client = GetClient();
		    string TestObjectKey = "Hello_World";
            client.Store(StoreMode.Set, TestObjectKey, "devin");
            bool isRemoved = client.Remove(TestObjectKey);
            HandleLogs("[Cmd=Remove]Hello_World is removed " + isRemoved);
        }
        
        //mutil get test
        public void MutilGetTest()
        {
            var prefix = new Random().Next(300) + ":";
			// note, this test will fail, if memcached version is < 1.2.4
            using (var client = GetClient())
            {
                var keys = new List<string>();
                for (int i = 0; i < 3; i++)
                {
                    string k = prefix + "_Hello_Multi_Get_" + i;
                    keys.Add(k);
                    client.Store(StoreMode.Set, k, i);
                }

                IDictionary<string, object> retvals = client.Get(keys);
                var values = new List<string>();
                object value;
                for (int i = 0; i < keys.Count; i++)
                {
                    retvals.TryGetValue(keys[i], out value);
                    values.Add(Convert.ToString(value));
                }
                HandleLogs("[Cmd=Get]MutilGetTest key = " + string.Join(",", keys.ToArray()) + ", value = " + string.Join(",", values.ToArray()));
            }
        }

        //try get test
        public void TryGetTest()
        {
            using (var client = GetClient())
            {
                client.Store(StoreMode.Set, "goHome", "Done");
                object retVal;
                client.TryGet("goHome", out retVal);
                if (retVal is string)
                {
                    HandleLogs("[Cmd=TryGet]goHome= " + retVal.ToString());
                }
  
            }
        }

        //try get with cas
        public virtual void MultiGetWithCasTest()
        {
            var prefix = new Random().Next(300) + ":";
            using (var client = GetClient())
            {
                var keys = new List<string>();

                for (int i = 0; i < 3; i++)
                {
                    string k = prefix + "_Cas_Multi_Get_" + i;
                    keys.Add(k);
                    client.Store(StoreMode.Set, k, i);
                }

                IDictionary<string, CasResult<object>> retvals = client.GetWithCas(keys);
                var values = new List<string>();
                CasResult<object> value;
                for (int i = 0; i < keys.Count; i++)
                {
                    retvals.TryGetValue(keys[i], out value);
                    values.Add(Convert.ToString(value.Result));
                }

                HandleLogs("[Cmd=MultiGetWithCas]MultiGetWithCas key = " + string.Join(",", keys.ToArray()) + ", value = " + string.Join(",", values.ToArray()));
            }
        }


        protected string GetUniqueKey(string prefix = null)
        {
            return (String.IsNullOrEmpty(prefix) ? "" : prefix + "_")
                    + "unit_test_"
                    + DateTime.Now.Ticks
                    + "_" + Rnd.Next();
        }

        protected IEnumerable<string> GetUniqueKeys(string prefix = null, int max = 5)
        {
            var keys = new List<string>(max);

            for (int i = 0; i < max; i++)
            {
                keys.Add(GetUniqueKey(prefix));
            }

            return keys;
        }

        public void ExecuteMutiGetTest()
        {
            using (var client = GetClient())
            {
                var keys = GetUniqueKeys().Distinct();
                foreach (var key in keys)
                {
                    client.Store(StoreMode.Set, key, "Value for" + key);
                }

                var dict = client.ExecuteGet(keys);
                var values = new List<string>();
                foreach (var key in dict.Keys)
                {
                    values.Add(dict[key].Value.ToString());
                }

                HandleLogs("[Cmd=ExecuteMutiGet]ExecuteMutiGet key = " + string.Join(",", keys.ToArray()) + ", value = " + string.Join(",", values.ToArray()));
            }
            
        }

        protected void OnBeITMemcachedClicked(object sender, EventArgs e)
        {
            Response.Redirect("BeITMemcached.aspx");
        }

        protected void OnMemcachedClientLibraryClicked(object sender, EventArgs e)
        {
            Response.Redirect("MemcacheClientLibrary.aspx");
        }
    }
}