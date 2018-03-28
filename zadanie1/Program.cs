using System;
using System.Collections;
using System.Collections.Generic; 

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {

            Samochod s = new SamochodOsobowy("Czerwony", 1.4, "Opel");
            Samochod c = new SamochodCiezarowy("Bialy", 4.5, "DAF");
            
            
            
            var cars = new List<Samochod>();
            cars.Add(s);
            cars.Add(c);

            foreach ( var item in cars ) {
                
                item.wypiszKolor();
                item.wypiszPojemnoscSilnika();
                item.wypiszMarka();
            }       
        }
    }
}
