namespace auto_salon.Presentation.FProizvodjacNudi
{
    partial class ProizvodjacNudiUC
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
            lvSaloni = new ListView();
            lvProizvodjaci = new ListView();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lvSaloni, 0, 3);
            tableLayoutPanel1.Controls.Add(lvProizvodjaci, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.238606F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.76139F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 289F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(990, 746);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lvSaloni
            // 
            lvSaloni.Dock = DockStyle.Fill;
            lvSaloni.FullRowSelect = true;
            lvSaloni.GridLines = true;
            lvSaloni.Location = new Point(3, 401);
            lvSaloni.Name = "lvSaloni";
            lvSaloni.Size = new Size(984, 283);
            lvSaloni.TabIndex = 4;
            lvSaloni.UseCompatibleStateImageBehavior = false;
            lvSaloni.View = View.Details;
            // 
            // lvProizvodjaci
            // 
            lvProizvodjaci.Dock = DockStyle.Fill;
            lvProizvodjaci.FullRowSelect = true;
            lvProizvodjaci.GridLines = true;
            lvProizvodjaci.Location = new Point(3, 29);
            lvProizvodjaci.Name = "lvProizvodjaci";
            lvProizvodjaci.Size = new Size(984, 337);
            lvProizvodjaci.TabIndex = 1;
            lvProizvodjaci.UseCompatibleStateImageBehavior = false;
            lvProizvodjaci.View = View.Details;
            lvProizvodjaci.SelectedIndexChanged += lvProizvodjaci_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Proizvođači:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 369);
            label2.Name = "label2";
            label2.Size = new Size(276, 15);
            label2.TabIndex = 2;
            label2.Text = "Saloni kojima izabrani proizvođač nudi svoja vozila:";
            // 
            // ProizvodjacNudiUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ProizvodjacNudiUC";
            Size = new Size(990, 746);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ListView lvProizvodjaci;
        private Label label2;
        private ListView lvSaloni;
    }
}
