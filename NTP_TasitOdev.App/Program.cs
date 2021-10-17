using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasitLib;
using LogLib;

namespace NTP_TasitOdev.App
{//OKAN ERDEM -193801025
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet araba gireceksiniz?");

            int car = 0;
            car = int.Parse(Console.ReadLine());

            Araba[] cars = new Araba[car];

            for (int i = 0; i < cars.Length; i++)
            {
                string marka; int kapisayisi; int koltuksayisi; string vitesturu; string yakitturu; string kasatipi; int yil;

                Console.Write($"\n{i + 1}. Aracın Markasını Giriniz: ");
                marka = Console.ReadLine();
                Console.Write($"{i + 1}. Aracın Kapı Sayısını Giriniz: ");
                kapisayisi = int.Parse(Console.ReadLine());
                Console.Write($"{i + 1}. Aracın Koltuk Sayısını Giriniz: ");
                koltuksayisi = int.Parse(Console.ReadLine());
                Console.Write($"{i + 1}. Aracın Vites Türünü Giriniz-(Otomatik/Düz): ");
                vitesturu = Console.ReadLine();
                Console.Write($"{i + 1}. Aracın Yakıt Türünü Giriniz-(Benzin/Dizel): ");
                yakitturu = Console.ReadLine();
                Console.Write($"{i + 1}. Aracın Kasa Tipini Giriniz-(Sedan/Hatchback/SW/Cabrio): ");
                kasatipi = Console.ReadLine();
                Console.Write($"{i + 1}. Aracın Yılını Giriniz: ");
                yil = int.Parse(Console.ReadLine());

                var arb = new Araba(marka, kapisayisi, koltuksayisi, vitesturu, yakitturu, kasatipi, yil);
                cars[i] = arb;
            }

            for (int i = 0; i < cars.Length; i++)
            {
                string LogArb;
                LogArb = "\n" + cars[i].TasitBil();

                try
                {
                    Log.LogAraba($@"C:\Users\HP\source\repos\NTP_TasitOdev.App\txt\tasit.txt", LogArb);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
