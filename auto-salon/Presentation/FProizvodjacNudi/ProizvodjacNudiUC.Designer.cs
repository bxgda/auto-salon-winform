namespace auto_salon.Presentation.FProizvodjacNudi
{
    partial class ProizvodjacNudiUC
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            lvSaloni = new ListView();
            lvProizvodjaci = new ListView();
            panel1 = new Panel();
            btnEdit = new Button();
            btnDodajSalonUPonudu = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btnIzbaciSalonIzPonudu = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lvSaloni, 0, 3);
            tableLayoutPanel1.Controls.Add(lvProizvodjaci, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.238606F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.76139F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 271F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(990, 746);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lvSaloni
            // 
            lvSaloni.Dock = DockStyle.Fill;
            lvSaloni.FullRowSelect = true;
            lvSaloni.GridLines = true;
            lvSaloni.Location = new Point(3, 419);
            lvSaloni.Name = "lvSaloni";
            lvSaloni.Size = new Size(984, 265);
            lvSaloni.TabIndex = 4;
            lvSaloni.UseCompatibleStateImageBehavior = false;
            lvSaloni.View = View.Details;
            // 
            // lvProizvodjaci
            // 
            lvProizvodjaci.Dock = DockStyle.Fill;
            lvProizvodjaci.FullRowSelect = true;
            lvProizvodjaci.GridLines = true;
            lvProizvodjaci.Location = new Point(3, 26);
            lvProizvodjaci.Name = "lvProizvodjaci";
            lvProizvodjaci.Size = new Size(984, 292);
            lvProizvodjaci.TabIndex = 1;
            lvProizvodjaci.UseCompatibleStateImageBehavior = false;
            lvProizvodjaci.View = View.Details;
            lvProizvodjaci.SelectedIndexChanged += lvProizvodjaci_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDodajSalonUPonudu);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 324);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 89);
            panel1.TabIndex = 5;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Khaki;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.pencil;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(111, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(102, 37);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDodajSalonUPonudu
            // 
            btnDodajSalonUPonudu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDodajSalonUPonudu.BackColor = SystemColors.Info;
            btnDodajSalonUPonudu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajSalonUPonudu.Image = Properties.Resources.plus;
            btnDodajSalonUPonudu.ImageAlign = ContentAlignment.MiddleLeft;
            btnDodajSalonUPonudu.Location = new Point(798, 3);
            btnDodajSalonUPonudu.Name = "btnDodajSalonUPonudu";
            btnDodajSalonUPonudu.Padding = new Padding(10, 0, 0, 0);
            btnDodajSalonUPonudu.Size = new Size(183, 37);
            btnDodajSalonUPonudu.TabIndex = 10;
            btnDodajSalonUPonudu.Text = "Ponudi salonima";
            toolTip1.SetToolTip(btnDodajSalonUPonudu, "Odaberite salone koji će nuditi vozila odabranog proizvođača");
            btnDodajSalonUPonudu.UseVisualStyleBackColor = false;
            btnDodajSalonUPonudu.Click += btnDodajSalonUPonudu_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.trash;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(219, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(108, 37);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleGreen;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(102, 37);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 74);
            label2.Name = "label2";
            label2.Size = new Size(276, 15);
            label2.TabIndex = 2;
            label2.Text = "Saloni kojima izabrani proizvođač nudi svoja vozila:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 17);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Proizvođači:";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnIzbaciSalonIzPonudu);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 690);
            panel3.Name = "panel3";
            panel3.Size = new Size(984, 53);
            panel3.TabIndex = 7;
            // 
            // btnIzbaciSalonIzPonudu
            // 
            btnIzbaciSalonIzPonudu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIzbaciSalonIzPonudu.BackColor = Color.FromArgb(255, 192, 192);
            btnIzbaciSalonIzPonudu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIzbaciSalonIzPonudu.Image = Properties.Resources.minus;
            btnIzbaciSalonIzPonudu.ImageAlign = ContentAlignment.MiddleLeft;
            btnIzbaciSalonIzPonudu.Location = new Point(4, 3);
            btnIzbaciSalonIzPonudu.Name = "btnIzbaciSalonIzPonudu";
            btnIzbaciSalonIzPonudu.Padding = new Padding(10, 0, 0, 0);
            btnIzbaciSalonIzPonudu.Size = new Size(215, 37);
            btnIzbaciSalonIzPonudu.TabIndex = 11;
            btnIzbaciSalonIzPonudu.Text = "Skloni salon iz ponude";
            toolTip2.SetToolTip(btnIzbaciSalonIzPonudu, "Izbacivanje salona iz ponude odabranog proizvođača");
            btnIzbaciSalonIzPonudu.UseVisualStyleBackColor = false;
            btnIzbaciSalonIzPonudu.Click += btnIzbaciSalonIzPonudu_Click;
            // 
            // ProizvodjacNudiUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ProizvodjacNudiUC";
            Size = new Size(990, 746);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView lvProizvodjaci;
        private Label label2;
        private ListView lvSaloni;
        private Panel panel1;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button btnDodajSalonUPonudu;
        private Button btnIzbaciSalonIzPonudu;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}
