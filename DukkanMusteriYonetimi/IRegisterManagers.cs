using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukkanMusteriYonetimi
{
    interface ICompaniesRegisterManager
    {
        void RegisterCustomer(); // müşteri kaydeder

    }

    interface IRegisterVerificationManager // kayıt doğrulaması
    {
        bool MernisVerification(); // Mernis doğrulaması

    }




}
