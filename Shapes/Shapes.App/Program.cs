using Shapes.Library;
using System;

namespace Shapes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Square shape1 = Square();
            shape1.Id = 0;
            shape1.Length = 3;
            shape1.Width = 3;
            shape1.NumSides = 4;

/*            Triangle shape2 = Triangle();
            shape2.Id = 1;
            shape2.NumSides = 3;

            Circle shape3 = Circle();
            shape3.Id = 2;
            shape3.NumSides = 0;
            shape3.Radius = 2;
*/
        }
    }
}
