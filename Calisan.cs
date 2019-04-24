using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimMiras
{
    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal Maas { get; set; }
        public int TCNo { get; set; }

        public Calisan(string ad,string soyad, decimal maas,int tcno)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Maas = maas;
            this.TCNo = tcno;
        }

        public virtual void BilgiVer()
        {
            Console.WriteLine(this.Ad + " " + this.Soyad);
        }

        public virtual decimal MaasArtis(int zam)
        {
            return this.Maas += zam;
        }

        public void Cikis()
        {
            Console.WriteLine(this.Ad + " " + this.Soyad + " Çıkış Yaptı");
        }
    }   
}
