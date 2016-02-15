using NorthwindClient.ServiceReference1;
using System;

namespace NorthwindClient
{
    public class Program
    {
        static void Main()
        {
            var client = new NorthwindServiceClient();

            var day = client.GetDayToBgString(DateTime.Now);
            Console.WriteLine(day);

            string content = "Windows Communication Foundation";
            string substring = "on";
            int substrCount = client.GetSubstrCount(content,substring);
            Console.WriteLine("{0} -> {1} : {2}",content,substring,substrCount);

            ProductInfo info = client.GetProductInfo(3);
            Console.WriteLine("{0} -> {1}",info.Name,info.UnitPrice);
        }
    }
}
