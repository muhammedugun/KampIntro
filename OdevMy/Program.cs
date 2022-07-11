using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevMy
{
    /*
        Web site kayıt ve hesap sistemi
        Siteye kayıt olma, kayıt silme, bilgi güncelleme(parola, isim, soyisim, 
        kullanıcı adı değişikliği)
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hesap bilgileri girildi
            Account account1 = new Account { name="Muhammed",surName="Uğun",userName="kullanıcıAdım",
                password="şifrem123",id=123 };

            // Kayıt işlemi başlatıldı
            Register register = new Register();
            register.GetInformation(account1);
            
            // Hesap silindi.
            account1.Delete(account1.id);

            Console.ReadLine();
        }
    }
}
