using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteriniz Eklendi. " + musteri.musteriAdi + " " + musteri.musteriSoyadi);
        }
        public void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("\n---KAYITLI MÜŞTERİ BİLGİLERİ---");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı-Soyadı : " + musteri.musteriAdi + " " + musteri.musteriSoyadi + "\nMüşteri Telefon : " + musteri.musteriTelefon + "\n" + "Müşteri E-Posta Adresi : " + musteri.musteriEPosta + "\n");
            }
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.musteriAdi + " " + musteri.musteriSoyadi + " " + "adlı müşterininiz silinmiştir.");
        }


    }
}
