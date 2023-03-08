class Osoba
{
    private Klient klient;
    private Serwisant serwisant;
    private Opiekun opiekun;
}
class Opiekun : Klient
{   
    public void zlecNaprawe()
    {
        System.Console.WriteLine("Naprawa zlecona...");
    }
}
class Klient
{
    public string imie;
}
class Serwisant
{
    public string imie;
}
class Zlecenie : Opiekun
{
    public int idZlecenia;
    public string typUrzadzenia;
    public void Zlec()
    {
        System.Console.WriteLine("Zlecam...");
    }
}
class Naprawa
{
    public Zlecenie zlecenie { get; set; }
}
class Stacjonarny
{
    public string marka;
    public string model;
    public string rodzajObudowy;
    public override void wyswietl()
    {
        base.wyswietl();
        System.Console.WriteLine($"Rodzaj obudowy: {rodzajObudowy}.");
    }
}
class Laptop
{
    public string marka;
    public string model;
    public string przekatnaEkranu;
    public string kolorObudowy;
    public void setKolor(string kolor)
    {
        this.kolorObudowy = kolor;
    }
}


Laptop lap = new Laptop();
lap.marka = Console.ReadLine();
lap.model = Console.ReadLine();
lap.przekatnaEkranu = Console.ReadLine();
lap.kolorObudowy = Console.ReadLine();
lap.setKolor(Console.ReadLine());

Console.WriteLine(lap.marka + " " + lap.model + " " + lap.przekatnaEkranu + " " + lap.kolorObudowy);