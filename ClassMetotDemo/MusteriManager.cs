using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.HesapNo + " " + musteri.Açiklama + " " + "bilgilerine sahip müşteri sisteme eklendi.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.HesapNo + " " + musteri.Açiklama);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.HesapNo + " " + musteri.Açiklama + " " + "bilgilerine sahip müşterinin kaydı sistemden kaldırıldı.");
        }
    }
}
