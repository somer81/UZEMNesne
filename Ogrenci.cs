using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayuzSoyut
{
    class Ogrenci : IInsan
    {
        public void Konus()
        {
            Console.WriteLine("Öğrenci Ders Sunumu anlatıyor");
        }

        public void Oku()
        {
            Console.WriteLine("Öğrenci Ders Kitabı Okuyor");
        }
    }
}
