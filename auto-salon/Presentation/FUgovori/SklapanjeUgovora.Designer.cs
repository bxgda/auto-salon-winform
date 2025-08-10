namespace auto_salon.Presentation.FUgovori
{
    partial class SklapanjeUgovora
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
            lvProdavci = new ListView();
            label1 = new Label();
            label4 = new Label();
            btnSubmit = new Button();
            tblMain = new TableLayoutPanel();
            tblLeft = new TableLayoutPanel();
            panel2 = new Panel();
            tblProdavci = new TableLayoutPanel();
            tblKupci = new TableLayoutPanel();
            label2 = new Label();
            tcKupci = new TabControl();
            tabPage1 = new TabPage();
            lvFizickaLica = new ListView();
            tabPage2 = new TabPage();
            lvPravnaLica = new ListView();
            btnDodajKupca = new Button();
            groupBox1 = new GroupBox();
            tblMain.SuspendLayout();
            tblLeft.SuspendLayout();
            panel2.SuspendLayout();
            tblProdavci.SuspendLayout();
            tblKupci.SuspendLayout();
            tcKupci.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lvProdavci
            // 
            lvProdavci.Dock = DockStyle.Fill;
            lvProdavci.FullRowSelect = true;
            lvProdavci.GridLines = true;
            lvProdavci.Location = new Point(3, 23);
            lvProdavci.Name = "lvProdavci";
            lvProdavci.Size = new Size(647, 303);
            lvProdavci.TabIndex = 0;
            lvProdavci.UseCompatibleStateImageBehavior = false;
            lvProdavci.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Prodavci salona";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(18, 15);
            label4.Name = "label4";
            label4.Size = new Size(423, 28);
            label4.TabIndex = 6;
            label4.Text = "Izaberite kupca i prodavca koji sklapaju ugovor";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(747, 787);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(194, 46);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Kreiraj ugovor";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.64557F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.3544312F));
            tblMain.Controls.Add(tblLeft, 0, 1);
            tblMain.Controls.Add(btnSubmit, 1, 2);
            tblMain.Controls.Add(groupBox1, 1, 1);
            tblMain.Controls.Add(label4, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(15);
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 703F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(959, 851);
            tblMain.TabIndex = 9;
            // 
            // tblLeft
            // 
            tblLeft.ColumnCount = 1;
            tblLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLeft.Controls.Add(panel2, 0, 1);
            tblLeft.Controls.Add(tblKupci, 0, 0);
            tblLeft.Dock = DockStyle.Fill;
            tblLeft.Location = new Point(18, 52);
            tblLeft.Name = "tblLeft";
            tblLeft.RowCount = 2;
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 51.93687F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 48.06313F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLeft.Size = new Size(659, 697);
            tblLeft.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(tblProdavci);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 329);
            panel2.TabIndex = 1;
            // 
            // tblProdavci
            // 
            tblProdavci.ColumnCount = 1;
            tblProdavci.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblProdavci.Controls.Add(label1, 0, 0);
            tblProdavci.Controls.Add(lvProdavci, 0, 1);
            tblProdavci.Dock = DockStyle.Fill;
            tblProdavci.Location = new Point(0, 0);
            tblProdavci.Name = "tblProdavci";
            tblProdavci.RowCount = 2;
            tblProdavci.RowStyles.Add(new RowStyle());
            tblProdavci.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblProdavci.RowStyles.Add(new RowStyle());
            tblProdavci.Size = new Size(653, 329);
            tblProdavci.TabIndex = 0;
            // 
            // tblKupci
            // 
            tblKupci.ColumnCount = 1;
            tblKupci.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblKupci.Controls.Add(label2, 0, 0);
            tblKupci.Controls.Add(tcKupci, 0, 1);
            tblKupci.Controls.Add(btnDodajKupca, 0, 2);
            tblKupci.Dock = DockStyle.Fill;
            tblKupci.Location = new Point(3, 3);
            tblKupci.Name = "tblKupci";
            tblKupci.RowCount = 3;
            tblKupci.RowStyles.Add(new RowStyle());
            tblKupci.RowStyles.Add(new RowStyle(SizeType.Absolute, 288F));
            tblKupci.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblKupci.Size = new Size(653, 356);
            tblKupci.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Kupci";
            // 
            // tcKupci
            // 
            tcKupci.Controls.Add(tabPage1);
            tcKupci.Controls.Add(tabPage2);
            tcKupci.Dock = DockStyle.Fill;
            tcKupci.Location = new Point(3, 23);
            tcKupci.Name = "tcKupci";
            tcKupci.SelectedIndex = 0;
            tcKupci.Size = new Size(647, 282);
            tcKupci.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lvFizickaLica);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(639, 254);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Fizičko lice";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvFizickaLica
            // 
            lvFizickaLica.Dock = DockStyle.Fill;
            lvFizickaLica.FullRowSelect = true;
            lvFizickaLica.GridLines = true;
            lvFizickaLica.Location = new Point(3, 3);
            lvFizickaLica.Name = "lvFizickaLica";
            lvFizickaLica.Size = new Size(633, 248);
            lvFizickaLica.TabIndex = 0;
            lvFizickaLica.UseCompatibleStateImageBehavior = false;
            lvFizickaLica.View = View.Details;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lvPravnaLica);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(639, 254);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pravno lice";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvPravnaLica
            // 
            lvPravnaLica.Dock = DockStyle.Fill;
            lvPravnaLica.FullRowSelect = true;
            lvPravnaLica.GridLines = true;
            lvPravnaLica.Location = new Point(3, 3);
            lvPravnaLica.Name = "lvPravnaLica";
            lvPravnaLica.Size = new Size(633, 248);
            lvPravnaLica.TabIndex = 1;
            lvPravnaLica.UseCompatibleStateImageBehavior = false;
            lvPravnaLica.View = View.Details;
            // 
            // btnDodajKupca
            // 
            btnDodajKupca.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDodajKupca.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDodajKupca.Location = new Point(494, 316);
            btnDodajKupca.Name = "btnDodajKupca";
            btnDodajKupca.Size = new Size(156, 37);
            btnDodajKupca.TabIndex = 6;
            btnDodajKupca.Text = "Dodaj kupca";
            btnDodajKupca.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(683, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 697);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "# Podaci o vozilu";
            // 
            // SklapanjeUgovora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 851);
            Controls.Add(tblMain);
            MinimumSize = new Size(867, 890);
            Name = "SklapanjeUgovora";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sklapanje ugovora";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblLeft.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tblProdavci.ResumeLayout(false);
            tblProdavci.PerformLayout();
            tblKupci.ResumeLayout(false);
            tblKupci.PerformLayout();
            tcKupci.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvProdavci;
        private Label label1;
        private Label label4;
        private Button btnSubmit;
        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblLeft;
        private Panel panel2;
        private TableLayoutPanel tblProdavci;
        private GroupBox groupBox1;
        private TableLayoutPanel tblKupci;
        private Label label2;
        private Button btnDodajKupca;
        private TabControl tcKupci;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView lvFizickaLica;
        private ListView lvPravnaLica;
    }
}