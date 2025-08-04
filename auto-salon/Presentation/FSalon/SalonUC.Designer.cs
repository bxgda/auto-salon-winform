namespace auto_salon.Presentation.FSalon
{
    partial class SalonUC
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
            dgvSaloni = new DataGridView();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvSaloni).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSaloni
            // 
            dgvSaloni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaloni.Dock = DockStyle.Top;
            dgvSaloni.Location = new Point(0, 0);
            dgvSaloni.Name = "dgvSaloni";
            dgvSaloni.Size = new Size(750, 270);
            dgvSaloni.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(220, 20);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 37);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(8, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 37);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(114, 20);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 37);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Izmeni";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(3, 434);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 63);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Saloni";
            // 
            // SalonUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(groupBox1);
            Controls.Add(dgvSaloni);
            MinimumSize = new Size(750, 500);
            Name = "SalonUC";
            Size = new Size(750, 500);
            ((System.ComponentModel.ISupportInitialize)dgvSaloni).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSaloni;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private GroupBox groupBox1;
    }
}
