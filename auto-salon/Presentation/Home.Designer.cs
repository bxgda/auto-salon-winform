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
            label9 = new Label();
            SuspendLayout();
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(-2, 650);
            label9.Name = "label9";
            label9.Size = new Size(310, 21);
            label9.TabIndex = 14;
            label9.Text = "Elektronski fakultet Univerziteta u Nišu";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.autoSalonBg;
            BackgroundImageLayout = ImageLayout.Zoom;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(label9);
            DoubleBuffered = true;
            Name = "Home";
            Size = new Size(843, 671);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
    }
}
