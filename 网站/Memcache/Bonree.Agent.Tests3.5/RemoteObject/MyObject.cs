using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;

namespace RemoteObject
{
    public class MyObject : MarshalByRefObject
    {
        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// 
        [SoapMethod(XmlNamespace = "RemoteObject", SoapAction = "MyObject#Add")]
        public int Add(int a, int b)
        {
            Console.WriteLine("Add Called!");
            return a + b;
        }
        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Less(int a, int b)
        {
            Console.WriteLine("Less Called!");
            if (a >= b)
            {
                return a - b;
            }
            else
            {
                return b - a;
            }
        }
        /// <summary>
        /// 乘法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Multiply(int a, int b)
        {
            Console.WriteLine("Multiply Called!");
            return a * b;
        }
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Division(int a, int b)
        {
            Console.WriteLine("Division Called!");
            if (a >= b)
            {
                if (a % b == 0)
                {
                    return a / b;
                }
                else
                {
                    return Convert.ToInt32(a / b);
                }
            }
            else
            {
                if (b % a == 0)
                {
                    return b / a;
                }
                else
                {
                    return Convert.ToInt32(b / a);
                }

            }
        }

        [SoapMethod(XmlNamespace = "RemoteObject", SoapAction = "MyObject#TimeConsumingRemoteCall")]
        public string TimeConsumingRemoteCall()
        {
            Console.WriteLine("TimeConsumingRemoteCall Called!");
            return "This is a time-consuming server call.";
        }

    }

}
