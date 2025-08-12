namespace auto_salon.Presentation.FKupac
{
    partial class AddKupac
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
            rbPravnoLice = new RadioButton();
            rbFizickoLice = new RadioButton();
            groupBox2 = new GroupBox();
            tbx6Kupac = new TextBox();
            lbl6Kupac = new Label();
            tbx5Kupac = new TextBox();
            lbl5Kupac = new Label();
            tbx4Kupac = new TextBox();
            lbl4Kupac = new Label();
            tbx3Kupac = new TextBox();
            lbl3Kupac = new Label();
            tbx2Kupac = new TextBox();
            tbx1Kupac = new TextBox();
            lbl2Kupac = new Label();
            lbl1Kupac = new Label();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbPravnoLice);
            groupBox1.Controls.Add(rbFizickoLice);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 61);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tip kupca";
            // 
            // rbPravnoLice
            // 
            rbPravnoLice.AutoSize = true;
            rbPravnoLice.Location = new Point(105, 28);
            rbPravnoLice.Name = "rbPravnoLice";
            rbPravnoLice.Size = new Size(83, 19);
            rbPravnoLice.TabIndex = 1;
            rbPravnoLice.Text = "Pravno lice";
            rbPravnoLice.UseVisualStyleBackColor = true;
            // 
            // rbFizickoLice
            // 
            rbFizickoLice.AutoSize = true;
            rbFizickoLice.Checked = true;
            rbFizickoLice.Location = new Point(17, 28);
            rbFizickoLice.Name = "rbFizickoLice";
            rbFizickoLice.Size = new Size(82, 19);
            rbFizickoLice.TabIndex = 1;
            rbFizickoLice.TabStop = true;
            rbFizickoLice.Text = "Fizičko lice";
            rbFizickoLice.UseVisualStyleBackColor = true;
            rbFizickoLice.CheckedChanged += rbFizickoLice_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbx6Kupac);
            groupBox2.Controls.Add(lbl6Kupac);
            groupBox2.Controls.Add(tbx5Kupac);
            groupBox2.Controls.Add(lbl5Kupac);
            groupBox2.Controls.Add(tbx4Kupac);
            groupBox2.Controls.Add(lbl4Kupac);
            groupBox2.Controls.Add(tbx3Kupac);
            groupBox2.Controls.Add(lbl3Kupac);
            groupBox2.Controls.Add(tbx2Kupac);
            groupBox2.Controls.Add(tbx1Kupac);
            groupBox2.Controls.Add(lbl2Kupac);
            groupBox2.Controls.Add(lbl1Kupac);
            groupBox2.Location = new Point(12, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 201);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci o kupcu";
            // 
            // tbx6Kupac
            // 
            tbx6Kupac.Location = new Point(241, 158);
            tbx6Kupac.Name = "tbx6Kupac";
            tbx6Kupac.Size = new Size(203, 23);
            tbx6Kupac.TabIndex = 5;
            // 
            // lbl6Kupac
            // 
            lbl6Kupac.AutoSize = true;
            lbl6Kupac.Location = new Point(241, 140);
            lbl6Kupac.Name = "lbl6Kupac";
            lbl6Kupac.Size = new Size(43, 15);
            lbl6Kupac.TabIndex = 11;
            lbl6Kupac.Text = "Adresa";
            // 
            // tbx5Kupac
            // 
            tbx5Kupac.Location = new Point(241, 101);
            tbx5Kupac.Name = "tbx5Kupac";
            tbx5Kupac.Size = new Size(203, 23);
            tbx5Kupac.TabIndex = 4;
            // 
            // lbl5Kupac
            // 
            lbl5Kupac.AutoSize = true;
            lbl5Kupac.Location = new Point(241, 83);
            lbl5Kupac.Name = "lbl5Kupac";
            lbl5Kupac.Size = new Size(96, 15);
            lbl5Kupac.TabIndex = 9;
            lbl5Kupac.Text = "Kontakt telefon *";
            // 
            // tbx4Kupac
            // 
            tbx4Kupac.Location = new Point(241, 48);
            tbx4Kupac.Name = "tbx4Kupac";
            tbx4Kupac.Size = new Size(203, 23);
            tbx4Kupac.TabIndex = 3;
            // 
            // lbl4Kupac
            // 
            lbl4Kupac.AutoSize = true;
            lbl4Kupac.Location = new Point(241, 30);
            lbl4Kupac.Name = "lbl4Kupac";
            lbl4Kupac.Size = new Size(36, 15);
            lbl4Kupac.TabIndex = 7;
            lbl4Kupac.Text = "Email";
            // 
            // tbx3Kupac
            // 
            tbx3Kupac.Location = new Point(17, 158);
            tbx3Kupac.Name = "tbx3Kupac";
            tbx3Kupac.Size = new Size(203, 23);
            tbx3Kupac.TabIndex = 2;
            // 
            // lbl3Kupac
            // 
            lbl3Kupac.AutoSize = true;
            lbl3Kupac.Location = new Point(17, 140);
            lbl3Kupac.Name = "lbl3Kupac";
            lbl3Kupac.Size = new Size(57, 15);
            lbl3Kupac.TabIndex = 5;
            lbl3Kupac.Text = "Prezime *";
            // 
            // tbx2Kupac
            // 
            tbx2Kupac.Location = new Point(17, 102);
            tbx2Kupac.Name = "tbx2Kupac";
            tbx2Kupac.Size = new Size(203, 23);
            tbx2Kupac.TabIndex = 1;
            // 
            // tbx1Kupac
            // 
            tbx1Kupac.Location = new Point(17, 48);
            tbx1Kupac.MaxLength = 13;
            tbx1Kupac.Name = "tbx1Kupac";
            tbx1Kupac.Size = new Size(203, 23);
            tbx1Kupac.TabIndex = 0;
            // 
            // lbl2Kupac
            // 
            lbl2Kupac.AutoSize = true;
            lbl2Kupac.Location = new Point(17, 84);
            lbl2Kupac.Name = "lbl2Kupac";
            lbl2Kupac.Size = new Size(35, 15);
            lbl2Kupac.TabIndex = 1;
            lbl2Kupac.Text = "Ime *";
            // 
            // lbl1Kupac
            // 
            lbl1Kupac.AutoSize = true;
            lbl1Kupac.Location = new Point(17, 30);
            lbl1Kupac.Name = "lbl1Kupac";
            lbl1Kupac.Size = new Size(45, 15);
            lbl1Kupac.TabIndex = 0;
            lbl1Kupac.Text = "JMBG *";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Location = new Point(337, 299);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(145, 39);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Dodaj";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddKupac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 353);
            Controls.Add(btnSubmit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(510, 392);
            MinimizeBox = false;
            MinimumSize = new Size(510, 392);
            Name = "AddKupac";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodavanje kupca";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbPravnoLice;
        private RadioButton rbFizickoLice;
        private GroupBox groupBox2;
        private Label lbl1Kupac;
        private Button btnSubmit;
        private TextBox tbx2Kupac;
        private TextBox tbx1Kupac;
        private Label lbl2Kupac;
        private TextBox tbx6Kupac;
        private Label lbl6Kupac;
        private TextBox tbx5Kupac;
        private Label lbl5Kupac;
        private TextBox tbx4Kupac;
        private Label lbl4Kupac;
        private TextBox tbx3Kupac;
        private Label lbl3Kupac;
    }
}