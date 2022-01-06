
namespace QuanLyHangHoa
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMuaHang = new System.Windows.Forms.Button();
            this.btnQLXuatHang = new System.Windows.Forms.Button();
            this.btnQLNhapHang = new System.Windows.Forms.Button();
            this.btnQLDSHangHoa = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btn_XacNhanDN = new System.Windows.Forms.Button();
            this.btn_QuenMK = new System.Windows.Forms.Button();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.datMuaSP1 = new QuanLyHangHoa.DatMuaSP();
            this.qL_HangHoa1 = new QuanLyHangHoa.QL_HangHoa();
            this.qlNhapHang1 = new QuanLyHangHoa.QLNhapHang();
            this.qlXuatHang1 = new QuanLyHangHoa.QLXuatHang();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnMuaHang);
            this.panel1.Controls.Add(this.btnQLXuatHang);
            this.panel1.Controls.Add(this.btnQLNhapHang);
            this.panel1.Controls.Add(this.btnQLDSHangHoa);
            this.panel1.Controls.Add(this.btnDangNhap);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 729);
            this.panel1.TabIndex = 0;
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaHang.Location = new System.Drawing.Point(0, 448);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(200, 77);
            this.btnMuaHang.TabIndex = 5;
            this.btnMuaHang.Text = "Đặt mua sản phẩm";
            this.btnMuaHang.UseVisualStyleBackColor = true;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // btnQLXuatHang
            // 
            this.btnQLXuatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLXuatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLXuatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLXuatHang.Location = new System.Drawing.Point(0, 371);
            this.btnQLXuatHang.Name = "btnQLXuatHang";
            this.btnQLXuatHang.Size = new System.Drawing.Size(200, 77);
            this.btnQLXuatHang.TabIndex = 4;
            this.btnQLXuatHang.Text = "Quản lý Xuất hàng";
            this.btnQLXuatHang.UseVisualStyleBackColor = true;
            this.btnQLXuatHang.Visible = false;
            this.btnQLXuatHang.Click += new System.EventHandler(this.btnQLXuatHang_Click);
            // 
            // btnQLNhapHang
            // 
            this.btnQLNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhapHang.Location = new System.Drawing.Point(0, 294);
            this.btnQLNhapHang.Name = "btnQLNhapHang";
            this.btnQLNhapHang.Size = new System.Drawing.Size(200, 77);
            this.btnQLNhapHang.TabIndex = 3;
            this.btnQLNhapHang.Text = "Quản lý Nhập hàng";
            this.btnQLNhapHang.UseVisualStyleBackColor = true;
            this.btnQLNhapHang.Visible = false;
            this.btnQLNhapHang.Click += new System.EventHandler(this.btnQLNhapHang_Click);
            // 
            // btnQLDSHangHoa
            // 
            this.btnQLDSHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDSHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDSHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDSHangHoa.Location = new System.Drawing.Point(0, 217);
            this.btnQLDSHangHoa.Name = "btnQLDSHangHoa";
            this.btnQLDSHangHoa.Size = new System.Drawing.Size(200, 77);
            this.btnQLDSHangHoa.TabIndex = 2;
            this.btnQLDSHangHoa.Text = "Quản lý danh sách hàng hóa";
            this.btnQLDSHangHoa.UseVisualStyleBackColor = true;
            this.btnQLDSHangHoa.Visible = false;
            this.btnQLDSHangHoa.Click += new System.EventHandler(this.btnQLDSHangHoa_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(0, 140);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(200, 77);
            this.btnDangNhap.TabIndex = 1;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::QuanLyHangHoa.Properties.Resources._12;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(527, 237);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(193, 20);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(527, 270);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(193, 20);
            this.txtMatKhau.TabIndex = 4;
            // 
            // btn_XacNhanDN
            // 
            this.btn_XacNhanDN.Location = new System.Drawing.Point(527, 296);
            this.btn_XacNhanDN.Name = "btn_XacNhanDN";
            this.btn_XacNhanDN.Size = new System.Drawing.Size(75, 23);
            this.btn_XacNhanDN.TabIndex = 5;
            this.btn_XacNhanDN.Text = "Đăng Nhập";
            this.btn_XacNhanDN.UseVisualStyleBackColor = true;
            this.btn_XacNhanDN.Click += new System.EventHandler(this.btn_XacNhanDN_Click);
            // 
            // btn_QuenMK
            // 
            this.btn_QuenMK.Location = new System.Drawing.Point(645, 296);
            this.btn_QuenMK.Name = "btn_QuenMK";
            this.btn_QuenMK.Size = new System.Drawing.Size(75, 23);
            this.btn_QuenMK.TabIndex = 6;
            this.btn_QuenMK.Text = "Quên MK";
            this.btn_QuenMK.UseVisualStyleBackColor = true;
            this.btn_QuenMK.Click += new System.EventHandler(this.btn_QuenMK_Click);
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Location = new System.Drawing.Point(559, 204);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(117, 13);
            this.lblDangNhap.TabIndex = 7;
            this.lblDangNhap.Text = "Đăng nhập thành công";
            // 
            // datMuaSP1
            // 
            this.datMuaSP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datMuaSP1.Location = new System.Drawing.Point(200, 0);
            this.datMuaSP1.Name = "datMuaSP1";
            this.datMuaSP1.Size = new System.Drawing.Size(808, 729);
            this.datMuaSP1.TabIndex = 8;
            // 
            // qL_HangHoa1
            // 
            this.qL_HangHoa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qL_HangHoa1.Location = new System.Drawing.Point(200, 0);
            this.qL_HangHoa1.Name = "qL_HangHoa1";
            this.qL_HangHoa1.Size = new System.Drawing.Size(808, 729);
            this.qL_HangHoa1.TabIndex = 9;
            // 
            // qlNhapHang1
            // 
            this.qlNhapHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlNhapHang1.Location = new System.Drawing.Point(200, 0);
            this.qlNhapHang1.Name = "qlNhapHang1";
            this.qlNhapHang1.Size = new System.Drawing.Size(808, 729);
            this.qlNhapHang1.TabIndex = 10;
            // 
            // qlXuatHang1
            // 
            this.qlXuatHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlXuatHang1.Location = new System.Drawing.Point(200, 0);
            this.qlXuatHang1.Name = "qlXuatHang1";
            this.qlXuatHang1.Size = new System.Drawing.Size(808, 729);
            this.qlXuatHang1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.qlXuatHang1);
            this.Controls.Add(this.qlNhapHang1);
            this.Controls.Add(this.qL_HangHoa1);
            this.Controls.Add(this.datMuaSP1);
            this.Controls.Add(this.lblDangNhap);
            this.Controls.Add(this.btn_QuenMK);
            this.Controls.Add(this.btn_XacNhanDN);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý hàng hóa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMuaHang;
        private System.Windows.Forms.Button btnQLXuatHang;
        private System.Windows.Forms.Button btnQLNhapHang;
        private System.Windows.Forms.Button btnQLDSHangHoa;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btn_XacNhanDN;
        private System.Windows.Forms.Button btn_QuenMK;
        private System.Windows.Forms.Label lblDangNhap;
        private DatMuaSP datMuaSP1;
        private QL_HangHoa qL_HangHoa1;
        private QLNhapHang qlNhapHang1;
        private QLXuatHang qlXuatHang1;
    }
}

