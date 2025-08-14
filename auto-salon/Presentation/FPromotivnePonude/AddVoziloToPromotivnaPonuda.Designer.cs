namespace auto_salon.Presentation.FPromotivnePonude
{
    partial class AddVoziloToPromotivnaPonuda
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lvVozila = new ListView();
            panel1 = new Panel();
            btnPotvrdi = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lvVozila, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lvVozila
            // 
            lvVozila.Dock = DockStyle.Fill;
            lvVozila.FullRowSelect = true;
            lvVozila.GridLines = true;
            lvVozila.Location = new Point(3, 3);
            lvVozila.Name = "lvVozila";
            lvVozila.Size = new Size(794, 369);
            lvVozila.TabIndex = 0;
            lvVozila.UseCompatibleStateImageBehavior = false;
            lvVozila.View = View.Details;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPotvrdi);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 378);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 69);
            panel1.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPotvrdi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPotvrdi.Image = Properties.Resources.check_circle;
            btnPotvrdi.ImageAlign = ContentAlignment.MiddleLeft;
            btnPotvrdi.Location = new Point(3, 29);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Padding = new Padding(10, 0, 0, 0);
            btnPotvrdi.Size = new Size(156, 37);
            btnPotvrdi.TabIndex = 6;
            btnPotvrdi.Text = "Potvrdi izabrane";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(604, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 15);
            label1.TabIndex = 7;
            label1.Text = "Izaberite jedno ili više vozila iz liste";
            // 
            // AddVoziloToPromotivnaPonuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(816, 489);
            Name = "AddVoziloToPromotivnaPonuda";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddVoziloToPromotivnaPonuda";
            Load += AddVoziloToPromotivnaPonuda_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView lvVozila;
        private Panel panel1;
        private Button btnPotvrdi;
        private Label label1;
    }
}