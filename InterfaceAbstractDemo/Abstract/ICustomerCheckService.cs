using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    // Müşteri doğrulama ile ilgil operasyonlar
    public interface ICustomerCheckService 
    {
        // Verilen bilgilerin gerçek kişiye ait olup olmadığını doğrulayan metot
        bool CheckIfRealPerson(Customer customer);
    }
}
