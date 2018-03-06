using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using thrift.demo.print;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThrfitWebClient
{
    public class ThriftTHttpClient : ThriftBase
    {
        public override void Test(UpdateDelegate action)
        {
            string myUri = @"http://"+ m_Ip + @":7913";
            TTransport transport = new THttpClient(new Uri(myUri));
            TProtocol protocol = new TJSONProtocol(transport);
            PrintServices.Client client = new PrintServices.Client(protocol);

            m_StrTransport = "THttpClient";
            m_StrProtocol = "TBinaryProtocol";

            HandleAdd(transport, client, action);

        }
    }
}