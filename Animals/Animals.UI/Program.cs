using System;
using Animals.Library;

namespace Animals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dog = new Dog();
            /* dog.Name = ""
            Console.WriteLine($"Dog's name is {dog.name}");
            */
            dog.MakeNoise();
            dog.GoTo("the park");
        }
    }
}
