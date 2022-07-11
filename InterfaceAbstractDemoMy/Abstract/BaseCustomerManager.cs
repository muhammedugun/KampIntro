using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemoMy.Abstract
{
    public abstract class BaseCustomerManager : IBuyManager, ICompaniesRegisterManager
    {
        public virtual void Buy()
        {
            Console.WriteLine("Satın alım gerçekleştirildi.");
        }

        public virtual void RegisterCustomer(string firstName, string lastName)
        {

            Console.WriteLine(firstName + " " + lastName + " İçin " + "Kayıt gerçekleştirildi.");
        }
    }
}
