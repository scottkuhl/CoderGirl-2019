using System;
using System.Collections.Generic;

namespace ListsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string> { "hello", "world", "i", "am", "a", "coder" };
            PrintFiveLetterWords(words);
        }

        private static void PrintFiveLetterWords(List<string> words)
        {
            foreach (var word in words)
            {
                if (word.Length == 5) Console.WriteLine(word);
            }
        }
    }
}
