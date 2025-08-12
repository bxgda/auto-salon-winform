namespace auto_salon.Presentation.FVozilo
{
    partial class EditVozilo
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
            groupBox1 = new GroupBox();
            cbSaloni = new ComboBox();
            label12 = new Label();
            tbxMarka = new TextBox();
            cbTipGoriva = new ComboBox();
            cbBrojVrata = new ComboBox();
            tbxBrSasije = new TextBox();
            label11 = new Label();
            label1 = new Label();
            tbxModel = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label3 = new Label();
            numKilometraza = new NumericUpDown();
            numBrojVlasnika = new NumericUpDown();
            label9 = new Label();
            label4 = new Label();
            lblDatumRegistracije = new Label();
            label5 = new Label();
            dtpDatumRegistracije = new DateTimePicker();
            numSnagaMotora = new NumericUpDown();
            numGodinaProizvodnje = new NumericUpDown();
            tbxBoja = new TextBox();
            label7 = new Label();
            label6 = new Label();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKilometraza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBrojVlasnika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSnagaMotora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGodinaProizvodnje).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbSaloni);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(tbxMarka);
            groupBox1.Controls.Add(cbTipGoriva);
            groupBox1.Controls.Add(cbBrojVrata);
            groupBox1.Controls.Add(tbxBrSasije);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbxModel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numKilometraza);
            groupBox1.Controls.Add(numBrojVlasnika);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblDatumRegistracije);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpDatumRegistracije);
            groupBox1.Controls.Add(numSnagaMotora);
            groupBox1.Controls.Add(numGodinaProizvodnje);
            groupBox1.Controls.Add(tbxBoja);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 398);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o vozilu";
            // 
            // cbSaloni
            // 
            cbSaloni.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSaloni.FormattingEnabled = true;
            cbSaloni.Items.AddRange(new object[] { "2", "3", "4", "5" });
            cbSaloni.Location = new Point(214, 338);
            cbSaloni.Name = "cbSaloni";
            cbSaloni.Size = new Size(159, 23);
            cbSaloni.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(214, 320);
            label12.Name = "label12";
            label12.Size = new Size(126, 15);
            label12.TabIndex = 30;
            label12.Text = "Salon u kome se nalazi";
            // 
            // tbxMarka
            // 
            tbxMarka.Enabled = false;
            tbxMarka.Location = new Point(18, 105);
            tbxMarka.MaxLength = 17;
            tbxMarka.Name = "tbxMarka";
            tbxMarka.Size = new Size(159, 23);
            tbxMarka.TabIndex = 28;
            // 
            // cbTipGoriva
            // 
            cbTipGoriva.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipGoriva.FormattingEnabled = true;
            cbTipGoriva.Items.AddRange(new object[] { "Dizel", "Benzin", "Struja", "Hidrogen", "Plin", "Metan", "Hibrid" });
            cbTipGoriva.Location = new Point(214, 49);
            cbTipGoriva.Name = "cbTipGoriva";
            cbTipGoriva.Size = new Size(159, 23);
            cbTipGoriva.TabIndex = 6;
            // 
            // cbBrojVrata
            // 
            cbBrojVrata.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrojVrata.FormattingEnabled = true;
            cbBrojVrata.Items.AddRange(new object[] { "2", "3", "4", "5" });
            cbBrojVrata.Location = new Point(214, 166);
            cbBrojVrata.Name = "cbBrojVrata";
            cbBrojVrata.Size = new Size(159, 23);
            cbBrojVrata.TabIndex = 8;
            // 
            // tbxBrSasije
            // 
            tbxBrSasije.Enabled = false;
            tbxBrSasije.Location = new Point(17, 49);
            tbxBrSasije.MaxLength = 17;
            tbxBrSasije.Name = "tbxBrSasije";
            tbxBrSasije.Size = new Size(159, 23);
            tbxBrSasije.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(214, 149);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 27;
            label11.Text = "Broj vrata*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Broj šasije*";
            // 
            // tbxModel
            // 
            tbxModel.Location = new Point(17, 166);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(159, 23);
            tbxModel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 148);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Model*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(214, 31);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 24;
            label10.Text = "Tip goriva*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 205);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 7;
            label3.Text = "Kilometraža*";
            // 
            // numKilometraza
            // 
            numKilometraza.Location = new Point(17, 223);
            numKilometraza.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numKilometraza.Name = "numKilometraza";
            numKilometraza.Size = new Size(159, 23);
            numKilometraza.TabIndex = 3;
            // 
            // numBrojVlasnika
            // 
            numBrojVlasnika.Location = new Point(214, 280);
            numBrojVlasnika.Name = "numBrojVlasnika";
            numBrojVlasnika.Size = new Size(159, 23);
            numBrojVlasnika.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(214, 262);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 21;
            label9.Text = "Broj vlasnika";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(17, 87);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Marka*";
            // 
            // lblDatumRegistracije
            // 
            lblDatumRegistracije.AutoSize = true;
            lblDatumRegistracije.Location = new Point(214, 205);
            lblDatumRegistracije.Name = "lblDatumRegistracije";
            lblDatumRegistracije.Size = new Size(103, 15);
            lblDatumRegistracije.TabIndex = 20;
            lblDatumRegistracije.Text = "Datum registracije";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 262);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 11;
            label5.Text = "Snaga motora*";
            // 
            // dtpDatumRegistracije
            // 
            dtpDatumRegistracije.Location = new Point(214, 223);
            dtpDatumRegistracije.Name = "dtpDatumRegistracije";
            dtpDatumRegistracije.Size = new Size(159, 23);
            dtpDatumRegistracije.TabIndex = 9;
            // 
            // numSnagaMotora
            // 
            numSnagaMotora.Location = new Point(17, 280);
            numSnagaMotora.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numSnagaMotora.Name = "numSnagaMotora";
            numSnagaMotora.Size = new Size(159, 23);
            numSnagaMotora.TabIndex = 4;
            // 
            // numGodinaProizvodnje
            // 
            numGodinaProizvodnje.Location = new Point(17, 338);
            numGodinaProizvodnje.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numGodinaProizvodnje.Minimum = new decimal(new int[] { 1887, 0, 0, 0 });
            numGodinaProizvodnje.Name = "numGodinaProizvodnje";
            numGodinaProizvodnje.Size = new Size(159, 23);
            numGodinaProizvodnje.TabIndex = 5;
            numGodinaProizvodnje.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // tbxBoja
            // 
            tbxBoja.Location = new Point(214, 105);
            tbxBoja.Name = "tbxBoja";
            tbxBoja.Size = new Size(159, 23);
            tbxBoja.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 320);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 15;
            label7.Text = "Godina proizvodnje*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 87);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 14;
            label6.Text = "Boja*";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Image = Properties.Resources.pencil;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(257, 443);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(10, 0, 0, 0);
            btnSubmit.Size = new Size(145, 39);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Izmeni";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // EditVozilo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 497);
            Controls.Add(groupBox1);
            Controls.Add(btnSubmit);
            MaximizeBox = false;
            MaximumSize = new Size(435, 536);
            MinimizeBox = false;
            MinimumSize = new Size(435, 536);
            Name = "EditVozilo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditVozilo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numKilometraza).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBrojVlasnika).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSnagaMotora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGodinaProizvodnje).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbTipGoriva;
        private ComboBox cbBrojVrata;
        private TextBox tbxBrSasije;
        private Label label11;
        private Label label1;
        private TextBox tbxModel;
        private Label label2;
        private Label label10;
        private Label label3;
        private NumericUpDown numKilometraza;
        private NumericUpDown numBrojVlasnika;
        private Label label9;
        private Label label4;
        private Label lblDatumRegistracije;
        private Label label5;
        private DateTimePicker dtpDatumRegistracije;
        private NumericUpDown numSnagaMotora;
        private NumericUpDown numGodinaProizvodnje;
        private TextBox tbxBoja;
        private Label label7;
        private Label label6;
        private Button btnSubmit;
        private TextBox tbxMarka;
        private ComboBox cbSaloni;
        private Label label12;
    }
}