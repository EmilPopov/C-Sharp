using System;
using IronMQ;

public class IronMQSender
{
    static void Main(string[] args)
    {
        Client client = new Client(
            "5644be224aa0310009000046",
            "9ix12PticgkMu9vjknm4");
        Queue queue = client.Queue("Today's demo");
        Console.WriteLine("Enter messages to be sent to the IronMQ server:");
        while (true)
        {
            string msg = Console.ReadLine();
            queue.Push(msg);
            Console.WriteLine("Message sent to the IronMQ server.");
        }
    }
}