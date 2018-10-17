using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class GreatCalculator
    {
        public double TotalAreas { get; private set; }
        public double TotalPetimeters { get; private set; }

        public void Calculate(IEnumerable<IGeometricShape> figuras)
        {
            var areaOperaions = new AreaOperations();
            var perimeterOperations = new PerimeterOperations();

            TotalAreas = areaOperaions.Sum(figuras);
            TotalPetimeters = perimeterOperations.Sum(figuras);
        }
    }
}
