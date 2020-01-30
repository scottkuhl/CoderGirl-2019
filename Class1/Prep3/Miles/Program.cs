using System;

namespace Miles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many miles have you driven? ");
            var miles = decimal.Parse(Console.ReadLine());

            Console.Write("How many gallons of gas have you used? ");
            var gallons = decimal.Parse(Console.ReadLine());

            var mpg = miles / gallons;
            Console.WriteLine($"You are getting {mpg} miles per gallon.");
        }
    }
}
