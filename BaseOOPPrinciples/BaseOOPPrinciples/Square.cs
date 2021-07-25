using System;

namespace BaseOOPPrinciples
{
    internal class Square : Figure
    {

        readonly protected double Width;

        public Square(double width)
        {
            if (width > 0)
            {
                Width = width;
            }
            else
            {
                throw new Exception();
            }
        }

        public override double SquareFigure()
        {
            return Width * Width;
        }
        public override void PrintFigureInfo()
        {
            Console.WriteLine($"Фигура: квадрат\nДлина: {Width}\nПлощадь фигуры: {SquareFigure()}");
        }
    }
}
