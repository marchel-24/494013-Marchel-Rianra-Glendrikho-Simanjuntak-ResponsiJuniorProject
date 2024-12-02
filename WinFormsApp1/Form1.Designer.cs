namespace WinFormsApp1
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbNama = new TextBox();
            listBox1 = new ListBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            cbDep = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cbJabatan = new ComboBox();
            LbEmpID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoPiringPeduli;
            pictureBox1.Location = new Point(24, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 28);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 1;
            label1.Text = "Piring Peduli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 103);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 2;
            label2.Text = "Nama Karyawan ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 150);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 3;
            label3.Text = "Dep. Karyawan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(184, 103);
            label4.Name = "label4";
            label4.Size = new Size(12, 19);
            label4.TabIndex = 4;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(184, 150);
            label5.Name = "label5";
            label5.Size = new Size(12, 19);
            label5.TabIndex = 5;
            label5.Text = ":";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(219, 99);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(127, 23);
            tbNama.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ScrollBar;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID Departemen:", "HR : HR", "ENG : Engineer", "DEV : Developer", "PM : Product M", "FIN : Finance" });
            listBox1.Location = new Point(664, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(124, 109);
            listBox1.TabIndex = 8;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(24, 201);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(106, 44);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(163, 201);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(106, 44);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(303, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 44);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(24, 251);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(744, 187);
            dgvData.TabIndex = 12;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDep.Location = new Point(219, 146);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(127, 23);
            cbDep.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(397, 103);
            label6.Name = "label6";
            label6.Size = new Size(55, 19);
            label6.TabIndex = 14;
            label6.Text = "Jabatan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(475, 103);
            label7.Name = "label7";
            label7.Size = new Size(12, 19);
            label7.TabIndex = 15;
            label7.Text = ":";
            // 
            // cbJabatan
            // 
            cbJabatan.FormattingEnabled = true;
            cbJabatan.Items.AddRange(new object[] { "Admin", "Manager", "Petinggi" });
            cbJabatan.Location = new Point(510, 99);
            cbJabatan.Name = "cbJabatan";
            cbJabatan.Size = new Size(121, 23);
            cbJabatan.TabIndex = 16;
            // 
            // LbEmpID
            // 
            LbEmpID.AutoSize = true;
            LbEmpID.Location = new Point(397, 153);
            LbEmpID.Name = "LbEmpID";
            LbEmpID.Size = new Size(0, 15);
            LbEmpID.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LbEmpID);
            Controls.Add(cbJabatan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbDep);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(listBox1);
            Controls.Add(tbNama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNama;
        private ListBox listBox1;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private ComboBox cbDep;
        private Label label6;
        private Label label7;
        private ComboBox cbJabatan;
        private Label LbEmpID;
    }
}
