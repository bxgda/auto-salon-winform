namespace auto_salon.Presentation.FProizvodjacNudi
{
    partial class AddProizvodjac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProizvodjac));
            btnSubmit = new Button();
            label1 = new Label();
            tbxNaziv = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Image = Properties.Resources.plus;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(12, 56);
            btnSubmit.MaximumSize = new Size(145, 39);
            btnSubmit.MinimumSize = new Size(145, 39);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(10, 0, 0, 0);
            btnSubmit.Size = new Size(145, 39);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Dodaj";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 7;
            label1.Text = "Ime:";
            // 
            // tbxNaziv
            // 
            tbxNaziv.Location = new Point(12, 27);
            tbxNaziv.Name = "tbxNaziv";
            tbxNaziv.Size = new Size(145, 23);
            tbxNaziv.TabIndex = 8;
            // 
            // AddProizvodjac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(170, 107);
            Controls.Add(tbxNaziv);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(186, 146);
            MinimizeBox = false;
            MinimumSize = new Size(186, 146);
            Name = "AddProizvodjac";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj proizvođača";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label label1;
        private TextBox tbxNaziv;
    }
}