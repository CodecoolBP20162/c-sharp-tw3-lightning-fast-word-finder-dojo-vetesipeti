using System;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            string[] separators = { ", ", ". ", "!", "?", ";", ": ", " ", "-", "/", "//", "/t" };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //string[] words = text.Split(new Char[] { ' ', ',', '.', ';', '!', '?', '\t', '\n', '-' });
            string longest = "";

            foreach(string word in words)
            {
                if (word.Length > longest.Length) longest = word;
            }
            Console.WriteLine(longest);
            return longest;

           /* var currentLargestString = "";
            string pattern = @"(\w+)\s";
            foreach (Match m in Regex.Matches(text, pattern))
            {
                if (m.Groups[1].Value.Length > currentLargestString.Length) currentLargestString = m.Groups[1].Value;
            }

          /*      var regex = new Regex(@"(\w+)\s", RegexOptions.Compiled);
            var match = regex.Match(text);
           

            while (match.Success)
            {
                if (match.Groups[1].Value.Length > currentLargestString.Length)
                {
                    currentLargestString = match.Groups[1].Value;
                }

                match = match.NextMatch();
            }*/

            /*return currentLargestString;*/
        }
    }
}
