namespace auto_salon.Presentation.FPromotivnePonude
{
    partial class EditPromotivnaPonuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPromotivnaPonuda));
            btnSubmit = new Button();
            label5 = new Label();
            dtpDo = new DateTimePicker();
            label4 = new Label();
            dtpOd = new DateTimePicker();
            label3 = new Label();
            nudPopust = new NumericUpDown();
            label2 = new Label();
            tbxNazivPromocije = new TextBox();
            label1 = new Label();
            rtbUslovi = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)nudPopust).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Image = Properties.Resources.pencil;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(255, 264);
            btnSubmit.MaximumSize = new Size(145, 39);
            btnSubmit.MinimumSize = new Size(145, 39);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(10, 0, 0, 0);
            btnSubmit.Size = new Size(145, 39);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Izmeni";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 131);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 20;
            label5.Text = "Uslovi:";
            // 
            // dtpDo
            // 
            dtpDo.Format = DateTimePickerFormat.Short;
            dtpDo.Location = new Point(233, 95);
            dtpDo.Name = "dtpDo";
            dtpDo.Size = new Size(167, 23);
            dtpDo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 77);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 18;
            label4.Text = "Datum kraja važenja:";
            // 
            // dtpOd
            // 
            dtpOd.Format = DateTimePickerFormat.Short;
            dtpOd.Location = new Point(233, 37);
            dtpOd.Name = "dtpOd";
            dtpOd.Size = new Size(167, 23);
            dtpOd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 19);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 16;
            label3.Text = "Datum početka važenja:";
            // 
            // nudPopust
            // 
            nudPopust.Location = new Point(24, 95);
            nudPopust.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPopust.Name = "nudPopust";
            nudPopust.Size = new Size(167, 23);
            nudPopust.TabIndex = 1;
            nudPopust.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 77);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 14;
            label2.Text = "Popust u procentima:";
            // 
            // tbxNazivPromocije
            // 
            tbxNazivPromocije.Location = new Point(24, 37);
            tbxNazivPromocije.Name = "tbxNazivPromocije";
            tbxNazivPromocije.Size = new Size(167, 23);
            tbxNazivPromocije.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 12;
            label1.Text = "Naziv promocije:";
            // 
            // rtbUslovi
            // 
            rtbUslovi.Location = new Point(24, 149);
            rtbUslovi.Name = "rtbUslovi";
            rtbUslovi.Size = new Size(376, 96);
            rtbUslovi.TabIndex = 4;
            rtbUslovi.Text = "";
            // 
            // EditPromotivnaPonuda
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(432, 354);
            MinimumSize = new Size(432, 354);
            Name = "EditPromotivnaPonuda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmena promotivne ponude";
            ((System.ComponentModel.ISupportInitialize)nudPopust).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label label5;
        private DateTimePicker dtpDo;
        private Label label4;
        private DateTimePicker dtpOd;
        private Label label3;
        private NumericUpDown nudPopust;
        private Label label2;
        private TextBox tbxNazivPromocije;
        private Label label1;
        private RichTextBox rtbUslovi;
    }
}