using System;


namespace Attribute.Test
{
    [VersionAttribute("2.11")]
    class AttributeTest
    {
        static void Main()
        {
            object[] versionAttributes = typeof(AttributeTest).GetCustomAttributes(typeof(AttributeTest), false);
            Console.WriteLine("Version: {0}", versionAttributes[0]);
        }
    }
}
