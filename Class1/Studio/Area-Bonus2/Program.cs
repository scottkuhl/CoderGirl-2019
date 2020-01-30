using System;

namespace CoderGirl_Area_Bonus2
{
    class Program
    {
        static void Main(string[] args)
        {
            var radiusText = string.Empty;
            var radius = 0d;

            // Loop until the user enters a positive number.
            do
            {
                // Ask the user to enter the radius.
                Console.Write("Enter a radius: ");

                // Get the radius from the user.
                radiusText = Console.ReadLine();

                // Convert the text input to a double.
                radius = double.Parse(radiusText);

                // If the user enters a negative number, print an error message.
                if (radius < 0)
                {
                    Console.WriteLine("You can't enter a negative number.");
                }

            } while (radius < 0);

            // Compute the area. (A = pi * r * r)
            var area = Math.Round(Math.PI * radius * radius, 3);

            // Ouput the area of the circle.
            Console.WriteLine($"The area of a circle with radius {radius} is: {area}");
        }
    }
}
