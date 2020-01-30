using System;
using System.Collections.Generic;
using System.IO;

namespace Bonus4
{
    class Program
    {
        static void Main(string[] args)
        {
            // HACK: Get the project path.
            var dir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));

            // Get the text string from a file.
            var inputString = File.ReadAllText($"{dir}\\Input.txt");

            var countDict = new Dictionary<char, int>();

            // Loop through each character in the input string.
            foreach (char item in inputString)
            {
                // Throw away non-alpanumeric characters.
                if (!char.IsLetterOrDigit(item)) continue;

                // Force the character to lower case.
                var c = Convert.ToChar(item.ToString().ToLower());

                // Already in there, increment the count.
                if (countDict.ContainsKey(c))
                    countDict[c] += 1;
                // First time, add to the dictionary.
                else
                    countDict.Add(c, 1);
            }

            // Loop through the dictionary and output the counts.
            foreach (var item in countDict)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
