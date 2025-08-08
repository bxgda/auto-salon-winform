namespace auto_salon.Presentation.FUgovori
{
    partial class SklapanjeUgovora
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
            lvProdavci = new ListView();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            btnAddKupca = new Button();
            label4 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lvProdavci
            // 
            lvProdavci.FullRowSelect = true;
            lvProdavci.GridLines = true;
            lvProdavci.Location = new Point(12, 399);
            lvProdavci.Name = "lvProdavci";
            lvProdavci.Size = new Size(455, 289);
            lvProdavci.TabIndex = 0;
            lvProdavci.UseCompatibleStateImageBehavior = false;
            lvProdavci.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 376);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Prodavci salona";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Kupci";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(489, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 568);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 312);
            label3.Name = "label3";
            label3.Size = new Size(217, 15);
            label3.TabIndex = 0;
            label3.Text = "Ovde moze info o vozilu koje se prodaje";
            // 
            // btnAddKupca
            // 
            btnAddKupca.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddKupca.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddKupca.Location = new Point(322, 327);
            btnAddKupca.Name = "btnAddKupca";
            btnAddKupca.Size = new Size(145, 37);
            btnAddKupca.TabIndex = 5;
            btnAddKupca.Text = "Dodaj novog kupca";
            btnAddKupca.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(334, 21);
            label4.TabIndex = 6;
            label4.Text = "Izaberite kupca i prodavca koji sklapaju ugovor";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(553, 712);
            button1.Name = "button1";
            button1.Size = new Size(194, 49);
            button1.TabIndex = 7;
            button1.Text = "Kreiraj ugovor";
            button1.UseVisualStyleBackColor = true;
            // 
            // SklapanjeUgovora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 773);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(btnAddKupca);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvProdavci);
            Name = "SklapanjeUgovora";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SklapanjeUgovora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvProdavci;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnAddKupca;
        private Label label4;
        private Button button1;
    }
}