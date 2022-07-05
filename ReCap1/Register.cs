using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCap1
{
    internal class Register : ISignUp
    {
        public void GetInformation(IAccount iAccount)
        {
            Console.WriteLine("Kayıt bilgilerini giriniz");

            if (Verification())
                Console.WriteLine("Kayıt başarılı.");
            else
                Console.WriteLine("Kayıt başarısız.");
        }

        public bool Verification()
        {
            return true;
        }

     
    }
}
