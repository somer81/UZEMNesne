using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimMiras
{
    class Mudur: Calisan
    {
        public int Kidem { get; set; }

        public Mudur(string ad,string soyad,decimal maas,int tcno, int kidem):base(ad,soyad,maas,tcno)
        {
            this.Kidem = kidem;
        }

        public override void BilgiVer()
        {
            base.BilgiVer();
            Console.WriteLine("Kidem : " + this.Kidem);
        }

    }
}
