using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseOOPPrinciples
{

    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[4];

            figures[0] = new Square(2);
            figures[1] = new Rectangle(2, 3);
            figures[2] = new Rectangle(1, 2);
            figures[3] = new Square(5);

            foreach (var item in figures)
            {
                item.PrintFigureInfo();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
