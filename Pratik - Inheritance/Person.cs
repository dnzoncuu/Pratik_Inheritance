using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik___Inheritance
{
    public abstract class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void AdSoyadYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    public class Ogrenci:Person
    {
        public int OgrenciNo {get; set;}

        public void BilgileriYazdir()
        {
            AdSoyadYazdir();
            Console.WriteLine($" Ogrenci Numarası : {OgrenciNo}");
        }
    }

    public class Ogretmen : Person
    {
        public int Maas { get; set;}

        public void BilgileriYazdir()
        {
            AdSoyadYazdir();
            Console.WriteLine($" Ogretmen maaşı : {Maas}");
        }
    }
}
