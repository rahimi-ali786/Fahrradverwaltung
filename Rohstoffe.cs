using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrradverwaltung
{
    public class Rohstoffe
    {
        private int rohstoffid;
        private double preis;
        private string bezeichnung;
       
        

        public int Rohstoffid { get => rohstoffid; set => rohstoffid = value; }
        public double Preis { get => preis; set => preis = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }

        public Rohstoffe(int rohstoffid, double preis, string bezeichnung)
        {
            this.rohstoffid = rohstoffid;
            this.preis = preis;
            this.bezeichnung = bezeichnung;
            
        }

    }
}
