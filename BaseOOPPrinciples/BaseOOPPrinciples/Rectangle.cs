using System;

namespace BaseOOPPrinciples
{
    internal class Rectangle : Square
    {
        private readonly double Lenght;
        public Rectangle(double width, double lenght)
          : base(width)
        {
            if (width > 0 && lenght > 0)
            {
                Lenght = lenght;
            }
            else
            {
                throw new Exception();
            }
        }

        public override double SquareFigure()
        {
            return Width * Lenght;
        }
        public override void PrintFigureInfo()
        {
            Console.WriteLine($"Фигура: прямоугольник\nДлина: {Width}\nШирина: {Lenght}\nПлощадь фигуры: {SquareFigure()}");
        }
    }
}
