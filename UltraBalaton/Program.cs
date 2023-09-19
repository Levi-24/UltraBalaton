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
                path: @"..\..\..\src\ub2017egyeni.txt",
                Encoding.UTF8);
            _ = sr.ReadLine();

            while (!sr.EndOfStream) versenyzok.Add(new Versenyzo(sr.ReadLine()));

            Console.WriteLine($"3.Feladat: Egyéni indulók száma: {versenyzok.Count} fő");

            var f4 = versenyzok.Count(v => !v.Kategoria && v.TavSzazalek == 100);
            Console.WriteLine($"4.Feladat: Célba érkező női sportolók: {f4} fő");

            Console.Write("5.Feladat: Kérem a sportoló nevét: ");
            string nev = Console.ReadLine();

            string indult = "Nem";
            string teljesitett = "Nem";
            bool tartalmaz = versenyzok.Any(v => v.Nev == nev);

            if (tartalmaz)
            {
                indult = "Igen";
                foreach (var v in versenyzok) if (v.Nev == nev && v.TavSzazalek == 100) teljesitett = "Igen";
            }

            Console.WriteLine($"\t Indult egyéniben a sportoló? {indult}");
            Console.WriteLine($"\t Teljesítette a teljes távot? {teljesitett}");
        }
    }
}
