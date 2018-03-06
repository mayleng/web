<%@ Application Language="C#" %>
<%@ Import Namespace="localhost" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // 在应用程序启动时运行的代码
        AuthConfig.RegisterOpenAuth();
        RouteConfig.RegisterRoutes(RouteTable.Routes);
    }
    
    void Application_End(object sender, EventArgs e)
    {
        //  在应用程序关闭时运行的代码

    }

    void Application_Error(object sender, EventArgs e)
    {
        // 在出现未处理的错误时运行的代码

    }
    
    //生成小于30的非负整数
    int randomAge()
    {
        Random rand=new Random();
        return rand.Next(30);
    }
    
    //产生两位小写字母
    string randomTwochars()
    {
        Random rand=new Random();
        string twochars;
        twochars = Convert.ToString(rand.Next(26) + 97);
        twochars += Convert.ToString(rand.Next(26) + 97);
        return twochars;
    }
</script>
