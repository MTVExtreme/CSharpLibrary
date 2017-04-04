using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_ClassChallenge_Abstract_Concrete_Interface
{
    public interface IPolygon
    {
        int NumberOfSides { get; set; }
        double SideLength  { get; set; }

        double GetPerimeter();

        double GetArea();
    }
}
