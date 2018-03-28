using System;

public class Trapez : Figura {

    public double podstawaA {get; set;}
    public double podstawaB {get; set;} 
    public double wysokosc {get; set;}
    public double bokA {get; set;}
    public double bokB {get; set;}  

    
    // Przeciążenie metod z klasy abstrakcyjnej Figura

    override public double obliczPole(){
        if(podstawaA > 0 && podstawaB > 0 && wysokosc > 0){
            double pole = ((podstawaA + podstawaB) * wysokosc) / 2;
            return pole;
        }    
        else if ()
    }

    override public double obliczObwod(){
        double obwod = podstawaA + podstawaB + bokA + bokB;
        return obwod;
    }

    public double obliczBoki(){}


    // konstruktor :
    public Trapez(){}


}