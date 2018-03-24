using System;
using System.Collections;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {

            Samochod s = new SamochodOsobowy("Czerwony", 1.4, "Opel");
            Samochod c = new SamochodCiezarowy("Bialy", 4.5, "DAF");
            
            ArrayList samochodyAL = new ArrayList();
            samochodyAL.Add(s);
            samochodyAL.Add(c);

            foreach ( Object i in samochodyAL ) {
                Console.WriteLine(i);
            }       
        }
    }
}
