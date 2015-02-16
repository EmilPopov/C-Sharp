//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
using System;
using System.Text;


namespace Parse_Tags
{
    class ParseTags
    {
        static void Main()
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else";
            int start = str.IndexOf("<upcase>") + 7;
            int end = str.IndexOf("</upcase>");
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if ((i > start) && (i < end))
                {
                    newStr.Append(str[i].ToString().ToUpper());                   
                }
                else
                {
                    newStr.Append(str[i]);
                }
                if (i == end)
                {
                    start = str.IndexOf("<upcase>", start) + 7;
                    end = str.IndexOf("</upcase>",end + 8); 
                }
            }
            Console.WriteLine(newStr.ToString());
        }
    }
}
