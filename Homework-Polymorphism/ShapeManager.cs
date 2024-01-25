using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Polymorphism
{
    internal class ShapeManager
    {
        private int _circleLimited;
        private int _rectangleLimited;
        public int RectangleLimit => _rectangleLimited;
        public int CircleLimit => _circleLimited;

        public int Rectangle;
        private Shapes[] _shapes = new Shapes[0];
        public Shapes[] Shapes => _shapes;
        public int GetCircleCount()
        {
            int count = 0;
            for (int i = 0; i < _shapes.Length; i++)
            {
                if (_shapes[i] is Circle)
                {
                    count++;
                }
            }
            return count;
        }
        public double[] GetCircles()
        {
            int count = 0;
            for (int i = 0; i < _shapes.Length; i++)
            {
                if (_shapes[i] is Circle)
                {
                    count++;
                }
            }
            double[] newArr = new double[count];
            int index = 0;
            for (int i = 0; i < _shapes.Length; i++)
            {
                if (_shapes[i] is Circle)
                {
                    newArr[index++] = ((Circle)_shapes[i]).CalculateArea();
                }
            }
            return newArr;
        }
        public double GetTotalCircleAreas()
        {
            double total = 0;
            for (int i = 0; i < _shapes.Length; i++)
            {
                if (_shapes[i] is Circle)
                {
                    total += ((Circle)_shapes[i]).CalculateArea();
                }
            }
            return total;
        }
        public int GetSquareCount()
        {
            int count = 0;
            for (int i = 0; i < _shapes.Length; i++)
            {
                if (_shapes[i] is Rectangle)
                {
                    if (((Rectangle)_shapes[i]).Width == ((Rectangle)_shapes[i]).Height)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public void AddShape(Shapes shapes)
        {
            if (shapes is Circle)
            {
                if (_circleLimited < 10)
                {
                    Array.Resize(ref _shapes, _shapes.Length + 1);
                    _shapes[_shapes.Length - 1] = shapes;
                    _circleLimited++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rectangle Limiti dolub");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            if (shapes is Rectangle)
            {
                if (_rectangleLimited < 10)
                {
                    Array.Resize(ref _shapes, _shapes.Length + 1);
                    _shapes[_shapes.Length - 1] = shapes;
                    _rectangleLimited++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Rectangle Limiti dolub");
                    Console.ForegroundColor = ConsoleColor.White;
                }               
            }
        }
    }
}
