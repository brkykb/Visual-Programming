using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chatper14_Homework
{
    internal class Program
    {
        private int ogrenciNo;
        private string ad;
        private string soyad;
        private double vize1;
        private double vize2;
        private double final;
        private string okuladi;
        static void Main(string[] args)
        {
            Program ogrenci = new Program();
            ogrenci.ogrenciNo = 1;
            ogrenci.ad = "Berkay";
            ogrenci.soyad = "Karabulut";
            ogrenci.vize1 = 70;
            ogrenci.vize2 = 80;
            ogrenci.final = 90;
            ogrenci.okuladi = "Karabuk Universitesi";

            System.Console.WriteLine("1-Ogrenci Bilgilerini Goster");
            System.Console.WriteLine("2-Ogrenci Ortalamasini Goster");
            System.Console.WriteLine("3-Ogrenci Okulunu Ogren");
            System.Console.WriteLine("4-Cikis Yap");
            int secim = int.Parse(System.Console.ReadLine());

            switch (secim)
            {
                case 1:
                    ogrenci.ogrenciBilgileriGoster();
                    Console.ReadLine();
                    break;
                case 2:
                    ogrenci.ogrenciOrtalamaHesapla();
                    Console.ReadLine();
                    break;
                case 3:
                    ogrenci.okulGetir();
                    Console.ReadLine();
                    break;
                case 4:
                    System.Console.WriteLine("Cikis Yapiliyor...");
                    break;
            }
            
        }

        void ogrenciBilgileriGoster()
        {
            System.Console.WriteLine("Ogrenci Adi: " + ad);
            System.Console.WriteLine("Ogrenci Soyadi: " + soyad);
            System.Console.WriteLine("Ogrenci No: " + ogrenciNo);

        }

        void ogrenciOrtalamaHesapla()
        {
            System.Console.WriteLine("Ortalama: " + (vize1 * 0.3 + vize2 * 0.3 + final * 0.4));
        }

        void okulGetir()
        {
            System.Console.WriteLine("Okul Adi: " + okuladi);
        }
    }
    
}
