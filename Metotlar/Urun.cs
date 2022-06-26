using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Urun
    {
        public int Id { get; set; }
        protected int bbc;
       
        
    }

    class Urun2:Urun
    {
       internal void eneme()
        {
            bbc = 5;
        }
    }
    class Ana
    {
        static void Main()
        {
            Urun2 u = new Urun2();
            u.eneme();
        }
    }

}
