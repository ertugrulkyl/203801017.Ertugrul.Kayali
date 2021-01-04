using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _203801017.Ertugrul.Kayali
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int random = 0;
            int girilensayi = 0, hak = 0;
            Console.WriteLine("HOŞGELDİNİZ, Zorluk Seçin:");
            Console.WriteLine("Easy Mode için 1'e\nNormal Mode için 2'ye\nHard Mode için 3'e basınız.");
            int oyunseviyesi = Convert.ToInt32(Console.ReadLine());


            if (oyunseviyesi == 1)
            {

                Console.WriteLine("Easy Mode seçtiniz. Tahmin hakkınız 6. Tahmin edeceğiniz sayı aralığı 1-10.");
                hak = 6;
                random = rastgele.Next(1, 10);
                for (int i = 1; i <= hak; i++)
                {
                    Console.WriteLine("Sayı Tahmini Giriniz : ");
                    girilensayi = Convert.ToInt32(Console.ReadLine());
                    if (random == girilensayi)
                    {
                        Console.WriteLine("Tebrikler Bildiniz!");
                        Console.WriteLine("Oyun bitti");
                        break;
                    }
                    Console.WriteLine("Bilemediniz Kalan Hakkınız : " + (hak - i));
                    if ((hak - i) == 0)
                    {
                        Console.WriteLine("Oyun bitti");
                    }
                }

            }

            else if (oyunseviyesi == 2)
            {

                Console.WriteLine("Normal Mode seçtiniz. Tahmin hakkınız 4. Tahmin edeceğiniz sayı aralığı 1-25.");
                hak = 4;
                random = rastgele.Next(1, 25);
                for (int i = 1; i <= hak; i++)
                {
                    Console.WriteLine("Sayı Tahmini Giriniz: ");
                    girilensayi = Convert.ToInt32(Console.ReadLine());
                    if (random == girilensayi)
                    {
                        Console.WriteLine("Tebrikler Bildiniz!");
                        Console.WriteLine("Oyun bitti");
                        break;
                    }
                    Console.WriteLine("Bilemediniz Kalan Hakkınız : " + (hak - i));
                    if ((hak - i) == 0)
                    {
                        Console.WriteLine("Oyun bitti");
                    }
                }

            }

            else if (oyunseviyesi == 3)
            {

                Console.WriteLine("Hard Mode seçtiniz. Tahmin hakkınız 2. Tahmin edeceğiniz sayı aralığı 1-50.");
                hak = 2;
                random = rastgele.Next(1, 50);
                for (int i = 1; i <= hak; i++)
                {
                    Console.WriteLine("Sayı Tahmini Giriniz : ");
                    girilensayi = Convert.ToInt32(Console.ReadLine());
                    if (random == girilensayi)
                    {
                        Console.WriteLine("Tebrikler Bildiniz!");
                        Console.WriteLine("Oyun bitti");
                        break;
                    }
                    Console.WriteLine("Bilemediniz Klan Hakkınız : " + (hak - i));
                    if ((hak - i) == 0)
                    {
                        Console.WriteLine("Oyun bitti");
                    }
                }

            }

            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz!");
            }

            Console.ReadKey();
        }
    }
}
