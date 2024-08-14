using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        // Her geometrik şeklin kendi alan hesaplaması olacak
        public abstract double AlanHesapla();
    }

    public class Kare : BaseGeometrikSekil
    {
        // Karenin alanı Genişlik * Yükseklik olarak hesaplanır (kare olduğu için genişlik ve yükseklik aynıdır)
        public override double AlanHesapla()
        {
            return Genislik * Genislik;
        }
    }

    public class Dikdortgen : BaseGeometrikSekil
    {
        // Dikdörtgenin alanı Genişlik * Yükseklik olarak hesaplanır
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    public class DikUcgen : BaseGeometrikSekil
    {
        // Dik üçgenin alanı (Genişlik * Yükseklik) / 2 olarak hesaplanır
        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }
    }

}
