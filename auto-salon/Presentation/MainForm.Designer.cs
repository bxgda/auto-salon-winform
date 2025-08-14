namespace auto_salon
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tblMainLayout = new TableLayoutPanel();
            pnlDashboard = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btnPromotivnePonude = new Button();
            btnKupci = new Button();
            btnUgovori = new Button();
            btnVozila = new Button();
            btnZaposleni = new Button();
            btnSaloni = new Button();
            pnlContent = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnOcene = new Button();
            tblMainLayout.SuspendLayout();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMainLayout
            // 
            tblMainLayout.AutoScroll = true;
            tblMainLayout.ColumnCount = 2;
            tblMainLayout.ColumnStyles.Add(new ColumnStyle());
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.8630142F));
            tblMainLayout.Controls.Add(pnlDashboard, 0, 0);
            tblMainLayout.Controls.Add(pnlContent, 1, 0);
            tblMainLayout.Dock = DockStyle.Fill;
            tblMainLayout.Location = new Point(0, 0);
            tblMainLayout.Margin = new Padding(0);
            tblMainLayout.Name = "tblMainLayout";
            tblMainLayout.RowCount = 1;
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 860F));
            tblMainLayout.Size = new Size(1284, 839);
            tblMainLayout.TabIndex = 0;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = SystemColors.InactiveCaption;
            pnlDashboard.Controls.Add(btnOcene);
            pnlDashboard.Controls.Add(label2);
            pnlDashboard.Controls.Add(pictureBox2);
            pnlDashboard.Controls.Add(btnPromotivnePonude);
            pnlDashboard.Controls.Add(btnKupci);
            pnlDashboard.Controls.Add(btnUgovori);
            pnlDashboard.Controls.Add(btnVozila);
            pnlDashboard.Controls.Add(btnZaposleni);
            pnlDashboard.Controls.Add(btnSaloni);
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Location = new Point(0, 0);
            pnlDashboard.Margin = new Padding(0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(250, 839);
            pnlDashboard.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 34);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 9;
            label2.Text = "Lanac auto salona";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.garage256;
            pictureBox2.Location = new Point(12, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnPromotivnePonude
            // 
            btnPromotivnePonude.AutoSize = true;
            btnPromotivnePonude.BackColor = SystemColors.Control;
            btnPromotivnePonude.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPromotivnePonude.Image = Properties.Resources.percentage;
            btnPromotivnePonude.ImageAlign = ContentAlignment.MiddleLeft;
            btnPromotivnePonude.Location = new Point(4, 310);
            btnPromotivnePonude.Name = "btnPromotivnePonude";
            btnPromotivnePonude.Padding = new Padding(10, 0, 0, 0);
            btnPromotivnePonude.Size = new Size(243, 39);
            btnPromotivnePonude.TabIndex = 7;
            btnPromotivnePonude.Text = "Promotivne ponude";
            btnPromotivnePonude.UseVisualStyleBackColor = false;
            btnPromotivnePonude.Click += btnPromotivnePonude_Click;
            // 
            // btnKupci
            // 
            btnKupci.AutoSize = true;
            btnKupci.BackColor = SystemColors.Control;
            btnKupci.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKupci.Image = Properties.Resources.user_bag;
            btnKupci.ImageAlign = ContentAlignment.MiddleLeft;
            btnKupci.Location = new Point(4, 265);
            btnKupci.Name = "btnKupci";
            btnKupci.Padding = new Padding(10, 0, 0, 0);
            btnKupci.Size = new Size(243, 39);
            btnKupci.TabIndex = 6;
            btnKupci.Text = "Kupci";
            btnKupci.UseVisualStyleBackColor = false;
            btnKupci.Click += btnKupci_Click;
            // 
            // btnUgovori
            // 
            btnUgovori.AutoSize = true;
            btnUgovori.BackColor = SystemColors.Control;
            btnUgovori.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUgovori.Image = Properties.Resources.contract;
            btnUgovori.ImageAlign = ContentAlignment.MiddleLeft;
            btnUgovori.Location = new Point(4, 220);
            btnUgovori.Name = "btnUgovori";
            btnUgovori.Padding = new Padding(10, 0, 0, 0);
            btnUgovori.Size = new Size(243, 39);
            btnUgovori.TabIndex = 5;
            btnUgovori.Text = "Ugovori";
            btnUgovori.UseVisualStyleBackColor = false;
            btnUgovori.Click += btnUgovori_Click;
            // 
            // btnVozila
            // 
            btnVozila.AutoSize = true;
            btnVozila.BackColor = SystemColors.Control;
            btnVozila.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVozila.Image = Properties.Resources.cars;
            btnVozila.ImageAlign = ContentAlignment.MiddleLeft;
            btnVozila.Location = new Point(4, 175);
            btnVozila.Name = "btnVozila";
            btnVozila.Padding = new Padding(10, 0, 0, 0);
            btnVozila.Size = new Size(243, 39);
            btnVozila.TabIndex = 4;
            btnVozila.Text = "Vozila";
            btnVozila.UseVisualStyleBackColor = false;
            btnVozila.Click += btnVozila_Click;
            // 
            // btnZaposleni
            // 
            btnZaposleni.AutoSize = true;
            btnZaposleni.BackColor = SystemColors.Control;
            btnZaposleni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZaposleni.Image = Properties.Resources.users;
            btnZaposleni.ImageAlign = ContentAlignment.MiddleLeft;
            btnZaposleni.Location = new Point(4, 130);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Padding = new Padding(10, 0, 0, 0);
            btnZaposleni.Size = new Size(243, 39);
            btnZaposleni.TabIndex = 3;
            btnZaposleni.Text = "Zaposleni";
            btnZaposleni.UseVisualStyleBackColor = false;
            btnZaposleni.Click += btnZaposleni_Click;
            // 
            // btnSaloni
            // 
            btnSaloni.AutoSize = true;
            btnSaloni.BackColor = SystemColors.Control;
            btnSaloni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaloni.Image = Properties.Resources.garage_car;
            btnSaloni.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaloni.Location = new Point(4, 85);
            btnSaloni.Name = "btnSaloni";
            btnSaloni.Padding = new Padding(10, 0, 0, 0);
            btnSaloni.Size = new Size(243, 41);
            btnSaloni.TabIndex = 2;
            btnSaloni.Text = "Saloni";
            btnSaloni.UseVisualStyleBackColor = false;
            btnSaloni.Click += btnSaloni_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(253, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1028, 833);
            pnlContent.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tblMainLayout, 0, 0);
            tableLayoutPanel1.Controls.Add(statusStrip1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.89547F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1284, 861);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 839);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(1284, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(251, 17);
            toolStripStatusLabel1.Text = "Sistemi baza podataka © 2025 - Drugi projekat";
            // 
            // btnOcene
            // 
            btnOcene.AutoSize = true;
            btnOcene.BackColor = SystemColors.Control;
            btnOcene.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOcene.Image = Properties.Resources.feedback_review;
            btnOcene.ImageAlign = ContentAlignment.MiddleLeft;
            btnOcene.Location = new Point(4, 355);
            btnOcene.Name = "btnOcene";
            btnOcene.Padding = new Padding(10, 0, 0, 0);
            btnOcene.Size = new Size(243, 39);
            btnOcene.TabIndex = 10;
            btnOcene.Text = "Ocene";
            btnOcene.UseVisualStyleBackColor = false;
            btnOcene.Click += btnOcene_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 861);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1300, 900);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lanac Auto Salona";
            tblMainLayout.ResumeLayout(false);
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMainLayout;
        private Panel pnlDashboard;
        private Button btnSaloni;
        private Panel pnlContent;
        private Button btnZaposleni;
        private Button btnVozila;
        private Button btnUgovori;
        private Button btnKupci;
        private Button btnPromotivnePonude;
        private TableLayoutPanel tableLayoutPanel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Button btnOcene;
    }
}
