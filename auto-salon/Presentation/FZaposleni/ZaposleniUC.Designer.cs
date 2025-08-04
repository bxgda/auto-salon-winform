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
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvZaposleni
            // 
            dgvZaposleni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZaposleni.Dock = DockStyle.Fill;
            dgvZaposleni.Location = new Point(3, 3);
            dgvZaposleni.Name = "dgvZaposleni";
            dgvZaposleni.Size = new Size(1118, 696);
            dgvZaposleni.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(3, 735);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 37);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvZaposleni, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.60665F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.393347F));
            tableLayoutPanel1.Size = new Size(1124, 775);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // ZaposleniUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(750, 500);
            Name = "ZaposleniUC";
            Size = new Size(1124, 775);
            ((System.ComponentModel.ISupportInitialize)dgvZaposleni).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvZaposleni;
        private Button btnDelete;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
