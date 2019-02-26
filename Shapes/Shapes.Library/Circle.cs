using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Library
{
    public class Circle : IShapes
    {
        public int NumSides { get; set; }
        public int Id { get; set; }
        public int Radius { get; set; }

        //area = pi r^2
    }
}
