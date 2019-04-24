using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimMiras
{
    class Ogretmen : Calisan
    {
        public string Brans { get; set; }
        public Ogretmen(string ad,string soyad, decimal maas, int tcno,string brans):base(ad,soyad,maas,tcno)
        {
            this.Brans = brans;
        }

     //   public override void BilgiVer()
     //   {
     //       base.BilgiVer();
            //  Console.WriteLine(this.Ad + " " + this.Soyad + " " +  this.Brans);
     //   }
    }
}
