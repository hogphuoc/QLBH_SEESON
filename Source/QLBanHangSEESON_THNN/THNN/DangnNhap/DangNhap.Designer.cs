namespace THNN
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            txttendangnhap = new TextBox();
            txtmatkhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btndangnhap = new Button();
            btnthoat = new Button();
            label15 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txttendangnhap
            // 
            txttendangnhap.Location = new Point(170, 272);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(324, 27);
            txttendangnhap.TabIndex = 0;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(170, 371);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(324, 27);
            txtmatkhau.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(170, 232);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(170, 340);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // btndangnhap
            // 
            btndangnhap.BackColor = Color.LightGray;
            btndangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndangnhap.ForeColor = Color.DarkGreen;
            btndangnhap.Location = new Point(561, 283);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(130, 41);
            btndangnhap.TabIndex = 4;
            btndangnhap.Text = "Đăng Nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.LightGray;
            btnthoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnthoat.ForeColor = Color.DarkGreen;
            btnthoat.Location = new Point(561, 340);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(130, 41);
            btnthoat.TabIndex = 5;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(500, 272);
            label15.Name = "label15";
            label15.Size = new Size(20, 25);
            label15.TabIndex = 32;
            label15.Text = "*";
            label15.Click += label15_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(500, 370);
            label3.Name = "label3";
            label3.Size = new Size(20, 25);
            label3.TabIndex = 33;
            label3.Text = "*";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1183, 555);
            Controls.Add(label3);
            Controls.Add(label15);
            Controls.Add(btnthoat);
            Controls.Add(btndangnhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtmatkhau);
            Controls.Add(txttendangnhap);
            Name = "DangNhap";
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttendangnhap;
        private TextBox txtmatkhau;
        private Label label1;
        private Label label2;
        private Button btndangnhap;
        private Button btnthoat;
        private Label label15;
        private Label label3;
    }
}