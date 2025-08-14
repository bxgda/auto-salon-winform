namespace auto_salon.Presentation.FServisnaStavka
{
    partial class EditServisnaStavka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditServisnaStavka));
            btnSubmit = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            tbxOpis = new RichTextBox();
            cbxUserCurrentDate = new CheckBox();
            label8 = new Label();
            dtpDatum = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Image = Properties.Resources.pencil;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(188, 328);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(10, 0, 0, 0);
            btnSubmit.Size = new Size(145, 39);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Izmeni";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbxOpis);
            groupBox1.Controls.Add(cbxUserCurrentDate);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpDatum);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 299);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o odrađenom servisu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 20;
            label1.Text = "Opis";
            // 
            // tbxOpis
            // 
            tbxOpis.Location = new Point(21, 44);
            tbxOpis.Name = "tbxOpis";
            tbxOpis.Size = new Size(276, 112);
            tbxOpis.TabIndex = 19;
            tbxOpis.Text = "";
            // 
            // cbxUserCurrentDate
            // 
            cbxUserCurrentDate.AutoSize = true;
            cbxUserCurrentDate.Checked = true;
            cbxUserCurrentDate.CheckState = CheckState.Checked;
            cbxUserCurrentDate.Location = new Point(153, 221);
            cbxUserCurrentDate.Name = "cbxUserCurrentDate";
            cbxUserCurrentDate.Size = new Size(144, 19);
            cbxUserCurrentDate.TabIndex = 17;
            cbxUserCurrentDate.Text = "Koristi današnji datum";
            cbxUserCurrentDate.UseVisualStyleBackColor = true;
            cbxUserCurrentDate.CheckedChanged += cbxUserCurrentDate_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 174);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 18;
            label8.Text = "Datum";
            // 
            // dtpDatum
            // 
            dtpDatum.Enabled = false;
            dtpDatum.Format = DateTimePickerFormat.Short;
            dtpDatum.Location = new Point(21, 192);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(276, 23);
            dtpDatum.TabIndex = 16;
            // 
            // EditServisnaStavka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 383);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(368, 422);
            MinimizeBox = false;
            MinimumSize = new Size(368, 422);
            Name = "EditServisnaStavka";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Uređivanje servisne stavke";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubmit;
        private GroupBox groupBox1;
        private Label label1;
        private RichTextBox tbxOpis;
        private CheckBox cbxUserCurrentDate;
        private Label label8;
        private DateTimePicker dtpDatum;
    }
}