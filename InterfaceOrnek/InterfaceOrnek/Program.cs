using System;

namespace InterfaceOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Civic civic = new Civic();
            Console.WriteLine(civic.Marka());
            Console.WriteLine(civic.Renk());
            Console.WriteLine(civic.TekerlerSayisi());



            NewCivic ncivic = new NewCivic();
            Console.WriteLine(ncivic.Marka());
            Console.WriteLine(ncivic.Renk());
            Console.WriteLine(ncivic.TekerlerSayisi());

            NewCorolla ncorolla = new NewCorolla();
            Console.WriteLine(ncorolla.Marka());
            Console.WriteLine(ncorolla.Renk());
            Console.WriteLine(ncorolla.TekerlerSayisi());
        }
    }
}
