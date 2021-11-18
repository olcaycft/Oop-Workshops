using System;

namespace class_consept
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class_tanimlama();

            Ogrenci ogr1 = new Ogrenci("Olcay",5);
            ogr1.ogrbilgi();

            Calisan2 cls1  = new Calisan2("Alican", 2);
            //Calisan2 cls1 = new Calisan2();
            //cls1.calisanisim = "Alican";
            //cls1.calisanno = 2;
            cls1.clsbilgi();
            cls1.noarttir();
            cls1.clsbilgi();
            cls1.calisanno=2;
            cls1.clsbilgi();
            cls1.nodusur();
            cls1.clsbilgi();
            cls1.nodusur();
            cls1.clsbilgi();
            cls1.nodusur();
            cls1.clsbilgi();

        }

        private static void Class_tanimlama()
        {
            //class SinifAdi
            //{
            //[Erişim Belirleyici] [Veri Tipi] ÖzellikAdı;
            //[Erişim Belirleyici] [Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
            // {
            //Metot Gövdesi
            //  }
            //}

            Calisan calisan = new Calisan
            {
                Ad = "Olcay",
                Soyad = "ÇİFTÇİ",
                No = 312312414,
                Departman = "Yazılım Mühendisi"

            };
            calisan.CalisanBilgi();
        }
    }
    class Calisan2
    { 
        private string _calisanisim;
        private int _calisanno;

        public Calisan2()
        {
        }

        public Calisan2(string calisanisim, int calisanno)
        {
            _calisanisim = calisanisim;
            _calisanno = calisanno;
        }
        public int calisanno {
            get
            {
                return _calisanno;
            }
            set
            {
                if (value<1)
                {
                    Console.WriteLine("Numara en az 1 olabilir");
                    _calisanno = 1;
                }
                else
                {
                    _calisanno = value;
                }
                
            }
                
        }
        public string calisanisim
        {
            get
            {
                return _calisanisim;
            }
            set
            {
                _calisanisim = value;
            }
        }

        public void clsbilgi()
        {
            Console.WriteLine(this.calisanisim + " " + this.calisanno);
        }

        public void noarttir()
        {
            this.calisanno += 1;
        }

        public void nodusur()
        {
            this.calisanno -= 1;
        }
    }
    class Ogrenci
    {
        private string _isim;
        private int _ogrenciNo;

        public Ogrenci()
        {

        }
        public Ogrenci(string isim,int ogrenciNo)
        {
            Isim = isim;
            Ogrno = ogrenciNo;
        }
        public string Isim 
        {
            get 
            {
                return _isim;
            }

            set
            {
                _isim = value;
            }
        }

        public int Ogrno
        {
            get
            {
                return _ogrenciNo;
            }

            set
            {
                _ogrenciNo = value;
            }
        }

        public void ogrbilgi()
        {
            Console.WriteLine(this.Isim+"  "+this.Ogrno);
        }

    }
    class Calisan
    {

        public Calisan()
        {

        }
        public Calisan(int a)
        {

        }
        public Calisan(string b)
        {

        }
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public int No { get; set; }
        public String Departman { get; set; }


        public void CalisanBilgi()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Soyad);
            Console.WriteLine(No);
            Console.WriteLine(Departman);
        }

    }
}
