using System;
using System.Linq.Expressions;

namespace consoleapp4
{
    internal class class1
    {

        public static void Loop()
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

