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
            btnTestVoznja = new Button();
            btnEdit = new Button();
            btnProdaj = new Button();
            btnServisnaIstorija = new Button();
            btnDelete = new Button();
            lvVozila = new ListView();
            panel2 = new Panel();
            label1 = new Label();
            cbFilter = new ComboBox();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 657F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1031, 783);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTestVoznja);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnProdaj);
            panel1.Controls.Add(btnServisnaIstorija);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 694);
            panel1.Name = "panel1";
            panel1.Size = new Size(1025, 86);
            panel1.TabIndex = 1;
            // 
            // btnTestVoznja
            // 
            btnTestVoznja.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTestVoznja.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTestVoznja.Image = Properties.Resources.steering_wheel;
            btnTestVoznja.ImageAlign = ContentAlignment.MiddleLeft;
            btnTestVoznja.Location = new Point(677, 46);
            btnTestVoznja.Name = "btnTestVoznja";
            btnTestVoznja.Padding = new Padding(10, 0, 0, 0);
            btnTestVoznja.Size = new Size(183, 37);
            btnTestVoznja.TabIndex = 7;
            btnTestVoznja.Text = "Dodaj test vožnju";
            btnTestVoznja.UseVisualStyleBackColor = true;
            btnTestVoznja.Click += btnTestVoznja_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.pencil;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(124, 46);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(115, 37);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnProdaj
            // 
            btnProdaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProdaj.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdaj.Image = Properties.Resources.shopping_cart;
            btnProdaj.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdaj.Location = new Point(866, 46);
            btnProdaj.Name = "btnProdaj";
            btnProdaj.Padding = new Padding(10, 0, 0, 0);
            btnProdaj.Size = new Size(156, 37);
            btnProdaj.TabIndex = 5;
            btnProdaj.Text = "Prodaj";
            btnProdaj.UseVisualStyleBackColor = true;
            btnProdaj.Click += btnProdaj_Click;
            // 
            // btnServisnaIstorija
            // 
            btnServisnaIstorija.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnServisnaIstorija.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServisnaIstorija.Image = Properties.Resources.service;
            btnServisnaIstorija.ImageAlign = ContentAlignment.MiddleLeft;
            btnServisnaIstorija.Location = new Point(245, 46);
            btnServisnaIstorija.Name = "btnServisnaIstorija";
            btnServisnaIstorija.Padding = new Padding(10, 0, 0, 0);
            btnServisnaIstorija.Size = new Size(165, 37);
            btnServisnaIstorija.TabIndex = 4;
            btnServisnaIstorija.Text = "Servisna istorija";
            btnServisnaIstorija.UseVisualStyleBackColor = true;
            btnServisnaIstorija.Click += btnServisnaIstorija_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.trash;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(3, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(115, 37);
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
            lvVozila.Size = new Size(1025, 651);
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
            panel2.Size = new Size(1025, 28);
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
            // VoziloUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "VoziloUC";
            Size = new Size(1031, 783);
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
        private Button btnEdit;
        private Button btnTestVoznja;
    }
}
