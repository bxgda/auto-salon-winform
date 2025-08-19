namespace auto_salon.Presentation.FOcene
{
    partial class OceniProdavca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OceniProdavca));
            tableLayoutPanel1 = new TableLayoutPanel();
            tcKupci = new TabControl();
            tpFizickoLice = new TabPage();
            lvFizickaLica = new ListView();
            tpPravnoLice = new TabPage();
            lvPravnaLica = new ListView();
            panel1 = new Panel();
            label2 = new Label();
            nupOcena = new NumericUpDown();
            panel2 = new Panel();
            btnSubmit = new Button();
            panel3 = new Panel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tcKupci.SuspendLayout();
            tpFizickoLice.SuspendLayout();
            tpPravnoLice.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupOcena).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tcKupci, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 3);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.625F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.Size = new Size(621, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tcKupci
            // 
            tcKupci.Controls.Add(tpFizickoLice);
            tcKupci.Controls.Add(tpPravnoLice);
            tcKupci.Dock = DockStyle.Fill;
            tcKupci.Location = new Point(3, 49);
            tcKupci.Name = "tcKupci";
            tcKupci.SelectedIndex = 0;
            tcKupci.Size = new Size(615, 269);
            tcKupci.TabIndex = 10;
            // 
            // tpFizickoLice
            // 
            tpFizickoLice.Controls.Add(lvFizickaLica);
            tpFizickoLice.Location = new Point(4, 24);
            tpFizickoLice.Name = "tpFizickoLice";
            tpFizickoLice.Padding = new Padding(3);
            tpFizickoLice.Size = new Size(607, 241);
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
            lvFizickaLica.Size = new Size(601, 235);
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
            tpPravnoLice.Size = new Size(607, 241);
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
            lvPravnaLica.Size = new Size(601, 235);
            lvPravnaLica.TabIndex = 1;
            lvPravnaLica.UseCompatibleStateImageBehavior = false;
            lvPravnaLica.View = View.Details;
            lvPravnaLica.SelectedIndexChanged += lvPravnaLica_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nupOcena);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 324);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 70);
            panel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 11);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "Ocena";
            // 
            // nupOcena
            // 
            nupOcena.DecimalPlaces = 1;
            nupOcena.Location = new Point(9, 29);
            nupOcena.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nupOcena.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nupOcena.Name = "nupOcena";
            nupOcena.Size = new Size(120, 23);
            nupOcena.TabIndex = 0;
            nupOcena.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(btnSubmit);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 47);
            panel2.TabIndex = 12;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.BackColor = Color.PaleGreen;
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Image = Properties.Resources.plus;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(422, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Padding = new Padding(10, 0, 0, 0);
            btnSubmit.Size = new Size(184, 39);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Dodaj ocenu";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(615, 40);
            panel3.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 21);
            label1.TabIndex = 1;
            label1.Text = "Izaberite kupca koji ocenjuje prodavca";
            // 
            // OceniProdavca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(637, 489);
            Name = "OceniProdavca";
            StartPosition = FormStartPosition.CenterParent;
            Text = "OceniProdavca";
            tableLayoutPanel1.ResumeLayout(false);
            tcKupci.ResumeLayout(false);
            tpFizickoLice.ResumeLayout(false);
            tpPravnoLice.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupOcena).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private NumericUpDown nupOcena;
        private Panel panel2;
        private Button btnSubmit;
        private Label label2;
        private Panel panel3;
        private Label label1;
    }
}