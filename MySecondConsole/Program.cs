using System;
namespace MySecondConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            double e = Math.Sqrt(2);

            Console.WriteLine("Константа PI: " + PI);
            Console.WriteLine("Константа Пифагора: " + e);
            Console.ReadKey();
        }
    }
}