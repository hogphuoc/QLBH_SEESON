namespace THNN
{
    partial class QLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNhanVien));
            grbkh = new GroupBox();
            txttenbp_nv = new TextBox();
            txttench_nv = new TextBox();
            label11 = new Label();
            label10 = new Label();
            cbmbp_nv = new ComboBox();
            label8 = new Label();
            cbmch_nv = new ComboBox();
            label7 = new Label();
            dtpngaysinhnv = new DateTimePicker();
            cbgtnv = new ComboBox();
            txtemailnv = new TextBox();
            txtsdtnv = new TextBox();
            txttennv = new TextBox();
            txtmnv = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvnhanvien = new DataGridView();
            panel1 = new Panel();
            btnload = new Button();
            btnthoat = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            groupBox1 = new GroupBox();
            txttimkiemtennv = new TextBox();
            btntimkiemnv = new Button();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            grbkh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbkh
            // 
            grbkh.BackColor = Color.Transparent;
            grbkh.Controls.Add(label13);
            grbkh.Controls.Add(label12);
            grbkh.Controls.Add(txttenbp_nv);
            grbkh.Controls.Add(txttench_nv);
            grbkh.Controls.Add(label11);
            grbkh.Controls.Add(label10);
            grbkh.Controls.Add(cbmbp_nv);
            grbkh.Controls.Add(label8);
            grbkh.Controls.Add(cbmch_nv);
            grbkh.Controls.Add(label7);
            grbkh.Controls.Add(dtpngaysinhnv);
            grbkh.Controls.Add(cbgtnv);
            grbkh.Controls.Add(txtemailnv);
            grbkh.Controls.Add(txtsdtnv);
            grbkh.Controls.Add(txttennv);
            grbkh.Controls.Add(txtmnv);
            grbkh.Controls.Add(label6);
            grbkh.Controls.Add(label5);
            grbkh.Controls.Add(label4);
            grbkh.Controls.Add(label3);
            grbkh.Controls.Add(label2);
            grbkh.Controls.Add(label1);
            grbkh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbkh.ForeColor = Color.Black;
            grbkh.Location = new Point(331, 24);
            grbkh.Name = "grbkh";
            grbkh.Size = new Size(833, 280);
            grbkh.TabIndex = 1;
            grbkh.TabStop = false;
            grbkh.Text = "Nhân Viên";
            // 
            // txttenbp_nv
            // 
            txttenbp_nv.Enabled = false;
            txttenbp_nv.Location = new Point(568, 227);
            txttenbp_nv.Name = "txttenbp_nv";
            txttenbp_nv.Size = new Size(229, 31);
            txttenbp_nv.TabIndex = 19;
            // 
            // txttench_nv
            // 
            txttench_nv.Enabled = false;
            txttench_nv.Location = new Point(568, 180);
            txttench_nv.Name = "txttench_nv";
            txttench_nv.Size = new Size(229, 31);
            txttench_nv.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(445, 232);
            label11.Name = "label11";
            label11.Size = new Size(113, 23);
            label11.TabIndex = 17;
            label11.Text = "Tên bộ phận:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(445, 183);
            label10.Name = "label10";
            label10.Size = new Size(120, 23);
            label10.TabIndex = 16;
            label10.Text = "Tên cửa hàng:";
            // 
            // cbmbp_nv
            // 
            cbmbp_nv.FormattingEnabled = true;
            cbmbp_nv.Location = new Point(167, 227);
            cbmbp_nv.Name = "cbmbp_nv";
            cbmbp_nv.Size = new Size(137, 33);
            cbmbp_nv.TabIndex = 15;
            cbmbp_nv.SelectedIndexChanged += cbmbp_nv_SelectedIndexChanged;
            cbmbp_nv.Click += cbmbp_nv_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 232);
            label8.Name = "label8";
            label8.Size = new Size(111, 23);
            label8.TabIndex = 14;
            label8.Text = "Mã bộ phận:";
            // 
            // cbmch_nv
            // 
            cbmch_nv.FormattingEnabled = true;
            cbmch_nv.Location = new Point(167, 178);
            cbmch_nv.Name = "cbmch_nv";
            cbmch_nv.Size = new Size(137, 33);
            cbmch_nv.TabIndex = 13;
            cbmch_nv.SelectedIndexChanged += cbmch_nv_SelectedIndexChanged;
            cbmch_nv.Click += cbmch_nv_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 183);
            label7.Name = "label7";
            label7.Size = new Size(118, 23);
            label7.TabIndex = 12;
            label7.Text = "Mã cửa hàng:";
            // 
            // dtpngaysinhnv
            // 
            dtpngaysinhnv.Format = DateTimePickerFormat.Custom;
            dtpngaysinhnv.Location = new Point(568, 35);
            dtpngaysinhnv.Name = "dtpngaysinhnv";
            dtpngaysinhnv.Size = new Size(229, 31);
            dtpngaysinhnv.TabIndex = 11;
            // 
            // cbgtnv
            // 
            cbgtnv.FormattingEnabled = true;
            cbgtnv.Items.AddRange(new object[] { "Nam ", "Nữ" });
            cbgtnv.Location = new Point(167, 130);
            cbgtnv.Name = "cbgtnv";
            cbgtnv.Size = new Size(137, 33);
            cbgtnv.TabIndex = 10;
            // 
            // txtemailnv
            // 
            txtemailnv.Location = new Point(568, 135);
            txtemailnv.Name = "txtemailnv";
            txtemailnv.Size = new Size(229, 31);
            txtemailnv.TabIndex = 9;
            // 
            // txtsdtnv
            // 
            txtsdtnv.Location = new Point(568, 84);
            txtsdtnv.Name = "txtsdtnv";
            txtsdtnv.Size = new Size(229, 31);
            txtsdtnv.TabIndex = 8;
            // 
            // txttennv
            // 
            txttennv.Location = new Point(167, 84);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(229, 31);
            txttennv.TabIndex = 7;
            // 
            // txtmnv
            // 
            txtmnv.Location = new Point(167, 35);
            txtmnv.Name = "txtmnv";
            txtmnv.Size = new Size(229, 31);
            txtmnv.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(442, 135);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(442, 89);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 4;
            label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(442, 43);
            label4.Name = "label4";
            label4.Size = new Size(94, 23);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 140);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 2;
            label3.Text = "Giới tính:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 89);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(127, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhân Viên:";
            // 
            // dgvnhanvien
            // 
            dgvnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnhanvien.Location = new Point(331, 319);
            dgvnhanvien.Name = "dgvnhanvien";
            dgvnhanvien.RowHeadersWidth = 51;
            dgvnhanvien.Size = new Size(842, 387);
            dgvnhanvien.TabIndex = 2;
            dgvnhanvien.CellContentClick += dgvnhanvien_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(12, 593);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 3;
            // 
            // btnload
            // 
            btnload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnload.Location = new Point(1059, 736);
            btnload.Name = "btnload";
            btnload.Size = new Size(99, 40);
            btnload.TabIndex = 11;
            btnload.Text = "Tải lại";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(844, 736);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(99, 40);
            btnthoat.TabIndex = 10;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxoa.Location = new Point(689, 736);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(99, 40);
            btnxoa.TabIndex = 9;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsua.Location = new Point(527, 736);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(99, 40);
            btnsua.TabIndex = 8;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthem.Location = new Point(363, 736);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(99, 40);
            btnthem.TabIndex = 7;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txttimkiemtennv);
            groupBox1.Controls.Add(btntimkiemnv);
            groupBox1.Controls.Add(label9);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 183);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm thông tin nhân viên";
            // 
            // txttimkiemtennv
            // 
            txttimkiemtennv.Location = new Point(6, 73);
            txttimkiemtennv.Name = "txttimkiemtennv";
            txttimkiemtennv.Size = new Size(260, 27);
            txttimkiemtennv.TabIndex = 12;
            // 
            // btntimkiemnv
            // 
            btntimkiemnv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntimkiemnv.Location = new Point(76, 119);
            btntimkiemnv.Name = "btntimkiemnv";
            btntimkiemnv.Size = new Size(99, 40);
            btntimkiemnv.TabIndex = 9;
            btntimkiemnv.Text = "Tìm kiếm";
            btntimkiemnv.UseVisualStyleBackColor = true;
            btntimkiemnv.Click += btntimkiem_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 35);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 12;
            label9.Text = "Nhập tên:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(310, 178);
            label12.Name = "label12";
            label12.Size = new Size(20, 25);
            label12.TabIndex = 20;
            label12.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(310, 230);
            label13.Name = "label13";
            label13.Size = new Size(20, 25);
            label13.TabIndex = 21;
            label13.Text = "*";
            // 
            // QLNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1201, 849);
            Controls.Add(groupBox1);
            Controls.Add(btnload);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(panel1);
            Controls.Add(dgvnhanvien);
            Controls.Add(grbkh);
            Name = "QLNhanVien";
            Text = "QuanLyNV";
            Load += QLNhanVien_Load;
            grbkh.ResumeLayout(false);
            grbkh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbkh;
        private DateTimePicker dtpngaysinhnv;
        private ComboBox cbgtnv;
        private TextBox txtemailnv;
        private TextBox txtsdtnv;
        private TextBox txttennv;
        private TextBox txtmnv;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox cbmbp_nv;
        private Label label8;
        private ComboBox cbmch_nv;
        private DataGridView dgvnhanvien;
        private Panel panel1;
        private Button btnload;
        private Button btnthoat;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private GroupBox groupBox1;
        private TextBox txttimkiemtennv;
        private Button btntimkiemnv;
        private Label label9;
        private TextBox txttenbp_nv;
        private TextBox txttench_nv;
        private Label label11;
        private Label label10;
        private Label label13;
        private Label label12;
    }
}