using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class UserValidationManager : IUserValidationService
    {
        // Test için fake bir doğrulama sistemi
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear==1999)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
