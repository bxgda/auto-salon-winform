namespace auto_salon.Presentation.FUgovori
{
    partial class UgovoriUC
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
            btnDelete = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            lvUgovori = new ListView();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            lblGodinaProizvodnje = new Label();
            lblModel = new Label();
            lblBrojSasije = new Label();
            label6 = new Label();
            label4 = new Label();
            lblStanje = new Label();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.47979F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.52021F));
            tableLayoutPanel1.Size = new Size(1200, 771);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 646);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 122);
            panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(3, 82);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 37);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.77052F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.22948F));
            tableLayoutPanel2.Controls.Add(lvUgovori, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1194, 637);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // lvUgovori
            // 
            lvUgovori.Dock = DockStyle.Fill;
            lvUgovori.FullRowSelect = true;
            lvUgovori.GridLines = true;
            lvUgovori.Location = new Point(3, 3);
            lvUgovori.Name = "lvUgovori";
            lvUgovori.Size = new Size(839, 631);
            lvUgovori.TabIndex = 1;
            lvUgovori.UseCompatibleStateImageBehavior = false;
            lvUgovori.View = View.Details;
            lvUgovori.SelectedIndexChanged += lvUgovori_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(848, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 631);
            panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Location = new Point(3, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 195);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Podaci o kupcu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 2;
            label2.Text = "Detalji ugovora";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblGodinaProizvodnje);
            groupBox1.Controls.Add(lblModel);
            groupBox1.Controls.Add(lblBrojSasije);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblStanje);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 148);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podaci o vozilu";
            // 
            // lblGodinaProizvodnje
            // 
            lblGodinaProizvodnje.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGodinaProizvodnje.AutoSize = true;
            lblGodinaProizvodnje.Location = new Point(207, 114);
            lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            lblGodinaProizvodnje.Size = new Size(12, 15);
            lblGodinaProizvodnje.TabIndex = 10;
            lblGodinaProizvodnje.Text = "/";
            // 
            // lblModel
            // 
            lblModel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblModel.AutoSize = true;
            lblModel.Location = new Point(207, 87);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(12, 15);
            lblModel.TabIndex = 8;
            lblModel.Text = "/";
            // 
            // lblBrojSasije
            // 
            lblBrojSasije.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBrojSasije.AutoSize = true;
            lblBrojSasije.Location = new Point(207, 31);
            lblBrojSasije.Name = "lblBrojSasije";
            lblBrojSasije.Size = new Size(12, 15);
            lblBrojSasije.TabIndex = 7;
            lblBrojSasije.Text = "/";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 114);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 6;
            label6.Text = "Godina proizvodnje:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 87);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Model:";
            // 
            // lblStanje
            // 
            lblStanje.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStanje.AutoSize = true;
            lblStanje.Location = new Point(207, 58);
            lblStanje.Name = "lblStanje";
            lblStanje.Size = new Size(12, 15);
            lblStanje.TabIndex = 3;
            lblStanje.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 58);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Stanje:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Broj šasije:";
            // 
            // UgovoriUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UgovoriUC";
            Size = new Size(1200, 771);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnDelete;
        private TableLayoutPanel tableLayoutPanel2;
        private ListView lvUgovori;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStanje;
        private Label label6;
        private Label label4;
        private Label lblGodinaProizvodnje;
        private Label lblModel;
        private Label lblBrojSasije;
        private GroupBox groupBox2;
    }
}
