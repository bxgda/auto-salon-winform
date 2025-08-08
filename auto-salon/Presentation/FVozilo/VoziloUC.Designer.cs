namespace auto_salon.Presentation.FVozilo
{
    partial class VoziloUC
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
            panel1 = new Panel();
            btnServisnaIstorija = new Button();
            btnDelete = new Button();
            lvVozila = new ListView();
            panel2 = new Panel();
            label1 = new Label();
            cbFilter = new ComboBox();
            btnProdaj = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(lvVozila, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(719, 500);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProdaj);
            panel1.Controls.Add(btnServisnaIstorija);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 437);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 60);
            panel1.TabIndex = 1;
            // 
            // btnServisnaIstorija
            // 
            btnServisnaIstorija.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnServisnaIstorija.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServisnaIstorija.Location = new Point(97, 20);
            btnServisnaIstorija.Name = "btnServisnaIstorija";
            btnServisnaIstorija.Size = new Size(156, 37);
            btnServisnaIstorija.TabIndex = 4;
            btnServisnaIstorija.Text = "Vidi servisnu istoriju";
            btnServisnaIstorija.UseVisualStyleBackColor = true;
            btnServisnaIstorija.Click += btnServisnaIstorija_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(3, 20);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvVozila
            // 
            lvVozila.Dock = DockStyle.Fill;
            lvVozila.FullRowSelect = true;
            lvVozila.GridLines = true;
            lvVozila.Location = new Point(3, 37);
            lvVozila.Name = "lvVozila";
            lvVozila.Size = new Size(713, 394);
            lvVozila.TabIndex = 2;
            lvVozila.UseCompatibleStateImageBehavior = false;
            lvVozila.View = View.Details;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cbFilter);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 28);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Filter:";
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Sve", "Dostupno", "Prodato" });
            cbFilter.Location = new Point(45, 2);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(121, 23);
            cbFilter.TabIndex = 0;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // btnProdaj
            // 
            btnProdaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProdaj.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdaj.Location = new Point(554, 20);
            btnProdaj.Name = "btnProdaj";
            btnProdaj.Size = new Size(156, 37);
            btnProdaj.TabIndex = 5;
            btnProdaj.Text = "Prodaj";
            btnProdaj.UseVisualStyleBackColor = true;
            btnProdaj.Click += btnProdaj_Click;
            // 
            // VoziloUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "VoziloUC";
            Size = new Size(719, 500);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnDelete;
        private ListView lvVozila;
        private Button btnServisnaIstorija;
        private Panel panel2;
        private Label label1;
        private ComboBox cbFilter;
        private Button btnProdaj;
    }
}
