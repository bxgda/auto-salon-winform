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
            groupBox3 = new GroupBox();
            lblTelefonProdavca = new Label();
            lblPozicijaProdavca = new Label();
            lblPrezimeProdavca = new Label();
            lblImeProdavca = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox2 = new GroupBox();
            lblKupacJe = new Label();
            lbl11 = new Label();
            lblTelefonKupca = new Label();
            lblEmailKupca = new Label();
            lblPrezimeKupca = new Label();
            lblImeKupca = new Label();
            lbl4Kupac = new Label();
            lbl3Kupac = new Label();
            lbl2Kupac = new Label();
            lbl1Kupac = new Label();
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
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(848, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 631);
            panel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(lblTelefonProdavca);
            groupBox3.Controls.Add(lblPozicijaProdavca);
            groupBox3.Controls.Add(lblPrezimeProdavca);
            groupBox3.Controls.Add(lblImeProdavca);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(3, 446);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(337, 148);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "# Podaci o prodavcu:";
            // 
            // lblTelefonProdavca
            // 
            lblTelefonProdavca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTelefonProdavca.AutoSize = true;
            lblTelefonProdavca.Location = new Point(172, 114);
            lblTelefonProdavca.Name = "lblTelefonProdavca";
            lblTelefonProdavca.Size = new Size(12, 15);
            lblTelefonProdavca.TabIndex = 14;
            lblTelefonProdavca.Text = "/";
            // 
            // lblPozicijaProdavca
            // 
            lblPozicijaProdavca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPozicijaProdavca.AutoSize = true;
            lblPozicijaProdavca.Location = new Point(172, 87);
            lblPozicijaProdavca.Name = "lblPozicijaProdavca";
            lblPozicijaProdavca.Size = new Size(12, 15);
            lblPozicijaProdavca.TabIndex = 13;
            lblPozicijaProdavca.Text = "/";
            // 
            // lblPrezimeProdavca
            // 
            lblPrezimeProdavca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrezimeProdavca.AutoSize = true;
            lblPrezimeProdavca.Location = new Point(172, 58);
            lblPrezimeProdavca.Name = "lblPrezimeProdavca";
            lblPrezimeProdavca.Size = new Size(12, 15);
            lblPrezimeProdavca.TabIndex = 12;
            lblPrezimeProdavca.Text = "/";
            // 
            // lblImeProdavca
            // 
            lblImeProdavca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblImeProdavca.AutoSize = true;
            lblImeProdavca.Location = new Point(172, 31);
            lblImeProdavca.Name = "lblImeProdavca";
            lblImeProdavca.Size = new Size(12, 15);
            lblImeProdavca.TabIndex = 11;
            lblImeProdavca.Text = "/";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(344, 114);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 10;
            label5.Text = "/";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(344, 87);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 8;
            label7.Text = "/";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(344, 31);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 7;
            label8.Text = "/";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 114);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 6;
            label9.Text = "Kontakt telefon:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 87);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 4;
            label10.Text = "Pozicija:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(344, 58);
            label12.Name = "label12";
            label12.Size = new Size(12, 15);
            label12.TabIndex = 3;
            label12.Text = "/";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 58);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 2;
            label13.Text = "Prezime:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 31);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 0;
            label14.Text = "Ime:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lblKupacJe);
            groupBox2.Controls.Add(lbl11);
            groupBox2.Controls.Add(lblTelefonKupca);
            groupBox2.Controls.Add(lblEmailKupca);
            groupBox2.Controls.Add(lblPrezimeKupca);
            groupBox2.Controls.Add(lblImeKupca);
            groupBox2.Controls.Add(lbl4Kupac);
            groupBox2.Controls.Add(lbl3Kupac);
            groupBox2.Controls.Add(lbl2Kupac);
            groupBox2.Controls.Add(lbl1Kupac);
            groupBox2.Location = new Point(3, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 180);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "# Podaci o kupcu";
            // 
            // lblKupacJe
            // 
            lblKupacJe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblKupacJe.AutoSize = true;
            lblKupacJe.Location = new Point(172, 32);
            lblKupacJe.Name = "lblKupacJe";
            lblKupacJe.Size = new Size(12, 15);
            lblKupacJe.TabIndex = 9;
            lblKupacJe.Text = "/";
            // 
            // lbl11
            // 
            lbl11.AutoSize = true;
            lbl11.Location = new Point(6, 32);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(55, 15);
            lbl11.TabIndex = 8;
            lbl11.Text = "Kupac je:";
            // 
            // lblTelefonKupca
            // 
            lblTelefonKupca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTelefonKupca.AutoSize = true;
            lblTelefonKupca.Location = new Point(172, 153);
            lblTelefonKupca.Name = "lblTelefonKupca";
            lblTelefonKupca.Size = new Size(12, 15);
            lblTelefonKupca.TabIndex = 7;
            lblTelefonKupca.Text = "/";
            // 
            // lblEmailKupca
            // 
            lblEmailKupca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEmailKupca.AutoSize = true;
            lblEmailKupca.Location = new Point(172, 125);
            lblEmailKupca.Name = "lblEmailKupca";
            lblEmailKupca.Size = new Size(12, 15);
            lblEmailKupca.TabIndex = 6;
            lblEmailKupca.Text = "/";
            // 
            // lblPrezimeKupca
            // 
            lblPrezimeKupca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrezimeKupca.AutoSize = true;
            lblPrezimeKupca.Location = new Point(172, 93);
            lblPrezimeKupca.Name = "lblPrezimeKupca";
            lblPrezimeKupca.Size = new Size(12, 15);
            lblPrezimeKupca.TabIndex = 5;
            lblPrezimeKupca.Text = "/";
            // 
            // lblImeKupca
            // 
            lblImeKupca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblImeKupca.AutoSize = true;
            lblImeKupca.Location = new Point(172, 63);
            lblImeKupca.Name = "lblImeKupca";
            lblImeKupca.Size = new Size(12, 15);
            lblImeKupca.TabIndex = 4;
            lblImeKupca.Text = "/";
            // 
            // lbl4Kupac
            // 
            lbl4Kupac.AutoSize = true;
            lbl4Kupac.Location = new Point(6, 153);
            lbl4Kupac.Name = "lbl4Kupac";
            lbl4Kupac.Size = new Size(12, 15);
            lbl4Kupac.TabIndex = 3;
            lbl4Kupac.Text = "/";
            // 
            // lbl3Kupac
            // 
            lbl3Kupac.AutoSize = true;
            lbl3Kupac.Location = new Point(6, 125);
            lbl3Kupac.Name = "lbl3Kupac";
            lbl3Kupac.Size = new Size(12, 15);
            lbl3Kupac.TabIndex = 2;
            lbl3Kupac.Text = "/";
            // 
            // lbl2Kupac
            // 
            lbl2Kupac.AutoSize = true;
            lbl2Kupac.Location = new Point(6, 93);
            lbl2Kupac.Name = "lbl2Kupac";
            lbl2Kupac.Size = new Size(12, 15);
            lbl2Kupac.TabIndex = 1;
            lbl2Kupac.Text = "/";
            // 
            // lbl1Kupac
            // 
            lbl1Kupac.AutoSize = true;
            lbl1Kupac.Location = new Point(6, 63);
            lbl1Kupac.Name = "lbl1Kupac";
            lbl1Kupac.Size = new Size(12, 15);
            lbl1Kupac.TabIndex = 0;
            lbl1Kupac.Text = "/";
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
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 148);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "# Podaci o vozilu";
            // 
            // lblGodinaProizvodnje
            // 
            lblGodinaProizvodnje.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGodinaProizvodnje.AutoSize = true;
            lblGodinaProizvodnje.Location = new Point(172, 114);
            lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            lblGodinaProizvodnje.Size = new Size(12, 15);
            lblGodinaProizvodnje.TabIndex = 10;
            lblGodinaProizvodnje.Text = "/";
            // 
            // lblModel
            // 
            lblModel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblModel.AutoSize = true;
            lblModel.Location = new Point(172, 87);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(12, 15);
            lblModel.TabIndex = 8;
            lblModel.Text = "/";
            // 
            // lblBrojSasije
            // 
            lblBrojSasije.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBrojSasije.AutoSize = true;
            lblBrojSasije.Location = new Point(172, 31);
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
            lblStanje.Location = new Point(172, 58);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Label lblTelefonKupca;
        private Label lblEmailKupca;
        private Label lblPrezimeKupca;
        private Label lblImeKupca;
        private Label lbl4Kupac;
        private Label lbl3Kupac;
        private Label lbl2Kupac;
        private Label lbl1Kupac;
        private Label lblKupacJe;
        private Label lbl11;
        private GroupBox groupBox3;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblTelefonProdavca;
        private Label lblPozicijaProdavca;
        private Label lblPrezimeProdavca;
        private Label lblImeProdavca;
    }
}
