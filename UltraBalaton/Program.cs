using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
        }
    }
}
