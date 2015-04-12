﻿using System;
using System.Net;

class Program
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            {
                webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "../../logo.jpg");
            }

            catch (WebException)
            {
                Console.Error.WriteLine("The address is invalid.");
            }

            catch (NotSupportedException)
            {
                Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
            }
        }
    }
}