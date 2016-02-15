﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

public class PubnubDemo
{
	static void Main()
	{
		// Start the HTML5 Pubnub client
		Process.Start("..\\..\\PubNub-HTML5-Client.html");

        System.Threading.Thread.Sleep(2000);

		PubnubAPI pubnub = new PubnubAPI(
            "pub-c-4c88dcfd-2722-4d3f-a561-109481fa9adc",               // PUBLISH_KEY
            "sub-c-c452f2d8-89de-11e5-83e3-02ee2ddab7fe",               // SUBSCRIBE_KEY
            "sec-c-YTg4ODdkZWUtMzRhOC00NmU1LWFkZDctNGJjN2Y3NzZmMDdh",   // SECRET_KEY
			true                                                        // SSL_ON?
		);
		string channel = "AAA";
        
		// Publish a sample message to Pubnub
		List<object> publishResult = pubnub.Publish(channel, "Hello Pubnub!");
		Console.WriteLine(
			"Publish Success: " + publishResult[0].ToString() + "\n" +
			"Publish Info: " + publishResult[1]
		);

		// Show PubNub server time
		object serverTime = pubnub.Time();
		Console.WriteLine("Server Time: " + serverTime.ToString());

		// Subscribe for receiving messages (in a background task to avoid blocking)
		System.Threading.Tasks.Task t = new System.Threading.Tasks.Task(
			() =>
			pubnub.Subscribe(
				channel,
				delegate(object message)
				{
					Console.WriteLine("Received Message -> '" + message + "'");
					return true;
				}
			)
		);
		t.Start();

		// Read messages from the console and publish them to Pubnub
		while (true)
		{
			Console.Write("Enter a message to be sent to Pubnub: ");
			string msg = Console.ReadLine();
			pubnub.Publish(channel, msg);
			Console.WriteLine("Message {0} sent.", msg);
		}
	}
}