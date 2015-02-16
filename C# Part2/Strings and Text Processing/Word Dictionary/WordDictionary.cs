//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input	output
//.NET	platform for applications from Microsoft
//CLR	managed execution environment for .NET
//namespace	hierarchical organization of classes
using System;
using System.Text.RegularExpressions;


namespace Word_Dictionary
{
    class WordDictionary
    {
        static void Main()
        {
            string[] dictionary = {
            ".NET - platform for applications from Microsoft",
            "CLR - managed execution environment for .NET",
            "namespace - hierarchical - organization of classes"
        };
            string word = "CLR";
            foreach (string item in dictionary)
            {
                var fragments = Regex.Match(item, "(.*?) - (.*)").Groups;

                if (fragments[1].Value == word)
                {
                    Console.WriteLine(fragments[1] + " - " + fragments[2]);
                    return;
                }
            }
        }
    }
}
