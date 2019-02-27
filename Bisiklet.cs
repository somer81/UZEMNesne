using System;
using System.Collections.Generic;
using System.Text;

namespace NesneTabanliUzem
{
    class Bisiklet
    {
        public string Renk { get; set; }
        public string Marka { get; set; }
        public static int bisikletSayisi =0;
        public const int tekerSayisi = 2;
        public int VitesSayisi { get; set; }

        public Bisiklet(int vitesSayi)
        {
            Vites = 1;
            Hiz = 0;
            bisikletSayisi++;
            VitesSayisi = vitesSayi;
           // tekerSayisi = 3;
        }

        public Bisiklet(int vs, string mark, string renk)
        {
            Vites = 1;
            Hiz = 0;
            bisikletSayisi++;
            VitesSayisi = vs;
            Marka = mark;
            Renk = renk;
         }
        public int Vites { get; set; }
        public int Hiz { get; set; }

        public void Hizlan(int artis) { Hiz += artis; }
        public void VitesArtir(int vites) {
            if ((Vites + vites) <= VitesSayisi)
                Vites += vites;
            else
                Vites = VitesSayisi;
        }
            public void FrenYap(int azalis, int vites) { Hiz -= azalis; Vites -= vites; }
        public void VitesDusur(int vites) { Vites -= vites; }

        public void DurumYazdir()
        {
            Console.WriteLine("Vites : " + Vites + " Hiz : " + Hiz + " Vites Sayısı : " + VitesSayisi + " Marka : " + Marka + " Renk : " + Renk) ;
        }
        public void BisikletSayisi()
        {
            Console.WriteLine("Toplam Bisiklet Sayısı : " + bisikletSayisi);
        }

    }
}
