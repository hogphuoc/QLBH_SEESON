namespace THNN
{
    partial class QLPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLPhieuXuat));
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            txttimkiemmakh = new TextBox();
            btntimkiempx = new Button();
            label7 = new Label();
            dgvctpx = new DataGridView();
            dgvpx = new DataGridView();
            btnthemctpx = new Button();
            btnxoactpx = new Button();
            btnupdate_ctpx = new Button();
            button1 = new Button();
            btnxoapx = new Button();
            btnsua = new Button();
            btnthem = new Button();
            btnload = new Button();
            groupBox1 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            txttensp_ctpx = new TextBox();
            cbmasp_ctpx = new ComboBox();
            txtmpx_ctpx = new TextBox();
            label6 = new Label();
            txtslxuat = new TextBox();
            label9 = new Label();
            label11 = new Label();
            grbkh = new GroupBox();
            label10 = new Label();
            label2 = new Label();
            label15 = new Label();
            label5 = new Label();
            label4 = new Label();
            dtpngayxuat = new DateTimePicker();
            cbmnv_px = new ComboBox();
            cbmch_px = new ComboBox();
            txttench_px = new TextBox();
            txtmpx = new TextBox();
            label = new Label();
            label1 = new Label();
            label3 = new Label();
            btnxuathd = new Button();
            button2 = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvctpx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvpx).BeginInit();
            groupBox1.SuspendLayout();
            grbkh.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 89);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txttimkiemmakh);
            groupBox2.Controls.Add(btntimkiempx);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(784, 54);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(479, 74);
            groupBox2.TabIndex = 49;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm thông tin phiếu nhập";
            // 
            // txttimkiemmakh
            // 
            txttimkiemmakh.Location = new Point(171, 32);
            txttimkiemmakh.Name = "txttimkiemmakh";
            txttimkiemmakh.Size = new Size(120, 27);
            txttimkiemmakh.TabIndex = 12;
            // 
            // btntimkiempx
            // 
            btntimkiempx.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntimkiempx.Location = new Point(374, 24);
            btntimkiempx.Name = "btntimkiempx";
            btntimkiempx.Size = new Size(99, 40);
            btntimkiempx.TabIndex = 9;
            btntimkiempx.Text = "Tìm kiếm";
            btntimkiempx.UseVisualStyleBackColor = true;
            btntimkiempx.Click += btntimkiempx_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 35);
            label7.Name = "label7";
            label7.Size = new Size(155, 20);
            label7.TabIndex = 12;
            label7.Text = "Nhập mã phiếu xuất:";
            // 
            // dgvctpx
            // 
            dgvctpx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvctpx.Location = new Point(784, 469);
            dgvctpx.Name = "dgvctpx";
            dgvctpx.RowHeadersWidth = 51;
            dgvctpx.Size = new Size(551, 249);
            dgvctpx.TabIndex = 48;
            dgvctpx.CellContentClick += dgvctpx_CellContentClick;
            // 
            // dgvpx
            // 
            dgvpx.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpx.Location = new Point(784, 134);
            dgvpx.Name = "dgvpx";
            dgvpx.RowHeadersWidth = 51;
            dgvpx.Size = new Size(720, 294);
            dgvpx.TabIndex = 47;
            dgvpx.CellContentClick += dgvpx_CellContentClick;
            // 
            // btnthemctpx
            // 
            btnthemctpx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthemctpx.Location = new Point(602, 546);
            btnthemctpx.Name = "btnthemctpx";
            btnthemctpx.Size = new Size(146, 40);
            btnthemctpx.TabIndex = 46;
            btnthemctpx.Text = "Thêm CTPX";
            btnthemctpx.UseVisualStyleBackColor = true;
            btnthemctpx.Click += btnthemctpx_Click;
            // 
            // btnxoactpx
            // 
            btnxoactpx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxoactpx.Location = new Point(602, 673);
            btnxoactpx.Name = "btnxoactpx";
            btnxoactpx.Size = new Size(146, 40);
            btnxoactpx.TabIndex = 45;
            btnxoactpx.Text = "Xóa CTPX";
            btnxoactpx.UseVisualStyleBackColor = true;
            btnxoactpx.Click += btnxoactpx_Click;
            // 
            // btnupdate_ctpx
            // 
            btnupdate_ctpx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate_ctpx.Location = new Point(602, 608);
            btnupdate_ctpx.Name = "btnupdate_ctpx";
            btnupdate_ctpx.Size = new Size(146, 40);
            btnupdate_ctpx.TabIndex = 44;
            btnupdate_ctpx.Text = "Sửa CTPX";
            btnupdate_ctpx.UseVisualStyleBackColor = true;
            btnupdate_ctpx.Click += btnupdate_ctpx_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(602, 374);
            button1.Name = "button1";
            button1.Size = new Size(136, 40);
            button1.TabIndex = 43;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnxoapx
            // 
            btnxoapx.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxoapx.Location = new Point(590, 250);
            btnxoapx.Name = "btnxoapx";
            btnxoapx.Size = new Size(158, 40);
            btnxoapx.TabIndex = 41;
            btnxoapx.Text = "Xóa phiếu xuất";
            btnxoapx.UseVisualStyleBackColor = true;
            btnxoapx.Click += btnxoapx_Click;
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsua.Location = new Point(590, 186);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(158, 40);
            btnsua.TabIndex = 40;
            btnsua.Text = "Sửa phiếu xuất";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthem.Location = new Point(590, 129);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(158, 40);
            btnthem.TabIndex = 39;
            btnthem.Text = "Thêm phiếu xuất";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnload
            // 
            btnload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnload.Location = new Point(602, 315);
            btnload.Name = "btnload";
            btnload.Size = new Size(136, 40);
            btnload.TabIndex = 42;
            btnload.Text = "Tải lại";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txttensp_ctpx);
            groupBox1.Controls.Add(cbmasp_ctpx);
            groupBox1.Controls.Add(txtmpx_ctpx);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtslxuat);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label11);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(13, 456);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 262);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi Tiết Phiếu Nhập";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(179, 133);
            label13.Name = "label13";
            label13.Size = new Size(20, 25);
            label13.TabIndex = 55;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(179, 66);
            label12.Name = "label12";
            label12.Size = new Size(20, 25);
            label12.TabIndex = 54;
            label12.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(209, 108);
            label8.Name = "label8";
            label8.Size = new Size(124, 23);
            label8.TabIndex = 17;
            label8.Text = "Tên sản phẩm:";
            // 
            // txttensp_ctpx
            // 
            txttensp_ctpx.BackColor = SystemColors.Control;
            txttensp_ctpx.Enabled = false;
            txttensp_ctpx.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttensp_ctpx.Location = new Point(209, 136);
            txttensp_ctpx.Name = "txttensp_ctpx";
            txttensp_ctpx.Size = new Size(326, 30);
            txttensp_ctpx.TabIndex = 18;
            // 
            // cbmasp_ctpx
            // 
            cbmasp_ctpx.FormattingEnabled = true;
            cbmasp_ctpx.Location = new Point(22, 133);
            cbmasp_ctpx.Name = "cbmasp_ctpx";
            cbmasp_ctpx.Size = new Size(151, 33);
            cbmasp_ctpx.TabIndex = 14;
            cbmasp_ctpx.SelectedIndexChanged += cbmasp_ctpx_SelectedIndexChanged;
            cbmasp_ctpx.Click += cbmasp_ctpx_Click;
            // 
            // txtmpx_ctpx
            // 
            txtmpx_ctpx.Location = new Point(22, 66);
            txtmpx_ctpx.Name = "txtmpx_ctpx";
            txtmpx_ctpx.Size = new Size(151, 31);
            txtmpx_ctpx.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 40);
            label6.Name = "label6";
            label6.Size = new Size(131, 23);
            label6.TabIndex = 12;
            label6.Text = "Mã Phiếu Xuất:";
            // 
            // txtslxuat
            // 
            txtslxuat.Location = new Point(22, 208);
            txtslxuat.Name = "txtslxuat";
            txtslxuat.Size = new Size(151, 31);
            txtslxuat.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 182);
            label9.Name = "label9";
            label9.Size = new Size(128, 23);
            label9.TabIndex = 2;
            label9.Text = "Số lượng xuất:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(18, 107);
            label11.Name = "label11";
            label11.Size = new Size(124, 23);
            label11.TabIndex = 0;
            label11.Text = "Mã Sản Phẩm:";
            // 
            // grbkh
            // 
            grbkh.BackColor = Color.Transparent;
            grbkh.Controls.Add(label10);
            grbkh.Controls.Add(label2);
            grbkh.Controls.Add(label15);
            grbkh.Controls.Add(label5);
            grbkh.Controls.Add(label4);
            grbkh.Controls.Add(dtpngayxuat);
            grbkh.Controls.Add(cbmnv_px);
            grbkh.Controls.Add(cbmch_px);
            grbkh.Controls.Add(txttench_px);
            grbkh.Controls.Add(txtmpx);
            grbkh.Controls.Add(label);
            grbkh.Controls.Add(label1);
            grbkh.Controls.Add(label3);
            grbkh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbkh.ForeColor = Color.Black;
            grbkh.Location = new Point(13, 113);
            grbkh.Name = "grbkh";
            grbkh.Size = new Size(541, 315);
            grbkh.TabIndex = 37;
            grbkh.TabStop = false;
            grbkh.Text = "Phiếu Xuất Sản Phẩm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(167, 194);
            label10.Name = "label10";
            label10.Size = new Size(20, 25);
            label10.TabIndex = 53;
            label10.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(167, 130);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 52;
            label2.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(167, 66);
            label15.Name = "label15";
            label15.Size = new Size(20, 25);
            label15.TabIndex = 51;
            label15.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(209, 106);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 15;
            label5.Text = "Tên Cửa Hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 235);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 3;
            label4.Text = "Ngày xuất:";
            // 
            // dtpngayxuat
            // 
            dtpngayxuat.Format = DateTimePickerFormat.Short;
            dtpngayxuat.Location = new Point(24, 261);
            dtpngayxuat.Name = "dtpngayxuat";
            dtpngayxuat.Size = new Size(189, 31);
            dtpngayxuat.TabIndex = 12;
            // 
            // cbmnv_px
            // 
            cbmnv_px.FormattingEnabled = true;
            cbmnv_px.Location = new Point(24, 194);
            cbmnv_px.Name = "cbmnv_px";
            cbmnv_px.Size = new Size(137, 33);
            cbmnv_px.TabIndex = 13;
            // 
            // cbmch_px
            // 
            cbmch_px.FormattingEnabled = true;
            cbmch_px.Items.AddRange(new object[] { "Có", "Không" });
            cbmch_px.Location = new Point(24, 127);
            cbmch_px.Name = "cbmch_px";
            cbmch_px.Size = new Size(137, 33);
            cbmch_px.TabIndex = 10;
            cbmch_px.SelectedIndexChanged += cbmch_px_SelectedIndexChanged;
            cbmch_px.Click += cbmch_px_Click;
            // 
            // txttench_px
            // 
            txttench_px.Location = new Point(209, 132);
            txttench_px.Name = "txttench_px";
            txttench_px.ReadOnly = true;
            txttench_px.Size = new Size(326, 31);
            txttench_px.TabIndex = 7;
            // 
            // txtmpx
            // 
            txtmpx.Location = new Point(24, 66);
            txtmpx.Name = "txtmpx";
            txtmpx.Size = new Size(137, 31);
            txtmpx.TabIndex = 6;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(24, 106);
            label.Name = "label";
            label.Size = new Size(124, 23);
            label.TabIndex = 1;
            label.Text = "Mã Cửa Hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã phiếu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 168);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 2;
            label3.Text = "Mã Nhân Viên:";
            // 
            // btnxuathd
            // 
            btnxuathd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxuathd.Location = new Point(1367, 78);
            btnxuathd.Name = "btnxuathd";
            btnxuathd.Size = new Size(138, 40);
            btnxuathd.TabIndex = 50;
            btnxuathd.Text = "In phiếu xuất";
            btnxuathd.UseVisualStyleBackColor = true;
            btnxuathd.Click += btnxuathd_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(602, 469);
            button2.Name = "button2";
            button2.Size = new Size(146, 60);
            button2.TabIndex = 51;
            button2.Text = "Cập nhật số lượng tồn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // QLPhieuXuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1517, 739);
            Controls.Add(button2);
            Controls.Add(btnxuathd);
            Controls.Add(groupBox2);
            Controls.Add(dgvctpx);
            Controls.Add(dgvpx);
            Controls.Add(btnthemctpx);
            Controls.Add(btnxoactpx);
            Controls.Add(btnupdate_ctpx);
            Controls.Add(button1);
            Controls.Add(btnxoapx);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(btnload);
            Controls.Add(groupBox1);
            Controls.Add(grbkh);
            Controls.Add(panel1);
            Name = "QLPhieuXuat";
            Text = "QLPhieuXuat";
            Load += QLPhieuXuat_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvctpx).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvpx).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grbkh.ResumeLayout(false);
            grbkh.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private TextBox txttimkiemmakh;
        private Button btntimkiempx;
        private Label label7;
        private DataGridView dgvctpx;
        private DataGridView dgvpx;
        private Button btnthemctpx;
        private Button btnxoactpx;
        private Button btnupdate_ctpx;
        private Button button1;
        private Button btnxoapx;
        private Button btnsua;
        private Button btnthem;
        private Button btnload;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txttensp_ctpx;
        private ComboBox cbmasp_ctpx;
        private TextBox txtmpx_ctpx;
        private Label label6;
        private TextBox txtslxuat;
        private Label label9;
        private Label label11;
        private GroupBox grbkh;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpngayxuat;
        private ComboBox cbmnv_px;
        private ComboBox cbmch_px;
        private TextBox txttench_px;
        private TextBox txtmpx;
        private Label label;
        private Label label1;
        private Label label3;
        private Button btnxuathd;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label2;
        private Label label15;
        private Button button2;
    }
}