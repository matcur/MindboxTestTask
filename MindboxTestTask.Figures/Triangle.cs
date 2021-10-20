using System;

namespace MindboxTestTask.Figures
{
    public class Triangle : IFigure
    {
        private readonly double _a;
        
        private readonly double _b;
        
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            CheckSide(a);
            CheckSide(b);
            CheckSide(c);
            
            _a = a;
            _b = b;
            _c = c;
        }

        public double Area()
        {
            var p = (_a + _b + _c) / 2;

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRight()
        {
            return _a * _a + _b * _b == _c * _c;
        }

        private static void CheckSide(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Side can't be negative. {value} was given");
            }
        }
    }
}