using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1 , "Istanbul");
            myDictionary.Add(2 , "Ankara");
            myDictionary.Add(3 , "Izmir");
            myDictionary.Add(4, "Kocaeli");
            myDictionary.Add(5, "Bursa");

            Console.WriteLine(myDictionary.GetLength());
            Console.WriteLine(myDictionary.GetValue(1));
            Console.WriteLine(myDictionary.GetValue(3));
            Console.WriteLine(myDictionary.GetValue(5));
            Console.WriteLine(myDictionary.GetValue(2));
            Console.WriteLine(myDictionary.GetValue(4));
        }
    }
}
