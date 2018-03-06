using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Threading.Tasks;

public partial class WebApi : System.Web.UI.Page
{
    public static int i = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string id = TextBox1.Text.Trim();
        //string id = "WebAPI";
        HttpClient hclient = new HttpClient();
        // hclient.BaseAddress = new Uri("http://localhost:9695/WebApi_Test/");
        HttpResponseMessage response = hclient.GetAsync("http://localhost:9695/api/TestApi/Thumbnail/" + id).Result;  //端口根据服务端端口
        string sb = "love";
        response.Content.ReadAsStringAsync().ContinueWith((str) =>{sb = str.Result; });
        
        Response.Write("<script>window.alert('" + sb + "')</script>");
    }

    protected void NoBaseAddressCall()
    {
        string id = TextBox1.Text.Trim();
        //string id = "WebAPI";
        HttpClient hclient = new HttpClient();
        // hclient.BaseAddress = new Uri("http://localhost:9695/WebApi_Test/");
        HttpResponseMessage response = hclient.GetAsync("http://localhost:9695/api/TestApi/Thumbnail" + id).Result;
        string sb = "love";
        response.Content.ReadAsStringAsync().ContinueWith(
            (str) => {
                sb = str.Result;
                });
        Thread.Sleep(30);
        Response.Write("<script>window.alert('" + id + sb + "');window.location.href='Default.aspx'</script>");
    }

    public void BaseAddressCall()
    {
        string id = TextBox1.Text.Trim();
        //string id = "WebAPI";
        HttpClient hclient = new HttpClient();
        hclient.BaseAddress = new Uri("http://localhost/WebApi_Test/");
        // hclient.BaseAddress = new Uri("http://localhost/WebApi_Test/");
        HttpResponseMessage response = hclient.GetAsync("api/TestApi/Thumbnail/" + id).Result;
        string sb = "love";
        response.Content.ReadAsStringAsync().ContinueWith(
           (str) =>
           {
               sb = str.Result;
           });
        Thread.Sleep(30);
        Response.Write("<script>window.alert('" + id + sb + "');window.location.href='Default.aspx'</script>");
    }
}
