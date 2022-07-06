using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanMusteriYonetimi
{
    class StarBucks : IBuyManager, IAwardManager, IRegisterVerificationManager, ICompaniesRegisterManager
    {
        public void Buy()
        {
            Console.WriteLine("Starbucks müşterisi satın alma gerçekleştirildi.");
            EarnStar();
        }

        public void EarnStar()
        {
            Console.WriteLine("Starbucks müşterisi yıldız kazandı.");
        }

        public bool MernisVerification()
        {
            Console.WriteLine("Mernis doğrulaması gerçekleştiriliyor...");
            return true;
        }

        public void RegisterCustomer()
        {
            Console.WriteLine("Starbucks müşterisi için kayıt işlemi başlatıldı.");
            if (MernisVerification())
                Console.WriteLine("Müşteri kaydı başarılı.");
            else
                Console.WriteLine("Müşteri kaydı başarısız.");

        }
    }

    class Nero : IBuyManager, ICompaniesRegisterManager
    {
        public void Buy()
        {
            Console.WriteLine("Nero müşterisi satın alma gerçekleştirildi.");
            
        }

        public void RegisterCustomer()
        {
            Console.WriteLine("Nero müşterisi için kayıt işlemi başlatıldı.");
            Console.WriteLine("Müşteri kaydı başarılı.");


        }
    }
}
