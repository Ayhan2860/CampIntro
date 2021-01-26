using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Yasin";
            musteri1.LastName = "Şahin";
            musteri1.CustomerNumber = 5834;
            musteri1.Adress = "İstanbul Esenyurt";
            musteri1.PhoneNumber = "5352415658";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.FirstName = "Okan";
            musteri2.LastName = "Ünal";
            musteri2.CustomerNumber = 0534;
            musteri2.Adress = "İstanbul Esenyurt";
            musteri2.PhoneNumber = "53525568984";

            Musteri muster3 = new Musteri();
            muster3.Id = 3;
            muster3.FirstName = "Kadriye";
            muster3.LastName = "Kılınç";
            muster3.CustomerNumber = 6034;
            muster3.Adress = "İstanbul Gürpınar";
            muster3.PhoneNumber = "5368974125";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.FirstName = "Ahmet";
            musteri4.LastName = "Karaman";
            musteri4.CustomerNumber = 2828;
            musteri4.Adress = "Giresun Boztekke";
            musteri4.PhoneNumber = "5452142365";

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.FirstName = "Zafer";
            musteri5.LastName = "Duran";
            musteri5.CustomerNumber = 2434;
            musteri5.Adress = "İstanbul Arnavutköy";
            musteri5.PhoneNumber = "5428799845";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, muster3, musteri4, musteri5 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(muster3);
            musteriManager.Add(musteri5);
            musteriManager.Add(musteri2);

            musteriManager.Listing(musteriler);


            musteriManager.Delete(musteri2);
            musteriManager.Delete(musteri1);

        }
    }
}
