using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimals.Library
{
    public class Eagle : ABird
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Squak!");
        }

        public void GoTo(string location)
        {
            Console.WriteLine($"I'm flying to {location}");
        }
    }
}
