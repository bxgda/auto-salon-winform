namespace auto_salon.Presentation.FVozilo
{
    partial class AddVozilo
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
            tbxBrSasije = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbxModel = new TextBox();
            label3 = new Label();
            numKilometraza = new NumericUpDown();
            cbMarka = new ComboBox();
            label4 = new Label();
            numSnagaMotora = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            tbxBoja = new TextBox();
            numGodinaProizvodnje = new NumericUpDown();
            label7 = new Label();
            rbNovo = new RadioButton();
            rbPolovno = new RadioButton();
            dtpDatumRegistracije = new DateTimePicker();
            label8 = new Label();
            numBrojVlasnika = new NumericUpDown();
            label9 = new Label();
            cbTipGoriva = new ComboBox();
            label10 = new Label();
            btnSubmit = new Button();
            gbStanje = new GroupBox();
            label11 = new Label();
            cbBrojVrata = new ComboBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numKilometraza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSnagaMotora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGodinaProizvodnje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBrojVlasnika).BeginInit();
            gbStanje.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbxBrSasije
            // 
            tbxBrSasije.Location = new Point(17, 49);
            tbxBrSasije.MaxLength = 17;
            tbxBrSasije.Name = "tbxBrSasije";
            tbxBrSasije.Size = new Size(159, 23);
            tbxBrSasije.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Broj šasije*";
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
            // tbxModel
            // 
            tbxModel.Location = new Point(17, 166);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(159, 23);
            tbxModel.TabIndex = 2;
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
            // cbMarka
            // 
            cbMarka.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarka.FormattingEnabled = true;
            cbMarka.Location = new Point(17, 105);
            cbMarka.Name = "cbMarka";
            cbMarka.Size = new Size(159, 23);
            cbMarka.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 87);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Marka*";
            // 
            // numSnagaMotora
            // 
            numSnagaMotora.Location = new Point(17, 280);
            numSnagaMotora.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numSnagaMotora.Name = "numSnagaMotora";
            numSnagaMotora.Size = new Size(159, 23);
            numSnagaMotora.TabIndex = 4;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 87);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 14;
            label6.Text = "Boja*";
            // 
            // tbxBoja
            // 
            tbxBoja.Location = new Point(214, 105);
            tbxBoja.Name = "tbxBoja";
            tbxBoja.Size = new Size(159, 23);
            tbxBoja.TabIndex = 7;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 320);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 15;
            label7.Text = "Godina proizvodnje*";
            // 
            // rbNovo
            // 
            rbNovo.AutoSize = true;
            rbNovo.Location = new Point(17, 22);
            rbNovo.Name = "rbNovo";
            rbNovo.Size = new Size(54, 19);
            rbNovo.TabIndex = 1;
            rbNovo.TabStop = true;
            rbNovo.Text = "Novo";
            rbNovo.UseVisualStyleBackColor = true;
            rbNovo.CheckedChanged += rbNovo_CheckedChanged;
            // 
            // rbPolovno
            // 
            rbPolovno.AutoSize = true;
            rbPolovno.Location = new Point(77, 22);
            rbPolovno.Name = "rbPolovno";
            rbPolovno.Size = new Size(69, 19);
            rbPolovno.TabIndex = 1;
            rbPolovno.TabStop = true;
            rbPolovno.Text = "Polovno";
            rbPolovno.UseVisualStyleBackColor = true;
            rbPolovno.CheckedChanged += rbPolovno_CheckedChanged;
            // 
            // dtpDatumRegistracije
            // 
            dtpDatumRegistracije.Location = new Point(214, 223);
            dtpDatumRegistracije.Name = "dtpDatumRegistracije";
            dtpDatumRegistracije.Size = new Size(159, 23);
            dtpDatumRegistracije.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(214, 205);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 20;
            label8.Text = "Datum registracije";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(214, 31);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 24;
            label10.Text = "Tip goriva*";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Location = new Point(267, 483);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(145, 39);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Dodaj";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // gbStanje
            // 
            gbStanje.Controls.Add(rbNovo);
            gbStanje.Controls.Add(rbPolovno);
            gbStanje.Location = new Point(22, 12);
            gbStanje.Name = "gbStanje";
            gbStanje.Size = new Size(390, 51);
            gbStanje.TabIndex = 0;
            gbStanje.TabStop = false;
            gbStanje.Text = "Stanje vozila";
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
            // groupBox1
            // 
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
            groupBox1.Controls.Add(cbMarka);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpDatumRegistracije);
            groupBox1.Controls.Add(numSnagaMotora);
            groupBox1.Controls.Add(numGodinaProizvodnje);
            groupBox1.Controls.Add(tbxBoja);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(22, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 398);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o vozilu";
            // 
            // AddVozilo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 537);
            Controls.Add(groupBox1);
            Controls.Add(gbStanje);
            Controls.Add(btnSubmit);
            MaximizeBox = false;
            MaximumSize = new Size(450, 576);
            MinimizeBox = false;
            MinimumSize = new Size(450, 576);
            Name = "AddVozilo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodavanje vozila";
            Load += AddVozilo_Load;
            ((System.ComponentModel.ISupportInitialize)numKilometraza).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSnagaMotora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGodinaProizvodnje).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBrojVlasnika).EndInit();
            gbStanje.ResumeLayout(false);
            gbStanje.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbxBrSasije;
        private Label label1;
        private Label label2;
        private TextBox tbxModel;
        private Label label3;
        private NumericUpDown numKilometraza;
        private ComboBox cbMarka;
        private Label label4;
        private NumericUpDown numSnagaMotora;
        private Label label5;
        private Label label6;
        private TextBox tbxBoja;
        private NumericUpDown numGodinaProizvodnje;
        private Label label7;
        private RadioButton rbNovo;
        private RadioButton rbPolovno;
        private DateTimePicker dtpDatumRegistracije;
        private Label label8;
        private NumericUpDown numBrojVlasnika;
        private Label label9;
        private ComboBox cbTipGoriva;
        private Label label10;
        private Button btnSubmit;
        private GroupBox gbStanje;
        private Label label11;
        private ComboBox cbBrojVrata;
        private GroupBox groupBox1;
    }
}