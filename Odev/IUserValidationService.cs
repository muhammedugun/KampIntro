using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    // UserValidationManager sınıfının soyutu
    interface IUserValidationService
    {
        //Doğrulama metodu
        bool Validate(Gamer gamer); // Daha ileriye yönelik bir kod için Gamer yerine daha çok varlığı kapsayan genel bir yapı 
        //istenebilir.
    }
}
