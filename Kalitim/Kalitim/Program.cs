using System;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Baliklar balik = new Baliklar();
            balik.Yuzmek();

            Canlilar balik2 = new Baliklar();
            balik2.Keko();

            Canlilar kus1 = new Kuslar();
            kus1.Keko();
        }
    }
}
