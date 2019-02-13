using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot
{

    class A
    {
        public int Kare()
        {
            return 10 * 10; 
        }
    }

    

    class Program
    {

        static int x, y; 
        public static int Alan()
        {
            x = 10;
            y = 2;
            return x * y; 
        }

        public static int SonucYaz()
        {
            return x + y; 
        }

        public static int Alan(int a, int b)
        {
            return a * b; 
        }


        public static int Topla(float s1, float s2)
        {
            return (int)(s1 + s2); 
        }
        public static void Yaz(string mesaj)
        {
            Console.WriteLine("Hoşgeldin UZEM !"  + mesaj);
         }

        public static int ardisikToplam(int n)
        {
            if (n == 0) return 0;
            return n + ardisikToplam(n - 1);
         }
        public static int fakt(int n)
        {
            if (n == 1) return 1;
            return n * fakt(n - 1);
        }

        static void Main(string[] args)
        {
            A a = new A(); 
            Console.WriteLine(Alan());
            Console.WriteLine(Alan(15,10));
            a.Kare();
            
            Console.WriteLine(Topla(5,6));
            Yaz(" 2019");

            Console.WriteLine("Bir sayısal değer giriniz : ");
            int s = Int32.Parse(Console.ReadLine());
            Console.WriteLine(s + " sayısının 0 dan toplamı : " + ardisikToplam(s));

         
            Console.WriteLine(s + " sayısının fakoriyeli : " + fakt(s));

        }
    }
}
