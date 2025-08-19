namespace auto_salon.Presentation.FTestVoznja
{
    partial class EditTestVoznja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTestVoznja));
            label6 = new Label();
            rtbZakljucak = new RichTextBox();
            label5 = new Label();
            nupOcena = new NumericUpDown();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)nupOcena).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 70);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 29;
            label6.Text = "Zaključak";
            // 
            // rtbZakljucak
            // 
            rtbZakljucak.Location = new Point(12, 88);
            rtbZakljucak.Name = "rtbZakljucak";
            rtbZakljucak.Size = new Size(198, 190);
            rtbZakljucak.TabIndex = 28;
            rtbZakljucak.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 27;
            label5.Text = "Ocena";
            // 
            // nupOcena
            // 
            nupOcena.DecimalPlaces = 1;
            nupOcena.Location = new Point(12, 27);
            nupOcena.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupOcena.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupOcena.Name = "nupOcena";
            nupOcena.Size = new Size(198, 23);
            nupOcena.TabIndex = 26;
            nupOcena.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.BackColor = Color.Khaki;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.pencil;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(12, 321);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(198, 37);
            btnEdit.TabIndex = 30;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // EditTestVoznja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 370);
            Controls.Add(btnEdit);
            Controls.Add(label6);
            Controls.Add(rtbZakljucak);
            Controls.Add(label5);
            Controls.Add(nupOcena);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(240, 409);
            MinimizeBox = false;
            MinimumSize = new Size(240, 409);
            Name = "EditTestVoznja";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditTestVoznja";
            ((System.ComponentModel.ISupportInitialize)nupOcena).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private RichTextBox rtbZakljucak;
        private Label label5;
        private NumericUpDown nupOcena;
        private Button btnEdit;
    }
}