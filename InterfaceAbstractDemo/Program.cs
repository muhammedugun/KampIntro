using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1999, 1, 1), FirstName = "Muhammed", LastName = "Uğun" });
            Console.ReadLine();

        }
    }
}
