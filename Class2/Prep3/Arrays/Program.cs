using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
