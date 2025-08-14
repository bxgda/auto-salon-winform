namespace auto_salon.Presentation.FOcene
{
    partial class OceneUC
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
            tcKupci = new TabControl();
            tpFizickoLice = new TabPage();
            lvFizickaLica = new ListView();
            tpPravnoLice = new TabPage();
            lvPravnaLica = new ListView();
            panel1 = new Panel();
            lblOcena = new Label();
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
            panel2 = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            tableLayoutPanel1.SuspendLayout();
            tcKupci.SuspendLayout();
            tpFizickoLice.SuspendLayout();
            tpPravnoLice.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.9281235F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.0718765F));
            tableLayoutPanel1.Controls.Add(tcKupci, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.48115F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5188541F));
            tableLayoutPanel1.Size = new Size(1042, 732);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tcKupci
            // 
            tcKupci.Controls.Add(tpFizickoLice);
            tcKupci.Controls.Add(tpPravnoLice);
            tcKupci.Dock = DockStyle.Fill;
            tcKupci.Location = new Point(3, 3);
            tcKupci.Name = "tcKupci";
            tcKupci.SelectedIndex = 0;
            tcKupci.Size = new Size(618, 634);
            tcKupci.TabIndex = 10;
            // 
            // tpFizickoLice
            // 
            tpFizickoLice.Controls.Add(lvFizickaLica);
            tpFizickoLice.Location = new Point(4, 24);
            tpFizickoLice.Name = "tpFizickoLice";
            tpFizickoLice.Padding = new Padding(3);
            tpFizickoLice.Size = new Size(610, 606);
            tpFizickoLice.TabIndex = 0;
            tpFizickoLice.Text = "Fizičko lice";
            tpFizickoLice.UseVisualStyleBackColor = true;
            // 
            // lvFizickaLica
            // 
            lvFizickaLica.Dock = DockStyle.Fill;
            lvFizickaLica.FullRowSelect = true;
            lvFizickaLica.GridLines = true;
            lvFizickaLica.Location = new Point(3, 3);
            lvFizickaLica.Name = "lvFizickaLica";
            lvFizickaLica.Size = new Size(604, 600);
            lvFizickaLica.TabIndex = 0;
            lvFizickaLica.UseCompatibleStateImageBehavior = false;
            lvFizickaLica.View = View.Details;
            lvFizickaLica.SelectedIndexChanged += lvFizickaLica_SelectedIndexChanged;
            // 
            // tpPravnoLice
            // 
            tpPravnoLice.Controls.Add(lvPravnaLica);
            tpPravnoLice.Location = new Point(4, 24);
            tpPravnoLice.Name = "tpPravnoLice";
            tpPravnoLice.Padding = new Padding(3);
            tpPravnoLice.Size = new Size(610, 606);
            tpPravnoLice.TabIndex = 1;
            tpPravnoLice.Text = "Pravno lice";
            tpPravnoLice.UseVisualStyleBackColor = true;
            // 
            // lvPravnaLica
            // 
            lvPravnaLica.Dock = DockStyle.Fill;
            lvPravnaLica.FullRowSelect = true;
            lvPravnaLica.GridLines = true;
            lvPravnaLica.Location = new Point(3, 3);
            lvPravnaLica.Name = "lvPravnaLica";
            lvPravnaLica.Size = new Size(604, 600);
            lvPravnaLica.TabIndex = 1;
            lvPravnaLica.UseCompatibleStateImageBehavior = false;
            lvPravnaLica.View = View.Details;
            lvPravnaLica.SelectedIndexChanged += lvPravnaLica_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblOcena);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(627, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 634);
            panel1.TabIndex = 11;
            // 
            // lblOcena
            // 
            lblOcena.AutoSize = true;
            lblOcena.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOcena.Location = new Point(12, 367);
            lblOcena.Name = "lblOcena";
            lblOcena.Size = new Size(0, 37);
            lblOcena.TabIndex = 6;
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
            groupBox3.Location = new Point(12, 210);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(387, 144);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "# Podaci o prodavcu:";
            // 
            // lblTelefonProdavca
            // 
            lblTelefonProdavca.AutoSize = true;
            lblTelefonProdavca.Location = new Point(199, 114);
            lblTelefonProdavca.Name = "lblTelefonProdavca";
            lblTelefonProdavca.Size = new Size(12, 15);
            lblTelefonProdavca.TabIndex = 14;
            lblTelefonProdavca.Text = "/";
            // 
            // lblPozicijaProdavca
            // 
            lblPozicijaProdavca.AutoSize = true;
            lblPozicijaProdavca.Location = new Point(199, 87);
            lblPozicijaProdavca.Name = "lblPozicijaProdavca";
            lblPozicijaProdavca.Size = new Size(12, 15);
            lblPozicijaProdavca.TabIndex = 13;
            lblPozicijaProdavca.Text = "/";
            // 
            // lblPrezimeProdavca
            // 
            lblPrezimeProdavca.AutoSize = true;
            lblPrezimeProdavca.Location = new Point(199, 58);
            lblPrezimeProdavca.Name = "lblPrezimeProdavca";
            lblPrezimeProdavca.Size = new Size(12, 15);
            lblPrezimeProdavca.TabIndex = 12;
            lblPrezimeProdavca.Text = "/";
            // 
            // lblImeProdavca
            // 
            lblImeProdavca.AutoSize = true;
            lblImeProdavca.Location = new Point(199, 31);
            lblImeProdavca.Name = "lblImeProdavca";
            lblImeProdavca.Size = new Size(12, 15);
            lblImeProdavca.TabIndex = 11;
            lblImeProdavca.Text = "/";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(531, 114);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 10;
            label5.Text = "/";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(531, 87);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 8;
            label7.Text = "/";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(531, 31);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 7;
            label8.Text = "/";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 114);
            label9.Name = "label9";
            label9.Size = new Size(91, 15);
            label9.TabIndex = 6;
            label9.Text = "Kontakt telefon:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 87);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 4;
            label10.Text = "Pozicija:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(531, 58);
            label12.Name = "label12";
            label12.Size = new Size(12, 15);
            label12.TabIndex = 3;
            label12.Text = "/";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 58);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 2;
            label13.Text = "Prezime:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 31);
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
            groupBox2.Location = new Point(12, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(387, 180);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "# Podaci o kupcu";
            // 
            // lblKupacJe
            // 
            lblKupacJe.AutoSize = true;
            lblKupacJe.Location = new Point(199, 32);
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
            lblTelefonKupca.AutoSize = true;
            lblTelefonKupca.Location = new Point(199, 153);
            lblTelefonKupca.Name = "lblTelefonKupca";
            lblTelefonKupca.Size = new Size(12, 15);
            lblTelefonKupca.TabIndex = 7;
            lblTelefonKupca.Text = "/";
            // 
            // lblEmailKupca
            // 
            lblEmailKupca.AutoSize = true;
            lblEmailKupca.Location = new Point(199, 125);
            lblEmailKupca.Name = "lblEmailKupca";
            lblEmailKupca.Size = new Size(12, 15);
            lblEmailKupca.TabIndex = 6;
            lblEmailKupca.Text = "/";
            // 
            // lblPrezimeKupca
            // 
            lblPrezimeKupca.AutoSize = true;
            lblPrezimeKupca.Location = new Point(199, 93);
            lblPrezimeKupca.Name = "lblPrezimeKupca";
            lblPrezimeKupca.Size = new Size(12, 15);
            lblPrezimeKupca.TabIndex = 5;
            lblPrezimeKupca.Text = "/";
            // 
            // lblImeKupca
            // 
            lblImeKupca.AutoSize = true;
            lblImeKupca.Location = new Point(199, 63);
            lblImeKupca.Name = "lblImeKupca";
            lblImeKupca.Size = new Size(12, 15);
            lblImeKupca.TabIndex = 4;
            lblImeKupca.Text = "/";
            // 
            // lbl4Kupac
            // 
            lbl4Kupac.AutoSize = true;
            lbl4Kupac.Location = new Point(15, 153);
            lbl4Kupac.Name = "lbl4Kupac";
            lbl4Kupac.Size = new Size(12, 15);
            lbl4Kupac.TabIndex = 3;
            lbl4Kupac.Text = "/";
            // 
            // lbl3Kupac
            // 
            lbl3Kupac.AutoSize = true;
            lbl3Kupac.Location = new Point(15, 125);
            lbl3Kupac.Name = "lbl3Kupac";
            lbl3Kupac.Size = new Size(12, 15);
            lbl3Kupac.TabIndex = 2;
            lbl3Kupac.Text = "/";
            // 
            // lbl2Kupac
            // 
            lbl2Kupac.AutoSize = true;
            lbl2Kupac.Location = new Point(15, 93);
            lbl2Kupac.Name = "lbl2Kupac";
            lbl2Kupac.Size = new Size(12, 15);
            lbl2Kupac.TabIndex = 1;
            lbl2Kupac.Text = "/";
            // 
            // lbl1Kupac
            // 
            lbl1Kupac.AutoSize = true;
            lbl1Kupac.Location = new Point(15, 63);
            lbl1Kupac.Name = "lbl1Kupac";
            lbl1Kupac.Size = new Size(12, 15);
            lbl1Kupac.TabIndex = 0;
            lbl1Kupac.Text = "/";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDelete);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 643);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 86);
            panel2.TabIndex = 12;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.pencil;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(118, 46);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(105, 37);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = Properties.Resources.trash;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(7, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(105, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // OceneUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OceneUC";
            Size = new Size(1042, 732);
            tableLayoutPanel1.ResumeLayout(false);
            tcKupci.ResumeLayout(false);
            tpFizickoLice.ResumeLayout(false);
            tpPravnoLice.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tcKupci;
        private TabPage tpFizickoLice;
        private ListView lvFizickaLica;
        private TabPage tpPravnoLice;
        private ListView lvPravnaLica;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label lblKupacJe;
        private Label lbl11;
        private Label lblTelefonKupca;
        private Label lblEmailKupca;
        private Label lblPrezimeKupca;
        private Label lblImeKupca;
        private Label lbl4Kupac;
        private Label lbl3Kupac;
        private Label lbl2Kupac;
        private Label lbl1Kupac;
        private GroupBox groupBox3;
        private Label lblTelefonProdavca;
        private Label lblPozicijaProdavca;
        private Label lblPrezimeProdavca;
        private Label lblImeProdavca;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblOcena;
        private Panel panel2;
        private Button btnDelete;
        private Button btnEdit;
    }
}
