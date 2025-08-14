namespace auto_salon.Presentation.FPromotivnePonude
{
    partial class AddPromotivnaPonuda
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
            rtbUslovi = new RichTextBox();
            label1 = new Label();
            tbxNazivPromocije = new TextBox();
            label2 = new Label();
            nudPopust = new NumericUpDown();
            label3 = new Label();
            dtpOd = new DateTimePicker();
            oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            dtpDo = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPopust).BeginInit();
            SuspendLayout();
            // 
            // rtbUslovi
            // 
            rtbUslovi.Location = new Point(23, 149);
            rtbUslovi.Name = "rtbUslovi";
            rtbUslovi.Size = new Size(376, 96);
            rtbUslovi.TabIndex = 0;
            rtbUslovi.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Naziv promocije:";
            // 
            // tbxNazivPromocije
            // 
            tbxNazivPromocije.Location = new Point(23, 37);
            tbxNazivPromocije.Name = "tbxNazivPromocije";
            tbxNazivPromocije.Size = new Size(167, 23);
            tbxNazivPromocije.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 77);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 3;
            label2.Text = "Popust u procentima:";
            // 
            // nudPopust
            // 
            nudPopust.Location = new Point(23, 95);
            nudPopust.Name = "nudPopust";
            nudPopust.Size = new Size(167, 23);
            nudPopust.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 19);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 5;
            label3.Text = "Datum početka važenja:";
            // 
            // dtpOd
            // 
            dtpOd.Format = DateTimePickerFormat.Short;
            dtpOd.Location = new Point(232, 37);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(167, 23);
            dtpOd.TabIndex = 6;
            // 
            // dtpDo
            // 
            dtpDo.Format = DateTimePickerFormat.Short;
            dtpDo.Location = new Point(232, 95);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(167, 23);
            dtpDo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 77);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 7;
            label4.Text = "Datum kraja važenja:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 131);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 9;
            label5.Text = "Uslovi:";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Location = new Point(254, 264);
            btnSubmit.MaximumSize = new Size(145, 39);
            btnSubmit.MinimumSize = new Size(145, 39);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(145, 39);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Dodaj";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddPromotivnaPonuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 315);
            Controls.Add(btnSubmit);
            Controls.Add(label5);
            Controls.Add(dtpDo);
            Controls.Add(label4);
            Controls.Add(dtpOd);
            Controls.Add(label3);
            Controls.Add(nudPopust);
            Controls.Add(label2);
            Controls.Add(tbxNazivPromocije);
            Controls.Add(label1);
            Controls.Add(rtbUslovi);
            MaximumSize = new Size(432, 354);
            MinimumSize = new Size(432, 354);
            Name = "AddPromotivnaPonuda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nova promotivna ponuda";
            ((System.ComponentModel.ISupportInitialize)nudPopust).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbUslovi;
        private Label label1;
        private TextBox tbxNazivPromocije;
        private Label label2;
        private NumericUpDown nudPopust;
        private Label label3;
        private DateTimePicker dtpOd;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private DateTimePicker dtpDo;
        private Label label4;
        private Label label5;
        private Button btnSubmit;
    }
}