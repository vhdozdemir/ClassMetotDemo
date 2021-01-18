using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteriBir = new Musteri();
            musteriBir.musteriId = 1;
            musteriBir.musteriAdi = "Ali Osman";
            musteriBir.musteriSoyadi = "Özdemir";
            musteriBir.musteriTelefon = "01111111111";
            musteriBir.musteriEPosta = "aoo@gmail.com";

            Musteri musteriIki = new Musteri();
            musteriIki.musteriId = 2;
            musteriIki.musteriAdi = "Mehmet Ali";
            musteriIki.musteriSoyadi = "Şengül";
            musteriIki.musteriTelefon = "02222222222";
            musteriIki.musteriEPosta = "mas@gmail.com";

            Musteri musteriUc = new Musteri();
            musteriUc.musteriId = 3;
            musteriUc.musteriAdi = "Mustafa";
            musteriUc.musteriSoyadi = "Turan";
            musteriUc.musteriTelefon = "03333333333";
            musteriUc.musteriEPosta = "mt@gmail.com";

            Musteri[] musteri = new Musteri[] { musteriBir, musteriIki, musteriUc };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteriBir);
            musteriManager.MusteriEkle(musteriIki);
            musteriManager.MusteriEkle(musteriUc);

            musteriManager.MusteriListele(musteri);

            musteriManager.MusteriSil(musteriIki);
            musteriManager.MusteriSil(musteriUc);
        }


    }
}
