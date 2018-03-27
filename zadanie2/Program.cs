using System;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            // KOLO

            Kolo kolo = new Kolo();
            kolo.promien = 3;
           
            Console.WriteLine(kolo.obliczPole());
            Console.WriteLine(kolo.obliczObwod());

            // PROSTOKAT

            Prostokat prostokat = new Prostokat();
            prostokat.bokA = 20;
            prostokat.bokB = 23;

            Console.WriteLine(prostokat.obliczPole());
            Console.WriteLine(prostokat.obliczObwod());



            
        }
    }
}
