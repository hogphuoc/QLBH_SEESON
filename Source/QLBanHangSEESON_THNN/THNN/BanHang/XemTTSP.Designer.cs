namespace THNN.DangnNhap
{
    partial class XemTTSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemTTSP));
            pbsp = new PictureBox();
            groupBox2 = new GroupBox();
            btnload = new Button();
            btnthoat = new Button();
            txttimkiemmsp = new TextBox();
            btntimkiemnv = new Button();
            label9 = new Label();
            dgvsp = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbsp).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsp).BeginInit();
            SuspendLayout();
            // 
            // pbsp
            // 
            pbsp.Location = new Point(709, 337);
            pbsp.Name = "pbsp";
            pbsp.Size = new Size(455, 245);
            pbsp.TabIndex = 30;
            pbsp.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnload);
            groupBox2.Controls.Add(btnthoat);
            groupBox2.Controls.Add(txttimkiemmsp);
            groupBox2.Controls.Add(btntimkiemnv);
            groupBox2.Controls.Add(label9);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 159);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(679, 120);
            groupBox2.TabIndex = 29;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm thông tin sản phẩm";
            // 
            // btnload
            // 
            btnload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnload.Location = new Point(433, 66);
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
            btnthoat.Location = new Point(563, 66);
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
            dgvsp.Location = new Point(60, 285);
            dgvsp.Name = "dgvsp";
            dgvsp.RowHeadersWidth = 51;
            dgvsp.Size = new Size(574, 368);
            dgvsp.TabIndex = 28;
            dgvsp.CellContentClick += dgvsp_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(9, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 89);
            panel1.TabIndex = 27;
            // 
            // XemTTSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1181, 698);
            Controls.Add(pbsp);
            Controls.Add(groupBox2);
            Controls.Add(dgvsp);
            Controls.Add(panel1);
            Name = "XemTTSP";
            Text = "XemTTSP";
            Load += XemTTSP_Load;
            ((System.ComponentModel.ISupportInitialize)pbsp).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvsp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbsp;
        private GroupBox groupBox2;
        private Button btnload;
        private Button btnthoat;
        private TextBox txttimkiemmsp;
        private Button btntimkiemnv;
        private Label label9;
        private DataGridView dgvsp;
        private Panel panel1;
    }
}