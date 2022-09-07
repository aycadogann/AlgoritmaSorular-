using System;

namespace AlgoritmaSoruları
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.Write("Pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];

            Console.WriteLine("Lütfen {0} adet pozitif sayı giriniz: ", n);
            string sayilar = Console.ReadLine();
            string[] sayilarDizi = sayilar.Split(' ');

            for (int i = 0; i < sayilarDizi.Length; i++)
            {
                dizi[i] = int.Parse(sayilarDizi[i]);

                if (dizi[i] % 2 == 0)
                {
                    Console.WriteLine("Çift sayı: " + dizi[i]);
                }
            }


            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.Write("Lütfen 1. sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen 2. sayıyı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int[] sayilarDizisi = new int[sayi1];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Lütfen {0}. pozitif sayıyı giriniz: ", i+1);
                sayilarDizisi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var sayi in sayilar)
            {
                if (sayi==sayi2 || sayi%sayi2==0)
                {
                    Console.WriteLine("{0} sayısına eşit ya da bölünebilen sayı: {1}",sayi2,sayi);
                }
            }

            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın
             Console.Write("Pozitif bir sayı giriniz: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} adet kelime giriniz:",p);
            string kelimeler = Console.ReadLine();
            string[] kelimelerDizi = kelimeler.Split(' ');
            if (p==kelimelerDizi.Length)
            {
                Console.WriteLine("Kelimlerin sondan başa doğru yazılması: ");
                Array.Reverse(kelimelerDizi);
                foreach (var kelime in kelimelerDizi)
                {
                    Console.WriteLine(kelime);
                }
            }
            else
            {
                Console.WriteLine("Lütfen {0} adet kelime giriniz!",p);
            }

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.Write("Lütfen bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string[] cumleDizi = cumle.Split(' ');
            Console.WriteLine("Cümledeki toplam kelime sayısı:{0} ",dizi.Length);
            string karakter=string.Join("", dizi);
            int sayac = 0;
            for (int i = 0; i < karakter.Length; i++)
            {
                sayac++;
            }
            Console.WriteLine("Cümledeki toplam harf sayısı:{0}",sayac);

           
        }
    }
}
