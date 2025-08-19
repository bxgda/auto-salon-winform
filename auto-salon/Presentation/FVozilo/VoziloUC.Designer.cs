namespace auto_salon.Presentation.FVozilo
{
    partial class VoziloUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnTestVoznja = new Button();
            btnEdit = new Button();
            btnProdaj = new Button();
            btnServisnaIstorija = new Button();
            btnDelete = new Button();
            lvVozila = new ListView();
            panel2 = new Panel();
            label1 = new Label();
            cbFilter = new ComboBox();
            groupBox1 = new GroupBox();
            lblJeProdato = new Label();
            lblBrZaposlenih = new Label();
            lblKontaktTelefon = new Label();
            lblRadnoVreme = new Label();
            lblGrad = new Label();
            lblDrzava = new Label();
            lblNaziv = new Label();
            lblID = new Label();
            lbl8 = new Label();
            lbl7 = new Label();
            lbl6 = new Label();
            lbl2 = new Label();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 295F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(lvVozila, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 657F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1164, 783);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTestVoznja);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnProdaj);
            panel1.Controls.Add(btnServisnaIstorija);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 694);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 86);
            panel1.TabIndex = 1;
            // 
            // btnTestVoznja
            // 
            btnTestVoznja.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTestVoznja.BackColor = Color.FromArgb(255, 192, 255);
            btnTestVoznja.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTestVoznja.Image = Properties.Resources.steering_wheel;
            btnTestVoznja.ImageAlign = ContentAlignment.MiddleLeft;
            btnTestVoznja.Location = new Point(573, 46);
            btnTestVoznja.Name = "btnTestVoznja";
            btnTestVoznja.Padding = new Padding(10, 0, 0, 0);
            btnTestVoznja.Size = new Size(169, 37);
            btnTestVoznja.TabIndex = 7;
            btnTestVoznja.Text = "Dodaj test vožnju";
            btnTestVoznja.UseVisualStyleBackColor = false;
            btnTestVoznja.Click += btnTestVoznja_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.BackColor = Color.Khaki;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.pencil;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(124, 46);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(115, 37);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnProdaj
            // 
            btnProdaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProdaj.BackColor = Color.LightSkyBlue;
            btnProdaj.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdaj.Image = Properties.Resources.shopping_cart;
            btnProdaj.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdaj.Location = new Point(748, 46);
            btnProdaj.Name = "btnProdaj";
            btnProdaj.Padding = new Padding(10, 0, 0, 0);
            btnProdaj.Size = new Size(112, 37);
            btnProdaj.TabIndex = 5;
            btnProdaj.Text = "Prodaj";
            btnProdaj.UseVisualStyleBackColor = false;
            btnProdaj.Click += btnProdaj_Click;
            // 
            // btnServisnaIstorija
            // 
            btnServisnaIstorija.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnServisnaIstorija.BackColor = Color.SandyBrown;
            btnServisnaIstorija.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServisnaIstorija.Image = Properties.Resources.service;
            btnServisnaIstorija.ImageAlign = ContentAlignment.MiddleLeft;
            btnServisnaIstorija.Location = new Point(245, 46);
            btnServisnaIstorija.Name = "btnServisnaIstorija";
            btnServisnaIstorija.Padding = new Padding(10, 0, 0, 0);
            btnServisnaIstorija.Size = new Size(165, 37);
            btnServisnaIstorija.TabIndex = 4;
            btnServisnaIstorija.Text = "Servisna istorija";
            btnServisnaIstorija.UseVisualStyleBackColor = false;
            btnServisnaIstorija.Click += btnServisnaIstorija_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.trash;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(3, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(115, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvVozila
            // 
            lvVozila.Dock = DockStyle.Fill;
            lvVozila.FullRowSelect = true;
            lvVozila.GridLines = true;
            lvVozila.Location = new Point(3, 37);
            lvVozila.Name = "lvVozila";
            lvVozila.Size = new Size(863, 651);
            lvVozila.TabIndex = 2;
            lvVozila.UseCompatibleStateImageBehavior = false;
            lvVozila.View = View.Details;
            lvVozila.SelectedIndexChanged += lvVozila_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cbFilter);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 28);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Filter:";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Sve", "Dostupno", "Prodato" });
            cbFilter.Location = new Point(45, 2);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 0;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblJeProdato);
            groupBox1.Controls.Add(lblBrZaposlenih);
            groupBox1.Controls.Add(lblKontaktTelefon);
            groupBox1.Controls.Add(lblRadnoVreme);
            groupBox1.Controls.Add(lblGrad);
            groupBox1.Controls.Add(lblDrzava);
            groupBox1.Controls.Add(lblNaziv);
            groupBox1.Controls.Add(lblID);
            groupBox1.Controls.Add(lbl8);
            groupBox1.Controls.Add(lbl7);
            groupBox1.Controls.Add(lbl6);
            groupBox1.Controls.Add(lbl2);
            groupBox1.Controls.Add(lbl5);
            groupBox1.Controls.Add(lbl4);
            groupBox1.Controls.Add(lbl1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(872, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 651);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "# Salon u kome se vozilo nalazi:";
            // 
            // lblJeProdato
            // 
            lblJeProdato.AutoSize = true;
            lblJeProdato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJeProdato.Location = new Point(6, 352);
            lblJeProdato.Name = "lblJeProdato";
            lblJeProdato.Size = new Size(0, 15);
            lblJeProdato.TabIndex = 30;
            // 
            // lblBrZaposlenih
            // 
            lblBrZaposlenih.AutoSize = true;
            lblBrZaposlenih.Location = new Point(108, 307);
            lblBrZaposlenih.Name = "lblBrZaposlenih";
            lblBrZaposlenih.Size = new Size(12, 15);
            lblBrZaposlenih.TabIndex = 29;
            lblBrZaposlenih.Text = "/";
            // 
            // lblKontaktTelefon
            // 
            lblKontaktTelefon.AutoSize = true;
            lblKontaktTelefon.Location = new Point(108, 257);
            lblKontaktTelefon.Name = "lblKontaktTelefon";
            lblKontaktTelefon.Size = new Size(12, 15);
            lblKontaktTelefon.TabIndex = 28;
            lblKontaktTelefon.Text = "/";
            // 
            // lblRadnoVreme
            // 
            lblRadnoVreme.AutoSize = true;
            lblRadnoVreme.Location = new Point(108, 209);
            lblRadnoVreme.Name = "lblRadnoVreme";
            lblRadnoVreme.Size = new Size(12, 15);
            lblRadnoVreme.TabIndex = 27;
            lblRadnoVreme.Text = "/";
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(108, 163);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(12, 15);
            lblGrad.TabIndex = 26;
            lblGrad.Text = "/";
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(108, 120);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(12, 15);
            lblDrzava.TabIndex = 25;
            lblDrzava.Text = "/";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(108, 77);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(12, 15);
            lblNaziv.TabIndex = 24;
            lblNaziv.Text = "/";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(108, 39);
            lblID.Name = "lblID";
            lblID.Size = new Size(12, 15);
            lblID.TabIndex = 23;
            lblID.Text = "/";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Location = new Point(6, 307);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(90, 15);
            lbl8.TabIndex = 22;
            lbl8.Text = "Broj zaposlenih:";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Location = new Point(6, 257);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(91, 15);
            lbl7.TabIndex = 21;
            lbl7.Text = "Kontakt telefon:";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(6, 209);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(80, 15);
            lbl6.TabIndex = 20;
            lbl6.Text = "Radno vreme:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(6, 77);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(39, 15);
            lbl2.TabIndex = 19;
            lbl2.Text = "Naziv:";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(6, 163);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(35, 15);
            lbl5.TabIndex = 18;
            lbl5.Text = "Grad:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(6, 120);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(45, 15);
            lbl4.TabIndex = 17;
            lbl4.Text = "Drzava:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(6, 39);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(21, 15);
            lbl1.TabIndex = 16;
            lbl1.Text = "ID:";
            // 
            // VoziloUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "VoziloUC";
            Size = new Size(1164, 783);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnDelete;
        private ListView lvVozila;
        private Button btnServisnaIstorija;
        private Panel panel2;
        private Label label1;
        private ComboBox cbFilter;
        private Button btnProdaj;
        private Button btnEdit;
        private Button btnTestVoznja;
        private GroupBox groupBox1;
        private Label lblBrZaposlenih;
        private Label lblKontaktTelefon;
        private Label lblRadnoVreme;
        private Label lblGrad;
        private Label lblDrzava;
        private Label lblNaziv;
        private Label lblID;
        private Label lbl8;
        private Label lbl7;
        private Label lbl6;
        private Label lbl2;
        private Label lbl5;
        private Label lbl4;
        private Label lbl1;
        private Label lblJeProdato;
    }
}
