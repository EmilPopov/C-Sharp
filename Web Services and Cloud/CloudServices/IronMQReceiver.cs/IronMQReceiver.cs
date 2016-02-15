using System;
using System.Threading;
using IronMQ;
using IronMQ.Data;

public class IronMQReceiver
{
    static void Main()
    {
        Client client = new Client(
           "5644be224aa0310009000046",
            "9ix12PticgkMu9vjknm4");
        Queue queue = client.Queue("Today's demo");
        Console.WriteLine("Listening for new messages from IronMQ server:");
        while (true)
        {
            Message msg = queue.Get();
            if (msg != null)
            {
                Console.WriteLine(msg.Body);
                queue.DeleteMessage(msg);
            }
            Thread.Sleep(100);
        }
    }
}