using System;

namespace NesneTabanliUzem
{
    class Program
    {
        static void Main(string[] args)
        {
            Bisiklet b1 = new Bisiklet(18);
            Bisiklet b2 = new Bisiklet(10);
            Bisiklet b3 = new Bisiklet(12);
            Bisiklet b4 = new Bisiklet(5);
            Bisiklet b5 = new Bisiklet(21, "Bianchi", "Siyah");
            b1.VitesArtir(4);
            b1.Hizlan(25);
            b1.DurumYazdir();
            b1.FrenYap(15, 3);
            b1.DurumYazdir();

            b4.BisikletSayisi();
            b2.BisikletSayisi();
            b5.DurumYazdir();
            Console.ReadKey();
        }
    }
}
