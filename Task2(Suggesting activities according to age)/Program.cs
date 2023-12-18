using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Suggesting_activities_according_to_age_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Yaşınızı Giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0)
                {
                    Console.WriteLine("Doğm");
                }
                if (sayi >= 0 && sayi < 3)
                {
                    Console.WriteLine("Mama");
                }
                if (sayi >= 3 && sayi < 12)
                {
                    Console.WriteLine("Parka Git");
                }
                if (sayi >= 12 && sayi < 18)
                {
                    Console.WriteLine("Sinemaya Git");
                }
                if (sayi >= 18 && sayi < 30)
                {
                    Console.WriteLine("Gençliğini Yaşa");
                }
                if (sayi >= 30 && sayi < 35)
                {
                    Console.WriteLine("Aşkı Bul");
                }
                if (sayi >= 35 && sayi < 40)
                {
                    Console.WriteLine("Kariyer Yap");
                }
                if (sayi >= 40 && sayi < 50)
                {
                    Console.WriteLine("Kendini Gerçekleştir");
                }
                if (sayi >= 50 && sayi <= 70)
                {
                    Console.WriteLine("Huzuru Bul");
                }
                if (sayi > 70)
                {
                    Console.WriteLine("Öl");
                }
                //Her İf için Bir else mi olmalı ?
                //Burada Neden Else Çalışıyor.
            }
        }
    }
}
