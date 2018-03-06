using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using thrift.demo.print;
using Thrift.Protocol;
using Thrift.Transport;


namespace ThrfitWebClient
{
    public class ThriftTTLSSocket : ThriftBase
    {
        public override void Test(UpdateDelegate action)
        {
             
            string appSetting = ConfigurationManager.AppSettings["CertPath"];
            if (string.IsNullOrEmpty(appSetting))
            {
                throw new Exception("授权文件路径为空，需要进行设置!设置位置： Web.Config->appSettings->CertPath");
            }
            string certPath = appSetting + "\\client.p12";
            if (!File.Exists(certPath))
            {
                throw new Exception("授权文件不存在, 请确认文件夹路径是否正确!" + certPath);
            }
            string password = "thrift";
            string currentPath = Directory.GetCurrentDirectory();
            TTransport transport = new TTLSSocket(m_Ip, 7912, new X509Certificate2(certPath, password), RemoteCertificateCallback);
            TProtocol protocol = new TBinaryProtocol(transport);
            PrintServices.Client client = new PrintServices.Client(protocol);

            m_StrTransport = "TTLSSocket";
            m_StrProtocol = "TBinaryProtocol";

            HandleAdd(transport, client, action);

        }

        private static bool RemoteCertificateCallback(Object sender,
                                                      X509Certificate certificate,
                                                      X509Chain chain,
                                                      SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                //Console.WriteLine(sslPolicyErrors.ToString());
            }

            return true;
        }
    }
}