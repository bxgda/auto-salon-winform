namespace auto_salon.Presentation.FPromotivnePonude
{
    partial class PromotivnaPonudaUC
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
            lvPromotivnePonude = new ListView();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lvPromotivnePonude, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.4459457F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.5540543F));
            tableLayoutPanel1.Size = new Size(843, 592);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lvPromotivnePonude
            // 
            lvPromotivnePonude.Dock = DockStyle.Fill;
            lvPromotivnePonude.FullRowSelect = true;
            lvPromotivnePonude.GridLines = true;
            lvPromotivnePonude.Location = new Point(3, 3);
            lvPromotivnePonude.Name = "lvPromotivnePonude";
            lvPromotivnePonude.Size = new Size(837, 488);
            lvPromotivnePonude.TabIndex = 0;
            lvPromotivnePonude.UseCompatibleStateImageBehavior = false;
            lvPromotivnePonude.View = View.Details;
            // 
            // PromotivnaPonudaUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PromotivnaPonudaUC";
            Size = new Size(843, 592);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView lvPromotivnePonude;
    }
}
