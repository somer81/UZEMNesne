using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayuzSoyut
{
    class Sekil
    {
        public const double PI = Math.PI;
        public int x { get; set; }
        public int y { get; set; }

        public Sekil() { }

        public Sekil(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Alan()
        {
            return x * y;
        }
    }
}
