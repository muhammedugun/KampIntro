using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevMy
{
    internal interface ISignUp
    {
        
        bool Verification();
        void GetInformation(IAccount iAccount);
    }
}
