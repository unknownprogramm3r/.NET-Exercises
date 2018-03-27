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

    override public void wypiszPole(){
        Console.WriteLine(pole);
    }

    override public void wypiszObwod(){
        Console.WriteLine(obwod);
    } 

    // konstruktor :
    public Kolo(){

    }


}