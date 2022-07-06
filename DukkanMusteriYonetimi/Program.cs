using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Kahve dükkanları için müşteri yönetimi yapan sistemin simulasyonu
    Starbucks ve Nero firmaları olacak.
    iki firmada müşterilerini veritabanına kaydetmek istiyor.
    starbucks müşterilerini kaydederken mernis doğrulaması istiyor ama Nero firması istemiyor.
    Starbucks müşterileri için her kahve alımında yıldız kazandırmak istiyor
    
*/
namespace DukkanMusteriYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StarBucks starBucks = new StarBucks();
            Nero nero = new Nero();

            starBucks.RegisterCustomer();
            starBucks.Buy();

            nero.RegisterCustomer();
            nero.Buy();

            Console.ReadLine();
        }
    }
}
