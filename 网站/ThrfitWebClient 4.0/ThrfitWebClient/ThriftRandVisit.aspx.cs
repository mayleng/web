using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThrfitWebClient
{
    public partial class ThriftRandVist : System.Web.UI.Page
    {
        Random Rnd = new Random((int)DateTime.UtcNow.Ticks);
        public string[] ThriftType = 
        { 
            "TriftBinary","TriftCompact","TriftJson",
            "TriftTTLSSocket","TriftTHttpClient","TriftNamePipe",
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            int randNum = Rnd.Next(0, 6);
            this.RandomRetLb.Text = "Rand Thrift Call:" + ThriftType[randNum];
            HandleTest(ThriftType[randNum]);
        }

        //call client function the same like call the server function
        public void HandleTest(string thriftType)
        {
            if (!string.IsNullOrEmpty(thriftType))
            {
                ThriftBase thriftClient = ThriftFactory.GetThrift(thriftType);
                thriftClient.Test(UpdateLabel);
            }
        }

        //set lable
        void UpdateLabel(string str)
        {
            this.resultLb.Text = str;
        }
    }
}