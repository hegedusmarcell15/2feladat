using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace feladat
{
    class Program
    {
        public static void koszon()
        {
            DateTime ido = DateTime.Now;
            Console.WriteLine("Jelenlegi idő: {0}:{1}.",
                          ido.Hour, ido.Minute);
            if (ido.Hour > 5 && ido.Hour < 9)
            {
                Console.WriteLine("Jó reggelt!");
            }
            else if (ido.Hour > 8 && ido.Hour < 19)
            {
                Console.WriteLine("Jó napot!");
            }
            else
            {
                Console.WriteLine("Jó éjszakat!");
            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            DateTime ido = DateTime.Now;
            Console.WriteLine("Jelenlegi idő: {0}:{1}.",
                          ido.Hour, ido.Minute);
            if (ido.Hour > 5 && ido.Hour < 9)
            {
                Console.WriteLine("Jó reggelt!");
            }
            else if (ido.Hour > 8 && ido.Hour < 19)
            {
                Console.WriteLine("Jó napot!");
            }
            else
            {
                Console.WriteLine("Jó éjszakat!");
            }
            Console.ReadLine();
        }
    }
}