namespace auto_salon.Presentation.FSalon
{
    partial class SalonUC
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
            dgvSaloni = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSaloni).BeginInit();
            SuspendLayout();
            // 
            // dgvSaloni
            // 
            dgvSaloni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaloni.Dock = DockStyle.Top;
            dgvSaloni.Location = new Point(0, 0);
            dgvSaloni.Name = "dgvSaloni";
            dgvSaloni.Size = new Size(750, 294);
            dgvSaloni.TabIndex = 0;
            // 
            // SalonUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(dgvSaloni);
            MinimumSize = new Size(750, 600);
            Name = "SalonUC";
            Size = new Size(750, 600);
            ((System.ComponentModel.ISupportInitialize)dgvSaloni).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSaloni;
    }
}
