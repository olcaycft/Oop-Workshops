using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_sinif
{
    class Calisan
    {
        private static int _calisanSayisi;

        public static int CalisanSayisi 
        {
            get 
            {
                return _calisanSayisi;
            }
            set
            {
                _calisanSayisi = value;
            }
        }

        private string _isim;
        private string _soyisim;
        private string _departman;
        public Calisan(string isim, string soyisim , string departman)
        {
            this._isim = isim;
            this._soyisim = soyisim;
            this._departman = departman;
            _calisanSayisi++;
        }

        static Calisan()
        {
            _calisanSayisi = 0;
        }
    }
}
