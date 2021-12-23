using System;

namespace odev1
{
    class Program
    {

         //Birinci Soru -------->Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
         //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
         // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

        static void Main(string[] args)
        {
            Console.Write("Lütfen Pozitif bir sayı giriniz ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen {0} adet sayı giriniz",n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}.Sayıyı Giriniz;", i+1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
               {
                    Console.WriteLine("Çift "+sayi);
               }     
            }
        }
   }
}