using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    class Civic : IOtomobil
    {
        public Sabitler.Marka Marka()
        {
            return Sabitler.Marka.Honda;
        }

        public Sabitler.Renk Renk()
        {
            return Sabitler.Renk.Siyah;
        }

        public int TekerlerSayisi()
        {
            return 4;
        }
    }
}
