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
            txtKontaktTelefon = new TextBox();
            cbxTip = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSubmit = new Button();
            groupBox1 = new GroupBox();
            timePickerDo = new DateTimePicker();
            timePickerOd = new DateTimePicker();
            label5 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDrzava
            // 
            txtDrzava.Location = new Point(16, 97);
            txtDrzava.Name = "txtDrzava";
            txtDrzava.Size = new Size(170, 23);
            txtDrzava.TabIndex = 2;
            // 
            // txtGrad
            // 
            txtGrad.Location = new Point(16, 147);
            txtGrad.Name = "txtGrad";
            txtGrad.Size = new Size(170, 23);
            txtGrad.TabIndex = 3;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(16, 43);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(170, 23);
            txtNaziv.TabIndex = 1;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(16, 196);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(170, 23);
            txtAdresa.TabIndex = 4;
            // 
            // txtKontaktTelefon
            // 
            txtKontaktTelefon.Location = new Point(212, 43);
            txtKontaktTelefon.Name = "txtKontaktTelefon";
            txtKontaktTelefon.Size = new Size(170, 23);
            txtKontaktTelefon.TabIndex = 5;
            // 
            // cbxTip
            // 
            cbxTip.FormattingEnabled = true;
            cbxTip.Items.AddRange(new object[] { "Nova", "Polovna", "Kombinovan" });
            cbxTip.Location = new Point(212, 147);
            cbxTip.Name = "cbxTip";
            cbxTip.Size = new Size(170, 23);
            cbxTip.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 79);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Država";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 129);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Grad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 178);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 7;
            label3.Text = "Adresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 25);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 1;
            label4.Text = "Naziv";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 25);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 9;
            label6.Text = "Kontakt telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 129);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 15;
            label7.Text = "Tip";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Location = new Point(261, 249);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(145, 39);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Dodaj";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(timePickerDo);
            groupBox1.Controls.Add(timePickerOd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtNaziv);
            groupBox1.Controls.Add(txtDrzava);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGrad);
            groupBox1.Controls.Add(cbxTip);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAdresa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtKontaktTelefon);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 231);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Osnovni podaci o salonu";
            // 
            // timePickerDo
            // 
            timePickerDo.Format = DateTimePickerFormat.Custom;
            timePickerDo.Location = new Point(309, 97);
            timePickerDo.Name = "timePickerDo";
            timePickerDo.Size = new Size(70, 23);
            timePickerDo.TabIndex = 7;
            // 
            // timePickerOd
            // 
            timePickerOd.Format = DateTimePickerFormat.Custom;
            timePickerOd.Location = new Point(212, 97);
            timePickerOd.Name = "timePickerOd";
            timePickerOd.Size = new Size(70, 23);
            timePickerOd.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(288, 100);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 17;
            label5.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(212, 79);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 16;
            label9.Text = "Radno vreme";
            // 
            // AddSalon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 302);
            Controls.Add(groupBox1);
            Controls.Add(btnSubmit);
            MaximizeBox = false;
            MaximumSize = new Size(436, 341);
            MinimizeBox = false;
            MinimumSize = new Size(436, 341);
            Name = "AddSalon";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodavanje salona";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDrzava;
        private TextBox txtGrad;
        private TextBox txtNaziv;
        private TextBox txtAdresa;
        private TextBox txtKontaktTelefon;
        private ComboBox cbxTip;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button btnSubmit;
        private GroupBox groupBox1;
        private Label label5;
        private Label label9;
        private DateTimePicker timePickerOd;
        private DateTimePicker timePickerDo;
    }
}