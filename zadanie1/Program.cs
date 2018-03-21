using System;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Samochod s = new SamochodOsobowy("Czerwony", 1.4, "Opel");
            s.wypiszPojemnoscSilnika();
            

        }
    }
}
