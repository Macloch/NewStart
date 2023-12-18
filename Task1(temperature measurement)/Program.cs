using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//onsole sana soracak, 
//sıcaklık kaç derece
//girdin cevabı
//eğer 0dan küçükse buz gibiymiş yazacak
//10dan küçükse baya soğuk

namespace Task1_temperature_measurement_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Sıcaklık Kaç Derece");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0)
                {
                    Console.WriteLine("Buz Gibiymiş");
                }
                if (sayi >= 0 && sayi < 10)
                {
                    Console.WriteLine("Baya Soğuk");
                }
                if (sayi >= 10 && sayi < 20)
                {
                    Console.WriteLine("Serin");
                }
                if (sayi >= 20 && sayi < 30)
                {
                    Console.WriteLine("Güzel Hava");
                }
                if (sayi >= 30)
                {
                    Console.WriteLine("Sıcak");
                }                       
                //Her İf için Bir else mi olmalı ?
                //Burada Neden Else Çalışıyor.
            }
        }
    }
}
