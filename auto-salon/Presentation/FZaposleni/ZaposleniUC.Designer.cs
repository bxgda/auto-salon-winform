namespace auto_salon.Presentation.FZaposleni
{
    partial class ZaposleniUC
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
            btnOceni = new Button();
            btnEdit = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            lvZaposleni = new ListView();
            groupBox1 = new GroupBox();
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
            panel2 = new Panel();
            label1 = new Label();
            cbFilter = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblStatus = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8597641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1028, 833);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOceni);
            panel1.Controls.Add(btnEdit);
            panel1.Location = new Point(3, 767);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 63);
            panel1.TabIndex = 4;
            // 
            // btnOceni
            // 
            btnOceni.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOceni.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOceni.Image = Properties.Resources.star;
            btnOceni.ImageAlign = ContentAlignment.MiddleLeft;
            btnOceni.Location = new Point(114, 23);
            btnOceni.Name = "btnOceni";
            btnOceni.Padding = new Padding(10, 0, 0, 0);
            btnOceni.Size = new Size(105, 37);
            btnOceni.TabIndex = 8;
            btnOceni.Text = "Oceni";
            btnOceni.UseVisualStyleBackColor = true;
            btnOceni.Click += btnOceni_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.pencil;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(3, 23);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(105, 37);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.22361F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.7763863F));
            tableLayoutPanel2.Controls.Add(lvZaposleni, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 44);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1022, 717);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // lvZaposleni
            // 
            lvZaposleni.Dock = DockStyle.Fill;
            lvZaposleni.FullRowSelect = true;
            lvZaposleni.GridLines = true;
            lvZaposleni.Location = new Point(3, 3);
            lvZaposleni.Name = "lvZaposleni";
            lvZaposleni.Size = new Size(762, 711);
            lvZaposleni.TabIndex = 3;
            lvZaposleni.UseCompatibleStateImageBehavior = false;
            lvZaposleni.View = View.Details;
            lvZaposleni.SelectedIndexChanged += lvZaposleni_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblStatus);
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
            groupBox1.Location = new Point(771, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 711);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "# Salon u kome radi";
            // 
            // lblBrZaposlenih
            // 
            lblBrZaposlenih.AutoSize = true;
            lblBrZaposlenih.Location = new Point(108, 311);
            lblBrZaposlenih.Name = "lblBrZaposlenih";
            lblBrZaposlenih.Size = new Size(12, 15);
            lblBrZaposlenih.TabIndex = 15;
            lblBrZaposlenih.Text = "/";
            // 
            // lblKontaktTelefon
            // 
            lblKontaktTelefon.AutoSize = true;
            lblKontaktTelefon.Location = new Point(108, 261);
            lblKontaktTelefon.Name = "lblKontaktTelefon";
            lblKontaktTelefon.Size = new Size(12, 15);
            lblKontaktTelefon.TabIndex = 14;
            lblKontaktTelefon.Text = "/";
            // 
            // lblRadnoVreme
            // 
            lblRadnoVreme.AutoSize = true;
            lblRadnoVreme.Location = new Point(108, 213);
            lblRadnoVreme.Name = "lblRadnoVreme";
            lblRadnoVreme.Size = new Size(12, 15);
            lblRadnoVreme.TabIndex = 13;
            lblRadnoVreme.Text = "/";
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(108, 167);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(12, 15);
            lblGrad.TabIndex = 12;
            lblGrad.Text = "/";
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(108, 124);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(12, 15);
            lblDrzava.TabIndex = 11;
            lblDrzava.Text = "/";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(108, 81);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(12, 15);
            lblNaziv.TabIndex = 9;
            lblNaziv.Text = "/";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(108, 43);
            lblID.Name = "lblID";
            lblID.Size = new Size(12, 15);
            lblID.TabIndex = 8;
            lblID.Text = "/";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Location = new Point(6, 311);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(90, 15);
            lbl8.TabIndex = 7;
            lbl8.Text = "Broj zaposlenih:";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Location = new Point(6, 261);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(91, 15);
            lbl7.TabIndex = 6;
            lbl7.Text = "Kontakt telefon:";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(6, 213);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(80, 15);
            lbl6.TabIndex = 5;
            lbl6.Text = "Radno vreme:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(6, 81);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(39, 15);
            lbl2.TabIndex = 4;
            lbl2.Text = "Naziv:";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(6, 167);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(35, 15);
            lbl5.TabIndex = 3;
            lbl5.Text = "Grad:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(6, 124);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(45, 15);
            lbl4.TabIndex = 2;
            lbl4.Text = "Drzava:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(6, 43);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(21, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cbFilter);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1022, 35);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 12);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Uloga:";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Sve", "Menadžer", "Finansijski savetnik", "Prodavac", "Serviser" });
            cbFilter.Location = new Point(46, 9);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(146, 23);
            cbFilter.TabIndex = 2;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(6, 360);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 16;
            // 
            // ZaposleniUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ZaposleniUC";
            Size = new Size(1028, 833);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private ListView lvZaposleni;
        private Panel panel1;
        private Button btnEdit;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private Label lbl1;
        private Label lbl8;
        private Label lbl7;
        private Label lbl6;
        private Label lbl2;
        private Label lbl5;
        private Label lbl4;
        private Label lblID;
        private Label lblBrZaposlenih;
        private Label lblKontaktTelefon;
        private Label lblRadnoVreme;
        private Label lblGrad;
        private Label lblDrzava;
        private Label lblNaziv;
        private Button btnOceni;
        private Panel panel2;
        private Label label1;
        private ComboBox cbFilter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblStatus;
    }
}
