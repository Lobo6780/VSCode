class Osoba
{
    private string imie;
    private string nazwisko;
    private string pesel;
}

class Kierownik : Osoba
{
    public string pracownicy;
    public void zlecUsluge()
    {
        System.Console.WriteLine("Zlecam usługę");
    }
    public void zamowCzesci()
    {
        System.Console.WriteLine("Zamawiam części");
    }
    public void konserwujMaszyne()
    {
        System.Console.WriteLine("Konsewuję maszynę");
    }
}

class Spawacz : Osoba
{

}

class Zasob
{
    string Nazwa { get; set; }
}

class Czesc : Zasob
{

}

class Maszyna : Zasob
{

}

class Produkt
{
    List<Czesc> cz;
    Kierownik K { get; }
    Osoba Spawacz { get; set; }
    Maszyna M { 
        get{

        }
        set{
            
        } 
    }

    public Produkt(Kierownik kierownik)
    {
        K = kierownik;
    }
    public void setCzesc(Czesc czesc)
    {
        cz.Add(czesc);
    }
}

