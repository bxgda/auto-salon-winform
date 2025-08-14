namespace auto_salon.Presentation.FVozilo
{
    partial class VozilaSalona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VozilaSalona));
            tableLayoutPanel1 = new TableLayoutPanel();
            lvVozila = new ListView();
            panel1 = new Panel();
            btnEdit = new Button();
            btnServisnaIstorija = new Button();
            btnProdaj = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lvVozila, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lvVozila
            // 
            lvVozila.Dock = DockStyle.Fill;
            lvVozila.FullRowSelect = true;
            lvVozila.GridLines = true;
            lvVozila.Location = new Point(3, 3);
            lvVozila.Name = "lvVozila";
            lvVozila.Size = new Size(794, 367);
            lvVozila.TabIndex = 2;
            lvVozila.UseCompatibleStateImageBehavior = false;
            lvVozila.View = View.Details;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnServisnaIstorija);
            panel1.Controls.Add(btnProdaj);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 376);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 71);
            panel1.TabIndex = 3;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.pencil;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(113, 31);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(115, 37);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnServisnaIstorija
            // 
            btnServisnaIstorija.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnServisnaIstorija.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnServisnaIstorija.Image = Properties.Resources.service;
            btnServisnaIstorija.ImageAlign = ContentAlignment.MiddleLeft;
            btnServisnaIstorija.Location = new Point(351, 31);
            btnServisnaIstorija.Name = "btnServisnaIstorija";
            btnServisnaIstorija.Padding = new Padding(7, 0, 0, 0);
            btnServisnaIstorija.Size = new Size(145, 37);
            btnServisnaIstorija.TabIndex = 6;
            btnServisnaIstorija.Text = "  Servisna istorija";
            btnServisnaIstorija.UseVisualStyleBackColor = true;
            btnServisnaIstorija.Click += btnServisnaIstorija_Click;
            // 
            // btnProdaj
            // 
            btnProdaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnProdaj.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProdaj.Image = Properties.Resources.shopping_cart;
            btnProdaj.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdaj.Location = new Point(661, 31);
            btnProdaj.Name = "btnProdaj";
            btnProdaj.Padding = new Padding(10, 0, 0, 0);
            btnProdaj.Size = new Size(130, 37);
            btnProdaj.TabIndex = 5;
            btnProdaj.Text = "Prodaj";
            btnProdaj.UseVisualStyleBackColor = true;
            btnProdaj.Click += btnProdaj_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(3, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(104, 37);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.trash;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(234, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(111, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // VozilaSalona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 489);
            Name = "VozilaSalona";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VozilaSalona";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView lvVozila;
        private Panel panel1;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnProdaj;
        private Button btnServisnaIstorija;
        private Button btnEdit;
    }
}