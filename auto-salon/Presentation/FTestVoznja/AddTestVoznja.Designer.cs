namespace auto_salon.Presentation.FTestVoznja
{
    partial class AddTestVoznja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTestVoznja));
            tblMain = new TableLayoutPanel();
            tblLeft = new TableLayoutPanel();
            panel2 = new Panel();
            tblProdavci = new TableLayoutPanel();
            label1 = new Label();
            lvZaposleni = new ListView();
            tblKupci = new TableLayoutPanel();
            label2 = new Label();
            tcKupci = new TabControl();
            tpFizickoLice = new TabPage();
            lvFizickaLica = new ListView();
            tpPravnoLice = new TabPage();
            lvPravnaLica = new ListView();
            btnDodajKupca = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            rtbZakljucak = new RichTextBox();
            label5 = new Label();
            nupOcena = new NumericUpDown();
            dtpDatum = new DateTimePicker();
            label3 = new Label();
            timePickerVreme = new DateTimePicker();
            label9 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            btnSubmit = new Button();
            tblMain.SuspendLayout();
            tblLeft.SuspendLayout();
            panel2.SuspendLayout();
            tblProdavci.SuspendLayout();
            tblKupci.SuspendLayout();
            tcKupci.SuspendLayout();
            tpFizickoLice.SuspendLayout();
            tpPravnoLice.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupOcena).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.53157F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.4684258F));
            tblMain.Controls.Add(tblLeft, 0, 1);
            tblMain.Controls.Add(groupBox1, 1, 1);
            tblMain.Controls.Add(label4, 0, 0);
            tblMain.Controls.Add(panel3, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(15);
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 755F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tblMain.Size = new Size(1040, 886);
            tblMain.TabIndex = 10;
            // 
            // tblLeft
            // 
            tblLeft.ColumnCount = 1;
            tblLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLeft.Controls.Add(panel2, 0, 1);
            tblLeft.Controls.Add(tblKupci, 0, 0);
            tblLeft.Dock = DockStyle.Fill;
            tblLeft.Location = new Point(18, 52);
            tblLeft.Name = "tblLeft";
            tblLeft.RowCount = 2;
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6008F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3992F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLeft.Size = new Size(766, 749);
            tblLeft.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(tblProdavci);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 382);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 364);
            panel2.TabIndex = 1;
            // 
            // tblProdavci
            // 
            tblProdavci.ColumnCount = 1;
            tblProdavci.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblProdavci.Controls.Add(label1, 0, 0);
            tblProdavci.Controls.Add(lvZaposleni, 0, 1);
            tblProdavci.Dock = DockStyle.Fill;
            tblProdavci.Location = new Point(0, 0);
            tblProdavci.Name = "tblProdavci";
            tblProdavci.RowCount = 2;
            tblProdavci.RowStyles.Add(new RowStyle());
            tblProdavci.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblProdavci.RowStyles.Add(new RowStyle());
            tblProdavci.Size = new Size(760, 364);
            tblProdavci.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 1;
            label1.Text = "Zaposleni salona (aktivni)";
            // 
            // lvZaposleni
            // 
            lvZaposleni.Dock = DockStyle.Fill;
            lvZaposleni.FullRowSelect = true;
            lvZaposleni.GridLines = true;
            lvZaposleni.Location = new Point(3, 23);
            lvZaposleni.Name = "lvZaposleni";
            lvZaposleni.Size = new Size(754, 338);
            lvZaposleni.TabIndex = 0;
            lvZaposleni.UseCompatibleStateImageBehavior = false;
            lvZaposleni.View = View.Details;
            lvZaposleni.SelectedIndexChanged += lvZaposleni_SelectedIndexChanged;
            // 
            // tblKupci
            // 
            tblKupci.ColumnCount = 1;
            tblKupci.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblKupci.Controls.Add(label2, 0, 0);
            tblKupci.Controls.Add(tcKupci, 0, 1);
            tblKupci.Controls.Add(btnDodajKupca, 0, 2);
            tblKupci.Dock = DockStyle.Fill;
            tblKupci.Location = new Point(3, 3);
            tblKupci.Name = "tblKupci";
            tblKupci.RowCount = 3;
            tblKupci.RowStyles.Add(new RowStyle());
            tblKupci.RowStyles.Add(new RowStyle(SizeType.Absolute, 288F));
            tblKupci.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblKupci.Size = new Size(760, 373);
            tblKupci.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Kupci";
            // 
            // tcKupci
            // 
            tcKupci.Controls.Add(tpFizickoLice);
            tcKupci.Controls.Add(tpPravnoLice);
            tcKupci.Dock = DockStyle.Fill;
            tcKupci.Location = new Point(3, 23);
            tcKupci.Name = "tcKupci";
            tcKupci.SelectedIndex = 0;
            tcKupci.Size = new Size(754, 282);
            tcKupci.TabIndex = 8;
            tcKupci.SelectedIndexChanged += tcKupci_SelectedIndexChanged;
            // 
            // tpFizickoLice
            // 
            tpFizickoLice.Controls.Add(lvFizickaLica);
            tpFizickoLice.Location = new Point(4, 24);
            tpFizickoLice.Name = "tpFizickoLice";
            tpFizickoLice.Padding = new Padding(3);
            tpFizickoLice.Size = new Size(746, 254);
            tpFizickoLice.TabIndex = 0;
            tpFizickoLice.Text = "Fizičko lice";
            tpFizickoLice.UseVisualStyleBackColor = true;
            // 
            // lvFizickaLica
            // 
            lvFizickaLica.Dock = DockStyle.Fill;
            lvFizickaLica.FullRowSelect = true;
            lvFizickaLica.GridLines = true;
            lvFizickaLica.Location = new Point(3, 3);
            lvFizickaLica.Name = "lvFizickaLica";
            lvFizickaLica.Size = new Size(740, 248);
            lvFizickaLica.TabIndex = 0;
            lvFizickaLica.UseCompatibleStateImageBehavior = false;
            lvFizickaLica.View = View.Details;
            lvFizickaLica.SelectedIndexChanged += lvFizickaLica_SelectedIndexChanged;
            // 
            // tpPravnoLice
            // 
            tpPravnoLice.Controls.Add(lvPravnaLica);
            tpPravnoLice.Location = new Point(4, 24);
            tpPravnoLice.Name = "tpPravnoLice";
            tpPravnoLice.Padding = new Padding(3);
            tpPravnoLice.Size = new Size(746, 254);
            tpPravnoLice.TabIndex = 1;
            tpPravnoLice.Text = "Pravno lice";
            tpPravnoLice.UseVisualStyleBackColor = true;
            // 
            // lvPravnaLica
            // 
            lvPravnaLica.Dock = DockStyle.Fill;
            lvPravnaLica.FullRowSelect = true;
            lvPravnaLica.GridLines = true;
            lvPravnaLica.Location = new Point(3, 3);
            lvPravnaLica.Name = "lvPravnaLica";
            lvPravnaLica.Size = new Size(740, 248);
            lvPravnaLica.TabIndex = 1;
            lvPravnaLica.UseCompatibleStateImageBehavior = false;
            lvPravnaLica.View = View.Details;
            lvPravnaLica.SelectedIndexChanged += lvPravnaLica_SelectedIndexChanged;
            // 
            // btnDodajKupca
            // 
            btnDodajKupca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDodajKupca.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajKupca.Location = new Point(601, 311);
            btnDodajKupca.Name = "btnDodajKupca";
            btnDodajKupca.Size = new Size(156, 37);
            btnDodajKupca.TabIndex = 6;
            btnDodajKupca.Text = "Dodaj kupca";
            btnDodajKupca.UseVisualStyleBackColor = true;
            btnDodajKupca.Click += btnDodajKupca_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(rtbZakljucak);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nupOcena);
            groupBox1.Controls.Add(dtpDatum);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(timePickerVreme);
            groupBox1.Controls.Add(label9);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(790, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 749);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o test vožnji";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 208);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 25;
            label6.Text = "Zaključak";
            // 
            // rtbZakljucak
            // 
            rtbZakljucak.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rtbZakljucak.Location = new Point(20, 226);
            rtbZakljucak.Name = "rtbZakljucak";
            rtbZakljucak.Size = new Size(193, 190);
            rtbZakljucak.TabIndex = 24;
            rtbZakljucak.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 147);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 23;
            label5.Text = "Ocena";
            // 
            // nupOcena
            // 
            nupOcena.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nupOcena.DecimalPlaces = 1;
            nupOcena.Location = new Point(20, 165);
            nupOcena.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupOcena.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupOcena.Name = "nupOcena";
            nupOcena.Size = new Size(193, 23);
            nupOcena.TabIndex = 22;
            nupOcena.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpDatum
            // 
            dtpDatum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDatum.Format = DateTimePickerFormat.Short;
            dtpDatum.Location = new Point(20, 53);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(193, 23);
            dtpDatum.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 35);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 21;
            label3.Text = "Datum";
            // 
            // timePickerVreme
            // 
            timePickerVreme.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            timePickerVreme.Format = DateTimePickerFormat.Custom;
            timePickerVreme.Location = new Point(20, 109);
            timePickerVreme.Name = "timePickerVreme";
            timePickerVreme.Size = new Size(78, 23);
            timePickerVreme.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 91);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 18;
            label9.Text = "Vreme";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(18, 15);
            label4.Name = "label4";
            label4.Size = new Size(494, 28);
            label4.TabIndex = 6;
            label4.Text = "Izaberite kupca i zaposlenog koji učestvuju u test vožnji";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSubmit);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(790, 807);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 67);
            panel3.TabIndex = 11;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Image = Properties.Resources.plus;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(3, 18);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(10, 0, 0, 0);
            btnSubmit.Size = new Size(226, 46);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Dodaj";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddTestVoznja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 886);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1056, 925);
            Name = "AddTestVoznja";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodavanje test vožnje";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblLeft.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tblProdavci.ResumeLayout(false);
            tblProdavci.PerformLayout();
            tblKupci.ResumeLayout(false);
            tblKupci.PerformLayout();
            tcKupci.ResumeLayout(false);
            tpFizickoLice.ResumeLayout(false);
            tpPravnoLice.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupOcena).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblLeft;
        private Panel panel2;
        private TableLayoutPanel tblProdavci;
        private Label label1;
        private ListView lvZaposleni;
        private TableLayoutPanel tblKupci;
        private Label label2;
        private TabControl tcKupci;
        private TabPage tpFizickoLice;
        private ListView lvFizickaLica;
        private TabPage tpPravnoLice;
        private ListView lvPravnaLica;
        private Button btnDodajKupca;
        private GroupBox groupBox1;
        private Label label4;
        private Panel panel3;
        private Button btnSubmit;
        private DateTimePicker timePickerVreme;
        private Label label9;
        private DateTimePicker dtpDatum;
        private Label label3;
        private Label label6;
        private RichTextBox rtbZakljucak;
        private Label label5;
        private NumericUpDown nupOcena;
    }
}