using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Square : IGeometricShape
    {
        public double Sides { get; } = 4;
        public double SideLength { get; set; }

        public double Area()
        {
            return SideLength * SideLength;
        }

        public double Perimeter()
        {
            return SideLength * 4;
        }
    }
}
