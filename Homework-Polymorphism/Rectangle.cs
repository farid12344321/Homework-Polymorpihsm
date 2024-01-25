using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Polymorphism
{
    internal class Rectangle : Shapes
    {
        public double Width;
        public double Height;
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
