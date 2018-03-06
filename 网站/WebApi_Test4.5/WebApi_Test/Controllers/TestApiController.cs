using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_Test.Controllers
{
    public class TestApiController : ApiController
    {
        /// <summary>
        /// http://localhost:8888/api/TestApi_Test/GetTest1
        /// </summary>
        /// <returns></returns>

        public string GetTest1()
        {
            return "hello world";
        }


        ///http://localhost:8888/api/TestApi_Test/GetTest1/Helloworld
        [HttpGet]
        [ActionName("Thumbnail")]
        public string GetTest2(string id)
        {
            return id.ToString()+"哈哈！" ;
           
        }

    }
}
