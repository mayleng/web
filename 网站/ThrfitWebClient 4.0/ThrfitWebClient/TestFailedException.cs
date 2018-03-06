using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThrfitWebClient
{
    public class TestFailedException : Exception
    {
        public TestFailedException(string msg) : base(msg) { }
    }     
}