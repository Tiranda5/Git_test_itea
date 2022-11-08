using System;

namespace OOP_ITEA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person_1 = new Person();
            person_1.Fam = "John";
            person_1.Age = 15;
            person_1.Salary = 10000;

            Person person_2 = new Person();
            person_2.Fam = "Vasyl";
            person_2.Age = 21;
            person_2.Salary = 7000;

            person_1[person_1.Counth_ch]=person_2;
           // person_2.Fam = "Vasyl_2";

            Console.WriteLine(person_1.Age + " " + person_1.Fam + " " + person_1.Status);
            Console.WriteLine(person_2.Age + " " + person_2.Fam + " " + person_2.Status);
            Console.WriteLine(person_1[0].Age + " " + person_1[0].Fam + " " + person_1[0].Status);
        }
    }
}
