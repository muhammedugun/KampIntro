using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemoMy.Abstract
{
    public interface ICompaniesRegisterManager
    {
        void RegisterCustomer(string firstName, string lastName); // müşteri kaydeder

    }

    public interface IRegisterVerificationManager // kayıt doğrulaması
    {
        bool MernisVerification(); // Mernis doğrulaması
    }

}
