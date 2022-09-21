using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayitahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random messi = new Random();
            //int Rastgelesayi = messi.Next(1, 5);

            //for (int a = 0; a < 5; a++)
            //{
            //    Console.WriteLine("ltfn sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == Rastgelesayi)
            //    {
            //        Console.WriteLine("daoru bildiniz");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("BİLEMEDİNİZ");
            //    }

            //}
            //Console.WriteLine("DOĞRU CEVAP: " + Rastgelesayi);

            //KLAVYEDEN GİRİLEN İKİ SAYI ARASINDAKİ TEK SAYILARI LİSTELEYEN PROGRAM polimorfizm nedir?????

            //---------------------------------------------------------------------------------------------//

            //Console.WriteLine("ltfn birinci sayıyı giriniz");
            //int birinciSayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("ltfn ikinci sayıyı giriniz");
            //int ikinciciSayi = Convert.ToInt32(Console.ReadLine());

            //for (int a = birinciSayi; a < ikinciciSayi; a++)
            //{
            //    if (a % 2 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(a);
            //    }

            //-----------------------------------------------------------------------------------------//


            //bir randon nesne üzenrinden sayı üretin 
            // içerinde 5 adet meyve olan string bir dizi oluşturun
            //klavyeden bir meyve isteyin
            // klavyeden istenen meyve ile dizinin içerisinden rastgele seçilen meyve eşit olursa doğru
            // aksi halde yanlıştır

            //if(gelenmeyve==meyveler[rastgelesayi]


            string[] meyveler = { "elma","armut","portakal","karpuz","muz" };

            Random fruit = new Random();
            int Rastgelesayi = fruit.Next(0, 4);

            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine("meyve seciniz:elma,armutiportakal,karpuz,muz");
                string cevap = Convert.ToString(Console.ReadLine());




                if (cevap == meyveler[Rastgelesayi])
                {
                    Console.WriteLine("doğru");
                }
                else
                {
                    Console.WriteLine("yanlış");
                }
            }
            Console.ReadKey();


            }
        }
    }


