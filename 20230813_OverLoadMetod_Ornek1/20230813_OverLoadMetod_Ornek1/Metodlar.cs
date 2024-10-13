using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230813_OverLoadMetod_Ornek1
{
    internal class Metodlar
    {
        public void Hesapla(int s1,int s2)
        {
            Console.WriteLine("Geçerli Bir işlem Türü Girmediniz Sayılar Toplanacak ");
            Console.WriteLine("Sayıların Toplamı = "+(s1+s2));
        }

        public void Hesapla(int s1,int s2 ,string secim)
        {
            string format = "{0} {1} {2} = {3}";
            double sonuc = 0;
            switch (secim)
            {
                case "+":
                    sonuc = s1 + s2;
                    break;

                case "-":
                    sonuc = s1 - s2;
                    break;

                case "*":
                    sonuc = s1 * s2;
                    break;

                case "/":
                    sonuc = s1 / s2;
                    break; 
            }
            Console.WriteLine(format,s1,secim,s2,sonuc);
        }
    }
}
