using System;
using System.Collections.Generic;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            sinif2 sinif = new sinif2();
        }
    }

    class sinif1
    {
        public int a { get; set; }
        public int b { get; set; }

        private int Yas;
        public int YAS
        {
            get { return Yas; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("18 yaşından küçükler üye olamaz.");
                }
                else
                {
                    Yas = value;
                }
            }
        }

    }

    class sinif2
    { 
        public void deneme()
        {
            sinif1 sinifc = new sinif1();
        }
        public int c { get; set; }
    }
    class sinif3 
    {

        public int d { get; set; }
    }
}
