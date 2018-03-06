using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bonree.Agent.Tests
{
    public partial class BonreeHttpWebRequest : System.Web.UI.Page
    {
        public delegate void UpdateDelegate(string str);
        public static string str = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //GetResponse Test
        protected void GetResponseBtn_Click(object sender, EventArgs e)
        {
            this.httpWebRequestTb.Text = "";
            string html = DoSimpleGet("http://baike.baidu.com/");
            if (!string.IsNullOrEmpty(html))
            {
                this.httpWebRequestTb.Text = "http://baike.baidu.com/" + " response is ok!";
            }
        }

        private string DoSimpleGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);   //创建一个请求示例
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();　　//获取响应，即发送请求
            Stream responseStream   = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
            string html = streamReader.ReadToEnd();
            streamReader.Close();
            responseStream.Close();
            response.Close();

            return html;
        }

        private void GetWeatherAsync(string city)
        {
            string weatherHtml = string.Empty;
            //转换输入参数的编码类型
            string cityInfo = HttpUtility.UrlEncode(city, System.Text.UnicodeEncoding.GetEncoding("GB2312"));
            //初始化新的webRequst
            string url = "http://php.weather.sina.com.cn/search.php?city=" + cityInfo;
            HttpWebRequest weatherRequest = (HttpWebRequest)WebRequest.Create(url);

            weatherRequest.BeginGetResponse(new AsyncCallback(OnResponse), weatherRequest);

        }

        void OnResponse(IAsyncResult ar)
        {
            HttpWebRequest request = (HttpWebRequest)ar.AsyncState;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(ar);
            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream, Encoding.UTF8);
            string weatherHtml = sr.ReadToEnd();
            str = "GetAsyncOk" + "," + DateTime.Now;
        }

        public void GetAsync_Click(object sender, EventArgs e)
        {
            
            GetWeatherAsync("武汉");
            httpWebRequestTb.Text = "GetAsyncOk : " + DateTime.Now;
        }

        public void Post_Click(Object sender, EventArgs e)
        {
            DoPost("hello!");
            httpWebRequestTb.Text = "Post : " + DateTime.Now;
        }

        public void DoPost(string str)
        {
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://fanyi.baidu.com/transcontent");
            Encoding encoding = Encoding.UTF8;
            string param = "ie=utf-8&source=txt&query=hello&t=1327829764203&token=8a7dcbacb3ed72cad9f3fb079809a127&from=auto&to=auto";
            byte[] bs = Encoding.ASCII.GetBytes(param);
            string responseData = String.Empty;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = bs.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
                reqStream.Close();
            }
            using (HttpWebResponse response = (HttpWebResponse)req.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), encoding))
                {
                    responseData = reader.ReadToEnd().ToString();
                }

                str = "GetRequestStream ok" + DateTime.Now;
            }
        }


    }
}