using System;

public class Prostokat : Figura {

    public double podstawaA {get; set;}
    public double podstawaB {get; set;} 
    public double wysokosc {get; set;} 
    
    // Przeciążenie metod z klasy abstrakcyjnej Figura

    override public double obliczPole(){
        double pole = ((podstawaA + podstawaB) * wysokosc) / 2;
        return pole;
    }

    override public double obliczObwod(){
        double obwod = 2 * bokA + 2 * bokB;
        return obwod;
    }


    // konstruktor :
    public Prostokat(){

    }


}