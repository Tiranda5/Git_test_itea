using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OOP_HW_ITP
{
    public class Car
    {
        public int weight;
        public string model;
        public char color;
        public int speed;


        public void printAll()
        {
            Console.WriteLine($"Модель: {model}, Вага: {weight}, Колір: {color}, Швидкість: {speed}");
        }
    }
}
