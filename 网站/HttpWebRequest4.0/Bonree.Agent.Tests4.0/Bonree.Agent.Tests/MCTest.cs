using BeIT.MemCached;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemcacheClient
{
    public class MCTest
    {
        Random Rnd = new Random((int)DateTime.UtcNow.Ticks);
        private static bool IsLoad = false;
        Object _SyncObject = new Object();
        private static int funcIndex = 1;

        public bool MemcacheClientInit()
        {
            MemcachedClient.Setup("BeITMemcached", new string[] { "127.0.0.1" });
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.SendReceiveTimeout = 5000;
            cache.ConnectTimeout = 5000;
            cache.MinPoolSize = 1;
            cache.MaxPoolSize = 5;

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

        public String HandleLogs(string str)
        {
            string testIndex = "测试序号[" + funcIndex + "]:";
            str += "\r\n";
            str = testIndex + str;
            //this.nosqlTb.Text += str;
            return str;
        }

        //1.Add test
        public String AddTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Add("BeIt", "123");
            return HandleLogs("[Cmd=Add]BeIt：" + cache.Get("BeIt").ToString());
        }

        //2.Append test
        public String AppendTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Append("BeIt", " baz");
            return HandleLogs("[Cmd=Append]BeIt：" + cache.Get("BeIt").ToString());
        }

        //3.CheckAndSet test
        public String CheckAndSetTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Set("castest", "a");
            //Trying to CAS key castest with the wrong unique
            return HandleLogs("[Cmd=CheckAndSet]castest：" + cache.CheckAndSet("castest", "a", 0));

        }

        //4.SetCounter test
        public String SetCounterTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.SetCounter("mycounter", 9000);
            ulong? counter = cache.GetCounter("mycounter");
            if (counter.HasValue)
            {
                return HandleLogs("[Cmd=SetCounter]mycounter：" + counter.Value.ToString());
            }
            return null;
        }

        //5.Increment the counter test
        public String IncrementTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            ulong? counter = cache.Increment("mycounter", 1);
            if (counter.HasValue)
            {
                return HandleLogs("[Cmd=Increment]mycounter：" + counter.Value.ToString());
            }
            return null;
        }

        //6.Decrement the counter test
        public String DecrementTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            ulong? counter = cache.Decrement("mycounter", 9000);
            if (counter.HasValue)
            {
                return HandleLogs("[Cmd=Decrement]mycounter：" + counter.Value.ToString());
            }
            return null;
        }

        //7.Delete test
        public String DeleteTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Delete("castest");
            return HandleLogs("[Cmd=Delete]castest：" + cache.CheckAndSet("castest", "a", 0));
        }

        //8.Exists test
        public String ExistsTest()
        {
            return HandleLogs("[Cmd=Exists]castest：" + MemcachedClient.Exists("castest"));
        }

        //9.Get test
        public String GetTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Set("liyanze", "Work harder, play happier!", 4711);
            return HandleLogs("[Cmd=Get]liyanze：" + cache.Get("liyanze"));
        }

        //10.GetCounter test
        public String GetCounterTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.SetCounter("mycounter", 1213);
            ulong? counter = cache.GetCounter("mycounter");
            if (counter.HasValue)
            {
                return HandleLogs("[Cmd=GetCounter]mycounter：" + counter.Value.ToString());
            }
            return null;
        }

        //11.Gets test
        public String GetsTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            ulong unique = 0;
            cache.Gets("liyanze", out unique);
            return HandleLogs("[Cmd=Gets]Getting cas unique for key liyanze：" + unique.ToString());
        }

        //12.Prepend test
        public String PrependTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Prepend("BeIt", "foo prepend");
            return HandleLogs("[Cmd=Prepend]BeIt：" + cache.Get("BeIt").ToString());
        }

        //13.Replace test
        public String ReplaceTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Replace("BeIt", "replaced");
            return HandleLogs("[Cmd=Replace]BeIt：" + cache.Get("BeIt").ToString());
        }

        //14.Set test
        public String SetTest()
        {
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.Set("BeIt", "happy");
            return HandleLogs("[Cmd=Set]BeIt：" + cache.Get("BeIt").ToString());
        }

        //15.get mutiple keys,同时获取多个key的value
        public String GetMutipleKeys()
        {
            //Get several values at once
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            object[] result = cache.Get(new string[] { "myinteger", "BeIt" });
            return HandleLogs("[Cmd=Get]myinteger：" + result[0].ToString() + ",+ BeIt：" + result[1].ToString());

        }

        //16.Gets,同时获取多个key的unique
        public String GetsMutipleKeys()
        {
            //Get several values at once
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");

            ulong[] unique = new ulong[2] { 0, 0 };
            object[] result = cache.Gets(new string[] { "myinteger", "BeIt" }, out unique);
            return HandleLogs("[Cmd=Gets] GetsMutipleKeys myinteger unique：" + unique[0].ToString() + ",+ BeIt unique：" + unique[1].ToString());
        }

        //17.GetCounter 传递多个key值
        public String GetCounterMutiplekeys()
        {
            //Get several values at once
            MemcachedClient cache = MemcachedClient.GetInstance("BeITMemcached");
            cache.SetCounter("mycounter2", 365);
            ulong?[] result = cache.GetCounter(new string[] { "mycounter", "mycounter2" });
            return HandleLogs("[Cmd=Gets]GetCounterMutiplekeys mycounter：" + result[0].ToString() + ",+ mycounter2：" + result[1].ToString());
        }

        public String TestMemcache()
        {
            switch (funcIndex)
            {
                case 1:
                    {
                        return AddTest();
                        break;
                    }
                case 2:
                    {
                        return AppendTest();
                        break;
                    }
                case 3:
                    {
                        return CheckAndSetTest();
                        break;
                    }
                case 4:
                    {
                        return SetCounterTest();
                        break;
                    }
                case 5:
                    {
                        return IncrementTest();
                        break;
                    }
                case 6:
                    {
                        return DecrementTest();
                        break;
                    }
                case 7:
                    {
                        return DeleteTest();
                        break;
                    }
                case 8:
                    {
                        return ExistsTest();
                        break;
                    }
                case 9:
                    {
                        return GetTest();
                        break;
                    }
                case 10:
                    {
                        return GetCounterTest();
                        break;
                    }
                case 11:
                    {
                        return GetsTest();
                        break;
                    }
                case 12:
                    {
                        return PrependTest();
                        break;
                    }
                case 13:
                    {
                        return ReplaceTest();
                        break;
                    }
                case 14:
                    {
                        return SetTest();
                        break;
                    }
                case 15:
                    {
                        return GetMutipleKeys();
                        break;
                    }
                case 16:
                    {
                        return GetsMutipleKeys();
                        break;
                    }
                case 17:
                    {
                        return GetCounterMutiplekeys();
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
            return null;
        }

    }
}