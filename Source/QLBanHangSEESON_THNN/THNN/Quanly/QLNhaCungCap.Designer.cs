namespace THNN.Quanly
{
    partial class QLNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNhaCungCap));
            panel1 = new Panel();
            dgvncc = new DataGridView();
            groupBox1 = new GroupBox();
            txttimkiemncc = new TextBox();
            btntimkiem = new Button();
            label9 = new Label();
            grbkh = new GroupBox();
            txtemailncc = new TextBox();
            label2 = new Label();
            txtsdtncc = new TextBox();
            txttenncc = new TextBox();
            txtmncc = new TextBox();
            label3 = new Label();
            txtmkh = new Label();
            label1 = new Label();
            btnxoa = new Button();
            btnload = new Button();
            btnsua = new Button();
            btnthoat = new Button();
            btnthem = new Button();
            label15 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvncc).BeginInit();
            groupBox1.SuspendLayout();
            grbkh.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(dgvncc);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(grbkh);
            panel1.Controls.Add(btnxoa);
            panel1.Controls.Add(btnload);
            panel1.Controls.Add(btnsua);
            panel1.Controls.Add(btnthoat);
            panel1.Controls.Add(btnthem);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 550);
            panel1.TabIndex = 0;
            // 
            // dgvncc
            // 
            dgvncc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvncc.Location = new Point(361, 197);
            dgvncc.Name = "dgvncc";
            dgvncc.RowHeadersWidth = 51;
            dgvncc.Size = new Size(617, 188);
            dgvncc.TabIndex = 32;
            dgvncc.CellContentClick += dgvncc_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txttimkiemncc);
            groupBox1.Controls.Add(btntimkiem);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(361, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 81);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm thông tin nhà cung cấp";
            // 
            // txttimkiemncc
            // 
            txttimkiemncc.Location = new Point(157, 32);
            txttimkiemncc.Name = "txttimkiemncc";
            txttimkiemncc.Size = new Size(180, 27);
            txttimkiemncc.TabIndex = 12;
            // 
            // btntimkiem
            // 
            btntimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntimkiem.Location = new Point(357, 23);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(99, 40);
            btntimkiem.TabIndex = 9;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 35);
            label9.Name = "label9";
            label9.Size = new Size(145, 20);
            label9.TabIndex = 12;
            label9.Text = "Nhập số điện thoại:";
            // 
            // grbkh
            // 
            grbkh.BackColor = Color.Transparent;
            grbkh.Controls.Add(label15);
            grbkh.Controls.Add(txtemailncc);
            grbkh.Controls.Add(label2);
            grbkh.Controls.Add(txtsdtncc);
            grbkh.Controls.Add(txttenncc);
            grbkh.Controls.Add(txtmncc);
            grbkh.Controls.Add(label3);
            grbkh.Controls.Add(txtmkh);
            grbkh.Controls.Add(label1);
            grbkh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbkh.ForeColor = Color.Black;
            grbkh.Location = new Point(12, 110);
            grbkh.Name = "grbkh";
            grbkh.Size = new Size(286, 437);
            grbkh.TabIndex = 3;
            grbkh.TabStop = false;
            grbkh.Text = "Nhà Cung Cấp";
            // 
            // txtemailncc
            // 
            txtemailncc.Location = new Point(24, 265);
            txtemailncc.Name = "txtemailncc";
            txtemailncc.Size = new Size(229, 31);
            txtemailncc.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 239);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 12;
            label2.Text = "Email:";
            // 
            // txtsdtncc
            // 
            txtsdtncc.Location = new Point(24, 198);
            txtsdtncc.Name = "txtsdtncc";
            txtsdtncc.Size = new Size(229, 31);
            txtsdtncc.TabIndex = 11;
            // 
            // txttenncc
            // 
            txttenncc.Location = new Point(24, 133);
            txttenncc.Name = "txttenncc";
            txttenncc.Size = new Size(229, 31);
            txttenncc.TabIndex = 7;
            // 
            // txtmncc
            // 
            txtmncc.Location = new Point(24, 66);
            txtmncc.Name = "txtmncc";
            txtmncc.Size = new Size(229, 31);
            txtmncc.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 172);
            label3.Name = "label3";
            label3.Size = new Size(121, 23);
            label3.TabIndex = 2;
            label3.Text = "Số điện thoại:";
            // 
            // txtmkh
            // 
            txtmkh.AutoSize = true;
            txtmkh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmkh.Location = new Point(20, 107);
            txtmkh.Name = "txtmkh";
            txtmkh.Size = new Size(162, 23);
            txtmkh.TabIndex = 1;
            txtmkh.Text = "Tên Nhà Cung Cấp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhà Cung Cấp:";
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxoa.Location = new Point(617, 435);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(99, 40);
            btnxoa.TabIndex = 28;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnload
            // 
            btnload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnload.Location = new Point(879, 435);
            btnload.Name = "btnload";
            btnload.Size = new Size(99, 40);
            btnload.TabIndex = 30;
            btnload.Text = "Tải lại";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsua.Location = new Point(487, 435);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(99, 40);
            btnsua.TabIndex = 27;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(749, 435);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(99, 40);
            btnthoat.TabIndex = 29;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthem.Location = new Point(361, 435);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(99, 40);
            btnthem.TabIndex = 26;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(259, 66);
            label15.Name = "label15";
            label15.Size = new Size(20, 25);
            label15.TabIndex = 33;
            label15.Text = "*";
            // 
            // QLNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 550);
            Controls.Add(panel1);
            Name = "QLNhaCungCap";
            Text = "QLNhaCungCap";
            Load += QLNhaCungCap_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvncc).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbkh.ResumeLayout(false);
            grbkh.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox grbkh;
        private TextBox txtemailncc;
        private Label label2;
        private TextBox txtsdtncc;
        private TextBox txttenncc;
        private TextBox txtmncc;
        private Label label3;
        private Label txtmkh;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txttimkiemncc;
        private Button btntimkiem;
        private Label label9;
        private Button btnxoa;
        private Button btnload;
        private Button btnsua;
        private Button btnthoat;
        private Button btnthem;
        private DataGridView dgvncc;
        private Label label15;
    }
}