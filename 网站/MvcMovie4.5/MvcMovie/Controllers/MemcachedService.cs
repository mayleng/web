using Memcached.ClientLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Xml;

namespace MvcMovie.Controllers
{
    public class MemCachedConfig : IConfigurationSectionHandler
    {
        public int minPoolSize;
        public int maxPoolSize;
        public int connectionTimeout;
        public int socketTimeout;
        public List<String> serverList = new List<string>();

        public object Create(object parent, object configContext, XmlNode section)
        {
            MemCachedConfig config = new MemCachedConfig();
            XmlNode servers = section.SelectSingleNode("servers");
            XmlNode socketPool = section.SelectSingleNode("socketPool");
            if (servers != null && socketPool != null)
            {
                XmlNodeList sList = servers.ChildNodes;
                for (int i = 0; i < sList.Count; i++)
                {
                    config.serverList.Add(sList[i].Attributes["address"].Value as string);
                }
                string minPoolSizeStr = (string)socketPool.Attributes["minPoolSize"].Value;
                string maxPoolSizeStr = (string)socketPool.Attributes["maxPoolSize"].Value;
                string connectionTimeoutStr = (string)socketPool.Attributes["connectionTimeout"].Value;
                string socketTimeoutStr = (string)socketPool.Attributes["socketTimeout"].Value;
                config.minPoolSize = int.Parse(minPoolSizeStr);
                config.maxPoolSize = int.Parse(maxPoolSizeStr);
                config.connectionTimeout = int.Parse(connectionTimeoutStr);
                config.socketTimeout = int.Parse(socketTimeoutStr);
            }
            return config;
        }
    }

    public class MemcachedService
    {
        public static MemcachedService ms;
        public MemCachedConfig mc;
        public MemcachedClient mClient;
        public SockIOPool pool;
        private static bool m_isOn = false;
        public void UnInit()
        {
            pool.Shutdown();
            m_isOn = false;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static MemcachedService GetInstance(string inst)
        {
            if (m_isOn)
                return ms;
            ms = new MemcachedService();
            ms.mc = ConfigurationManager.GetSection("memcached") as MemCachedConfig;
            ms.pool = SockIOPool.GetInstance(inst);
            ms.pool.SetServers(ms.mc.serverList.ToArray());
            ms.pool.MinConnections = ms.mc.minPoolSize;
            ms.pool.MaxConnections = ms.mc.maxPoolSize;
            ms.pool.SocketConnectTimeout = ms.mc.connectionTimeout;
            ms.pool.SocketTimeout = ms.mc.socketTimeout;
            ms.pool.Initialize();
            ms.mClient = new MemcachedClient();
            ms.mClient.PoolName = inst;
            ms.mClient.EnableCompression = true;
            m_isOn = true;

            return ms;

            //String[] serverlist = { "118.194.49.34:11211" };
            //pool = SockIOPool.GetInstance("test");
            //pool.SetServers(serverlist);
            //pool.MinConnections = 3;
            //pool.MaxConnections = 10;
            //pool.SocketConnectTimeout = 2000;
            //pool.SocketTimeout = 10000;
            //pool.Initialize();
            //mClient = new MemcachedClient();
            //mClient.PoolName = "test";
            //mClient.EnableCompression = true;
        }

    }
}