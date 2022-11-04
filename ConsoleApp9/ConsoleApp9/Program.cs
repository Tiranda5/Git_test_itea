using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 0, 3, 25, 99, 36, 101, 2 };
            int[] nums = { 5, 0, 89, 2, 45, 90, 23 };

            short[] digits_2 = { 0, 3, 25, 99, 36, 101, 2 };
            short[] nums_2 = { 5, 0, 89, 2, 45, 90, 23 };


            int max = 0;
            maxElement(digits, out max);
            Console.WriteLine(max);
            // Console.WriteLine(maxElement (nums));

            foreach (int el in digits)
                Console.Write("{0} ", el);
            Console.WriteLine("");
            foreach (int el in nums)

                Console.Write("{0} ", el);

            changeArrys(ref digits, ref nums);
            Console.WriteLine("");
            foreach (int el in digits)
                Console.Write("{0} ", el);
            Console.WriteLine("");
            foreach (int el in nums)

                Console.Write("{0} ", el);

            foreach (int el in digits_2)
                Console.Write("{0} ", el);
            Console.WriteLine("");
            foreach (int el in nums_2)

                Console.Write("{0} ", el);

            changeArrysShort(ref digits_2, ref nums_2);
            Console.WriteLine("");
            foreach (int el in digits_2)
                Console.Write("{0} ", el);
            Console.WriteLine("");
            foreach (int el in nums_2)

                Console.Write("{0} ", el);

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

        public static void changeArrys(ref int[] a, ref int[] b)
        {
            int[] temp = new int[a.Length];

            a.CopyTo(temp, 0);
            Array.Clear(a, 0, a.Length);
            b.CopyTo(a, 0);
            Array.Clear(b, 0, b.Length);
            temp.CopyTo(b, 0);
        }

        public static void changeArrysShort(ref short[] a, ref short[] b)
        {
            short[] temp = new short[a.Length];

            a.CopyTo(temp, 0);
            Array.Clear(a, 0, a.Length);
            b.CopyTo(a, 0);
            Array.Clear(b, 0, b.Length);
            temp.CopyTo(b, 0);
        }

    }
}
