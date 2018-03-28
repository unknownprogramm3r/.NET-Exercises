using System;

public class Kwadrat : Figura {

    public double bok {get; set;}
    
    // Przeciążenie metod z klasy abstrakcyjnej Figura

    override public double obliczPole(){
        double pole = Math.Sqrt(bok);
        return pole;
    }

    override public double obliczObwod(){
        double obwod = 4 * bok;
        return obwod;
    }


    // konstruktor :
    public Kwadrat(){

    }


}