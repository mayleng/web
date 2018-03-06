using System;
using System.Collections.Generic;
//using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bonree.Agent.Tests
{
    //Remoting 测试，更改配置http或者tcp即可进行协议的切换
    //服务器目前用的一个console
    public partial class Remoting : System.Web.UI.Page
    {
        //public static ManualResetEvent e;
        public delegate string RemoteSyncDelegate();
        public delegate string RemoteAsyncDelegate();
        public static bool isSync = true;
        public Object _sync = new Object();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (isSync)
            {
                SyncCall();
            }
            else
            {
                AsyncCall();
            }
            isSync = !isSync;
        }

        public void SyncCall()
        {
            string serviceUrl = System.Configuration.ConfigurationManager.AppSettings["ServiceURL"];
            RemoteObject.MyObject app = (RemoteObject.MyObject)Activator.GetObject(typeof(RemoteObject.MyObject),serviceUrl);
            Response.Write("[Sync]app.Add(18, 22) = " + app.Add(18, 22) + "<br/>");
        }

        // This is the call that the AsyncCallBack delegate references.
        [OneWayAttribute]
        public void OurRemoteAsyncCallBack(IAsyncResult ar)
        {
            lock (_sync)
            {
                RemoteAsyncDelegate del = (RemoteAsyncDelegate)((AsyncResult)ar).AsyncDelegate;
                del.EndInvoke(ar);
                //e.Set();
            }
        }


        public void AsyncCall()
        {
            //e = new ManualResetEvent(false);
            try
            {
                string serviceUrl = System.Configuration.ConfigurationManager.AppSettings["ServiceURL"];
                RemoteObject.MyObject app = (RemoteObject.MyObject)Activator.GetObject(typeof(RemoteObject.MyObject), serviceUrl);
                AsyncCallback RemoteCallback = new AsyncCallback(this.OurRemoteAsyncCallBack);
                RemoteAsyncDelegate RemoteDel = new RemoteAsyncDelegate(app.TimeConsumingRemoteCall);
                IAsyncResult RemAr = RemoteDel.BeginInvoke(RemoteCallback, null);
                Response.Write("Async Function calling... ");
                RemAr.AsyncWaitHandle.WaitOne();

            }
            catch (Exception)
            {

            }

        }
    }
}
