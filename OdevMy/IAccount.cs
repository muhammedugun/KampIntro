using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OdevMy
{

    internal interface IAccount
    {
        string name { get; set; }
        string surName { get; set; }
        string userName { get; set; }
        string password { get; set; }
        int id { get; set; }    


        void Delete(int _id);
        void InformationUpdate();
    }
}
