namespace auto_salon.Presentation.FOcene
{
    partial class EditOcena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOcena));
            nupOcena = new NumericUpDown();
            label1 = new Label();
            btnSubmit = new Button();
            lblProdavac = new Label();
            ((System.ComponentModel.ISupportInitialize)nupOcena).BeginInit();
            SuspendLayout();
            // 
            // nupOcena
            // 
            nupOcena.DecimalPlaces = 1;
            nupOcena.Location = new Point(12, 67);
            nupOcena.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupOcena.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupOcena.Name = "nupOcena";
            nupOcena.Size = new Size(182, 23);
            nupOcena.TabIndex = 0;
            nupOcena.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 1;
            label1.Text = "Izmena ocene prodavca:";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Image = Properties.Resources.pencil;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(12, 96);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(10, 0, 0, 0);
            btnSubmit.Size = new Size(182, 39);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Izmeni";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblProdavac
            // 
            lblProdavac.AutoSize = true;
            lblProdavac.Location = new Point(12, 33);
            lblProdavac.Name = "lblProdavac";
            lblProdavac.Size = new Size(12, 15);
            lblProdavac.TabIndex = 7;
            lblProdavac.Text = "/";
            // 
            // EditOcena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(211, 152);
            Controls.Add(lblProdavac);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(nupOcena);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(227, 191);
            MinimizeBox = false;
            MinimumSize = new Size(227, 191);
            Name = "EditOcena";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izmena ocene";
            ((System.ComponentModel.ISupportInitialize)nupOcena).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nupOcena;
        private Label label1;
        private Button btnSubmit;
        private Label lblProdavac;
    }
}