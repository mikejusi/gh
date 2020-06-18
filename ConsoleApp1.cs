using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double e = 2.71;
            if (0 <= x && x < e)
            {
                Console.WriteLine((3 / 2 * Math.Pow(x, 2)) - Math.Pow((b + 3.14), 1 / 3));
            }
            else if (x >= e)
            {
                Console.WriteLine(((Math.Pow(b, 2) + 3.14) + Math.Pow(e, x + 1)));
            }
            else if (x < 0)
            {
                Console.WriteLine(2 / 3 * Math.Atan(Math.Pow(b, 2) + 3.14) - Math.Log(2) * Math.Abs(x));

            }
            Console.ReadKey();
        }
    }
}