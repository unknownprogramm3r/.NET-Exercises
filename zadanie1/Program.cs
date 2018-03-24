using System;
using System.Collections;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {

            Samochod s = new SamochodOsobowy("Czerwony", 1.4, "Opel");
            s.wypiszPojemnoscSilnika();

            Samochod c = new SamochodCiezarowy("Bialy", 4.5, "DAF");
            c.wypiszPojemnoscSilnika();

            ArrayList samochodyAL = new ArrayList();
            samochodyAL.Add(s);
            samochodyAL.Add(c);

            foreach ( Object obj in samochodyAL ) {
                Console.WriteLine(obj);
            }       
        }
    }
}
