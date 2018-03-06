using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using thrift.demo.print;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThrfitWebClient
{
    public class ThriftJson : ThriftBase
    {
        public override void Test(UpdateDelegate action)
        {
            TTransport transport = new TSocket(m_Ip, 7916);
            TProtocol protocol = new TJSONProtocol(transport);
            PrintServices.Client client = new PrintServices.Client(protocol);

            m_StrTransport = "TSocket";
            m_StrProtocol = "ProtocolJson";

            HandleAdd(transport, client, action);

        }
    }
}