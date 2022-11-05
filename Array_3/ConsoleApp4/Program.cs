using consoleapp4;
using System;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answear;
            string administrator;

            do
            {
                Console.WriteLine("Enter the password");


                administrator = Console.ReadLine();

                if
                   (administrator != "administrator")
                {
                    Console.WriteLine("Incorrect password");
                    Console.WriteLine("Would you like to try again? y/n");
                }
                else
                    Console.WriteLine("Success");
                answear = Console.ReadLine();
            }

            while (answear == "y");



        }
    }
}


