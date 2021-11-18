using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Canlilar
    {
        public void Beslenmek()
        {
            Console.WriteLine("Canlılar Beslenir.");
        }

        public void Solunum()
        {
            Console.WriteLine("Canlılar Solunum Yapar.");
        }

        public void Bosaltim()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar.");
        }

        public virtual void Keko()
        {
            Console.WriteLine("Canlılar birer kekodur.");
        }
    }
}
