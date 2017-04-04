using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_ClassChallenge_Abstract_Concrete_Interface
{
    class Octagon : IPolygon
    {
        public int NumberOfSides { get; set; }
        public double SideLength { get ; set; }

        public Octagon(double length)
        {
            this.NumberOfSides = 8;
            this.SideLength = length;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
    }
}
