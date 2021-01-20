using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Urunler sepete eklendi: "+urun.Adi);
        }
        public void Ekle2(string UrunAdi,string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Urunler sepete eklendi: " + UrunAdi);
        }
    }
}
