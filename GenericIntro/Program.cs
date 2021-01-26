using System;
using System.Collections.Generic;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new List<string>() { "Ayhan", "Fuat", "Volkan", "Nevzat", "Yasin" };
            //names.Add("Okan");

            //foreach(var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            MyList<string> names = new MyList<string>();
            names.Add("Ayhan");
            names.Add("Yasin");
            names.Add("Fuat");

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
            names.Add("Karaman");

            Console.WriteLine(names.Count);

        }
    }
}
