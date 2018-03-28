using System;

public class Trapez : Figura {

    public double podstawaA {get; set;}
    public double podstawaB {get; set;} 
    public double wysokosc {get; set;}
    public double bokA {get; set;}
    public double bokB {get; set;}  

    
    // Przeciążenie metod z klasy abstrakcyjnej Figura

    override public double obliczPole(){
        // znamy podstawy i wysokosc
        if(podstawaA > 0 && podstawaB > 0 && wysokosc > 0){
            double pole = ((podstawaA + podstawaB) * wysokosc) / 2;
            return pole;
        }
        //     
        else if (){}
    }

    override public double obliczObwod(){
        double obwod = podstawaA + podstawaB + bokA + bokB;
        return obwod;
    }


    // Metoda dodatkowa tylko dla klasy "Trapez"

    public Boolean czyTrapezMozeIstniec(){

        if(podstawaA > 0 && podstawaB > 0 && bokA > 0 && bokB > 0){
            if(podstawaA == podstawaB && bokA == bokB){
                return true;
            }
            else if(podstawaA != podstawaB && bokA == bokB){
                return true;
            }    
        }
    } 

        public double obliczBoki(){
        // brakuje bokuB - znamy tylko podstawy (różne od siebie) i wysokość
        if (podstawaA > 0 && podstawaB > 0 && podstawaA != podstawaB && wysokosc > 0){
            bokA = wysokosc;
            // dlugosc boku B
            if (podstawaA > podstawaB){
                double przyprostokatnaPomocnicza = podstawaA - podstawaB;
                // obliczenie przeciwprostokatnej z twierdzenia Pitagorasa
                bokB = Math.Sqrt(Math.Pow(przyprostokatnaPomocnicza, 2) +  Math.Pow(bokA, 2));
                return bokB;     
            }else{
                double przyprostokatnaPomocnicza = podstawaB - podstawaA;
                // obliczenie przeciwprostokatnej z twierdzenia Pitagorasa
                bokB = Math.Sqrt(Math.Pow(przyprostokatnaPomocnicza, 2) +  Math.Pow(bokA, 2));
                return bokB;
            }            
        }
    }

    // konstruktor :
    public Trapez(){}


}