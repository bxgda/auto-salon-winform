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
            tblMainLayout = new TableLayoutPanel();
            pnlDashboard = new Panel();
            btnPromotivnePonude = new Button();
            btnKupci = new Button();
            btnUgovori = new Button();
            btnVozila = new Button();
            btnZaposleni = new Button();
            btnSaloni = new Button();
            lblTitle = new Label();
            pnlContent = new Panel();
            tblMainLayout.SuspendLayout();
            pnlDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // tblMainLayout
            // 
            tblMainLayout.AutoScroll = true;
            tblMainLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblMainLayout.ColumnCount = 2;
            tblMainLayout.ColumnStyles.Add(new ColumnStyle());
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.8630142F));
            tblMainLayout.Controls.Add(pnlDashboard, 0, 0);
            tblMainLayout.Controls.Add(pnlContent, 1, 0);
            tblMainLayout.Dock = DockStyle.Fill;
            tblMainLayout.Location = new Point(0, 0);
            tblMainLayout.Name = "tblMainLayout";
            tblMainLayout.RowCount = 1;
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 860F));
            tblMainLayout.Size = new Size(1284, 861);
            tblMainLayout.TabIndex = 0;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = SystemColors.InactiveCaption;
            pnlDashboard.Controls.Add(btnPromotivnePonude);
            pnlDashboard.Controls.Add(btnKupci);
            pnlDashboard.Controls.Add(btnUgovori);
            pnlDashboard.Controls.Add(btnVozila);
            pnlDashboard.Controls.Add(btnZaposleni);
            pnlDashboard.Controls.Add(btnSaloni);
            pnlDashboard.Controls.Add(lblTitle);
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Location = new Point(1, 1);
            pnlDashboard.Margin = new Padding(0);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(250, 859);
            pnlDashboard.TabIndex = 0;
            // 
            // btnPromotivnePonude
            // 
            btnPromotivnePonude.AutoSize = true;
            btnPromotivnePonude.BackColor = SystemColors.Control;
            btnPromotivnePonude.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPromotivnePonude.Image = Properties.Resources.user_bag;
            btnPromotivnePonude.ImageAlign = ContentAlignment.MiddleLeft;
            btnPromotivnePonude.Location = new Point(3, 284);
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
            btnKupci.Location = new Point(3, 239);
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
            btnUgovori.Location = new Point(3, 194);
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
            btnVozila.Location = new Point(3, 149);
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
            btnZaposleni.Location = new Point(3, 104);
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
            btnSaloni.Location = new Point(3, 59);
            btnSaloni.Name = "btnSaloni";
            btnSaloni.Padding = new Padding(10, 0, 0, 0);
            btnSaloni.Size = new Size(243, 41);
            btnSaloni.TabIndex = 2;
            btnSaloni.Text = "Saloni";
            btnSaloni.UseVisualStyleBackColor = false;
            btnSaloni.Click += btnSaloni_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(43, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Auto Salon";
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(255, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1025, 853);
            pnlContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 861);
            Controls.Add(tblMainLayout);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1300, 900);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Salon";
            tblMainLayout.ResumeLayout(false);
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMainLayout;
        private Panel pnlDashboard;
        private Label lblTitle;
        private Button btnSaloni;
        private Panel pnlContent;
        private Button btnZaposleni;
        private Button btnVozila;
        private Button btnUgovori;
        private Button btnKupci;
        private Button btnPromotivnePonude;
    }
}
