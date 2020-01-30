using System;

namespace CoderGirl_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter the radius.
            Console.Write("Enter a radius: ");

            // Get the radius from the user.
            var radiusText = Console.ReadLine();

            // Convert the text input to a double.
            var radius = double.Parse(radiusText);

            // Compute the area. (A = pi * r * r)
            var area = Math.Round(Math.PI * radius * radius, 3);

            // Ouput the area of the circle.
            Console.WriteLine($"The area of a circle with radius {radius} is: {area}");
        }
    }
}
