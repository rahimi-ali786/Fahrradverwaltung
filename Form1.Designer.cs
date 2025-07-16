namespace fahrradverwaltung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            Fertigwaren = new TabPage();
            dgvFRListe = new DataGridView();
            fwmodell = new DataGridViewTextBoxColumn();
            Bezeichnung = new DataGridViewTextBoxColumn();
            Menge = new DataGridViewTextBoxColumn();
            Gesamtpreis = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            btnZuordnen = new Button();
            txtMenge = new TextBox();
            cbZRohware = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pbFahrrad = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgvFListe = new DataGridView();
            fahrradnr = new DataGridViewTextBoxColumn();
            fahrradModell = new DataGridViewTextBoxColumn();
            btnHinzufuegen = new Button();
            label3 = new Label();
            txtFModell = new TextBox();
            Rohwaren = new TabPage();
            pbFahrrad2 = new PictureBox();
            groupBox6 = new GroupBox();
            dgvRListe = new DataGridView();
            RBezeichnung = new DataGridViewTextBoxColumn();
            RPreis = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
            btnRHinzufuegen = new Button();
            txtRPreis = new TextBox();
            txtRBezeichnung = new TextBox();
            label5 = new Label();
            label4 = new Label();
            bindingSource1 = new BindingSource(components);
            tabControl1.SuspendLayout();
            Fertigwaren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFRListe).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFahrrad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFListe).BeginInit();
            Rohwaren.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFahrrad2).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRListe).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Fertigwaren);
            tabControl1.Controls.Add(Rohwaren);
            tabControl1.Location = new Point(12, 42);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1636, 622);
            tabControl1.TabIndex = 0;
            // 
            // Fertigwaren
            // 
            Fertigwaren.BackColor = Color.LightSteelBlue;
            Fertigwaren.Controls.Add(dgvFRListe);
            Fertigwaren.Controls.Add(groupBox4);
            Fertigwaren.Controls.Add(groupBox3);
            Fertigwaren.Controls.Add(groupBox1);
            Fertigwaren.Location = new Point(4, 29);
            Fertigwaren.Name = "Fertigwaren";
            Fertigwaren.Padding = new Padding(3);
            Fertigwaren.Size = new Size(1628, 589);
            Fertigwaren.TabIndex = 1;
            Fertigwaren.Text = "Fertigwaren";
            // 
            // dgvFRListe
            // 
            dgvFRListe.AllowUserToAddRows = false;
            dgvFRListe.AllowUserToDeleteRows = false;
            dgvFRListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFRListe.BackgroundColor = Color.Pink;
            dgvFRListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFRListe.Columns.AddRange(new DataGridViewColumn[] { fwmodell, Bezeichnung, Menge, Gesamtpreis });
            dgvFRListe.Location = new Point(812, 48);
            dgvFRListe.Name = "dgvFRListe";
            dgvFRListe.ReadOnly = true;
            dgvFRListe.RowHeadersWidth = 51;
            dgvFRListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFRListe.Size = new Size(765, 491);
            dgvFRListe.TabIndex = 3;
            // 
            // fwmodell
            // 
            fwmodell.HeaderText = "Fahrrad Modell";
            fwmodell.MinimumWidth = 6;
            fwmodell.Name = "fwmodell";
            fwmodell.ReadOnly = true;
            // 
            // Bezeichnung
            // 
            Bezeichnung.HeaderText = "Bezeichnung";
            Bezeichnung.MinimumWidth = 6;
            Bezeichnung.Name = "Bezeichnung";
            Bezeichnung.ReadOnly = true;
            // 
            // Menge
            // 
            Menge.HeaderText = "Menge";
            Menge.MinimumWidth = 6;
            Menge.Name = "Menge";
            Menge.ReadOnly = true;
            // 
            // Gesamtpreis
            // 
            Gesamtpreis.HeaderText = "Gesamtpreis";
            Gesamtpreis.MinimumWidth = 6;
            Gesamtpreis.Name = "Gesamtpreis";
            Gesamtpreis.ReadOnly = true;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(776, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(828, 550);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Fahrrad - Rohwaren Liste";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnZuordnen);
            groupBox3.Controls.Add(txtMenge);
            groupBox3.Controls.Add(cbZRohware);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(pbFahrrad);
            groupBox3.Location = new Point(391, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(365, 550);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fahrrad-Rohwaren Zuordnen";
            // 
            // btnZuordnen
            // 
            btnZuordnen.BackColor = Color.Silver;
            btnZuordnen.Location = new Point(248, 378);
            btnZuordnen.Name = "btnZuordnen";
            btnZuordnen.Size = new Size(94, 29);
            btnZuordnen.TabIndex = 5;
            btnZuordnen.Text = "Zuordnen";
            btnZuordnen.UseVisualStyleBackColor = false;
            btnZuordnen.Click += btnZuordnen_Click;
            // 
            // txtMenge
            // 
            txtMenge.BackColor = SystemColors.Info;
            txtMenge.Location = new Point(106, 325);
            txtMenge.Name = "txtMenge";
            txtMenge.Size = new Size(236, 27);
            txtMenge.TabIndex = 4;
            // 
            // cbZRohware
            // 
            cbZRohware.BackColor = SystemColors.Info;
            cbZRohware.FormattingEnabled = true;
            cbZRohware.Location = new Point(106, 272);
            cbZRohware.Name = "cbZRohware";
            cbZRohware.Size = new Size(236, 28);
            cbZRohware.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 332);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 2;
            label2.Text = "Menge";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 280);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Rohware";
            // 
            // pbFahrrad
            // 
            pbFahrrad.BackColor = Color.Pink;
            pbFahrrad.Location = new Point(27, 42);
            pbFahrrad.Name = "pbFahrrad";
            pbFahrrad.Size = new Size(315, 206);
            pbFahrrad.SizeMode = PictureBoxSizeMode.Zoom;
            pbFahrrad.TabIndex = 0;
            pbFahrrad.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnHinzufuegen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFModell);
            groupBox1.Location = new Point(34, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 556);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fertigwaren";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvFListe);
            groupBox2.Location = new Point(18, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 397);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fahrrad Liste";
            // 
            // dgvFListe
            // 
            dgvFListe.AllowUserToAddRows = false;
            dgvFListe.AllowUserToDeleteRows = false;
            dgvFListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFListe.BackgroundColor = Color.LightPink;
            dgvFListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFListe.Columns.AddRange(new DataGridViewColumn[] { fahrradnr, fahrradModell });
            dgvFListe.Location = new Point(6, 43);
            dgvFListe.Name = "dgvFListe";
            dgvFListe.ReadOnly = true;
            dgvFListe.RowHeadersWidth = 51;
            dgvFListe.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvFListe.Size = new Size(279, 319);
            dgvFListe.TabIndex = 0;
            // 
            // fahrradnr
            // 
            fahrradnr.HeaderText = "ID";
            fahrradnr.MinimumWidth = 6;
            fahrradnr.Name = "fahrradnr";
            fahrradnr.ReadOnly = true;
            fahrradnr.Visible = false;
            // 
            // fahrradModell
            // 
            fahrradModell.HeaderText = "Fahrrad Modell";
            fahrradModell.MinimumWidth = 6;
            fahrradModell.Name = "fahrradModell";
            fahrradModell.ReadOnly = true;
            // 
            // btnHinzufuegen
            // 
            btnHinzufuegen.BackColor = Color.Silver;
            btnHinzufuegen.Location = new Point(234, 72);
            btnHinzufuegen.Name = "btnHinzufuegen";
            btnHinzufuegen.Size = new Size(94, 29);
            btnHinzufuegen.TabIndex = 2;
            btnHinzufuegen.Text = "Hinzufügen";
            btnHinzufuegen.UseVisualStyleBackColor = false;
            btnHinzufuegen.Click += btnHinzufuegen_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 0;
            label3.Text = "Fahrrad Modell";
            // 
            // txtFModell
            // 
            txtFModell.BackColor = SystemColors.Info;
            txtFModell.Location = new Point(143, 27);
            txtFModell.Name = "txtFModell";
            txtFModell.Size = new Size(185, 27);
            txtFModell.TabIndex = 1;
            // 
            // Rohwaren
            // 
            Rohwaren.BackColor = Color.LightSteelBlue;
            Rohwaren.Controls.Add(pbFahrrad2);
            Rohwaren.Controls.Add(groupBox6);
            Rohwaren.Controls.Add(groupBox5);
            Rohwaren.Location = new Point(4, 29);
            Rohwaren.Name = "Rohwaren";
            Rohwaren.Size = new Size(1628, 589);
            Rohwaren.TabIndex = 2;
            Rohwaren.Text = "Rohwaren";
            // 
            // pbFahrrad2
            // 
            pbFahrrad2.BackColor = Color.Transparent;
            pbFahrrad2.Location = new Point(24, 24);
            pbFahrrad2.Name = "pbFahrrad2";
            pbFahrrad2.Size = new Size(268, 228);
            pbFahrrad2.SizeMode = PictureBoxSizeMode.Zoom;
            pbFahrrad2.TabIndex = 9;
            pbFahrrad2.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgvRListe);
            groupBox6.Location = new Point(691, 41);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(447, 435);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Rohwaren Liste";
            // 
            // dgvRListe
            // 
            dgvRListe.AllowUserToAddRows = false;
            dgvRListe.AllowUserToDeleteRows = false;
            dgvRListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRListe.BackgroundColor = Color.Pink;
            dgvRListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRListe.Columns.AddRange(new DataGridViewColumn[] { RBezeichnung, RPreis });
            dgvRListe.Location = new Point(6, 25);
            dgvRListe.Name = "dgvRListe";
            dgvRListe.ReadOnly = true;
            dgvRListe.RowHeadersWidth = 51;
            dgvRListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRListe.Size = new Size(435, 403);
            dgvRListe.TabIndex = 0;
            // 
            // RBezeichnung
            // 
            RBezeichnung.HeaderText = "Bezeichnung";
            RBezeichnung.MinimumWidth = 6;
            RBezeichnung.Name = "RBezeichnung";
            RBezeichnung.ReadOnly = true;
            // 
            // RPreis
            // 
            RPreis.HeaderText = "Preis";
            RPreis.MinimumWidth = 6;
            RPreis.Name = "RPreis";
            RPreis.ReadOnly = true;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Pink;
            groupBox5.Controls.Add(btnRHinzufuegen);
            groupBox5.Controls.Add(txtRPreis);
            groupBox5.Controls.Add(txtRBezeichnung);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new Point(322, 66);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(352, 410);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "neue Rohware";
            // 
            // btnRHinzufuegen
            // 
            btnRHinzufuegen.BackColor = Color.Silver;
            btnRHinzufuegen.Location = new Point(229, 163);
            btnRHinzufuegen.Name = "btnRHinzufuegen";
            btnRHinzufuegen.Size = new Size(94, 29);
            btnRHinzufuegen.TabIndex = 4;
            btnRHinzufuegen.Text = "Hinzufügen";
            btnRHinzufuegen.UseVisualStyleBackColor = false;
            btnRHinzufuegen.Click += btnRHinzufuegen_Click;
            // 
            // txtRPreis
            // 
            txtRPreis.BackColor = SystemColors.Info;
            txtRPreis.Location = new Point(156, 114);
            txtRPreis.Name = "txtRPreis";
            txtRPreis.Size = new Size(190, 27);
            txtRPreis.TabIndex = 3;
            // 
            // txtRBezeichnung
            // 
            txtRBezeichnung.BackColor = SystemColors.Info;
            txtRBezeichnung.Location = new Point(156, 70);
            txtRBezeichnung.Name = "txtRBezeichnung";
            txtRBezeichnung.Size = new Size(190, 27);
            txtRBezeichnung.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 114);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 1;
            label5.Text = "Preis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 70);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 0;
            label4.Text = "Bezeichnung";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1700, 748);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Fertigwaren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFRListe).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFahrrad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFListe).EndInit();
            Rohwaren.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFahrrad2).EndInit();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRListe).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Fertigwaren;
        private TabPage Rohwaren;
        private TabPage tabPage2;
        private Label label3;
        private TextBox txtFModell;
        private DataGridView dgvFRListe;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvFListe;
        private Button btnHinzufuegen;
        private GroupBox groupBox3;
        private TextBox txtMenge;
        private ComboBox cbZRohware;
        private Label label2;
        private Label label1;
        private PictureBox pbFahrrad;
        private GroupBox groupBox4;
        private Button btnZuordnen;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private DataGridView dgvRListe;
        private DataGridViewTextBoxColumn RBezeichnung;
        private DataGridViewTextBoxColumn RPreis;
        private Button btnRHinzufuegen;
        private TextBox txtRPreis;
        private TextBox txtRBezeichnung;
        private Label label5;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn fahrradnr;
        private DataGridViewTextBoxColumn fahrradModell;
        private DataGridViewTextBoxColumn fwmodell;
        private DataGridViewTextBoxColumn Bezeichnung;
        private DataGridViewTextBoxColumn Menge;
        private DataGridViewTextBoxColumn Gesamtpreis;
        private PictureBox pbFahrrad2;
    }
}
