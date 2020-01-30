using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(EvenTotal(numbers));
        }

        private static int EvenTotal(List<int> numbers)
        {
            var total = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0) total += number;
            }

            return total;
        }
    }
}
