using System.Globalization;

namespace fahrradverwaltung
{
    public partial class Form1 : Form
    {
        Datenbank db = new Datenbank();
        List<Fertigwaren> liFertigwaren = new List<Fertigwaren>();
        List<Rohstoffe> liRohstoffe = new List<Rohstoffe>();
        List<fwrs> liFwrs = new List<fwrs>();
        List<FertigwarenDetails> liFertigwarenDetails = new List<FertigwarenDetails>();

        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;

            fertigwarenAnzeigen();
            vfertigwarenDetailsAnzeigen();
            rohwarenAnzeigen();


            string bildpfad;
            bildpfad = @"picture\fahrrad.png";
            pbFahrrad.Image = Image.FromFile(bildpfad);
            pbFahrrad2.Image = Image.FromFile(bildpfad);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            dgvFListe.ClearSelection();
            dgvFListe.CurrentCell = null;

        }
        public void vfertigwarenDetailsAnzeigen()
        {
            liFertigwarenDetails = db.vfertigwarenEinlesen();
            dgvFRListe.Rows.Clear();
            foreach (FertigwarenDetails f1 in liFertigwarenDetails)
            {
                dgvFRListe.Rows.Add(
                   f1.Fwmodell,
                   f1.Bezeichnung,
                   f1.RohwarenAnzahl,
                   f1.GesamtPreis
                );
            }
        }
        public void fertigwarenAnzeigen()
        {
            liFertigwaren = db.fertigwarenEinlesen();
            dgvFListe.Rows.Clear();
            foreach (Fertigwaren f in liFertigwaren)
            {
                dgvFListe.Rows.Add(f.Fertigwarenid, f.Fwmodell);
            }
        }



      

        public void rohwarenAnzeigen()
        {
            liRohstoffe = db.rohstoffeEinlesen();
            dgvRListe.Rows.Clear();
            foreach (Rohstoffe r in liRohstoffe)
            {
                dgvRListe.Rows.Add(r.Bezeichnung, r.Preis);
                cbZRohware.Items.Add(r.Bezeichnung);
            }
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            string fmodell = txtFModell.Text;
            Fertigwaren f = new Fertigwaren(-1, fmodell);
            db.fertigwareInsert(f);
            fertigwarenAnzeigen();

            txtFModell.Clear();
            dgvFListe.ClearSelection();
            dgvFListe.CurrentCell = null;
        }
        private void btnRHinzufuegen_Click(object sender, EventArgs e)
        {
          

            if (txtRBezeichnung.Text == null || txtRPreis.Text == null|| txtRBezeichnung.Text == "" || (txtRBezeichnung.Text == null && txtRPreis.Text == null))
            {
                if (txtRBezeichnung.Text == null || txtRBezeichnung.Text == "")
                {
                    MessageBox.Show("Bitte einen Namen für die Rohware eingeben!");
                    return;
                }
                else if (txtRPreis.Text == null || txtRPreis.Text == "")
                {
                    MessageBox.Show("Bitte einen Preis für die Rohware Preis eingeben!");
                    return;
                }
                else if (txtRBezeichnung.Text == null && txtRPreis.Text == null)
                {
                    MessageBox.Show("Bitte einen Namen & einen Preis für die Rohware eingeben!");
                    return;

                }
            }
            else if(txtRBezeichnung.Text != null && txtRPreis.Text != null)
            {
                string bezeichnung = txtRBezeichnung.Text;

                string text = txtRPreis.Text.Replace(',', '.');
                double preis;

                if (!double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out preis))
                {
                    MessageBox.Show("Bitte gib einen gültigen Preis ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Rohstoffe r = new Rohstoffe(-1, preis, bezeichnung);
                db.rohstoffInsert(r);
                rohwarenAnzeigen();

                txtRBezeichnung.Clear();
                txtRPreis.Clear();
            }
           
        }

        private void btnZuordnen_Click(object sender, EventArgs e)
        {
            Fertigwaren f = null;
            Rohstoffe r = null;

            if (dgvFListe.CurrentRow != null)
            {
                int zeilenIndex = dgvFListe.CurrentRow.Index;
                f = liFertigwaren[zeilenIndex];
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Fertigwarenmodell aus der Liste aus.");
                return;
            }

            int cbindex = cbZRohware.SelectedIndex;
            if (cbindex != -1)
            {
               r = liRohstoffe[cbindex]; 
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Rohware aus!");
                return;
            }

            int rAnzahl;
            if (!int.TryParse(txtMenge.Text, out rAnzahl))
            {

                MessageBox.Show("Bitte geben Sie eine gültige Anzahl ein.");
                return;
            }
          
                fwrs fero = new fwrs(-1, f.Fertigwarenid, r.Rohstoffid, rAnzahl);
                db.fwrsInsert(fero);
          
           

            liFertigwarenDetails = db.vfertigwarenEinlesen();
            dgvFRListe.Rows.Clear();
            foreach (FertigwarenDetails f1 in liFertigwarenDetails)
            {
                dgvFRListe.Rows.Add(
                   f1.Fwmodell,
                   f1.Bezeichnung,
                   f1.RohwarenAnzahl,
                   f1.GesamtPreis
                );
            }

            dgvFListe.ClearSelection();
            dgvFListe.CurrentCell = null;
            cbZRohware.SelectedIndex = -1;
            txtMenge.Clear();

        }

       
    }
}
