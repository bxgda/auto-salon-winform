namespace auto_salon.Presentation.FUgovori
{
    partial class SklapanjeUgovora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SklapanjeUgovora));
            lvProdavci = new ListView();
            label1 = new Label();
            label4 = new Label();
            btnSubmit = new Button();
            tblMain = new TableLayoutPanel();
            tblLeft = new TableLayoutPanel();
            panel2 = new Panel();
            tblProdavci = new TableLayoutPanel();
            tblKupci = new TableLayoutPanel();
            label2 = new Label();
            tcKupci = new TabControl();
            tpFizickoLice = new TabPage();
            lvFizickaLica = new ListView();
            tpPravnoLice = new TabPage();
            lvPravnaLica = new ListView();
            btnDodajKupca = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            nupKonacnaOcena = new NumericUpDown();
            label6 = new Label();
            nupOcenaProdavca = new NumericUpDown();
            cbNacinPlacanja = new ComboBox();
            label5 = new Label();
            tbxDodatnaOprema = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            lblPopust = new Label();
            lblCena = new Label();
            label8 = new Label();
            panel3 = new Panel();
            lblKonacnaCena = new Label();
            tblMain.SuspendLayout();
            tblLeft.SuspendLayout();
            panel2.SuspendLayout();
            tblProdavci.SuspendLayout();
            tblKupci.SuspendLayout();
            tcKupci.SuspendLayout();
            tpFizickoLice.SuspendLayout();
            tpPravnoLice.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupKonacnaOcena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupOcenaProdavca).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lvProdavci
            // 
            lvProdavci.Dock = DockStyle.Fill;
            lvProdavci.FullRowSelect = true;
            lvProdavci.GridLines = true;
            lvProdavci.Location = new Point(3, 23);
            lvProdavci.Name = "lvProdavci";
            lvProdavci.Size = new Size(647, 303);
            lvProdavci.TabIndex = 0;
            lvProdavci.UseCompatibleStateImageBehavior = false;
            lvProdavci.View = View.Details;
            lvProdavci.SelectedIndexChanged += lvProdavci_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Prodavci salona";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(18, 15);
            label4.Name = "label4";
            label4.Size = new Size(241, 28);
            label4.TabIndex = 6;
            label4.Text = "Izaberite kupca i prodavca";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Image = Properties.Resources.check_circle;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(3, 29);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(10, 0, 0, 0);
            btnSubmit.Size = new Size(252, 46);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Kreiraj ugovor";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.64557F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.3544312F));
            tblMain.Controls.Add(tblLeft, 0, 1);
            tblMain.Controls.Add(groupBox1, 1, 1);
            tblMain.Controls.Add(label4, 0, 0);
            tblMain.Controls.Add(panel1, 0, 2);
            tblMain.Controls.Add(panel3, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(15);
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 703F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(959, 851);
            tblMain.TabIndex = 9;
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
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 51.93687F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 48.06313F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLeft.Size = new Size(659, 697);
            tblLeft.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(tblProdavci);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 329);
            panel2.TabIndex = 1;
            // 
            // tblProdavci
            // 
            tblProdavci.ColumnCount = 1;
            tblProdavci.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblProdavci.Controls.Add(label1, 0, 0);
            tblProdavci.Controls.Add(lvProdavci, 0, 1);
            tblProdavci.Dock = DockStyle.Fill;
            tblProdavci.Location = new Point(0, 0);
            tblProdavci.Name = "tblProdavci";
            tblProdavci.RowCount = 2;
            tblProdavci.RowStyles.Add(new RowStyle());
            tblProdavci.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblProdavci.RowStyles.Add(new RowStyle());
            tblProdavci.Size = new Size(653, 329);
            tblProdavci.TabIndex = 0;
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
            tblKupci.Size = new Size(653, 356);
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
            tcKupci.Size = new Size(647, 282);
            tcKupci.TabIndex = 8;
            tcKupci.SelectedIndexChanged += tcKupci_SelectedIndexChanged;
            // 
            // tpFizickoLice
            // 
            tpFizickoLice.Controls.Add(lvFizickaLica);
            tpFizickoLice.Location = new Point(4, 24);
            tpFizickoLice.Name = "tpFizickoLice";
            tpFizickoLice.Padding = new Padding(3);
            tpFizickoLice.Size = new Size(639, 254);
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
            lvFizickaLica.Size = new Size(633, 248);
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
            tpPravnoLice.Size = new Size(639, 254);
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
            lvPravnaLica.Size = new Size(633, 248);
            lvPravnaLica.TabIndex = 1;
            lvPravnaLica.UseCompatibleStateImageBehavior = false;
            lvPravnaLica.View = View.Details;
            lvPravnaLica.SelectedIndexChanged += lvPravnaLica_SelectedIndexChanged;
            // 
            // btnDodajKupca
            // 
            btnDodajKupca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDodajKupca.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajKupca.Location = new Point(494, 316);
            btnDodajKupca.Name = "btnDodajKupca";
            btnDodajKupca.Size = new Size(156, 37);
            btnDodajKupca.TabIndex = 6;
            btnDodajKupca.Text = "Dodaj kupca";
            btnDodajKupca.UseVisualStyleBackColor = true;
            btnDodajKupca.Click += btnDodajKupca_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(nupKonacnaOcena);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(nupOcenaProdavca);
            groupBox1.Controls.Add(cbNacinPlacanja);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbxDodatnaOprema);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(683, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 697);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o ugovoru";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 344);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 7;
            label7.Text = "Konačna ocena (1-10)";
            // 
            // nupKonacnaOcena
            // 
            nupKonacnaOcena.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nupKonacnaOcena.Location = new Point(17, 362);
            nupKonacnaOcena.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupKonacnaOcena.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupKonacnaOcena.Name = "nupKonacnaOcena";
            nupKonacnaOcena.Size = new Size(219, 23);
            nupKonacnaOcena.TabIndex = 6;
            nupKonacnaOcena.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 276);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 5;
            label6.Text = "Ocena prodavca (1-10)";
            // 
            // nupOcenaProdavca
            // 
            nupOcenaProdavca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nupOcenaProdavca.Location = new Point(17, 294);
            nupOcenaProdavca.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupOcenaProdavca.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupOcenaProdavca.Name = "nupOcenaProdavca";
            nupOcenaProdavca.Size = new Size(219, 23);
            nupOcenaProdavca.TabIndex = 4;
            nupOcenaProdavca.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbNacinPlacanja
            // 
            cbNacinPlacanja.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbNacinPlacanja.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNacinPlacanja.FormattingEnabled = true;
            cbNacinPlacanja.Location = new Point(17, 53);
            cbNacinPlacanja.Name = "cbNacinPlacanja";
            cbNacinPlacanja.Size = new Size(219, 23);
            cbNacinPlacanja.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 90);
            label5.Name = "label5";
            label5.Size = new Size(151, 15);
            label5.TabIndex = 2;
            label5.Text = "Dodatna oprema (opciono)";
            // 
            // tbxDodatnaOprema
            // 
            tbxDodatnaOprema.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxDodatnaOprema.Location = new Point(17, 108);
            tbxDodatnaOprema.Multiline = true;
            tbxDodatnaOprema.Name = "tbxDodatnaOprema";
            tbxDodatnaOprema.Size = new Size(219, 144);
            tbxDodatnaOprema.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 35);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 0;
            label3.Text = "Način plaćanja";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPopust);
            panel1.Controls.Add(lblCena);
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(18, 755);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 78);
            panel1.TabIndex = 10;
            // 
            // lblPopust
            // 
            lblPopust.AutoSize = true;
            lblPopust.Font = new Font("Segoe UI", 12.25F);
            lblPopust.Location = new Point(6, 43);
            lblPopust.Name = "lblPopust";
            lblPopust.Size = new Size(66, 23);
            lblPopust.TabIndex = 2;
            lblPopust.Text = "Popust:";
            // 
            // lblCena
            // 
            lblCena.AutoSize = true;
            lblCena.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCena.Location = new Point(71, 10);
            lblCena.Name = "lblCena";
            lblCena.Size = new Size(19, 25);
            lblCena.TabIndex = 1;
            lblCena.Text = "/";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 10);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 0;
            label8.Text = "Cena:";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblKonacnaCena);
            panel3.Controls.Add(btnSubmit);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(683, 755);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 78);
            panel3.TabIndex = 11;
            // 
            // lblKonacnaCena
            // 
            lblKonacnaCena.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblKonacnaCena.AutoSize = true;
            lblKonacnaCena.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKonacnaCena.Location = new Point(0, 1);
            lblKonacnaCena.Name = "lblKonacnaCena";
            lblKonacnaCena.Size = new Size(134, 25);
            lblKonacnaCena.TabIndex = 3;
            lblKonacnaCena.Text = "Konačna cena:";
            lblKonacnaCena.TextAlign = ContentAlignment.TopRight;
            // 
            // SklapanjeUgovora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 851);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(867, 890);
            Name = "SklapanjeUgovora";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sklapanje ugovora";
            Load += SklapanjeUgovora_Load;
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
            ((System.ComponentModel.ISupportInitialize)nupKonacnaOcena).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupOcenaProdavca).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvProdavci;
        private Label label1;
        private Label label4;
        private Button btnSubmit;
        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblLeft;
        private Panel panel2;
        private TableLayoutPanel tblProdavci;
        private GroupBox groupBox1;
        private TableLayoutPanel tblKupci;
        private Label label2;
        private Button btnDodajKupca;
        private TabControl tcKupci;
        private TabPage tpFizickoLice;
        private TabPage tpPravnoLice;
        private ListView lvFizickaLica;
        private ListView lvPravnaLica;
        private ComboBox cbNacinPlacanja;
        private Label label5;
        private TextBox tbxDodatnaOprema;
        private Label label3;
        private Label label6;
        private NumericUpDown nupOcenaProdavca;
        private Label label7;
        private NumericUpDown nupKonacnaOcena;
        private Panel panel1;
        private Label lblCena;
        private Label label8;
        private Label lblPopust;
        private Label lblKonacnaCena;
        private Panel panel3;
    }
}