using System;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            string[] separators = { ", ", ". ", "!", "?", ";", ": ", " ", "-", "/", "//", "\t", "\n", "\n\r", "(", ")", "www" };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string longest = "";

            foreach(string word in words)
            {
                if (word.Length > longest.Length) longest = word;
            }
            Console.WriteLine(longest);
            return longest;

           
        }
    }
}
