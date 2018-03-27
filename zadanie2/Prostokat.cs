using System;

public class Prostokat : Figura {

    public double bokA {get; set;}
    public double bokB {get; set;} 
    
    // Przeciążenie metod z klasy abstrakcyjnej Figura

    override public double obliczPole(){
        double pole = bokA * bokB;
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