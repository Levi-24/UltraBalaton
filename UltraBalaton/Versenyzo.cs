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
        public string RajtSzam { get; set; }
        public bool Kategoria { get; set; }
        public TimeSpan VersenyIdo { get; set; }
        public int TavSzazalek { get; set; }

        public Versenyzo(string beolvasottSor)
        {
            var adat = beolvasottSor.Split(';');
            this.Nev = adat[0];
            this.RajtSzam = adat[1];
            this.Kategoria = adat[2] == "Ferfi";
            var ido = adat[3].Split(':');
            this.VersenyIdo = new TimeSpan(
                hours: int.Parse(ido[0]),
                minutes: int.Parse(ido[1]),
                seconds: int.Parse(ido[2]));
            this.TavSzazalek = int.Parse(adat[4]);
        }
    }
}
