using System;

namespace Lab2_z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite brzinu broda u čvorovima:");
            string unos = Console.ReadLine();

            int cvorovi = Int32.Parse(unos);
            float kilometri = (float)(cvorovi * 1852) / 1000;

            Console.WriteLine("Brzina broda u kilometrima je {0} km/h.", kilometri);
        }
    }
}