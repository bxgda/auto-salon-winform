namespace auto_salon.Presentation.FKupac
{
    partial class KupacUC
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
            btnEdit = new Button();
            btnAdd = new Button();
            tcKupci = new TabControl();
            tpFizickoLice = new TabPage();
            lvFizickaLica = new ListView();
            tpPravnoLice = new TabPage();
            lvPravnaLica = new ListView();
            panel2 = new Panel();
            tbxSearch = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tcKupci.SuspendLayout();
            tpFizickoLice.SuspendLayout();
            tpPravnoLice.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(tcKupci, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 637F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.Size = new Size(968, 775);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 690);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 82);
            panel1.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.BackColor = Color.Khaki;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Image = Properties.Resources.pencil;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(112, 42);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(108, 37);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.PaleGreen;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(3, 42);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(103, 37);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tcKupci
            // 
            tcKupci.Controls.Add(tpFizickoLice);
            tcKupci.Controls.Add(tpPravnoLice);
            tcKupci.Dock = DockStyle.Fill;
            tcKupci.Location = new Point(3, 53);
            tcKupci.Name = "tcKupci";
            tcKupci.SelectedIndex = 0;
            tcKupci.Size = new Size(962, 631);
            tcKupci.TabIndex = 9;
            tcKupci.SelectedIndexChanged += tcKupci_SelectedIndexChanged;
            // 
            // tpFizickoLice
            // 
            tpFizickoLice.Controls.Add(lvFizickaLica);
            tpFizickoLice.Location = new Point(4, 24);
            tpFizickoLice.Name = "tpFizickoLice";
            tpFizickoLice.Padding = new Padding(3);
            tpFizickoLice.Size = new Size(954, 603);
            tpFizickoLice.TabIndex = 0;
            tpFizickoLice.Text = "Fizičko lice";
            tpFizickoLice.UseVisualStyleBackColor = true;
            // 
            // lvFizickaLica
            // 
            lvFizickaLica.BackColor = SystemColors.Window;
            lvFizickaLica.Dock = DockStyle.Fill;
            lvFizickaLica.FullRowSelect = true;
            lvFizickaLica.GridLines = true;
            lvFizickaLica.Location = new Point(3, 3);
            lvFizickaLica.Name = "lvFizickaLica";
            lvFizickaLica.Size = new Size(948, 597);
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
            tpPravnoLice.Size = new Size(954, 603);
            tpPravnoLice.TabIndex = 1;
            tpPravnoLice.Text = "Pravno lice";
            tpPravnoLice.UseVisualStyleBackColor = true;
            // 
            // lvPravnaLica
            // 
            lvPravnaLica.BackColor = SystemColors.Window;
            lvPravnaLica.Dock = DockStyle.Fill;
            lvPravnaLica.FullRowSelect = true;
            lvPravnaLica.GridLines = true;
            lvPravnaLica.Location = new Point(3, 3);
            lvPravnaLica.Name = "lvPravnaLica";
            lvPravnaLica.Size = new Size(948, 597);
            lvPravnaLica.TabIndex = 1;
            lvPravnaLica.UseCompatibleStateImageBehavior = false;
            lvPravnaLica.View = View.Details;
            lvPravnaLica.SelectedIndexChanged += lvPravnaLica_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(tbxSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(962, 44);
            panel2.TabIndex = 10;
            // 
            // tbxSearch
            // 
            tbxSearch.ForeColor = SystemColors.WindowText;
            tbxSearch.Location = new Point(7, 10);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(198, 23);
            tbxSearch.TabIndex = 0;
            tbxSearch.Text = "Pretraga...";
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            tbxSearch.Enter += RemoveText;
            tbxSearch.Leave += AddText;
            // 
            // KupacUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "KupacUC";
            Size = new Size(968, 775);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tcKupci.ResumeLayout(false);
            tpFizickoLice.ResumeLayout(false);
            tpPravnoLice.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnAdd;
        private TabControl tcKupci;
        private TabPage tpFizickoLice;
        private ListView lvFizickaLica;
        private TabPage tpPravnoLice;
        private ListView lvPravnaLica;
        private Button btnEdit;
        private Panel panel2;
        private TextBox tbxSearch;
    }
}
