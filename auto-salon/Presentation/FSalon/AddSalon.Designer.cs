namespace auto_salon.Presentation.FSalon
{
    partial class AddSalon
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
            txtDrzava = new TextBox();
            txtGrad = new TextBox();
            txtNaziv = new TextBox();
            txtAdresa = new TextBox();
            txtRadnoVreme = new TextBox();
            txtKontaktTelefon = new TextBox();
            cbxTip = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtDrzava
            // 
            txtDrzava.Location = new Point(82, 34);
            txtDrzava.Name = "txtDrzava";
            txtDrzava.Size = new Size(170, 23);
            txtDrzava.TabIndex = 0;
            // 
            // txtGrad
            // 
            txtGrad.Location = new Point(82, 98);
            txtGrad.Name = "txtGrad";
            txtGrad.Size = new Size(170, 23);
            txtGrad.TabIndex = 1;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(82, 194);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(170, 23);
            txtNaziv.TabIndex = 2;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(82, 147);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(170, 23);
            txtAdresa.TabIndex = 3;
            // 
            // txtRadnoVreme
            // 
            txtRadnoVreme.Location = new Point(82, 247);
            txtRadnoVreme.Name = "txtRadnoVreme";
            txtRadnoVreme.Size = new Size(170, 23);
            txtRadnoVreme.TabIndex = 4;
            // 
            // txtKontaktTelefon
            // 
            txtKontaktTelefon.Location = new Point(82, 304);
            txtKontaktTelefon.Name = "txtKontaktTelefon";
            txtKontaktTelefon.Size = new Size(170, 23);
            txtKontaktTelefon.TabIndex = 5;
            // 
            // cbxTip
            // 
            cbxTip.FormattingEnabled = true;
            cbxTip.Items.AddRange(new object[] { "Nova", "Polovna", "Kombinovan" });
            cbxTip.Location = new Point(309, 54);
            cbxTip.Name = "cbxTip";
            cbxTip.Size = new Size(121, 23);
            cbxTip.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 16);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Država";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 80);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "Grad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 129);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "Adresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 176);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Naziv";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 229);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 11;
            label5.Text = "Radno vreme";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 286);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 12;
            label6.Text = "Kontakt telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 34);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 13;
            label7.Text = "Tip";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(354, 353);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(121, 39);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Kreiraj";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddSalon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 404);
            Controls.Add(btnSubmit);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxTip);
            Controls.Add(txtKontaktTelefon);
            Controls.Add(txtRadnoVreme);
            Controls.Add(txtAdresa);
            Controls.Add(txtNaziv);
            Controls.Add(txtGrad);
            Controls.Add(txtDrzava);
            Name = "AddSalon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kreiranje novog salona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDrzava;
        private TextBox txtGrad;
        private TextBox txtNaziv;
        private TextBox txtAdresa;
        private TextBox txtRadnoVreme;
        private TextBox txtKontaktTelefon;
        private ComboBox cbxTip;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSubmit;
    }
}