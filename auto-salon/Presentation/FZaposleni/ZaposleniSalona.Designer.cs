namespace auto_salon.Presentation.FZaposleni
{
    partial class ZaposleniSalona
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
            panel1 = new Panel();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            lvZaposleni = new ListView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(lvZaposleni, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.8888855F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.11111F));
            tableLayoutPanel1.Size = new Size(952, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 376);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 71);
            panel1.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(97, 31);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 37);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(3, 31);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 37);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(191, 31);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 37);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvZaposleni
            // 
            lvZaposleni.Dock = DockStyle.Fill;
            lvZaposleni.FullRowSelect = true;
            lvZaposleni.GridLines = true;
            lvZaposleni.Location = new Point(3, 3);
            lvZaposleni.Name = "lvZaposleni";
            lvZaposleni.Size = new Size(946, 367);
            lvZaposleni.TabIndex = 2;
            lvZaposleni.UseCompatibleStateImageBehavior = false;
            lvZaposleni.View = View.Details;
            // 
            // ZaposleniSalona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 450);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(332, 489);
            Name = "ZaposleniSalona";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ZaposleniSalona";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnDelete;
        private Button btnAdd;
        private ListView lvZaposleni;
        private Button btnEdit;
    }
}