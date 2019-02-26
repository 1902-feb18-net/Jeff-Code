using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class Square : IShapes
    {
        public int NumSides { get; set; }
        public int Id { get; set; }
//        public float Length  { get; set; }
//        public float Width { get; set; }

        public void GetArea(int length, int width)
        {
            int area = length * width;
            Console.WriteLine($"The area is {area}")
        }
    }
}
