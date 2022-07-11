using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        // Verilen bilgilerin gerçek kişiye ait olup olmadığını doğrulayan metot
        public bool CheckIfRealPerson(Customer customer)
        {
            // Simulasyon amaçlı fake metot oluşturduk
            return true;
        }
    }
}
