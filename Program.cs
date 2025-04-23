class Program{
    static void Main(){
        Kot kot1 = new Kot("Mruczek", 4.5f, 0.3f, 5, 2);
        Kot kot2 = new Kot("Puszek", 3.8f, 0.25f, 4, 3);
        Kot kot3 = new Kot("Miau", 5.0f, 0.35f, 6, 1);
        Kon kon1 = new Kon("Bucek", 500f, 1.5f, 3, 1);
        Kon kon2 = new Kon("Koniu", 450f, 1.4f, 2, 2);

        System.Console.WriteLine(kot1.ToString());
        System.Console.WriteLine(kot2.ToString());
        System.Console.WriteLine(kot3.ToString());
        System.Console.WriteLine(kon1.ToString());
        System.Console.WriteLine(kon2.ToString());

        BazaZwierzat baza = new BazaZwierzat();
        baza.DodajZwierze(kot1);
        baza.DodajZwierze(kot2);
        baza.DodajZwierze(kot3);
        baza.DodajZwierze(kon1);
        baza.DodajZwierze(kon2);

        baza.WszystkieZwierzetaJedza(2.0f);

        baza.WszystkieZwierzetaPoruszajaSie();

        System.Console.WriteLine(baza.ToString());

        baza.UsunZwierze(kot1);
        
        baza.WszystkieZwierzetaJedza(3.0f);

        baza.WszystkieZwierzetaPoruszajaSie();

        System.Console.WriteLine(baza.ToString());
    }
}