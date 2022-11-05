using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestMultiMatr();
        }

        public static void TestMultiMatr()
        {
            int n1, m1, n2, m2, n3, m3;

            Arrs.GetSizes("MatrA", out n1, out m1);
            Arrs.GetSizes("MatrB", out n2, out m2);
            Arrs.GetSizes("MatrC", out n3, out m3);

            int[,] MatrA = new int[n1, m1], MatrB = new int[n2, m2];
            int[,] MatrC = new int[n3, m3];

            Arrs.CreateTwoDimAr(MatrA); Arrs.CreateTwoDimAr(MatrB);
            Arrs.MultMatr(MatrA, MatrB, MatrC);
            Arrs.PrintAr2("MatrA", MatrA); Arrs.PrintAr2("MatrB", MatrB);
            Arrs.PrintAr2("MatrC", MatrC);
        }


    }

}
