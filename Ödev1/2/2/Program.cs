using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        class Kisi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public DateTime DogumTarihi { get; set; }

            public int YasHesapla()
            {
                DateTime bugun = DateTime.Now;
                int yas = bugun.Year - DogumTarihi.Year;

                if (DogumTarihi > bugun.AddYears(-yas))
                    yas--;

                return yas;
            }
            static void Main(string[] args)
            {
                List<Kisi> kisiler = new List<Kisi>
                {
                    new Kisi { Ad = "Kisi1", Soyad = "Kisi1", DogumTarihi = new DateTime(1990, 1, 1) },
                    new Kisi { Ad = "Kisi2", Soyad = "Kisi2", DogumTarihi = new DateTime(1995, 1, 1) },
                    new Kisi { Ad = "Kisi3", Soyad = "Kisi3", DogumTarihi = new DateTime(2000, 1, 1) },
                    new Kisi { Ad = "Kisi4", Soyad = "Kisi4", DogumTarihi = new DateTime(2005, 1, 1) },
                    new Kisi { Ad = "Kisi5", Soyad = "Kisi5", DogumTarihi = new DateTime(2010, 1, 1) },
                    new Kisi { Ad = "Kisi6", Soyad = "Kisi6", DogumTarihi = new DateTime(2015, 1, 1) },
                    new Kisi { Ad = "Kisi7", Soyad = "Kisi7", DogumTarihi = new DateTime(2020, 1, 1) },
                    new Kisi { Ad = "Kisi8", Soyad = "Kisi8", DogumTarihi = new DateTime(2021, 1, 1) },
                    new Kisi { Ad = "Kisi9", Soyad = "Kisi9", DogumTarihi = new DateTime(2017, 1, 1) },
                    new Kisi { Ad = "Kisi10", Soyad = "Kisi10", DogumTarihi = new DateTime(2009, 1, 1) }

                };

                var yasSiralama = kisiler.OrderBy(x => x.YasHesapla()).ToList();
                Console.WriteLine("Kişiler yaşlarına göre sıralandı:");
                foreach (var kisi in yasSiralama)
                {
                    Console.WriteLine($"{kisi.Ad} {kisi.Soyad} - Yaş: {kisi.YasHesapla()}");
                }
                Console.ReadLine();
            }
        }
    }
}
