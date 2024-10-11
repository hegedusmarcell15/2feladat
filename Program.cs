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
        public static void bank()
        {
            
            Console.Write("Kérem, adja meg a lekötni kívánt összeget: ");
            double osszeg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem, adja meg, hány évre szeretné lekötni: ");
            int ev = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérem, adja meg a lekötés kamatát (százalékban): ");
            double kamat = Convert.ToDouble(Console.ReadLine());

            
            double vegosszeg = osszeg * Math.Pow(1 + kamat / 100, ev);

            Console.WriteLine($"A {ev} év múlva a lekötött összeg: {vegosszeg:F2} Ft");
            Console.ReadKey();
        }
        public static void futas()
        {

        }
        static void Main(string[] args)
        {
            koszon();
            bank();

        }
    }
}