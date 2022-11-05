using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double c;

            Console.Write("x= ");
            x = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            y = double.Parse(Console.ReadLine());


            //Знайдемо гіпотенузу

            c = Math.Pow(x, 2) + Math.Pow(y, 2);
            c = Math.Pow(c, 2);

            Console.WriteLine("гiпотенуза = " + c);
                    
               
            Console.ReadLine();

            int R1 = 10;
            int R2 = 20;
            int R3 = 30;
            int R4 = 40;
            int R5 = 50;
            int R6 = 60;
            int R7 = 70;
            int R8 = 80;
            int R9 = 90;
            int R10 = 100;

            for (int с; int с < Math.Pow(R1, 2) + Math.Pow(R1, 2); i++)
            {
                Console.WriteLine("You get 10 point");
            }

            /*if (Math.Pow(R1, 2) + Math.Pow(R1, 2) > c) 
            {
                Console.WriteLine("You get 10 point");
            }

            else if (Math.Pow(R2, 2) + Math.Pow(R2, 2) > c)
            {
                Console.WriteLine("You get 20 point");
            }
            else if (Math.Pow(R3, 2) + Math.Pow(R3, 2) > c)
            {
                Console.WriteLine("You get 30 point");
            }
            else if (Math.Pow(R4, 2) + Math.Pow(R4, 2) > c)
            {
                Console.WriteLine("You get 40 point");
            }
            else if (Math.Pow(R5, 2) + Math.Pow(R5, 2) > c)
            {
                Console.WriteLine("You get 50 point");
            }
            else if (Math.Pow(R6, 2) + Math.Pow(R6, 2) > c)
            {
                Console.WriteLine("You get 60 point");
            }
            else if (Math.Pow(R7, 2) + Math.Pow(R7, 2) > c)
            {
                Console.WriteLine("You get 70 point");
            }
            else if (Math.Pow(R8, 2) + Math.Pow(R8, 2) > c)
            {
                Console.WriteLine("You get 80 point");
            }
            else if (Math.Pow(R9, 2) + Math.Pow(R9, 2) > c)
            {
                Console.WriteLine("You get 90 point");
            }
            else if (Math.Pow(R10, 2) + Math.Pow(R10, 2) > c)
            {
                Console.WriteLine("You get 100 point");
            }*/
            



        }
    }
}
