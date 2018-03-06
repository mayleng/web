using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace WebApplication1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("http://localhost:1189/api/product/GetAllProduct").Result;
            var responseJson = response.Content.ReadAsStringAsync().Result;
            Response.Write(responseJson);
            var products = JsonConvert.DeserializeObject<IList<Product>>(responseJson);

            products.ToList().ForEach(x => Response.Write(x.Id + "：" + x.Name + ":" + x.Category + ":" + x.Price));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:1189/api/product/GetProduct/";
            url += TextBox1.Text;
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync(url).Result;
            var responseJson = response.Content.ReadAsStringAsync().Result;
            Response.Write(responseJson);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var requestJson = JsonConvert.SerializeObject(new Product { Id = 5, Name = "New", Category = "Hardware", Price = 15M });

            HttpContent httpContent = new StringContent(requestJson);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var httpClient = new HttpClient();
            var responseJson = httpClient.PostAsync("http://localhost:1189/api/product/AddProduct", httpContent)
                .Result.Content.ReadAsStringAsync().Result;

            Response.Write(responseJson);
            var products = JsonConvert.DeserializeObject<IList<Product>>(responseJson);

            products.ToList().ForEach(x => Response.Write(x.Id + "：" + x.Name + ":" + x.Category + ":" + x.Price));

        }
    }
}