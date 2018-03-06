using System;
using System.Collections.Generic;

using System.Web;
using System.Threading;


using System.Web.UI;
using System.Web.UI.WebControls;

using TestWebService.MyWebReference;
using TestWebService.WeatherServiceReference1;
using System.Net;

namespace TestWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        double m_result;
        //WebService1 servAsync;
        WebService1 servAsync = new WebService1();

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(DateTime.Now.ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService1 serv = new WebService1();
            int a = (int)Convert.ToInt32(ViewState["m_x"]);
            int b = (int)Convert.ToInt32(ViewState["m_y"]);
            m_result = serv.Sum(a, b);
            TextBox3.Text = Convert.ToString(m_result);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            WeatherWebServiceSoapClient serv = new WeatherWebServiceSoapClient();
            string[] provinceList = serv.getSupportProvince();

            TextBox3.Text = Convert.ToString(provinceList[0]);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            WebService1 serv = new WebService1();

            double a = (double)Convert.ToDouble(ViewState["m_x"]);
            double b = (double)Convert.ToDouble(ViewState["m_y"]);


            m_result = serv.Mult(a, b);

            TextBox3.Text = Convert.ToString(m_result);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            WebService1 serv = new WebService1();

            double a = (double)Convert.ToDouble(ViewState["m_x"]);
            double b = (double)Convert.ToDouble(ViewState["m_y"]);
 

            m_result = serv.Div(a, b);

            TextBox3.Text = Convert.ToString(m_result);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            WebService1 serv = new WebService1();

            string a = Convert.ToString(ViewState["m_x"]);
            string b = Convert.ToString(ViewState["m_y"]);

            string strName = a + "  " + b;

            serv.SetPlayerName(strName);            


            //TextBox3.Text = serv.GetPlayerName();
            //TextBox3.Text = Convert.ToString(m_result);;
        }


        private void MyCallBack(System.IAsyncResult result)
        {
            string RetValue;
            RetValue = servAsync.EndHelloWorld(result);

            Application["Name"] = RetValue + "123";

            return;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {            
            TextBox1.Text = Thread.CurrentThread.ManagedThreadId.ToString();

            AsyncCallback cb = new AsyncCallback(MyCallBack);

            servAsync.BeginHelloWorld(cb, null);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            AsyncCallback cb = new AsyncCallback(MyCallBack);

            IAsyncResult ar = servAsync.BeginHelloWorld(null, null);
            
            DateTime begin = System.DateTime.Now;
            ar.AsyncWaitHandle.WaitOne();
            DateTime end = System.DateTime.Now;

            string RetValue = servAsync.EndHelloWorld(ar);

            TextBox2.Text = begin.Millisecond.ToString();
            TextBox3.Text = end.Millisecond.ToString();
            TextBox4.Text = RetValue;

            return;
        }

        private void OnHelloWorldComplete(object sender, HelloWorldCompletedEventArgs e)
        {
            string RetValue = e.Result;

            Application["Name"] = RetValue;

            return;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            servAsync.HelloWorldCompleted += new HelloWorldCompletedEventHandler(OnHelloWorldComplete);
            servAsync.HelloWorldAsync();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {            
            AsyncCallback cb = new AsyncCallback(MyCallBack);
            
            IAsyncResult ar = servAsync.BeginHelloWorld(null, null);

            int count = 0;
            DateTime begin = System.DateTime.Now;
            while (!ar.IsCompleted)
            {
                count++;
            }
            DateTime end = System.DateTime.Now;

            string RetValue = servAsync.EndHelloWorld(ar);

            TextBox1.Text = count.ToString();
            TextBox2.Text = begin.Millisecond.ToString();
            TextBox3.Text = end.Millisecond.ToString();
            TextBox4.Text = RetValue;
            
            return;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            TextBox3.Text = (string)Application["Name"];
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ViewState["m_x"] = TextBox1.Text;
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            ViewState["m_y"] = TextBox2.Text;
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}