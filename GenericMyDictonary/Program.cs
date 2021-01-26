using System;
using System.Collections.Generic;

namespace GenericMyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> names = new MyDictonary<int, string>();
            names.Add(28, "Ayhan");
            names.Add(01, "İlker");
            names.Add(58, "Yasin");

            Console.WriteLine("***** Key *****\n");

            Console.WriteLine(names.CountKey + " Adet Anahtara Karşılık Gelen Değer Sayısı : " + names.CountValue + " Adettir");
            foreach (var keyNumber in names.Keys)
            {
                Console.WriteLine(keyNumber);
            }

            Console.WriteLine("\n******* Value ******\n");

            foreach (var name in names.Values)
            {
                Console.WriteLine(name);

            }
        }
    }
}
