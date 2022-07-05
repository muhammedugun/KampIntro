using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCap1
{
    internal interface ISignUp
    {
        
        bool Verification();
        void GetInformation(IAccount iAccount);
    }
}
