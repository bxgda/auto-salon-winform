namespace auto_salon.Presentation.FServisnaStavka
{
    partial class ServisnaIstorijaVozila
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
            lvServisneStavke = new ListView();
            panel1 = new Panel();
            btnAdd = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lvServisneStavke, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel1.Size = new Size(688, 511);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lvServisneStavke
            // 
            lvServisneStavke.Dock = DockStyle.Fill;
            lvServisneStavke.FullRowSelect = true;
            lvServisneStavke.GridLines = true;
            lvServisneStavke.Location = new Point(3, 3);
            lvServisneStavke.Name = "lvServisneStavke";
            lvServisneStavke.Size = new Size(682, 433);
            lvServisneStavke.TabIndex = 0;
            lvServisneStavke.UseCompatibleStateImageBehavior = false;
            lvServisneStavke.View = View.Details;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 442);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 66);
            panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(3, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 37);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ServisnaIstorijaVozila
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 511);
            Controls.Add(tableLayoutPanel1);
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "ServisnaIstorijaVozila";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ServisnaIstorijaVozila";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView lvServisneStavke;
        private Panel panel1;
        private Button btnAdd;
    }
}