using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias

            string categoryLabel = "Categorys";

            int studentsCount = 3200;

            double interestRate = 1.45;

            bool loginIn = false;

            double dollarYesterday = 1.70;

            double dollarToday = 1.70;

            if (dollarYesterday>dollarToday)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dollarToday>dollarYesterday)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşit Butonu");
            }

            if (loginIn == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(categoryLabel);


        }
    }
}
