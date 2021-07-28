using System;
using System.Diagnostics;

namespace SpeedTestBoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new();
            int i = 123;

            Console.WriteLine("Упаковка...");
            sw.Start();
            object o = i;
            sw.Stop();
            Console.WriteLine($"Упаковка завершена, время упаковки(тики): {sw.ElapsedTicks}");

            sw.Restart();

            Console.WriteLine("\nРаспаковка...");
            sw.Start();
            try
            {
                int j = (int)o; // попытка распаковки
                sw.Stop();
                Console.WriteLine($"Распаковка завершена, время распаковки(тики): {sw.ElapsedTicks}");
            }

            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine($"{e.Message} \nОшибка: Неверная распаковка.");
            }
        }
    }
}
