using System;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width of the rectangle: ");
            var width = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the rectangle: ");
            var length = int.Parse(Console.ReadLine());

            var area = width * length;
            Console.WriteLine($"The area of the rectangle is {area}.");
        }
    }
}
