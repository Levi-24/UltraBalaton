using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraBalaton
{
    class Versenyzo
    {
        public string Nev { get; set; }
        public int VersenySzam { get; set; }
        public bool Kategoria { get; set; }
        public int[] IdoPontszamok { get; set; }
        public int TeljesTav { get; set; }

        public Versenyzo(string beolvasottSor)
        {
            string[] adat = beolvasottSor.Split(';');
            this.Nev = adat[0];
            this.VersenySzam = int.Parse(adat[1]);
            this.Kategoria = adat[2] == "Ferfi";
            this.IdoPontszamok = new int[3];
            string[] pontok = adat[3].Split(':');
            for (int i = 0; i < IdoPontszamok.Length; i++)
            {
                IdoPontszamok[i] = int.Parse(pontok[i]);
            }
            this.TeljesTav = int.Parse(adat[4]);
        }
    }
}
