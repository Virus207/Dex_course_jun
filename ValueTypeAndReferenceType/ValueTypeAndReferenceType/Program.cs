using System;

namespace ValueTypeAndReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            var cube = new Some3dFigure(6, 2);
            Console.WriteLine($"База куб:");
            PrintInfo(cube);

            Square(cube);
            Console.WriteLine("\nПосле метода cube:");
            PrintInfo(cube);
        }

        static Some3dFigure Square(Some3dFigure cube)
        {
            Console.WriteLine("\n//////Метод//////");
            var newCube = cube;

            newCube.LengthEdges = 3;
            newCube.AreaFigure = newCube.LengthEdges * newCube.LengthEdges * 6;
            Console.WriteLine("//newcube.LengthEdges = 3\n//AreaCalculation;\n");
            Console.Write($"куб:");
            PrintInfo(cube);

            Console.WriteLine($"\nnewCube:");
            PrintInfo(newCube);
            Console.WriteLine("/////////////////");
            return newCube;
        }

        static void Square2(Some3dFigure cube)
        {
            Console.WriteLine("\n//////Метод//////");
            cube.AreaFigure = cube.LengthEdges * cube.LengthEdges * 6;
            PrintInfo(cube);
            Console.WriteLine("/////////////////");
        }

        static void PrintInfo(Some3dFigure figure)
        {
            Console.WriteLine($"Количество граней: {figure.NumEdges}\nДлина граней: {figure.LengthEdges}\nПлощадь: {figure.AreaFigure}");
        }
    }
}
