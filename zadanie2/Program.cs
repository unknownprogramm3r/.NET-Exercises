using System;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            // var kolo = new Kolo{
            //     promien = 3
            // };
            //koloData.promien = 3;

            Kolo kolo = new Kolo();
            kolo.promien = 3;
            kolo.obliczPole();
            kolo.wypiszPole();

            
        }
    }
}
