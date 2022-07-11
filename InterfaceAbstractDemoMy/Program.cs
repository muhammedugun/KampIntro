using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemoMy.Concrete;
using InterfaceAbstractDemoMy.Entities;
/*
    Kahve dükkanları için müşteri yönetimi yapan sistemin simulasyonu.
    Starbucks ve Nero firmaları olacak.
    iki firmada müşterilerini aynı veritabanına kaydetmek istiyor.
    starbucks müşterilerini kaydederken mernis doğrulaması istiyor ama Nero firması istemiyor.
    Starbucks müşterileri için her kahve alımında yıldız kazandırmak istiyor.
*/

namespace InterfaceAbstractDemoMy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { FirstName ="Muhammed",LastName="Uğun" };
            NeroCustomerManager neroCustomerManager = new NeroCustomerManager();
            neroCustomerManager.RegisterCustomer(customer.FirstName, customer.LastName);

            TestCustomerManager testCustomerManager = new TestCustomerManager();

            testCustomerManager.RegisterCustomer(customer.FirstName, customer.LastName);
            

            Console.ReadLine();
        }
    }
}
