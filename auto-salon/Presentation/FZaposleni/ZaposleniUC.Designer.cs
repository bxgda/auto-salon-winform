namespace auto_salon.Presentation.FZaposleni
{
    partial class ZaposleniUC
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
            dgvZaposleni = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            SuspendLayout();
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZaposleni.Location = new Point(0, 0);
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.Size = new Size(750, 270);
            dgvZaposleni.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(3, 460);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 37);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ZaposleniUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(dgvZaposleni);
            MinimumSize = new Size(750, 500);
            Name = "ZaposleniUC";
            Size = new Size(750, 500);
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvZaposleni;
        private Button btnDelete;
    }
}
