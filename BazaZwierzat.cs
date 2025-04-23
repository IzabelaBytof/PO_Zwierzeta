using System.Runtime.InteropServices;

public class BazaZwierzat{
    Zwierze[] zwierzeta = new Zwierze[5];
    public void DodajZwierze(Zwierze zwierze){
        bool dodano = false;
        for(int i = 0; i < zwierzeta.Length; i++){
            if(zwierzeta[i] == null){
                zwierzeta[i] = zwierze;
                dodano = true;
                System.Console.WriteLine("Dodano zwierzę: " + zwierze.ToString());
                break;
            }
        }
        if(!dodano){
            System.Console.WriteLine("Brak miejsca w bazie zwierząt.");
        }
    }
    public void UsunZwierze(Zwierze zwierze){
        bool usunieto = false;
        for(int i = 0; i < zwierzeta.Length; i++){
            if(zwierzeta[i] == zwierze){
                zwierzeta[i] = null;
                usunieto = true;
                System.Console.WriteLine("Usunięto zwierzę: " + zwierze.ToString());
                break;
            }
        }
        if(!usunieto){
            System.Console.WriteLine("Nie znaleziono zwierzęcia do usunięcia.");
        }
    }
    private string ZwrocZwierzeta(){
        string tekst = "Zwierzęta w bazie:\n";
        for(int i = 0; i<zwierzeta.Length; i++){
            if(zwierzeta[i] != null){
                tekst += zwierzeta[i].ToString() + "\n";
            }
        }
        return tekst;
    }
    public void WszystkieZwierzetaJedza(float wartosc){
        for(int i = 0; i < zwierzeta.Length; i++){
            if(zwierzeta[i] != null){
                zwierzeta[i].Jedz(wartosc);
            }
        }
    }
    public void WszystkieZwierzetaPoruszajaSie(){
        for(int i = 0; i < zwierzeta.Length; i++){
            if(zwierzeta[i] != null){
                Console.WriteLine(zwierzeta[i].PoruszajSie());
            }
        }
    }
    public override string ToString(){
        return ZwrocZwierzeta();
    }
}