public abstract class Zwierze{
    private string nazwa;
    private float waga;
    private float Wysokosc;
    public float Waga{
        get { return waga; }
        set { waga = value; }
    }
    public string Nazwa{
        get { return nazwa; }
        set { nazwa = value; }
    }
    public Zwierze(string nazwa, float waga, float wysokosc){
        Nazwa = nazwa;
        Waga = waga;
        Wysokosc = wysokosc;
    }
    public virtual void Jedz(float wartosc){
        if(wartosc >= 0){
            Waga += wartosc;
        }
    }
    public abstract string PoruszajSie();
    public override string ToString(){
        return $"Nazwa: {Nazwa}, Waga: {Waga}, Wysokosc: {Wysokosc}";
    }
}