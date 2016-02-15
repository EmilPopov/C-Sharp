
namespace XML_Processing_in.NET
{
    using System;
    using System.Xml;

    public class DOMParser
    {
        static void Main()
        {
            var doc = new XmlDocument();
            doc.Load("../../catalog.xml");

            var root = doc.DocumentElement;
            Console.WriteLine(root);
        }

    }
}
