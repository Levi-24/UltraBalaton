using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace UltraBalaton
{
    class Program
    {
        static void Main(string[] args)
        {
            var versenyzok = new List<Versenyzo>();
            using var sr = new StreamReader(
                path: "../../../src/ub2017egyeni.txt",
                Encoding.UTF8);

            string headerLine = sr.ReadLine();

            while (!sr.EndOfStream) versenyzok.Add(new Versenyzo(sr.ReadLine()));

            Console.WriteLine($"3.Feladat: Egyéni indulók: {versenyzok.Count} fő");

            int teljesnoi = 0;
            foreach (var v in versenyzok)
            {
                if (v.Kategoria == false && v.TeljesTav == 100)
                {
                    teljesnoi++;
                }
            }
            Console.WriteLine($"4.Feladat: Célba érkező női sportolók: {teljesnoi} fő");

            Console.Write("5.Feladat: Kérem a sportoló nevét: ");
            string nev = Console.ReadLine();

            string indult = "Nem";
            string teljesitett = "Nem";
            bool tartalmaz = versenyzok.Any(v => v.Nev == nev);

            if (tartalmaz)
            {
                indult = "Igen";
                foreach (var v in versenyzok) if (v.Nev == nev && v.TeljesTav == 100) teljesitett = "Igen";
            }

            Console.WriteLine($"\t Indult egyéniben a sportoló? {indult}");
            Console.WriteLine($"\t Teljesítette a teljes távot? {teljesitett}");

            Console.WriteLine("6.Feladat:");

        }

        static double IdoOraban(int[] ido)
        {
            double vegeredmeny = (ido[0] * 3600 + ido[1] * 60 + ido[2]) / 3600;
            return vegeredmeny;
        }
    }
}
