using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService; // bunun yerine direkt olarak UserValidationManagerden bir nesne oluşturupta
        //işimizi görebilirdik ancak bu ileriye dönük olmazdı, bu yüzden daha geneli kapsaması açısından bir interface kullandık.

        // Aşağıdaki imza sayesinde interface'i implemente etmiş sınıflar bu yapıcı metoda referans olarak gönderilebilir.
        public GamerManager(IUserValidationService userValidationService) 
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            // ekleme yapmadan önce doğrulama yapılıyor
            if(_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
