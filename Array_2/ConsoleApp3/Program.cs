using System;

namespace ConsoleApp3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int patIndex;
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            if(SearchPattern(arr, 3, out patIndex))
            {
                Console.WriteLine(patIndex);
            }
        }
       public bool SearchPattern(int[] ar, int pat, out int patIndex)
        {
            int n = ar.Length;
            patIndex = -1;
            bool found = false;
            for (int i = 0; i < n; i++)
                if (ar[i] == pat)
                {
                    found = true;
                    patIndex = i;
                    break;
                }
            return found;
        }
        


        }
            }
        }
    }
}
