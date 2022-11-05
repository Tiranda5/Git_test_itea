using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

                short[] numbers = new short[10];

                Random random = new Random();

                for (byte i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = Convert.ToInt16(random.Next(5, 15);
                    Console.WriteLine("El: " + numbers[i]);
                }

            
        }
    }
}
