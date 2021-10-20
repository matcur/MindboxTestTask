using System;

namespace MindboxTestTask.Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowArea(new Circle(3));
        }

        static void ShowArea(IFigure figure)
        {
            Console.WriteLine($"Figure area: {figure.Area()}");
        }
    }
}