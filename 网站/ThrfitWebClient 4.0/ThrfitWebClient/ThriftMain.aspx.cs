using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using thrift.demo.print;
using Thrift.Protocol;
using Thrift.Transport;

namespace ThrfitWebClient
{
    public delegate void UpdateDelegate(string str);
    public partial class ThriftMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //click button event
        protected void ThriftClickEvent(object sender, EventArgs e)
        {
            HandleTest(sender);
        }

        //call client function the same like call the server function
        public void HandleTest(object sender)
        {
            if (sender != null && sender is Button)
            {
                Button btn = (Button)sender;
                string btnText = btn.Text.Trim();
                ThriftBase thriftClient = ThriftFactory.GetThrift(btnText);
                thriftClient.Test(UpdateLabel);
            }
        }

        //set lable
        void UpdateLabel(string str)
        {
            this.resultLb.Text = str;
        }

        protected void RandomVisitBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThriftRandVisit.aspx");
        }
    }

  
}