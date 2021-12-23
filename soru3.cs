using System;
using System.Collections.Generic;
using System.Text;

namespace odev1
{
    class soru3
    {
        //Üçüncü Soru-------> Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
        //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        static void Main(string[] args)
        {
            List<string> kelimeler = new List<string>();
            Console.Write("Lütfen Pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} adet de kelime giriniz", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}.Kelimeyi Giriniz;", i + 1);
                string kelime = Console.ReadLine();
                kelimeler.Add(kelime);
            }
            int son = kelimeler.Count - 1;
            Console.WriteLine("****Son yazılandan ilk yazılana doğru kelimeler*****");
            for (int i = son; i >= 0; --i)
            {
                Console.WriteLine(kelimeler[i]);
            }
        }
    }
}