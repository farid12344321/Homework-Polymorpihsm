using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Polymorphism
{
    internal class Circle : Shapes
    {
        public double Radius;
        public override double CalculateArea()
        {
            double p = 3.14;
            return p * Radius * Radius;
        }
    }
}
