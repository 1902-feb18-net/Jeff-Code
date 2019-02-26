using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var moviePlayer = new MoviePlayer();
            {
                Movies CurrentMovie = Movies.StarWars4;
            }

            moviePlayer.Play();
        }
    }
}
