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
            tableLayoutPanel1 = new TableLayoutPanel();
            lvZaposleni = new ListView();
            panel1 = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lvZaposleni, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.60665F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.393347F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1124, 775);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lvZaposleni
            // 
            lvZaposleni.Dock = DockStyle.Fill;
            lvZaposleni.FullRowSelect = true;
            lvZaposleni.GridLines = true;
            lvZaposleni.Location = new Point(3, 3);
            lvZaposleni.Name = "lvZaposleni";
            lvZaposleni.Size = new Size(1118, 696);
            lvZaposleni.TabIndex = 3;
            lvZaposleni.UseCompatibleStateImageBehavior = false;
            lvZaposleni.View = View.Details;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 705);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 67);
            panel1.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(3, 27);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 37);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(97, 27);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 37);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ZaposleniUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ZaposleniUC";
            Size = new Size(1124, 775);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private ListView lvZaposleni;
        private Panel panel1;
        private Button btnEdit;
        private Button btnDelete;
    }
}
