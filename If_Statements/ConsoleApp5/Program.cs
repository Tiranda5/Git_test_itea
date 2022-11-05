using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* byte i = 10;
             while (i >= 1)
             {
                 console.writeline("element: {0}", i);
                 i--;
             }*/

            /*bool isHasCar = true;
            while (isHasCar)
            {
                string end = Console.ReadLine();
                if (end == "end")
                    isHasCar = false;
            }*/

            for (short i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                    continue;

                Console.WriteLine("El: " + i) ;
            }
;



            



        }
    }
}
