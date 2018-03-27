using System;

public class Kolo : Figura {

    public readonly double pi = 3.14;
    public double promien {get; set;} 
    
    // Przeciążenie metod z klasy abstrakcyjnej Figura

    override public double obliczPole(){
        double pole = pi * Math.Sqrt(promien);
        return pole;
    }

    override public double obliczObwod(){
        double obwod = 2 * pi * promien;
        return obwod;
    }


    // konstruktor :
    public Kolo(){

    }


}