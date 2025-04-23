public class Kot : Zwierze{
    private int LiczbaWyskokow;
    private int LiczbaNawrotow;
    public Kot(string nazwa, float waga, float wysokosc, int liczbaWyskokow, int liczbaNawrotow):base (nazwa, waga, wysokosc){
        LiczbaWyskokow = liczbaWyskokow;
        LiczbaNawrotow = liczbaNawrotow;
    }
    public override void Jedz(float wartosc){
        if(wartosc >= 0){
            Waga += wartosc;
        }
        System.Console.WriteLine("Kot zjadł " + wartosc + " jednostek pokarmu.");
    }
    public override string PoruszajSie(){
        return $"Kot {Nazwa} porusza się skacząc {LiczbaWyskokow} razy i wykonując {LiczbaNawrotow} nawrotów.";
    }
    public override string ToString(){
        return base.ToString() + $", Liczba Wyskoków: {LiczbaWyskokow}, Liczba Nawrotów: {LiczbaNawrotow}";
    }
}