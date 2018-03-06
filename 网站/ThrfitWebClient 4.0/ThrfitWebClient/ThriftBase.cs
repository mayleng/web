using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using thrift.demo.print;
using Thrift.Transport;

namespace ThrfitWebClient
{
    public class ThriftBase
    {
        public string m_StrTransport;
        public string m_StrProtocol;
        public string m_result;
        public string m_Ip;

        public ThriftBase()
        {
            m_Ip = ConfigurationManager.AppSettings["ThriftIp"];
        }
        public virtual void Test(UpdateDelegate action)
        {

        }

        public void HandleAdd(TTransport transport, PrintServices.Client client, UpdateDelegate action)
        {
            try
            {
                transport.Open();
                testAdd(client, action);
            }
            catch (System.Exception)
            {
                throw new Exception("无法连接到服务器[ip和port是否设置正确]");
            }
            finally
            {
                transport.Close();
            }
        }

        public void testAdd(PrintServices.Client client, UpdateDelegate action)
        {
            int x = 1;
            int y = 2;
            int sum = client.add(x, y);

            m_result = "x=" + x + "," + "y=" + y + "," + "Sum=" + sum;

            string str = m_StrTransport + "\n" + m_StrProtocol + "\n" + m_result + "\n";

            action(str);

            if (sum != x + y)
            {
                throw new TestFailedException("testAdd Fail!");
            }

            return;
        }
    }
}