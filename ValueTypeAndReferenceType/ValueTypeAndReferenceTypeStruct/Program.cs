using System;

namespace ValueTypeAndReferenceTypeStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var cube1 = new Some3dFigureStruct(6, 2);
            Console.WriteLine("___________Struct__________");
            Console.WriteLine($"До 1 метода...\nКуб1:");
            PrintInfo(cube1);

            Console.WriteLine("\n//Присваивание возвращаемого из метода нового куба к старому...");
            cube1 = FirstMethodSquare(cube1);

            Console.WriteLine("\nПосле 1 метода Куб1:");
            PrintInfo(cube1);

            Console.WriteLine("___________________________");

            var cube2 = new Some3dFigureStruct(6, 2);
            Console.WriteLine($"До 2 метода...\nКуб2:");
            PrintInfo(cube2);

            SecondMethodSquare(cube2);

            Console.WriteLine("\nПосле 2 метода Куб2:");
            PrintInfo(cube2);
        }

        static Some3dFigureStruct FirstMethodSquare(Some3dFigureStruct cube)
        {
            Console.WriteLine("//////Метод №1//////");
            var newCube = cube;

            newCube.AreaFigure = newCube.LengthEdges * newCube.LengthEdges * 6;
            Console.WriteLine("\n// Создание нового куба=старому кубу, вычисление и присваивание площади в новом кубе...");

            Console.WriteLine($"\nnewКуб:");
            PrintInfo(newCube);

            Console.Write($"\nКуб:");
            PrintInfo(cube);
            Console.WriteLine("Возвращаем новый куб...");
            Console.WriteLine("/////////////////");
            return newCube;
        }

        static void SecondMethodSquare(Some3dFigureStruct cube)
        {
            Console.WriteLine("\n//////Метод №2//////");
            Console.WriteLine("Решение и присваивание переданному экземпляру площади...");
            cube.AreaFigure = cube.LengthEdges * cube.LengthEdges * 6;

            Console.WriteLine("");
            Console.Write($"Куб:");
            PrintInfo(cube);
            Console.WriteLine("/////////////////");
        }

        static void PrintInfo(Some3dFigureStruct figure)
        {
            Console.WriteLine($"Количество граней: {figure.NumEdges}\nДлина граней: {figure.LengthEdges}\nПлощадь: {figure.AreaFigure}");
        }
    }
}
