using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    // GamerManager sınıfının soyutu
    interface IGamerService
    {
        void Add(Gamer gamer); // Normalde Gamer sınıfı yerine daha geneli kapsayan bir interface ya da sınıf eklenmesi lazım 
        //ancak hoca, öğrencinin anlaması kolay olsun diye böyle yaptı

        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
