using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(" Id Numarası " + musteri.Id + " Olan " + musteri.FirstName + " " + musteri.LastName + " Kayıt Listesine Eklendi ");
            Console.WriteLine("\n**********************\n");
        }

        public void Listing(Musteri[] musteriler)
        {
            Console.WriteLine("\nGüncel Müşteriler Listesi\n");
            foreach (var musteri in musteriler)
            {

                Console.WriteLine("Müşterinin Adı Soyadı : " + musteri.FirstName + " " + musteri.LastName + "\nMüşteri Numarası : " + musteri.CustomerNumber);
                Console.WriteLine("*****************\n");
            }
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + "  Numaralı Id'si Olan " + musteri.FirstName + " " + musteri.LastName + " Müşteriniz Kayıt Listesinden Silindi..");
        }
    }
}
