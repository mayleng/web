using System;
using System.Collections.Generic;
//using System.Linq;
using System.Runtime.Remoting;
using System.Text;

namespace RemotingServer
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("RemotingServer.exe.config", false);
            Console.WriteLine("Remoting Http Server Listening...");
            Console.ReadLine();

        }
    }
}
