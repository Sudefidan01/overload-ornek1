using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230813_OverLoadMetod_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek 1 
            //Kullanıcıdan 2 adet sayı talep edelim
            //Bir adette işlem türü talep edelim
            //İşlem türüne göre sonucu ekrana yazdıralım
            //Kullanıcı işlem türü girmeden enter ' a basarsa toplama işlemi yaptıralım

            Console.Write("1.Sayıyı Girin : ");
            int sayi1= int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Girin : ");
            int sayi2=int.Parse(Console.ReadLine());

            Console.Write("İşlem Türünü Giriniz (+ , - , * , / ) : ");
            string islemTuru=Console.ReadLine();

            Metodlar m=new Metodlar();
            if (string.IsNullOrEmpty(islemTuru))
            {
                m.Hesapla(sayi1,sayi2);
            }
            else 
            {
                m.Hesapla(sayi1,sayi2,islemTuru);
            }

            Console.ReadKey();
        }
    }
}
