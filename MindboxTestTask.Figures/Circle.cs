using System;

namespace MindboxTestTask.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException($"Radius can't be negative. {radius} was given");
            }
            
            _radius = radius;
        }

        public double Area()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }
    }
}