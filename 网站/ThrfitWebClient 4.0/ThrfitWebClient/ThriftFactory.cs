using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThrfitWebClient
{
    public enum ThrifType
    {
        THRIFT_BINARY =1,

    }

    //factory design pattern
    public class ThriftFactory
    {
        public static ThriftBase GetThrift(string thriftType)
        {
            if (thriftType == "TriftBinary")
            {
                return new ThriftBinary();
            }
            else if (thriftType == "TriftCompact")
            {
                return new ThriftCompact();
            }
            else if (thriftType == "TriftJson")
            {
                return new ThriftJson();
            }
            else if (thriftType == "TriftTTLSSocket")
            {
                return new ThriftTTLSSocket();
            }
            else if (thriftType == "TriftTHttpClient")
            {
                return new ThriftTHttpClient();
            }
            else if (thriftType == "TriftNamePipe")
            {
                return new ThriftNamePipe();
            }

            return new ThriftNullObject();
        }
    }
}