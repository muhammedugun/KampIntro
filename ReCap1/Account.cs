using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCap1
{
    internal class Account : IAccount
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int id { get; set; }

        public void Delete(int _id)
        {
            Console.WriteLine("Hesap silindi.");
        }

        public void InformationUpdate()
        {
            Console.WriteLine("Bilgiler güncellendi.");
        }
    }
}
