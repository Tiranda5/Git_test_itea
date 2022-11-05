using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(56);
            arr.Add("Hello");
            arr.Add('C');

            Console.WriteLine(arr.Count);
            foreach (object el in arr)
                Console.WriteLine(el);

            Dictionary<string, char> dict = new Dictionary<string, char>();
            dict.Add("USA", 'u');
            dict.Add("UKR", 'y');

            dict.TryGetValue("UKR", out char example);
            Console.WriteLine(example);

            foreach (KeyValuePair<string, char> el in dict)
            {Console.WriteLine($"Ключ: {el.Key}, значення: {el.Value}");

            }

        }
    }
}
