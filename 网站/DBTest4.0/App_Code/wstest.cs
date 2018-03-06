using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// wstest 的摘要说明
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
// [System.Web.Script.Services.ScriptService]
public class wstest : System.Web.Services.WebService {

    public wstest () {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

  //  [WebMethod]
  //  public string HelloWorld() {
  //      return "Hello World";
  //  }

    ///<summary>
    ///加减乘除四大方法
    ///<summary>
    ///因为四大方法都是双目运算，所以有两个参数number1和number2
    [WebMethod(Description="加法")]
    public double Add(double number1,double number2)
    {
        return number1+number2;
    }

    [WebMethod(Description = "减法")]
    public double Sub(double number1, double number2)
    {
        return number1 - number2;
    }

    [WebMethod(Description = "乘法")]
    public double Plus(double number1, double number2)
    {
        return number1 * number2;
    }

    [WebMethod(Description = "除法")]
    public double Div(double number1, double number2)
    {
        if (number2 != 0)
            return number1 / number2;
        else
            return 0;
    }

    [WebMethod(Description = "HelloWorld")]
    public string HelloWorld()
    {
        return "HelloWorld!";
    }
}
