namespace THNN.BanHang
{
    partial class SuaSLTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaSLTon));
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            btnsua = new Button();
            btnload = new Button();
            btnthoat = new Button();
            txttimkiemmsp = new TextBox();
            btntimkiemnv = new Button();
            label9 = new Label();
            dgvsp = new DataGridView();
            pbsp = new PictureBox();
            txtmasp = new TextBox();
            txtslton = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbsp).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 89);
            panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnsua);
            groupBox2.Controls.Add(btnload);
            groupBox2.Controls.Add(btnthoat);
            groupBox2.Controls.Add(txttimkiemmsp);
            groupBox2.Controls.Add(btntimkiemnv);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(765, 120);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm thông tin sản phẩm";
            // 
            // btnsua
            // 
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsua.Location = new Point(420, 66);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(175, 40);
            btnsua.TabIndex = 15;
            btnsua.Text = "Sửa thông tin tồn";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += button1_Click;
            // 
            // btnload
            // 
            btnload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnload.Location = new Point(654, 66);
            btnload.Name = "btnload";
            btnload.Size = new Size(99, 40);
            btnload.TabIndex = 14;
            btnload.Text = "Tải lại";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(654, 20);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(99, 40);
            btnthoat.TabIndex = 13;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
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
            btntimkiemnv.Location = new Point(296, 66);
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
            // dgvsp
            // 
            dgvsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvsp.Location = new Point(191, 240);
            dgvsp.Name = "dgvsp";
            dgvsp.RowHeadersWidth = 51;
            dgvsp.Size = new Size(574, 368);
            dgvsp.TabIndex = 18;
            dgvsp.CellContentClick += dgvsp_CellContentClick;
            // 
            // pbsp
            // 
            pbsp.Location = new Point(779, 291);
            pbsp.Name = "pbsp";
            pbsp.Size = new Size(455, 245);
            pbsp.TabIndex = 26;
            pbsp.TabStop = false;
            // 
            // txtmasp
            // 
            txtmasp.Location = new Point(36, 291);
            txtmasp.Name = "txtmasp";
            txtmasp.ReadOnly = true;
            txtmasp.Size = new Size(125, 27);
            txtmasp.TabIndex = 16;
            // 
            // txtslton
            // 
            txtslton.Location = new Point(36, 370);
            txtslton.Name = "txtslton";
            txtslton.Size = new Size(125, 27);
            txtslton.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 268);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 16;
            label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 347);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 28;
            label2.Text = "Số lượng tồn:";
            // 
            // SuaSLTon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1253, 698);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtslton);
            Controls.Add(txtmasp);
            Controls.Add(pbsp);
            Controls.Add(groupBox2);
            Controls.Add(dgvsp);
            Controls.Add(panel1);
            Name = "SuaSLTon";
            Text = "Cập nhật số lượng tồn";
            Load += XemTTSP_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbsp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private TextBox txttimkiemmsp;
        private Button btntimkiemnv;
        private Label label9;
        private DataGridView dgvsp;
        private PictureBox pbsp;
        private Button btnthoat;
        private Button btnload;
        private Button btnsua;
        private TextBox txtmasp;
        private TextBox txtslton;
        private Label label1;
        private Label label2;
    }
}