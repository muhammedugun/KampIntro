using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Oyuncuları sisteme kaydeden,silen, güncelleyen program.
 kaydederken kaydın gerçek kişi olup olmadığını kontrol edecek.
     */

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer { FirstName="Muhammed",LastName="Uğun",BirthYear=1999 };
            new GamerManager(new UserValidationManager()).Add(gamer);

            Console.ReadLine();

        }
    }

    

    
    
}
