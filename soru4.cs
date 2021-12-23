using System;
using System.Collections.Generic;
using System.Text;

namespace soru4
{
    //Dördüncü Soru---->Bir konsol uygulamasında kullanıcıdan bir cümle yazmasını isteyin.
    //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

    class dorduncuSoru
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz:");
            string cumle = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                      + "abcçdefgğhiıjklmnoöprsştuüvyz";
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı:" + kelimeler.Length);

            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Toplam {0} tane  harf vardır.", sayac);
            Console.ReadLine();
        }
    }
}