namespace THNN
{
    partial class QLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSanPham));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            txttenloaisp_sp = new TextBox();
            label6 = new Label();
            btnloadhinh = new Button();
            txthinhanh = new TextBox();
            label5 = new Label();
            pbsp = new PictureBox();
            label4 = new Label();
            txtdvt = new TextBox();
            txtslt = new TextBox();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            cbgmloaisp_sp = new ComboBox();
            label3 = new Label();
            txttensp = new TextBox();
            txtmsp = new TextBox();
            dgvsp = new DataGridView();
            btnload = new Button();
            btnthoat = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            groupBox2 = new GroupBox();
            txttimkiemmsp = new TextBox();
            btntimkiemnv = new Button();
            label9 = new Label();
            label15 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbsp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvsp).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 88);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txttenloaisp_sp);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnloadhinh);
            groupBox1.Controls.Add(txthinhanh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(pbsp);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtdvt);
            groupBox1.Controls.Add(txtslt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbgmloaisp_sp);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txttensp);
            groupBox1.Controls.Add(txtmsp);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(38, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1116, 417);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục sản phẩm";
            // 
            // txttenloaisp_sp
            // 
            txttenloaisp_sp.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttenloaisp_sp.Location = new Point(853, 52);
            txttenloaisp_sp.Name = "txttenloaisp_sp";
            txttenloaisp_sp.ReadOnly = true;
            txttenloaisp_sp.Size = new Size(233, 30);
            txttenloaisp_sp.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(689, 57);
            label6.Name = "label6";
            label6.Size = new Size(158, 23);
            label6.TabIndex = 29;
            label6.Text = "Tên loại sản phẩm:";
            // 
            // btnloadhinh
            // 
            btnloadhinh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnloadhinh.Location = new Point(511, 150);
            btnloadhinh.Name = "btnloadhinh";
            btnloadhinh.Size = new Size(58, 29);
            btnloadhinh.TabIndex = 28;
            btnloadhinh.Text = "Mở";
            btnloadhinh.UseVisualStyleBackColor = true;
            btnloadhinh.Click += btnloadhinh_Click;
            // 
            // txthinhanh
            // 
            txthinhanh.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txthinhanh.Location = new Point(354, 185);
            txthinhanh.Multiline = true;
            txthinhanh.Name = "txthinhanh";
            txthinhanh.Size = new Size(215, 108);
            txthinhanh.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(354, 152);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 26;
            label5.Text = "Hình ảnh:";
            // 
            // pbsp
            // 
            pbsp.Location = new Point(645, 152);
            pbsp.Name = "pbsp";
            pbsp.Size = new Size(441, 245);
            pbsp.TabIndex = 25;
            pbsp.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(354, 57);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 24;
            label4.Text = "Loại sản phẩm:";
            // 
            // txtdvt
            // 
            txtdvt.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdvt.Location = new Point(173, 149);
            txtdvt.Name = "txtdvt";
            txtdvt.Size = new Size(137, 30);
            txtdvt.TabIndex = 23;
            // 
            // txtslt
            // 
            txtslt.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtslt.Location = new Point(173, 197);
            txtslt.Name = "txtslt";
            txtslt.Size = new Size(137, 30);
            txtslt.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 52);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 14;
            label1.Text = "Mã sản phẩm:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 200);
            label7.Name = "label7";
            label7.Size = new Size(120, 23);
            label7.TabIndex = 20;
            label7.Text = "Số lượng tồn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 101);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 15;
            label2.Text = "Tên sản phẩm:";
            // 
            // cbgmloaisp_sp
            // 
            cbgmloaisp_sp.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbgmloaisp_sp.FormattingEnabled = true;
            cbgmloaisp_sp.Items.AddRange(new object[] { "Nam ", "Nữ" });
            cbgmloaisp_sp.Location = new Point(490, 54);
            cbgmloaisp_sp.Name = "cbgmloaisp_sp";
            cbgmloaisp_sp.Size = new Size(137, 31);
            cbgmloaisp_sp.TabIndex = 19;
            cbgmloaisp_sp.SelectedIndexChanged += cbgmloaisp_sp_SelectedIndexChanged;
            cbgmloaisp_sp.Click += cbgmloaisp_sp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 152);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 16;
            label3.Text = "Đơn vị tính:";
            // 
            // txttensp
            // 
            txttensp.Location = new Point(173, 96);
            txttensp.Name = "txttensp";
            txttensp.Size = new Size(913, 38);
            txttensp.TabIndex = 18;
            // 
            // txtmsp
            // 
            txtmsp.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmsp.Location = new Point(173, 50);
            txtmsp.Name = "txtmsp";
            txtmsp.Size = new Size(137, 30);
            txtmsp.TabIndex = 17;
            // 
            // dgvsp
            // 
            dgvsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsp.Location = new Point(329, 541);
            dgvsp.Name = "dgvsp";
            dgvsp.RowHeadersWidth = 51;
            dgvsp.Size = new Size(815, 368);
            dgvsp.TabIndex = 2;
            dgvsp.CellContentClick += dgvsp_CellContentClick;
            // 
            // btnload
            // 
            btnload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnload.Location = new Point(974, 930);
            btnload.Name = "btnload";
            btnload.Size = new Size(99, 40);
            btnload.TabIndex = 16;
            btnload.Text = "Tải lại";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(838, 930);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(99, 40);
            btnthoat.TabIndex = 15;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnxoa
            // 
            btnxoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnxoa.Location = new Point(694, 930);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(99, 40);
            btnxoa.TabIndex = 14;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsua.Location = new Point(561, 930);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(99, 40);
            btnsua.TabIndex = 13;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthem.Location = new Point(426, 930);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(99, 40);
            btnthem.TabIndex = 12;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txttimkiemmsp);
            groupBox2.Controls.Add(btntimkiemnv);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(38, 613);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(272, 183);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm thông tin sản phẩm";
            // 
            // txttimkiemmsp
            // 
            txttimkiemmsp.Location = new Point(6, 73);
            txttimkiemmsp.Name = "txttimkiemmsp";
            txttimkiemmsp.Size = new Size(260, 27);
            txttimkiemmsp.TabIndex = 12;
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
            btntimkiemnv.Click += btntimkiemnv_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 35);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 12;
            label9.Text = "Nhập mã:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(633, 54);
            label15.Name = "label15";
            label15.Size = new Size(20, 25);
            label15.TabIndex = 33;
            label15.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(316, 51);
            label8.Name = "label8";
            label8.Size = new Size(20, 25);
            label8.TabIndex = 34;
            label8.Text = "*";
            // 
            // QLSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1201, 1040);
            Controls.Add(groupBox2);
            Controls.Add(btnload);
            Controls.Add(btnthoat);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthem);
            Controls.Add(dgvsp);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "QLSanPham";
            Text = "QLSanPham";
            Load += QLSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbsp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvsp).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtdvt;
        private TextBox txtslt;
        private Label label1;
        private Label label7;
        private Label label2;
        private ComboBox cbgmloaisp_sp;
        private Label label3;
        private TextBox txttensp;
        private TextBox txtmsp;
        private TextBox txthinhanh;
        private Label label5;
        private PictureBox pbsp;
        private Button btnloadhinh;
        private DataGridView dgvsp;
        private Button btnload;
        private Button btnthoat;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private GroupBox groupBox2;
        private TextBox txttimkiemmsp;
        private Button btntimkiemnv;
        private Label label9;
        private TextBox txttenloaisp_sp;
        private Label label6;
        private Label label8;
        private Label label15;
    }
}