using System;
public class SamochodCiezarowy : Samochod {

    private string kolor;
    private double pojemnoscSilnika;
    private string marka;

    override public void wypiszKolor() { Console.WriteLine(kolor); }
    override public void wypiszPojemnoscSilnika() { Console.WriteLine(pojemnoscSilnika); }
    override public void wypiszMarka() { Console.WriteLine(marka); }

    public SamochodCiezarowy(string k, double p, string m) {

        kolor = k;
        pojemnoscSilnika = p;
        marka = m;

    }

}