using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzemNesneTabanli
{
    class Program
    {
        public static int Min(params int[] Sayilar)
        {
            int min = Sayilar[0];  // Sayilar dizisinin ilk değerini al 
            foreach (int s in Sayilar)   // Diğer bütün sayılarla kıyasla 
                if (s < min)
                {
                    min = s;  //  En küçük olan değeri min değişkeninde sakla 
                }
            return min;  // Geriya dönder 
        }

        public static long Carpim(params int[] Carpanlar)
        {
            long sonuc = 1;
            foreach (int i in Carpanlar)
                sonuc *= i;

            return sonuc;
                    
        }

        public static void NesneYazdir(params object[] Nesneler)
        {
             foreach(object n in Nesneler)
                Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            int[] sayi = new int[12] { 545, 6, 998, 0,66, 3 ,35,36,95,14,25,355};

            Console.WriteLine("Elimizdeki dizinin en küçük elemanı : " + Min(sayi));
        
            Console.WriteLine("Carpim Sonucu : " + Carpim(12,5,2,4,2));

            object[] nesneler = new object[2];
            var v1 = new { Miktar = 108, Mesaj = "Selam" };
            var v2 = new { Miktar = 110, Mesaj = "Merhaba" };
            nesneler[0] = v1;
            nesneler[1] = v2;

            NesneYazdir(nesneler);

            Console.ReadKey();

        }
    }
}
