using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Calculator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1;
            int s2;
            int result;

            while (true)
            {
                Console.WriteLine("1. Sayıyı Giriniz");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sayıyı Giriniz");
                s2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
                Console.WriteLine("Toplamak için 1'e basınız");
                Console.WriteLine("Çıkarma için 2'ye basınız");
                Console.WriteLine("Çarpma için 3'e basınız");
                Console.WriteLine("Bölme için 4'e basınız");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Toplama(s1, s2);
                        break;
                    case 2:
                        Çıkarma(s1, s2);
                        break;
                    case 3:
                        Çarpma(s1, s2);
                        break;
                    case 4:
                        Bölme(s1, s2);
                        break;
                    default:
                        Console.WriteLine("Geçersiz İşlem");
                        break;
                }
            }
        }
        static void Toplama(int sayi1, int sayi2)
        {
            int result = sayi1 + sayi2;
            Console.WriteLine(result);
        }
        static void Çıkarma(int sayi1, int sayi2)
        {
            int result = sayi1 - sayi2;
            Console.WriteLine(result);
        }
        static void Çarpma(int sayi1, int sayi2)
        {
            int result = sayi1 * sayi2;
            Console.WriteLine(result);
        }
        static void Bölme(int sayi1, int sayi2)
        {
            int result = sayi1 / sayi2;
            Console.WriteLine(result);
        }

    }
}
