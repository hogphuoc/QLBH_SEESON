namespace THNN
{
    partial class QLCuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLCuaHang));
            grbkh = new GroupBox();
            txtdiachich = new TextBox();
            txttench = new TextBox();
            txtmch = new TextBox();
            label3 = new Label();
            txtmkh = new Label();
            label1 = new Label();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            btnload = new Button();
            btnthoat = new Button();
            dgvcuahang = new DataGridView();
            groupBox1 = new GroupBox();
            txttimkiemdcch = new TextBox();
            btntimkiem = new Button();
            label9 = new Label();
            label12 = new Label();
            grbkh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcuahang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbkh
            // 
            grbkh.BackColor = Color.Transparent;
            grbkh.Controls.Add(label12);
            grbkh.Controls.Add(txtdiachich);
            grbkh.Controls.Add(txttench);
            grbkh.Controls.Add(txtmch);
            grbkh.Controls.Add(label3);
            grbkh.Controls.Add(txtmkh);
            grbkh.Controls.Add(label1);
            grbkh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbkh.ForeColor = Color.Black;
            grbkh.Location = new Point(12, 101);
            grbkh.Name = "grbkh";
            grbkh.Size = new Size(393, 437);
            grbkh.TabIndex = 2;
            grbkh.TabStop = false;
            grbkh.Text = "Chi Nhánh Cửa Hàng";
            // 
            // txtdiachich
            // 
            txtdiachich.Location = new Point(24, 198);
            txtdiachich.Name = "txtdiachich";
            txtdiachich.Size = new Size(338, 31);
            txtdiachich.TabIndex = 11;
            // 
            // txttench
            // 
            txttench.Location = new Point(24, 133);
            txttench.Name = "txttench";
            txttench.Size = new Size(338, 31);
            txttench.TabIndex = 7;
            // 
            // txtmch
            // 
            txtmch.Location = new Point(24, 66);
            txtmch.Name = "txtmch";
            txtmch.Size = new Size(229, 31);
            txtmch.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 172);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ:";
            // 
            // txtmkh
            // 
            txtmkh.AutoSize = true;
            txtmkh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmkh.Location = new Point(20, 107);
            txtmkh.Name = "txtmkh";
            txtmkh.Size = new Size(126, 23);
            txtmkh.TabIndex = 1;
            txtmkh.Text = "Tên Cửa Hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã Cửa Hàng:";
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxoa.Location = new Point(686, 420);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(99, 40);
            btnxoa.TabIndex = 21;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsua.Location = new Point(556, 420);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(99, 40);
            btnsua.TabIndex = 20;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthem.Location = new Point(430, 420);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(99, 40);
            btnthem.TabIndex = 19;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnload
            // 
            btnload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnload.Location = new Point(1007, 420);
            btnload.Name = "btnload";
            btnload.Size = new Size(99, 40);
            btnload.TabIndex = 23;
            btnload.Text = "Tải lại";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(818, 420);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(99, 40);
            btnthoat.TabIndex = 22;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // dgvcuahang
            // 
            dgvcuahang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcuahang.Location = new Point(430, 191);
            dgvcuahang.Name = "dgvcuahang";
            dgvcuahang.RowHeadersWidth = 51;
            dgvcuahang.Size = new Size(676, 188);
            dgvcuahang.TabIndex = 24;
            dgvcuahang.CellContentClick += dgvcuahang_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txttimkiemdcch);
            groupBox1.Controls.Add(btntimkiem);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(430, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 81);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm thông tin cửa hàng";
            // 
            // txttimkiemdcch
            // 
            txttimkiemdcch.Location = new Point(112, 32);
            txttimkiemdcch.Name = "txttimkiemdcch";
            txttimkiemdcch.Size = new Size(260, 27);
            txttimkiemdcch.TabIndex = 12;
            // 
            // btntimkiem
            // 
            btntimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntimkiem.Location = new Point(388, 25);
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
            label9.Size = new Size(100, 20);
            label9.TabIndex = 12;
            label9.Text = "Nhập địa chỉ:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(259, 69);
            label12.Name = "label12";
            label12.Size = new Size(20, 25);
            label12.TabIndex = 26;
            label12.Text = "*";
            // 
            // QLCuaHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1201, 550);
            Controls.Add(groupBox1);
            Controls.Add(dgvcuahang);
            Controls.Add(btnxoa);
            Controls.Add(grbkh);
            Controls.Add(btnsua);
            Controls.Add(btnload);
            Controls.Add(btnthem);
            Controls.Add(btnthoat);
            Name = "QLCuaHang";
            Text = "QLCuaHang";
            Load += QLCuaHang_Load;
            grbkh.ResumeLayout(false);
            grbkh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcuahang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbkh;
        private TextBox txtdiachich;
        private TextBox txttench;
        private TextBox txtmch;
        private Label label3;
        private Label txtmkh;
        private Label label1;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private Button btnload;
        private Button btnthoat;
        private DataGridView dgvcuahang;
        private GroupBox groupBox1;
        private TextBox txttimkiemdcch;
        private Button btntimkiem;
        private Label label9;
        private Label label12;
    }
}