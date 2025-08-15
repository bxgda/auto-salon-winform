namespace auto_salon.Presentation.FZaposleni
{
    partial class EditZaposleni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditZaposleni));
            btnSubmit = new Button();
            groupBox2 = new GroupBox();
            label10 = new Label();
            cbxStatus = new ComboBox();
            label9 = new Label();
            cbxUloga = new ComboBox();
            label8 = new Label();
            dtpDatumZaposlenja = new DateTimePicker();
            tbxPozicija = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            tbxAdresa = new TextBox();
            label6 = new Label();
            tbxEmail = new TextBox();
            label5 = new Label();
            tbxKontaktTelefon = new TextBox();
            label4 = new Label();
            tbxJmbg = new TextBox();
            label3 = new Label();
            tbxPrezime = new TextBox();
            label2 = new Label();
            tbxIme = new TextBox();
            label1 = new Label();
            cbSaloni = new ComboBox();
            label12 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Image = Properties.Resources.pencil;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(283, 384);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(10, 0, 0, 0);
            btnSubmit.Size = new Size(145, 39);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Izmeni";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbSaloni);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cbxStatus);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cbxUloga);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dtpDatumZaposlenja);
            groupBox2.Controls.Add(tbxPozicija);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(233, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 352);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci o poziciji";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 32);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 20;
            label10.Text = "Status zaposlenja";
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Items.AddRange(new object[] { "Aktivan", "Neaktivan", "Na odmoru", "Na bolovanju" });
            cbxStatus.Location = new Point(18, 50);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(159, 23);
            cbxStatus.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 83);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 18;
            label9.Text = "Uloga *";
            // 
            // cbxUloga
            // 
            cbxUloga.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUloga.FormattingEnabled = true;
            cbxUloga.Items.AddRange(new object[] { "Menadžer", "Finansijski savetnik", "Serviser", "Prodavac" });
            cbxUloga.Location = new Point(18, 101);
            cbxUloga.Name = "cbxUloga";
            cbxUloga.Size = new Size(159, 23);
            cbxUloga.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 186);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 15;
            label8.Text = "Datum zaposlenja *";
            // 
            // dtpDatumZaposlenja
            // 
            dtpDatumZaposlenja.Enabled = false;
            dtpDatumZaposlenja.Format = DateTimePickerFormat.Short;
            dtpDatumZaposlenja.Location = new Point(18, 204);
            dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            dtpDatumZaposlenja.Size = new Size(159, 23);
            dtpDatumZaposlenja.TabIndex = 14;
            // 
            // tbxPozicija
            // 
            tbxPozicija.Location = new Point(18, 151);
            tbxPozicija.Name = "tbxPozicija";
            tbxPozicija.Size = new Size(159, 23);
            tbxPozicija.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 133);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 12;
            label7.Text = "Pozicija *";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbxAdresa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbxEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbxKontaktTelefon);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbxJmbg);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbxPrezime);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbxIme);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 352);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci";
            // 
            // tbxAdresa
            // 
            tbxAdresa.Location = new Point(20, 310);
            tbxAdresa.Name = "tbxAdresa";
            tbxAdresa.Size = new Size(159, 23);
            tbxAdresa.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 292);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 10;
            label6.Text = "Adresa";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(20, 258);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(159, 23);
            tbxEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 240);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "E-mail";
            // 
            // tbxKontaktTelefon
            // 
            tbxKontaktTelefon.Location = new Point(20, 207);
            tbxKontaktTelefon.Name = "tbxKontaktTelefon";
            tbxKontaktTelefon.Size = new Size(159, 23);
            tbxKontaktTelefon.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 189);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 6;
            label4.Text = "Kontakt telefon *";
            // 
            // tbxJmbg
            // 
            tbxJmbg.Enabled = false;
            tbxJmbg.Location = new Point(20, 153);
            tbxJmbg.MaxLength = 13;
            tbxJmbg.Name = "tbxJmbg";
            tbxJmbg.Size = new Size(159, 23);
            tbxJmbg.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 135);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "JMBG *";
            // 
            // tbxPrezime
            // 
            tbxPrezime.Location = new Point(20, 100);
            tbxPrezime.Name = "tbxPrezime";
            tbxPrezime.Size = new Size(159, 23);
            tbxPrezime.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 82);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Prezime *";
            // 
            // tbxIme
            // 
            tbxIme.Location = new Point(20, 50);
            tbxIme.Name = "tbxIme";
            tbxIme.Size = new Size(159, 23);
            tbxIme.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Ime *";
            // 
            // cbSaloni
            // 
            cbSaloni.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSaloni.FormattingEnabled = true;
            cbSaloni.Items.AddRange(new object[] { "2", "3", "4", "5" });
            cbSaloni.Location = new Point(18, 258);
            cbSaloni.Name = "cbSaloni";
            cbSaloni.Size = new Size(159, 23);
            cbSaloni.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 240);
            label12.Name = "label12";
            label12.Size = new Size(105, 15);
            label12.TabIndex = 32;
            label12.Text = "Salon u kome radi:";
            // 
            // EditZaposleni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(442, 438);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(458, 477);
            MinimizeBox = false;
            MinimumSize = new Size(458, 477);
            Name = "EditZaposleni";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditZaposleni";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubmit;
        private GroupBox groupBox2;
        private Label label9;
        private ComboBox cbxUloga;
        private Label label8;
        private DateTimePicker dtpDatumZaposlenja;
        private TextBox tbxPozicija;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox tbxAdresa;
        private Label label6;
        private TextBox tbxEmail;
        private Label label5;
        private TextBox tbxKontaktTelefon;
        private Label label4;
        private TextBox tbxJmbg;
        private Label label3;
        private TextBox tbxPrezime;
        private Label label2;
        private TextBox tbxIme;
        private Label label1;
        private ComboBox cbxStatus;
        private Label label10;
        private ComboBox cbSaloni;
        private Label label12;
    }
}