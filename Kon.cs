public class Kon : Zwierze{
    private int LiczbaPrzyspieszen;
    private int LiczbaSpowolnien;
    public Kon(string nazwa, float waga, float wysokosc, int liczbaPrzyspieszen, int liczbaSpowolnien) : base (nazwa, waga, wysokosc){
        LiczbaPrzyspieszen = liczbaPrzyspieszen;
        LiczbaSpowolnien = liczbaSpowolnien;
    }
    public override void Jedz(float wartosc){
        if(wartosc >= 0){
            Waga += wartosc;
        }
        System.Console.WriteLine("Koń zjadł " + wartosc + " jednostek pokarmu.");
    }
    public override string PoruszajSie(){
        return $"Koń {Nazwa} porusza się przyspieszając {LiczbaPrzyspieszen} razy i spowalniając {LiczbaSpowolnien} razy.";
    }
    public override string ToString(){
        return base.ToString() + $", Liczba Przyspieszeń: {LiczbaPrzyspieszen}, Liczba Spowolnień: {LiczbaSpowolnien}";
    }
}