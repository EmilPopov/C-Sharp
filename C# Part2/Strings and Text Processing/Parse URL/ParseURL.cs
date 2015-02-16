//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
using System;
using System.Text.RegularExpressions;


namespace Parse_URL
{
    class ParseURL
    {
        static void Main()
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";

            var fragments = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;

            Console.WriteLine(fragments[1]);
            Console.WriteLine(fragments[2]);
            Console.WriteLine(fragments[3]);
        }
    }
}
