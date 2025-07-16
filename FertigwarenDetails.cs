using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrradverwaltung
{
    public class FertigwarenDetails
    {
        private string fwmodell;
        private string bezeichnung;
        private int rohwarenAnzahl;
        private double gesamtPreis;

        public string Fwmodell { get => fwmodell; set => fwmodell = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public int RohwarenAnzahl { get => rohwarenAnzahl; set => rohwarenAnzahl = value; }
        public double GesamtPreis { get => gesamtPreis; set => gesamtPreis = value; }

        public FertigwarenDetails(string fwmodell, string bezeichnung, int rohwarenAnzahl, double gesamtPreis )
        {
            this.fwmodell=fwmodell;
            this.bezeichnung=bezeichnung;
            this.rohwarenAnzahl=rohwarenAnzahl;
            this.gesamtPreis=gesamtPreis;
        }


    }





}
