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
            numBrVrata = new NumericUpDown();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)numKilometraza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSnagaMotora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGodinaProizvodnje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBrojVlasnika).BeginInit();
            gbStanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBrVrata).BeginInit();
            SuspendLayout();
            // 
            // tbxBrSasije
            // 
            tbxBrSasije.Location = new Point(34, 93);
            tbxBrSasije.MaxLength = 17;
            tbxBrSasije.Name = "tbxBrSasije";
            tbxBrSasije.Size = new Size(159, 23);
            tbxBrSasije.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 75);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Broj šasije";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 192);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Model";
            // 
            // tbxModel
            // 
            tbxModel.Location = new Point(34, 210);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(159, 23);
            tbxModel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 249);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 7;
            label3.Text = "Kilometraža";
            // 
            // numKilometraza
            // 
            numKilometraza.Location = new Point(34, 267);
            numKilometraza.Name = "numKilometraza";
            numKilometraza.Size = new Size(159, 23);
            numKilometraza.TabIndex = 8;
            // 
            // cbMarka
            // 
            cbMarka.FormattingEnabled = true;
            cbMarka.Location = new Point(35, 149);
            cbMarka.Name = "cbMarka";
            cbMarka.Size = new Size(159, 23);
            cbMarka.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 131);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 10;
            label4.Text = "Marka";
            // 
            // numSnagaMotora
            // 
            numSnagaMotora.Location = new Point(34, 324);
            numSnagaMotora.Name = "numSnagaMotora";
            numSnagaMotora.Size = new Size(159, 23);
            numSnagaMotora.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 306);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 11;
            label5.Text = "Snaga motora";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 131);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 14;
            label6.Text = "Boja";
            // 
            // tbxBoja
            // 
            tbxBoja.Location = new Point(255, 149);
            tbxBoja.Name = "tbxBoja";
            tbxBoja.Size = new Size(159, 23);
            tbxBoja.TabIndex = 13;
            // 
            // numGodinaProizvodnje
            // 
            numGodinaProizvodnje.Location = new Point(34, 382);
            numGodinaProizvodnje.Name = "numGodinaProizvodnje";
            numGodinaProizvodnje.Size = new Size(159, 23);
            numGodinaProizvodnje.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 364);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 15;
            label7.Text = "Godina proizvodnje";
            // 
            // rbNovo
            // 
            rbNovo.AutoSize = true;
            rbNovo.Location = new Point(17, 22);
            rbNovo.Name = "rbNovo";
            rbNovo.Size = new Size(54, 19);
            rbNovo.TabIndex = 17;
            rbNovo.TabStop = true;
            rbNovo.Text = "Novo";
            rbNovo.UseVisualStyleBackColor = true;
            rbNovo.CheckedChanged += rbNovo_CheckedChanged;
            // 
            // rbPolovno
            // 
            rbPolovno.AutoSize = true;
            rbPolovno.Location = new Point(17, 47);
            rbPolovno.Name = "rbPolovno";
            rbPolovno.Size = new Size(69, 19);
            rbPolovno.TabIndex = 18;
            rbPolovno.TabStop = true;
            rbPolovno.Text = "Polovno";
            rbPolovno.UseVisualStyleBackColor = true;
            rbPolovno.CheckedChanged += rbPolovno_CheckedChanged;
            // 
            // dtpDatumRegistracije
            // 
            dtpDatumRegistracije.Location = new Point(255, 267);
            dtpDatumRegistracije.Name = "dtpDatumRegistracije";
            dtpDatumRegistracije.Size = new Size(159, 23);
            dtpDatumRegistracije.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(255, 249);
            label8.Name = "label8";
            label8.Size = new Size(103, 15);
            label8.TabIndex = 20;
            label8.Text = "Datum registracije";
            // 
            // numBrojVlasnika
            // 
            numBrojVlasnika.Location = new Point(255, 324);
            numBrojVlasnika.Name = "numBrojVlasnika";
            numBrojVlasnika.Size = new Size(159, 23);
            numBrojVlasnika.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 306);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 21;
            label9.Text = "Broj vlasnika";
            // 
            // cbTipGoriva
            // 
            cbTipGoriva.FormattingEnabled = true;
            cbTipGoriva.Items.AddRange(new object[] { "Dizel", "Benzin", "Struja", "Hidrogen", "Plin", "Metan", "Hibrid" });
            cbTipGoriva.Location = new Point(255, 93);
            cbTipGoriva.Name = "cbTipGoriva";
            cbTipGoriva.Size = new Size(159, 23);
            cbTipGoriva.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(255, 75);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 24;
            label10.Text = "Tip goriva";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Location = new Point(287, 384);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(145, 39);
            btnSubmit.TabIndex = 25;
            btnSubmit.Text = "Dodaj";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // gbStanje
            // 
            gbStanje.Controls.Add(rbNovo);
            gbStanje.Controls.Add(rbPolovno);
            gbStanje.Location = new Point(114, 3);
            gbStanje.Name = "gbStanje";
            gbStanje.Size = new Size(135, 75);
            gbStanje.TabIndex = 26;
            gbStanje.TabStop = false;
            gbStanje.Text = "Stanje vozila";
            // 
            // numBrVrata
            // 
            numBrVrata.Location = new Point(255, 211);
            numBrVrata.Name = "numBrVrata";
            numBrVrata.Size = new Size(159, 23);
            numBrVrata.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(255, 193);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 27;
            label11.Text = "Broj vrata";
            // 
            // AddVozilo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 435);
            Controls.Add(numBrVrata);
            Controls.Add(label11);
            Controls.Add(gbStanje);
            Controls.Add(btnSubmit);
            Controls.Add(label10);
            Controls.Add(cbTipGoriva);
            Controls.Add(numBrojVlasnika);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtpDatumRegistracije);
            Controls.Add(numGodinaProizvodnje);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tbxBoja);
            Controls.Add(numSnagaMotora);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbMarka);
            Controls.Add(numKilometraza);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbxModel);
            Controls.Add(label1);
            Controls.Add(tbxBrSasije);
            MaximumSize = new Size(460, 474);
            MinimumSize = new Size(460, 474);
            Name = "AddVozilo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodavanje vozila";
            Load += AddVozilo_Load;
            ((System.ComponentModel.ISupportInitialize)numKilometraza).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSnagaMotora).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGodinaProizvodnje).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBrojVlasnika).EndInit();
            gbStanje.ResumeLayout(false);
            gbStanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBrVrata).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private NumericUpDown numBrVrata;
        private Label label11;
    }
}