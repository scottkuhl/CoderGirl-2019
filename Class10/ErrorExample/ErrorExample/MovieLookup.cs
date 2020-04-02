using Ardalis.GuardClauses;
using System;

namespace ErrorExample
{
    public class MovieLookup
    {
        /// <summary>
        ///     Lookup the name of a star from the movie.
        /// </summary>
        /// <param name="movieName">Name of the movie.  This is required.</param>
        /// <returns>The name of a movie star.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the movie is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the movie is blank.</exception>
        /// <exception cref="NotFoundException">Thrown when we can't find the movie.</exception>
        public string Stars(string movieName)
        {
            Guard.Against.NullOrWhiteSpace(movieName, nameof(movieName));

            if (string.IsNullOrWhiteSpace(movieName)) throw new ArgumentNullException();

            if (movieName == "Ghostbusters")
            {
                return "Bill Murray";
            }

            throw new NotFoundException();
        }
    }
}
