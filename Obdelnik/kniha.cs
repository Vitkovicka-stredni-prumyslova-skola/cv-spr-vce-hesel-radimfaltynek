using System;


public class Kniha
{
    public string Nazev { get; set; }
    public string Autor { get; set; }
    public int RokVydani { get; set; }

    public Kniha(string nazev, string autor, int rokVydani)
    {
        Nazev = nazev;
        Autor = autor;
        RokVydani = rokVydani;
    }

    public virtual void VypisInformace()
        => Console.WriteLine($"Název: {Nazev}, Autor: {Autor}, Rok vydání: {RokVydani}");
}


public class Ebook : Kniha
{
    public double VelikostSouboru { get; set; }
    public string Format { get; set; }

    public Ebook(string nazev, string autor, int rokVydani, double velikostSouboru, string format)
        : base(nazev, autor, rokVydani)
    {
        VelikostSouboru = velikostSouboru;
        Format = format;
    }

    public override void VypisInformace()
    {
        base.VypisInformace();
        Console.WriteLine($"Velikost souboru: {VelikostSouboru} MB, Formát: {Format}");
    }
}


public static class Knihovna
{
    public static int PocetKnih { get; private set; }

    public static void PridatKnihu(Kniha kniha)
    {
        PocetKnih++;
        Console.WriteLine($"Přidána kniha: {kniha.Nazev}. Celkový počet knih: {PocetKnih}");
    }
}


public class Program
{
    public static void Main()
    {
        Knihovna.PridatKnihu(new Kniha("Velký Gatsby", "F. Scott Fitzgerald", 1925));
        Knihovna.PridatKnihu(new Ebook("Digitální pevnost", "Dan Brown", 1998, 1.5, "PDF"));
    }
}
