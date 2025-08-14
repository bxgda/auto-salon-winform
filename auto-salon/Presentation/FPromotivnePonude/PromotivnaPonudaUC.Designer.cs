namespace auto_salon.Presentation.FPromotivnePonude
{
    partial class PromotivnaPonudaUC
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
            lvPromotivnePonude = new ListView();
            label1 = new Label();
            lvVozila = new ListView();
            panel1 = new Panel();
            btnIzbaciVoziloIzPonudu = new Button();
            btnDodajVoziloUPonudu = new Button();
            panel2 = new Panel();
            label2 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lvPromotivnePonude, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(lvVozila, 0, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 4);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 254F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.01575F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.Size = new Size(990, 746);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lvPromotivnePonude
            // 
            lvPromotivnePonude.Dock = DockStyle.Fill;
            lvPromotivnePonude.FullRowSelect = true;
            lvPromotivnePonude.GridLines = true;
            lvPromotivnePonude.Location = new Point(3, 23);
            lvPromotivnePonude.Name = "lvPromotivnePonude";
            lvPromotivnePonude.Size = new Size(984, 248);
            lvPromotivnePonude.TabIndex = 0;
            lvPromotivnePonude.UseCompatibleStateImageBehavior = false;
            lvPromotivnePonude.View = View.Details;
            lvPromotivnePonude.SelectedIndexChanged += lvPromotivnePonude_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 1;
            label1.Text = "Promotivne ponude";
            // 
            // lvVozila
            // 
            lvVozila.Dock = DockStyle.Fill;
            lvVozila.FullRowSelect = true;
            lvVozila.GridLines = true;
            lvVozila.Location = new Point(3, 371);
            lvVozila.Name = "lvVozila";
            lvVozila.Size = new Size(984, 295);
            lvVozila.TabIndex = 3;
            lvVozila.UseCompatibleStateImageBehavior = false;
            lvVozila.View = View.Details;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnIzbaciVoziloIzPonudu);
            panel1.Controls.Add(btnDodajVoziloUPonudu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 672);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 71);
            panel1.TabIndex = 4;
            // 
            // btnIzbaciVoziloIzPonudu
            // 
            btnIzbaciVoziloIzPonudu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIzbaciVoziloIzPonudu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzbaciVoziloIzPonudu.Image = Properties.Resources.minus;
            btnIzbaciVoziloIzPonudu.ImageAlign = ContentAlignment.MiddleLeft;
            btnIzbaciVoziloIzPonudu.Location = new Point(225, 31);
            btnIzbaciVoziloIzPonudu.Name = "btnIzbaciVoziloIzPonudu";
            btnIzbaciVoziloIzPonudu.Padding = new Padding(10, 0, 0, 0);
            btnIzbaciVoziloIzPonudu.Size = new Size(215, 37);
            btnIzbaciVoziloIzPonudu.TabIndex = 10;
            btnIzbaciVoziloIzPonudu.Text = "Izbaci vozilo iz ponude";
            btnIzbaciVoziloIzPonudu.UseVisualStyleBackColor = true;
            btnIzbaciVoziloIzPonudu.Click += btnIzbaciVoziloIzPonudu_Click;
            // 
            // btnDodajVoziloUPonudu
            // 
            btnDodajVoziloUPonudu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDodajVoziloUPonudu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajVoziloUPonudu.Image = Properties.Resources.plus;
            btnDodajVoziloUPonudu.ImageAlign = ContentAlignment.MiddleLeft;
            btnDodajVoziloUPonudu.Location = new Point(4, 31);
            btnDodajVoziloUPonudu.Name = "btnDodajVoziloUPonudu";
            btnDodajVoziloUPonudu.Padding = new Padding(10, 0, 0, 0);
            btnDodajVoziloUPonudu.Size = new Size(215, 37);
            btnDodajVoziloUPonudu.TabIndex = 9;
            btnDodajVoziloUPonudu.Text = "Dodaj vozilo u ponudu";
            btnDodajVoziloUPonudu.UseVisualStyleBackColor = true;
            btnDodajVoziloUPonudu.Click += btnDodajVoziloUPonudu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 88);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 73);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 9;
            label2.Text = "Vozila u izabranoj ponudi";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.pencil;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(225, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(102, 37);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.trash;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(111, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(108, 37);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(102, 37);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // PromotivnaPonudaUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PromotivnaPonudaUC";
            Size = new Size(990, 746);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView lvPromotivnePonude;
        private Label label1;
        private ListView lvVozila;
        private Panel panel1;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDodajVoziloUPonudu;
        private Button btnIzbaciVoziloIzPonudu;
        private Panel panel2;
        private Label label2;
    }
}
