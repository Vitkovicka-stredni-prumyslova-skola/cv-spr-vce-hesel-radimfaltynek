using System;

public class kniha
{
    public static void Main()
    {
        Console.WriteLine("=== Knihovna ===\n");

        
        var kniha1 = new Kniha("Velký Gatsby", "F. Scott Fitzgerald", 1925);
        var ebook1 = new Ebook("Digitální pevnost", "Dan Brown", 1998, 1.5, "PDF");

        
        Console.WriteLine("Informace o knihách:\n");
        kniha1.VypisInformace();
        Console.WriteLine();
        ebook1.VypisInformace();
        Console.WriteLine();

        
        Console.WriteLine("Přidávání knih do knihovny:\n");
        Knihovna.PridatKnihu(kniha1);
        Knihovna.PridatKnihu(ebook1);

        
        Console.WriteLine($"\nCelkový počet knih v knihovně: {Knihovna.PocetKnih}");
    }
}

