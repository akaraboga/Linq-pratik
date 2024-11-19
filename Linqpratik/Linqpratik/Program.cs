using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqpratik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();//Rastgele olusturulan liste
            List<int> sayi = Enumerable.Range(1, 10).Select(n => random.Next(-40, 40)).ToList();//select ile random sayiyi -40 ve -30 arasında olustur diyoruz

            Console.Write("Listede ki sayılar :");
            Console.WriteLine(string.Join(" , ", sayi));

            Console.WriteLine();

            //Çift sayilar
            var CiftSayi = sayi.Where(n => n % 2 == 0);
            Console.WriteLine("Çift sayilar ");
            Console.WriteLine(string.Join(" , ", CiftSayi));

            Console.WriteLine();

            //Tek sayilar
            var TekSayi = sayi.Where(n => n % 2 != 0);
            Console.WriteLine("Tek sayilar");
            Console.WriteLine(string.Join(" , ", TekSayi));

            Console.WriteLine();

            //Negatif sayilar
            var Nsayilar = sayi.Where(n => n < 0);
            Console.WriteLine("Negatif sayilar");
            Console.WriteLine(string.Join(" ,  ", Nsayilar));

            Console.WriteLine();

            //Pozitif sayilar
            var psayilar = sayi.Where(n => n > 0);
            Console.WriteLine("Pozitif sayilar ");
            Console.WriteLine(string.Join(" , ", psayilar));

            Console.WriteLine();

            //15 den buyuk 22 den küçük sayilar
            var BuyukSayi = sayi.Where(n => n > 15 && n < 22);
            Console.WriteLine("15 den buyuk 22 den küçük sayilar");
            Console.WriteLine(string.Join(" , ", BuyukSayi));

            Console.WriteLine();

            var kare = sayi.Select(n => n * n).ToList();//Select ile karesini alıyoruz
            Console.WriteLine("Rastgele sayinin kareleri");
            Console.WriteLine(string.Join(" , ", kare));


            Console.ReadLine();


        }
    }
}
