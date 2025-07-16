using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrradverwaltung
{
    public class fwrs
    {
        private int fwrsnummer;
        private int fwid;
        private int rsid;
        private int rohwarenAnzahl;

        public int Fwrsnummer { get => fwrsnummer; set => fwrsnummer = value; }
        public int Fwid { get => fwid; set => fwid = value; }
        public int Rsid { get => rsid; set => rsid = value; }
        public int RohwarenAnzahl { get => rohwarenAnzahl; set => rohwarenAnzahl = value; }
      

        public fwrs(int fwrsnummer,  int fwid, int rsid, int rohwarenAnzahl)
        {
            this.fwrsnummer = fwrsnummer;
            this.fwid = fwid;
            this.rsid = rsid;
            this.rohwarenAnzahl = rohwarenAnzahl;
        }


    }
}
