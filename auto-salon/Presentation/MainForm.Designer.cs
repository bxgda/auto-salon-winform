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
            tblMainLayout.Size = new Size(984, 561);
            tblMainLayout.TabIndex = 0;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(btnVozila);
            pnlDashboard.Controls.Add(btnZaposleni);
            pnlDashboard.Controls.Add(btnSaloni);
            pnlDashboard.Controls.Add(lblTitle);
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Location = new Point(4, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(250, 553);
            pnlDashboard.TabIndex = 0;
            // 
            // btnVozila
            // 
            btnVozila.AutoSize = true;
            btnVozila.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVozila.Location = new Point(3, 149);
            btnVozila.Name = "btnVozila";
            btnVozila.Size = new Size(244, 39);
            btnVozila.TabIndex = 4;
            btnVozila.Text = "Vozila";
            btnVozila.UseVisualStyleBackColor = true;
            btnVozila.Click += btnVozila_Click;
            // 
            // btnZaposleni
            // 
            btnZaposleni.AutoSize = true;
            btnZaposleni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZaposleni.Location = new Point(3, 104);
            btnZaposleni.Name = "btnZaposleni";
            btnZaposleni.Size = new Size(244, 39);
            btnZaposleni.TabIndex = 3;
            btnZaposleni.Text = "Zaposleni";
            btnZaposleni.UseVisualStyleBackColor = true;
            btnZaposleni.Click += btnZaposleni_Click;
            // 
            // btnSaloni
            // 
            btnSaloni.AutoSize = true;
            btnSaloni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaloni.Location = new Point(3, 59);
            btnSaloni.Name = "btnSaloni";
            btnSaloni.Size = new Size(244, 39);
            btnSaloni.TabIndex = 2;
            btnSaloni.Text = "Saloni";
            btnSaloni.UseVisualStyleBackColor = true;
            btnSaloni.Click += btnSaloni_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(8, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(115, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Auto Salon";
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(261, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(719, 553);
            pnlContent.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tblMainLayout);
            MinimumSize = new Size(1000, 600);
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
    }
}
