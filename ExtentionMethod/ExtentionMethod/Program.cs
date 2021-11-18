using System;

namespace ExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a=MyExtentionClass.Ciftmi(21);

            if (a)
            {
                Console.WriteLine("çift");
            }
            else
            {
                Console.WriteLine("tek");
            }
        }
    }
}
