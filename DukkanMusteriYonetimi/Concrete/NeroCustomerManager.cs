using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemoMy.Abstract;

namespace InterfaceAbstractDemoMy.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public void Buy()
        {
            Console.WriteLine("Nero müşterisi satın alma gerçekleştirildi.");

        }
    }
}
