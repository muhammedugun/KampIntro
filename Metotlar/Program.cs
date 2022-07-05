using System;
using System.Collections.Generic;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Sinif2 sinif = new Sinif2();
        }
    }

    class Sinif1
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

    class Sinif2
    { 
        public void deneme()
        {
            Sinif1 sinifc = new Sinif1();
        }
        public int c { get; set; }
    }
    class Sinif3 
    {

        public int d { get; set; }
    }
}
