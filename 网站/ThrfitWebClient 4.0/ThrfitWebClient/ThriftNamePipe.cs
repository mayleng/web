using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using thrift.demo.print;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThrfitWebClient
{
    public class ThriftNamePipe : ThriftBase
    {
        public override void Test(UpdateDelegate action)
        {
            string pipeName = "pipe123";
            TTransport transport = new TNamedPipeClientTransport(pipeName);
            TProtocol protocol = new TBinaryProtocol(transport);
            PrintServices.Client client = new PrintServices.Client(protocol);

            m_StrTransport = "TNamedPipe";
            m_StrProtocol = "TBinaryProtocol"; 

            if (!transport.IsOpen)
            {
                transport.Open();
            }
            testAdd(client, action);
            transport.Close();
        }
    }
}