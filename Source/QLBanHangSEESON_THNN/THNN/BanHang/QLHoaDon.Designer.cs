namespace THNN
{
    partial class QLHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLHoaDon));
            grbkh = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            cbpttt = new ComboBox();
            dtpngayin = new DateTimePicker();
            txtmnv_hd = new TextBox();
            cbkm = new ComboBox();
            txtmkh_hd = new TextBox();
            txtmhd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtmkh = new Label();
            label1 = new Label();
            dgvhoadon = new DataGridView();
            btnload = new Button();
            btnthoat = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            btnxuathd = new Button();
            dgvCthoadon = new DataGridView();
            groupBox2 = new GroupBox();
            txttimkiemmakh = new TextBox();
            btntimkiemhd = new Button();
            label7 = new Label();
            panel1 = new Panel();
            btnthemcthd = new Button();
            button1 = new Button();
            btnupdate_cthd = new Button();
            txttensp_cthd = new TextBox();
            groupBox1 = new GroupBox();
            label16 = new Label();
            label15 = new Label();
            cbmasp_cthd = new ComboBox();
            txtmhd_cthd = new TextBox();
            label2 = new Label();
            txtslmua = new TextBox();
            txtdongiaban = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnthoathd = new Button();
            pdHoaDon = new System.Drawing.Printing.PrintDocument();
            pddHoaDon = new PrintPreviewDialog();
            grbkh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCthoadon).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbkh
            // 
            grbkh.BackColor = Color.Transparent;
            grbkh.Controls.Add(label14);
            grbkh.Controls.Add(label13);
            grbkh.Controls.Add(label12);
            grbkh.Controls.Add(cbpttt);
            grbkh.Controls.Add(dtpngayin);
            grbkh.Controls.Add(txtmnv_hd);
            grbkh.Controls.Add(cbkm);
            grbkh.Controls.Add(txtmkh_hd);
            grbkh.Controls.Add(txtmhd);
            grbkh.Controls.Add(label6);
            grbkh.Controls.Add(label5);
            grbkh.Controls.Add(label4);
            grbkh.Controls.Add(label3);
            grbkh.Controls.Add(txtmkh);
            grbkh.Controls.Add(label1);
            grbkh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbkh.ForeColor = Color.Black;
            grbkh.Location = new Point(12, 101);
            grbkh.Name = "grbkh";
            grbkh.Size = new Size(283, 437);
            grbkh.TabIndex = 1;
            grbkh.TabStop = false;
            grbkh.Text = "Hóa Đơn";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(257, 201);
            label14.Name = "label14";
            label14.Size = new Size(20, 25);
            label14.TabIndex = 30;
            label14.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(257, 136);
            label13.Name = "label13";
            label13.Size = new Size(20, 25);
            label13.TabIndex = 29;
            label13.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(257, 66);
            label12.Name = "label12";
            label12.Size = new Size(20, 25);
            label12.TabIndex = 28;
            label12.Text = "*";
            // 
            // cbpttt
            // 
            cbpttt.FormattingEnabled = true;
            cbpttt.Items.AddRange(new object[] { "Chuyển khoản", "Tiền mặt" });
            cbpttt.Location = new Point(24, 329);
            cbpttt.Name = "cbpttt";
            cbpttt.Size = new Size(207, 33);
            cbpttt.TabIndex = 13;
            // 
            // dtpngayin
            // 
            dtpngayin.Format = DateTimePickerFormat.Short;
            dtpngayin.Location = new Point(24, 262);
            dtpngayin.Name = "dtpngayin";
            dtpngayin.Size = new Size(229, 31);
            dtpngayin.TabIndex = 12;
            // 
            // txtmnv_hd
            // 
            txtmnv_hd.Location = new Point(24, 198);
            txtmnv_hd.Name = "txtmnv_hd";
            txtmnv_hd.Size = new Size(229, 31);
            txtmnv_hd.TabIndex = 11;
            // 
            // cbkm
            // 
            cbkm.FormattingEnabled = true;
            cbkm.Items.AddRange(new object[] { "Có", "Không" });
            cbkm.Location = new Point(24, 401);
            cbkm.Name = "cbkm";
            cbkm.Size = new Size(137, 33);
            cbkm.TabIndex = 10;
            // 
            // txtmkh_hd
            // 
            txtmkh_hd.Location = new Point(24, 133);
            txtmkh_hd.Name = "txtmkh_hd";
            txtmkh_hd.Size = new Size(229, 31);
            txtmkh_hd.TabIndex = 7;
            // 
            // txtmhd
            // 
            txtmhd.Location = new Point(24, 66);
            txtmhd.Name = "txtmhd";
            txtmhd.Size = new Size(229, 31);
            txtmhd.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 375);
            label6.Name = "label6";
            label6.Size = new Size(183, 23);
            label6.TabIndex = 5;
            label6.Text = "Áp dụng khuyến mãi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 303);
            label5.Name = "label5";
            label5.Size = new Size(211, 23);
            label5.TabIndex = 4;
            label5.Text = "Phương thức thanh toán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 236);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 3;
            label4.Text = "Ngày in:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 172);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 2;
            label3.Text = "Mã Nhân Viên:";
            // 
            // txtmkh
            // 
            txtmkh.AutoSize = true;
            txtmkh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmkh.Location = new Point(20, 107);
            txtmkh.Name = "txtmkh";
            txtmkh.Size = new Size(141, 23);
            txtmkh.TabIndex = 1;
            txtmkh.Text = "Mã Khách Hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã Hóa Đơn:";
            // 
            // dgvhoadon
            // 
            dgvhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadon.Location = new Point(516, 186);
            dgvhoadon.Name = "dgvhoadon";
            dgvhoadon.RowHeadersWidth = 51;
            dgvhoadon.Size = new Size(661, 362);
            dgvhoadon.TabIndex = 2;
            dgvhoadon.CellContentClick += dgvhoadon_CellContentClick;
            // 
            // btnload
            // 
            btnload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnload.Location = new Point(354, 387);
            btnload.Name = "btnload";
            btnload.Size = new Size(136, 40);
            btnload.TabIndex = 18;
            btnload.Text = "Tải lại";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(910, 498);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(99, 40);
            btnthoat.TabIndex = 17;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxoa.Location = new Point(354, 320);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(136, 40);
            btnxoa.TabIndex = 16;
            btnxoa.Text = "Xóa hóa đơn";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsua.Location = new Point(354, 256);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(136, 40);
            btnsua.TabIndex = 15;
            btnsua.Text = "Sửa hóa đơn";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthem.Location = new Point(354, 199);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(136, 40);
            btnthem.TabIndex = 14;
            btnthem.Text = "Thêm hóa đơn";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnxuathd
            // 
            btnxuathd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxuathd.Location = new Point(1039, 124);
            btnxuathd.Name = "btnxuathd";
            btnxuathd.Size = new Size(138, 40);
            btnxuathd.TabIndex = 19;
            btnxuathd.Text = "In hóa đơn";
            btnxuathd.UseVisualStyleBackColor = true;
            btnxuathd.Click += btnxuathd_Click;
            // 
            // dgvCthoadon
            // 
            dgvCthoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCthoadon.Location = new Point(516, 568);
            dgvCthoadon.Name = "dgvCthoadon";
            dgvCthoadon.RowHeadersWidth = 51;
            dgvCthoadon.Size = new Size(540, 296);
            dgvCthoadon.TabIndex = 20;
            dgvCthoadon.CellContentClick += dgvCthoadon_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txttimkiemmakh);
            groupBox2.Controls.Add(btntimkiemhd);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(516, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 74);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm thông tin hóa đơn";
            // 
            // txttimkiemmakh
            // 
            txttimkiemmakh.Location = new Point(162, 31);
            txttimkiemmakh.Name = "txttimkiemmakh";
            txttimkiemmakh.Size = new Size(120, 27);
            txttimkiemmakh.TabIndex = 12;
            // 
            // btntimkiemhd
            // 
            btntimkiemhd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntimkiemhd.Location = new Point(308, 24);
            btntimkiemhd.Name = "btntimkiemhd";
            btntimkiemhd.Size = new Size(99, 40);
            btntimkiemhd.TabIndex = 9;
            btntimkiemhd.Text = "Tìm kiếm";
            btntimkiemhd.UseVisualStyleBackColor = true;
            btntimkiemhd.Click += btntimkiemhd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 35);
            label7.Name = "label7";
            label7.Size = new Size(161, 20);
            label7.TabIndex = 12;
            label7.Text = "Nhập mã khách hàng:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnthemcthd);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnupdate_cthd);
            panel1.Controls.Add(txttensp_cthd);
            panel1.Location = new Point(2, 568);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 439);
            panel1.TabIndex = 26;
            // 
            // btnthemcthd
            // 
            btnthemcthd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthemcthd.Location = new Point(352, 72);
            btnthemcthd.Name = "btnthemcthd";
            btnthemcthd.Size = new Size(146, 40);
            btnthemcthd.TabIndex = 30;
            btnthemcthd.Text = "Thêm CTHD";
            btnthemcthd.UseVisualStyleBackColor = true;
            btnthemcthd.Click += btnthemcthd_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(352, 194);
            button1.Name = "button1";
            button1.Size = new Size(146, 40);
            button1.TabIndex = 29;
            button1.Text = "Xóa CTHD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnupdate_cthd
            // 
            btnupdate_cthd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate_cthd.Location = new Point(352, 134);
            btnupdate_cthd.Name = "btnupdate_cthd";
            btnupdate_cthd.Size = new Size(146, 40);
            btnupdate_cthd.TabIndex = 28;
            btnupdate_cthd.Text = "Sửa CTHD";
            btnupdate_cthd.UseVisualStyleBackColor = true;
            btnupdate_cthd.Click += btnupdate_cthd_Click;
            // 
            // txttensp_cthd
            // 
            txttensp_cthd.BackColor = Color.LightGray;
            txttensp_cthd.Enabled = false;
            txttensp_cthd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttensp_cthd.Location = new Point(10, 323);
            txttensp_cthd.Name = "txttensp_cthd";
            txttensp_cthd.Size = new Size(488, 38);
            txttensp_cthd.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(cbmasp_cthd);
            groupBox1.Controls.Add(txtmhd_cthd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtslmua);
            groupBox1.Controls.Add(txtdongiaban);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(10, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 314);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi Tiết Hóa Đơn";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(179, 133);
            label16.Name = "label16";
            label16.Size = new Size(20, 25);
            label16.TabIndex = 32;
            label16.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(257, 69);
            label15.Name = "label15";
            label15.Size = new Size(20, 25);
            label15.TabIndex = 31;
            label15.Text = "*";
            // 
            // cbmasp_cthd
            // 
            cbmasp_cthd.FormattingEnabled = true;
            cbmasp_cthd.Location = new Point(22, 133);
            cbmasp_cthd.Name = "cbmasp_cthd";
            cbmasp_cthd.Size = new Size(151, 33);
            cbmasp_cthd.TabIndex = 14;
            cbmasp_cthd.SelectedIndexChanged += cbmasp_cthd_SelectedIndexChanged;
            cbmasp_cthd.Click += cbmasp_cthd_Click;
            // 
            // txtmhd_cthd
            // 
            txtmhd_cthd.Location = new Point(22, 66);
            txtmhd_cthd.Name = "txtmhd_cthd";
            txtmhd_cthd.Size = new Size(231, 31);
            txtmhd_cthd.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 40);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 12;
            label2.Text = "Mã Hóa Đơn:";
            // 
            // txtslmua
            // 
            txtslmua.Location = new Point(22, 208);
            txtslmua.Name = "txtslmua";
            txtslmua.Size = new Size(135, 31);
            txtslmua.TabIndex = 11;
            // 
            // txtdongiaban
            // 
            txtdongiaban.Location = new Point(22, 273);
            txtdongiaban.Name = "txtdongiaban";
            txtdongiaban.Size = new Size(135, 31);
            txtdongiaban.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 182);
            label9.Name = "label9";
            label9.Size = new Size(128, 23);
            label9.TabIndex = 2;
            label9.Text = "Số lượng mua:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(22, 247);
            label10.Name = "label10";
            label10.Size = new Size(114, 23);
            label10.TabIndex = 1;
            label10.Text = "Đơn giá bán:";
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
            // btnthoathd
            // 
            btnthoathd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoathd.Location = new Point(354, 459);
            btnthoathd.Name = "btnthoathd";
            btnthoathd.Size = new Size(136, 40);
            btnthoathd.TabIndex = 27;
            btnthoathd.Text = "Thoát";
            btnthoathd.UseVisualStyleBackColor = true;
            btnthoathd.Click += btnthoathd_Click;
            // 
            // pdHoaDon
            // 
            pdHoaDon.PrintPage += pdHoaDon_PrintPage;
            // 
            // pddHoaDon
            // 
            pddHoaDon.AutoScrollMargin = new Size(0, 0);
            pddHoaDon.AutoScrollMinSize = new Size(0, 0);
            pddHoaDon.ClientSize = new Size(400, 300);
            pddHoaDon.Enabled = true;
            pddHoaDon.Icon = (Icon)resources.GetObject("pddHoaDon.Icon");
            pddHoaDon.Name = "pddHoaDon";
            pddHoaDon.Visible = false;
            // 
            // QLHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1209, 966);
            Controls.Add(btnthoathd);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(dgvCthoadon);
            Controls.Add(dgvhoadon);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(btnxuathd);
            Controls.Add(btnload);
            Controls.Add(btnthoat);
            Controls.Add(grbkh);
            Name = "QLHoaDon";
            Text = "QLHoaDon";
            Load += QLHoaDon_Load;
            grbkh.ResumeLayout(false);
            grbkh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCthoadon).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbkh;
        private DateTimePicker dtpngaysinhkh;
        private ComboBox cbkm;
        private TextBox txtmkh_hd;
        private TextBox txtmhd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label txtmkh;
        private Label label1;
        private DataGridView dgvhoadon;
        private TextBox txtmnv_hd;
        private DateTimePicker dtpngayin;
        private ComboBox cbpttt;
        private Button btnload;
        private Button btnthoat;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private Button btnxuathd;
        private DataGridView dgvCthoadon;
        private GroupBox groupBox2;
        private TextBox txttimkiemmakh;
        private Button btntimkiemhd;
        private Label label7;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtmhd_cthd;
        private Label label2;
        private TextBox txtslmua;
        private TextBox txtdongiaban;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cbmasp_cthd;
        private Button btnthemcthd;
        private Button button1;
        private Button btnupdate_cthd;
        private TextBox txttensp_cthd;
        private Button btnthoathd;
        private System.Drawing.Printing.PrintDocument pdHoaDon;
        private PrintPreviewDialog pddHoaDon;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label16;
        private Label label15;
    }
}