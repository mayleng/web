using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using thrift.demo.print;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThrfitWebClient
{
    

    public class ThriftCompact : ThriftBase
    {
        public override void Test(UpdateDelegate action)
        {
            TTransport transport = new TSocket(m_Ip, 7915);
            TProtocol protocol = new TCompactProtocol(transport);
            PrintServices.Client client = new PrintServices.Client(protocol);

            m_StrTransport = "TSocket";
            m_StrProtocol = "TProtocolCompact";

            HandleAdd(transport, client, action);

        }
    }
}