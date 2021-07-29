using System;
using System.Diagnostics;

namespace SpeedTestBoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new();
            int n = 1000;
            int[] i = new int[n];
            int[] j = new int[n];
            object[] o = new object[n];

            Console.WriteLine("Упаковка...");
            sw.Start();
            for (int k = 0; k < n; k++)
            {
                o[k] = i[k];
            }
            sw.Stop();
            Console.WriteLine($"Упаковка завершена, время упаковки(тики): {sw.ElapsedTicks/n}");

            sw.Restart();

            Console.WriteLine("\nРаспаковка...");
            try
            {
                sw.Start();
                for (int k = 0; k < n; k++)
                {
                    j[k] = (int)o[k];
                }
                sw.Stop();

                Console.WriteLine($"Распаковка завершена, время распаковки(тики): {sw.ElapsedTicks/n}");
            }

            catch (InvalidCastException e)
            {
                Console.WriteLine($"{e.Message} \nОшибка: Неверная распаковка.");
            }
        }
    }
}
