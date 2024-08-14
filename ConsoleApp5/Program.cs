using ConsoleApp5;

class Program
{
    static void Main(string[] args)
    {
        // Kare nesnesi oluşturma ve alan hesaplama
        Kare kare = new Kare();
        kare.Genislik = 5;
        Console.WriteLine("Karenin Alanı: " + kare.AlanHesapla());

        // Dikdörtgen nesnesi oluşturma ve alan hesaplama
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.Genislik = 4;
        dikdortgen.Yukseklik = 6;
        Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgen.AlanHesapla());

        // Dik üçgen nesnesi oluşturma ve alan hesaplama
        DikUcgen dikUcgen = new DikUcgen();
        dikUcgen.Genislik = 3;
        dikUcgen.Yukseklik = 4;
        Console.WriteLine("Dik Üçgenin Alanı: " + dikUcgen.AlanHesapla());
    }
}