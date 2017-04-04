using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_ClassChallenge_Abstract_Concrete_Interface
{
    abstract class AbstractPolygon
    {
        public int NumberOfSides { get; set; }
        public double SideLength { get; set; }

        public AbstractPolygon(int sides, double length)
        {
            this.NumberOfSides = sides;
            this.SideLength = length;
        }

        public double GetPerimeter()
        {
            double value = NumberOfSides * SideLength;
            return value;
        }

        public abstract double GetArea();

    }
}
