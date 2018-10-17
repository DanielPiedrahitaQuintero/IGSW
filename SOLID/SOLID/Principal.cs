using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Principal
    {
        static void Main(string[] args)
        {
            var figuras = new IGeometricShape[]
            {
                new Square{SideLength = 10},
                new EquilateralTriangle {SideLength = 5}
            };
            var calculator = new GreatCalculator();
            calculator.Calculate(figuras);
            Console.WriteLine($"Area Total:{calculator.TotalAreas} ");
        }
    }
}
