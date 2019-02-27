using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4] { 23, 56, 78, 99 };

            for(int i = 0; i<= sayilar.Length-1; i++)
                Console.WriteLine(sayilar[i]);

            Console.WriteLine("--------------------");

            foreach (int sy in sayilar)
                Console.WriteLine(sy);

            ArrayList takimlar = new ArrayList() { "GS","FB","BJK","TS"};
            takimlar.Add("Samsun Spor");
            takimlar.Remove("GS");
            takimlar.Sort();
            foreach(var deger in takimlar)
                Console.WriteLine(deger.ToString());


            Console.WriteLine("Kuyruk Örneği ---------------");

            Queue ku = new Queue();
            ku.Enqueue("İlk Değer");
            ku.Enqueue(212);
            ku.Enqueue(true);
            ku.Enqueue(1212.990);
            ku.Enqueue('A');
            ku.Enqueue("Türkiye");

            Console.WriteLine(ku.Dequeue());
            Console.WriteLine(ku.Dequeue());
            Console.WriteLine(ku.Dequeue());

            

            IEnumerator ind = ku.GetEnumerator();
            while(ind.MoveNext())
            {
                Console.WriteLine(ind.Current.ToString());
            }


            Console.WriteLine("Yığın Örneği ---------------");

            Stack stek = new Stack();
            stek.Push("İlk Değer");
            stek.Push(212);
            stek.Push(true);
            stek.Push(1212.990);
            stek.Push('A');
            stek.Push("Türkiye");

            Console.WriteLine(stek.Pop());
            Console.WriteLine(stek.Pop());
            Console.WriteLine(stek.Pop());

            IEnumerator indk = stek.GetEnumerator();
            while (indk.MoveNext())
            {
                Console.WriteLine(indk.Current.ToString());
            }
            Console.ReadKey();
        }
       
    }
}
