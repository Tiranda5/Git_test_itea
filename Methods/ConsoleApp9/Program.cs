using System;
using System.Security.Cryptography.X509Certificates;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] digits = { 0, 3, 25, 99, 36, 101, 2 };
            int[] nums = { 5, 0, 89, 2, 45, 90, 23 };

            short[] digits_2 = { 0, 3, 25, 99, 36, 101, 2 };
            short[] nums_2 = { 5, 0, 89, 2, 45, 90, 23 };


            int max = 0;
            maxElement(digits, out max);
            Console.WriteLine(max);
            // Console.WriteLine(maxElement (nums));

            showArrays<int>(ref digits, ref nums);
            showArrays<short>(ref digits_2, ref nums_2);

            summAll(2, 1, 11, 34);
            summAll(2, 1, 34);
            summAll(200, 34);

        }

        public static void summAll(params int[] nums)
        {
            int sum = 0;
            foreach (int el in nums)
                sum +=el;
            Console.WriteLine("Результат: {0}" , sum);
        }


        public static void maxElement(int[] numbers, out int max)
        {
            max = numbers[0];
            foreach (int el in numbers)
            {
                if (el > max)
                {
                    max = el;
                }
            }
        }

        public static void changeArrys<Type>(ref Type[] a, ref Type[] b)
        {
            Type[] temp = new Type[a.Length];

            a.CopyTo(temp, 0);
            Array.Clear(a, 0, a.Length);
            b.CopyTo(a, 0);
            Array.Clear(b, 0, b.Length);
            temp.CopyTo(b, 0);
        }


        public static void showArrays<T>(ref T[] digits, ref T[] nums)
        {
            foreach (T el in digits)
                Console.Write("{0} ", el);
            Console.WriteLine("");
            foreach (T el in nums)
                Console.Write("{0} ", el);
            changeArrys(ref digits, ref nums);
            Console.WriteLine("");

            foreach (T el in digits)
                Console.Write("{0} ", el);
            Console.WriteLine("");
            foreach (T el in nums)
                Console.Write("{0} ", el); 
            */


           
           /*HM
            Console.WriteLine("Введи час");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи швидкість");
            int c = Convert.ToInt32(Console.ReadLine());
            int result = way(x, c);
            print(result);

        }


        public static void print(int way)
        {
            Console.WriteLine("Ти подолав: {0} км", way);

        }

        public static int way(int time, int speed)
        {
            int way = speed / time;
            return way;
            */

        }
    }
}
