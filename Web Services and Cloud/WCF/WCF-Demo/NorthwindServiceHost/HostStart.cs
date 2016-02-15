using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WCF_Service;

namespace NorthwindServiceHost
{
    public class HostStart
    {
        static void Main(string[] args)
        {
            var serviceAddress = new Uri("http://localhost:1337/Northwind");
            var selfHost = new ServiceHost(
                typeof(NorthwindService),
                serviceAddress);
            var smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);

            selfHost.Open();
            Console.WriteLine("Service started on:{0}",serviceAddress);
            Console.WriteLine("Exit => Enter");
            Console.ReadLine();
        }
    }
}
