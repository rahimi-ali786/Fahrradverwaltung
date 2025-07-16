using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrradverwaltung
{
    public class Fertigwaren
    {
        private int fertigwarenid;
        private string fwmodell;

        public int Fertigwarenid { get => fertigwarenid; set => fertigwarenid = value; }
        public string Fwmodell { get => fwmodell; set => fwmodell = value; }

        public Fertigwaren(int fertigwarenid, string fwmodell)
        {
            this.fertigwarenid = fertigwarenid;
            this.fwmodell = fwmodell;
        }

    }
}
