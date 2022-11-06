using System;
using System.Runtime.Intrinsics.Arm;

namespace OOP_HW_ITP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Toyota = new Car();
            Toyota.color = 'B';
            Toyota.weight = 24;
            Toyota.speed = 250;
            Toyota.model = "CHR";


            Toyota.printAll();
        }
    }
}
