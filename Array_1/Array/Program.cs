using System;
using System.Collections.Generic;
using System.Linq;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < 10; i++)
            {
                employees.Add(new Employee
                {
                    Name = "name " + i,
                    Function = "fun " + i,
                    Age = i + 24,
                    Salary = 100 + i,
                    Studies = "stu" + i
                });
            }



        }
    }
}
