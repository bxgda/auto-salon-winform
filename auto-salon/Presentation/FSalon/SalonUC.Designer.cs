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
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnVozila = new Button();
            btnZaposleni = new Button();
            lvSaloni = new ListView();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(220, 20);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 37);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(8, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 37);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(114, 20);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 37);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 63);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Saloni";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(lvSaloni, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.2F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.8F));
            tableLayoutPanel1.Size = new Size(719, 500);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVozila);
            panel1.Controls.Add(btnZaposleni);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 419);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 78);
            panel1.TabIndex = 5;
            // 
            // btnVozila
            // 
            btnVozila.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVozila.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVozila.Location = new Point(399, 32);
            btnVozila.Name = "btnVozila";
            btnVozila.Size = new Size(148, 37);
            btnVozila.TabIndex = 5;
            btnVozila.Text = "Pregled vozila";
            btnVozila.UseVisualStyleBackColor = true;
            btnVozila.Click += btnVozila_Click;
            // 
            // btnZaposleni
            // 
            btnZaposleni.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnZaposleni.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZaposleni.Location = new Point(553, 32);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(148, 37);
            btnZaposleni.TabIndex = 2;
            btnZaposleni.Text = "Pregled zaposlenih";
            btnZaposleni.UseVisualStyleBackColor = true;
            btnZaposleni.Click += btnZaposleni_Click;
            // 
            // lvSaloni
            // 
            lvSaloni.Dock = DockStyle.Fill;
            lvSaloni.FullRowSelect = true;
            lvSaloni.GridLines = true;
            lvSaloni.Location = new Point(3, 3);
            lvSaloni.Name = "lvSaloni";
            lvSaloni.Size = new Size(713, 410);
            lvSaloni.TabIndex = 6;
            lvSaloni.UseCompatibleStateImageBehavior = false;
            lvSaloni.View = View.Details;
            // 
            // SalonUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "SalonUC";
            Size = new Size(719, 500);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnZaposleni;
        private ListView lvSaloni;
        private Button btnVozila;
    }
}
