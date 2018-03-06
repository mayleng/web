using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using thrift.demo.print;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThrfitWebClient
{
    public class ThriftBinary : ThriftBase
    {
        public override void Test(UpdateDelegate action)
        {
            TTransport transport = new TSocket(m_Ip, 7911);
            TProtocol protocol = new TBinaryProtocol(transport,false,false);
            PrintServices.Client client = new PrintServices.Client(protocol);

            m_StrTransport = "TSocket";
            m_StrProtocol = "TBinaryProtocol";
            HandleAdd(transport, client, action);
        }

    }
}