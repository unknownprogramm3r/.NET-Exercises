using System;

public class Trapez : Figura {

    public double podstawaA {get; set;}
    public double podstawaB {get; set;} 
    public double wysokosc {get; set;}
    public double bokA {get; set;}
    public double bokB {get; set;}  

    
    // Przeciążenie metod z klasy abstrakcyjnej Figura

    override public double obliczPole(){
        // jeśli znamy podstawy i wysokość to odrazu obliczamy
        if(podstawaA > 0 && podstawaB > 0 && wysokosc > 0){
            double pole = ((podstawaA + podstawaB) * wysokosc) / 2;
            return pole;
        }else{
        // Jeśli brakuje nam którejś z danych to najpierw szukamy jej metodą obliczBoki a potem robimu obliczenie    
            obliczBoki();
            double pole = ((podstawaA + podstawaB) * wysokosc) / 2;
            return pole;
        }
        
    }

    override public double obliczObwod(){
        if (podstawaA > 0 && podstawaB > 0 && bokA > 0 && bokB > 0){
            double obwod = podstawaA + podstawaB + bokA + bokB;
            return obwod;
        }else{
            obliczBoki();
            double obwod = podstawaA + podstawaB + bokA + bokB;
            return obwod;
        }
    }


    // Metoda dodatkowa tylko dla klasy "Trapez"

    // public Boolean czyTrapezMozeIstniec(){

    //     if(podstawaA > 0 && podstawaB > 0 && bokA > 0 && bokB > 0){
    //         if(podstawaA == podstawaB && bokA == bokB){
    //             return true;
    //         }
    //         else if(podstawaA != podstawaB && bokA == bokB){
    //             return true;
    //         }    
    //     }
    // } 

        public double obliczBoki(){
        // brakuje boków - znamy tylko podstawy (różne od siebie) i wysokość
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
        // brakuje wysokości - znamy tylko podstawy (różne od siebie) i jeden bok (zakładamy, że ten bok jest wysokością) 
        // TODO nie jestem pewien czy niezainicjalizowana wysokość ma wartość 0.               
        }else if (podstawaA > 0 && podstawaB > 0 && podstawaA != podstawaB && wysokosc == 0){
            // znamy bokA
            if (bokA > 0){
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
            // znamy bokB
            else{
                bokB = wysokosc;
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
        // brakuje boków, ale znamy wysokość i długości podstaw są sobie równe     
        }else if(podstawaA > 0 && podstawaA == podstawaB && wysokosc > 0){
            bokA = wysokosc;
            bokB = wysokosc;
            return bokA;
            return bokB;
        }
    }

    // konstruktor :
    public Trapez(){}

}