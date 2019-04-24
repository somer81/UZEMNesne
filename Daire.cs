using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayuzSoyut
{
    class Daire:Sekil,IComparable
    {
        public Daire(int r): base(r,0)
        {

        }

        public override double Alan()
        {
            return PI * x * x;
        }

        public int CompareTo(object daire1)
        {
            Daire d = daire1 as Daire;
            return (x == d.x) ? 0 : -1; 
        }
    }
}
