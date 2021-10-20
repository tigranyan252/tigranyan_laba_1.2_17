using System;

namespace tigranyan_17_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите t");
            double t = double.Parse(Console.ReadLine());
            double b = Math.Pow(Math.Log10(10), 2) * Math.Abs(x);
            Console.WriteLine("b={0:F2}", b);
            double a = t * x + Math.Abs(Math.Sqrt(b));
            Console.WriteLine("a={0:F2}", a);
            double y = Math.Pow(Math.Cos(a + b * b * b), 2);
            Console.WriteLine("y={0:F2}", y);
        }
    }
}