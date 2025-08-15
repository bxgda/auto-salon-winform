namespace auto_salon.Presentation
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 644);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 9;
            label6.Text = "David Marković";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 623);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 8;
            label5.Text = "Marijana Rančić";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 602);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 7;
            label4.Text = "Jovan Bogdanović";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 581);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 6;
            label3.Text = "Aleksandar Gospavić";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 560);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 5;
            label1.Text = "Autori:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.garage256;
            pictureBox2.Location = new Point(37, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 315);
            panel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(253, 25);
            label2.Name = "label2";
            label2.Size = new Size(343, 50);
            label2.TabIndex = 11;
            label2.Text = "Lanac Auto Salona";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Home";
            Size = new Size(847, 675);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
    }
}
