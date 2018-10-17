using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class EquilateralTriangle : IGeometricShape
    {
        public double Sides { get; } = 3;
        public double SideLength { get; set; }

        public double Area()
        {
            return Math.Sqrt(3) * Math.Pow(SideLength, 2) / 4;
        }

        public double Perimeter()
        {
            return SideLength * 3;
        }
    }
}
