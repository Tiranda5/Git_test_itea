using System;
using System.Data.SqlTypes;

namespace MathOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Знайду корінь квадратного рівняння");

            Console.WriteLine("Введи значення а");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи значення b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введи значення c");
            double c = Convert.ToDouble(Console.ReadLine());

            Double x = Convert.ToDouble(Console.ReadLine());

            //a* x *x + b * x + c = 0;

            double v = Math.Pow(x, 2);
            a * v +b * x + c

            Console.WriteLine("result = " a * v + b * x + c);

            Con
            //double a * Math.Pow(double x, 2) + b * x + c = 0

            //Console.WriteLine(a * Math.Pow(x, 2) + b * x + c = 0);


        }
    }
}
