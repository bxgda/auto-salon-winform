namespace auto_salon.Presentation.FProizvodjacNudi
{
    partial class AddSalonToNudi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSalonToNudi));
            tableLayoutPanel1 = new TableLayoutPanel();
            lvSaloni = new ListView();
            panel1 = new Panel();
            label1 = new Label();
            btnPotvrdi = new Button();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lvSaloni, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.44444F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5555553F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lvSaloni
            // 
            lvSaloni.Dock = DockStyle.Fill;
            lvSaloni.FullRowSelect = true;
            lvSaloni.GridLines = true;
            lvSaloni.Location = new Point(3, 3);
            lvSaloni.Name = "lvSaloni";
            lvSaloni.Size = new Size(794, 374);
            lvSaloni.TabIndex = 1;
            lvSaloni.UseCompatibleStateImageBehavior = false;
            lvSaloni.View = View.Details;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPotvrdi);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 383);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 64);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(601, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 8;
            label1.Text = "Izaberite jedan ili više salona iz liste";
            // 
            // btnPotvrdi
            // 
            btnPotvrdi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPotvrdi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPotvrdi.Image = Properties.Resources.check_circle;
            btnPotvrdi.ImageAlign = ContentAlignment.MiddleLeft;
            btnPotvrdi.Location = new Point(3, 24);
            btnPotvrdi.Name = "btnPotvrdi";
            btnPotvrdi.Padding = new Padding(10, 0, 0, 0);
            btnPotvrdi.Size = new Size(179, 37);
            btnPotvrdi.TabIndex = 7;
            btnPotvrdi.Text = "Potvrdi izabrane";
            btnPotvrdi.UseVisualStyleBackColor = true;
            btnPotvrdi.Click += btnPotvrdi_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(438, 24);
            label2.Name = "label2";
            label2.Size = new Size(356, 15);
            label2.TabIndex = 9;
            label2.Text = "Izabrani saloni će nakon potvrde moći da nude vozila proizvođača.";
            // 
            // AddSalonToNudi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "AddSalonToNudi";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj salone u ponude proizvođača";
            Load += AddSalonToNudi_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView lvSaloni;
        private Panel panel1;
        private Button btnPotvrdi;
        private Label label1;
        private Label label2;
    }
}