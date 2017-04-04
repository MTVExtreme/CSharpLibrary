using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_ClassChallenge_Abstract_Concrete_Interface
{
    class Polygon
    {
        public int NumberOfSides { get; set; }
        public double SideLength { get; set; }

        public Polygon(int sides, double length)
        {
            this.NumberOfSides = sides;
            this.SideLength = length;
        }

        public double GetPerimeter()
        {
            double value = NumberOfSides*SideLength;
            return value;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }

    }
}
