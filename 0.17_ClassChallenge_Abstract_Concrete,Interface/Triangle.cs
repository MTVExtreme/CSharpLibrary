using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_ClassChallenge_Abstract_Concrete_Interface
{
    class Triangle : AbstractPolygon
    {
        public Triangle(double length) : base(3, length) { }

        public override double GetArea()
        {
            double value = SideLength * SideLength * Math.Sqrt(3) / 4;
            return value;
        }
    }
}
