using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Arrs
    {

         static Random rnd = new Random();
        public static void CreateOneDimAr(int[] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                A[i] = rnd.Next(1, 100);
        }
        public static void PrintAr1(string name, int[] A)
        {
            Console.WriteLine(name);
            for (int i = 0; i < A.GetLength(0); i++)
                Console.Write("\t" + name + "[{0}]={1}", i, A[i]);
            Console.WriteLine();
        }
        public static void CreateTwoDimAr(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    A[i, j] = rnd.Next(1, 100);
        }
        public static void PrintAr2(string name, int[,] A)
        {
            Console.WriteLine(name);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("\t" + name +
                    "[{0},{1}] = {2}", i, j, A[i, j]);
                Console.WriteLine();
            }
        }
        public static void GetSizes(string name, out int n1, out int m1)
        {
            Console.WriteLine("For matrix" + name +
            " enter number of" + "lines");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("For matrix" + name +
            " enter number of " + "columns");
            m1 = Convert.ToInt32(Console.ReadLine());
        }

        public void MultMatr(int[,] A, int[,] B, int[,] C)
        {
            if (A.GetLength(1) != B.GetLength(0))
                Console.WriteLine("MultMatr: Error. Check dimensions!");
            else
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        int s = 0;
                        for (int k = 0; k < A.GetLength(1); k++)
                            s += A[i, k] * B[k, j];
                        C[i, j] = s;
                    }
        }



    }
}
