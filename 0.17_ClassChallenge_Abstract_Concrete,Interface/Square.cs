using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_ClassChallenge_Abstract_Concrete_Interface
{
    class Square : Polygon
    {
        public Square(double length) : base(4, length)
        {
            //this.NumberOfSides = 4;
        }

        public override double GetArea()
        {
            double value = SideLength * SideLength;
            return value;
        }
    }
}
