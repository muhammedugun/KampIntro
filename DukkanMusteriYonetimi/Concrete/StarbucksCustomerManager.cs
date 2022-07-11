using InterfaceAbstractDemoMy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemoMy.Concrete
{
    public class StarbucksManager : BaseCustomerManager, IAwardManager, IRegisterVerificationManager
    {
        public void Buy()
        {
            Console.WriteLine("Starbucks müşterisi satın alma gerçekleştirildi.");
            EarnStar();
        }

        public void EarnStar()
        {
            throw new NotImplementedException();
        }

        public bool MernisVerification()
        {
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
}
