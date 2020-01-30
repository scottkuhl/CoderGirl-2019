using System;

namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            var aliceText = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine("Enter search test.");
            var search = Console.ReadLine();

            var found = aliceText.Contains(search, StringComparison.OrdinalIgnoreCase);
            if (found)
                Console.WriteLine("Found it!");
            else
                Console.WriteLine("Not found.");
        }
    }
}
