using System;

namespace ErrorExample
{
    // 1. Always catch all exceptions, never show an hard error to the user.
    // 2. Always show helpful messages, like what the user can do next.
    // 3. Always throw a specific type of exception.
    // 4. Always protect your input parameters.

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your favorite movie?");
                var movie = Console.ReadLine();

                var movieLookup = new MovieLookup();

                try
                {
                    var stars = movieLookup.Stars(movie);
                    Console.WriteLine($"Oh wow {stars} starred in that.");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("I can't look up the movie without a name.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("I can't look up the movie without a name.");
                }
                catch (NotFoundException ex)
                {
                    Console.WriteLine("I'm sorry, I don't know that one.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"I'm sorry, something went wrong.  Please try again, or contact support at 314-111-1111.  Details: {ex.Message}");
            }
        }
    }
}
