using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Merhaba Dunya";
            string text2 = "Merhaba Mars";

            Console.WriteLine(text1);
            Console.WriteLine(text2);
            Console.WriteLine("-----------------------------------");

            text1 = text2;
            Console.WriteLine(text1);
            Console.WriteLine(text2);


        }
    }
}
