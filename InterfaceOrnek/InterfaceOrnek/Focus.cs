using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    class Focus:IOtomobil
    {
        public Sabitler.Marka Marka()
        {
            return Sabitler.Marka.Ford;
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
