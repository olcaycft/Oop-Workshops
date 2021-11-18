using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    abstract class Otomobil
    {
        public int TekerlerSayisi()
        {
            return 4;
        }

        public virtual Sabitler.Renk Renk()
        {
            return Sabitler.Renk.Siyah;
        }
        public abstract Sabitler.Marka Marka();
    }
}
