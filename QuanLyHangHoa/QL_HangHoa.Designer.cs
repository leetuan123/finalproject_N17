
namespace QuanLyHangHoa
{
    partial class QL_HangHoa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_CN = new System.Windows.Forms.Button();
            this.txt_CN_GiaTien = new System.Windows.Forms.TextBox();
            this.txt_CN_TenHang = new System.Windows.Forms.TextBox();
            this.txt_CN_MaHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_XoaHang = new System.Windows.Forms.Button();
            this.txt_Xoa_GiaTien = new System.Windows.Forms.TextBox();
            this.txt_Xoa_TenHang = new System.Windows.Forms.TextBox();
            this.txt_Xoa_MaHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ThemHang = new System.Windows.Forms.Button();
            this.txt_Them_GiaTien = new System.Windows.Forms.TextBox();
            this.txt_Them_TenHang = new System.Windows.Forms.TextBox();
            this.txt_Them_MaHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.table_HangHoa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_HangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1077, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_CN);
            this.groupBox4.Controls.Add(this.txt_CN_GiaTien);
            this.groupBox4.Controls.Add(this.txt_CN_TenHang);
            this.groupBox4.Controls.Add(this.txt_CN_MaHang);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(722, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(352, 146);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cập nhật thông tin";
            // 
            // btn_CN
            // 
            this.btn_CN.Location = new System.Drawing.Point(224, 114);
            this.btn_CN.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CN.Name = "btn_CN";
            this.btn_CN.Size = new System.Drawing.Size(100, 28);
            this.btn_CN.TabIndex = 9;
            this.btn_CN.Text = "Cập Nhật";
            this.btn_CN.UseVisualStyleBackColor = true;
            this.btn_CN.Click += new System.EventHandler(this.btn_CN_Click);
            // 
            // txt_CN_GiaTien
            // 
            this.txt_CN_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CN_GiaTien.Location = new System.Drawing.Point(85, 85);
            this.txt_CN_GiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CN_GiaTien.Name = "txt_CN_GiaTien";
            this.txt_CN_GiaTien.Size = new System.Drawing.Size(237, 26);
            this.txt_CN_GiaTien.TabIndex = 8;
            this.txt_CN_GiaTien.TextChanged += new System.EventHandler(this.txt_CN_GiaTien_TextChanged);
            this.txt_CN_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CN_GiaTien_KeyPress);
            // 
            // txt_CN_TenHang
            // 
            this.txt_CN_TenHang.Location = new System.Drawing.Point(85, 54);
            this.txt_CN_TenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CN_TenHang.Name = "txt_CN_TenHang";
            this.txt_CN_TenHang.Size = new System.Drawing.Size(237, 22);
            this.txt_CN_TenHang.TabIndex = 7;
            // 
            // txt_CN_MaHang
            // 
            this.txt_CN_MaHang.Enabled = false;
            this.txt_CN_MaHang.Location = new System.Drawing.Point(85, 23);
            this.txt_CN_MaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CN_MaHang.Name = "txt_CN_MaHang";
            this.txt_CN_MaHang.Size = new System.Drawing.Size(237, 22);
            this.txt_CN_MaHang.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giá Tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tên Hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mã Hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_XoaHang);
            this.groupBox3.Controls.Add(this.txt_Xoa_GiaTien);
            this.groupBox3.Controls.Add(this.txt_Xoa_TenHang);
            this.groupBox3.Controls.Add(this.txt_Xoa_MaHang);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(363, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(359, 146);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xóa Hàng";
            // 
            // btn_XoaHang
            // 
            this.btn_XoaHang.Location = new System.Drawing.Point(224, 114);
            this.btn_XoaHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_XoaHang.Name = "btn_XoaHang";
            this.btn_XoaHang.Size = new System.Drawing.Size(100, 28);
            this.btn_XoaHang.TabIndex = 9;
            this.btn_XoaHang.Text = "Xóa";
            this.btn_XoaHang.UseVisualStyleBackColor = true;
            this.btn_XoaHang.Click += new System.EventHandler(this.btn_XoaHang_Click);
            // 
            // txt_Xoa_GiaTien
            // 
            this.txt_Xoa_GiaTien.Enabled = false;
            this.txt_Xoa_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Xoa_GiaTien.Location = new System.Drawing.Point(85, 85);
            this.txt_Xoa_GiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Xoa_GiaTien.Name = "txt_Xoa_GiaTien";
            this.txt_Xoa_GiaTien.Size = new System.Drawing.Size(237, 26);
            this.txt_Xoa_GiaTien.TabIndex = 8;
            this.txt_Xoa_GiaTien.TextChanged += new System.EventHandler(this.txt_Xoa_GiaTien_TextChanged);
            this.txt_Xoa_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Xoa_GiaTien_KeyPress);
            // 
            // txt_Xoa_TenHang
            // 
            this.txt_Xoa_TenHang.Enabled = false;
            this.txt_Xoa_TenHang.Location = new System.Drawing.Point(85, 54);
            this.txt_Xoa_TenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Xoa_TenHang.Name = "txt_Xoa_TenHang";
            this.txt_Xoa_TenHang.Size = new System.Drawing.Size(237, 22);
            this.txt_Xoa_TenHang.TabIndex = 7;
            // 
            // txt_Xoa_MaHang
            // 
            this.txt_Xoa_MaHang.Enabled = false;
            this.txt_Xoa_MaHang.Location = new System.Drawing.Point(85, 23);
            this.txt_Xoa_MaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Xoa_MaHang.Name = "txt_Xoa_MaHang";
            this.txt_Xoa_MaHang.Size = new System.Drawing.Size(237, 22);
            this.txt_Xoa_MaHang.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã Hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ThemHang);
            this.groupBox2.Controls.Add(this.txt_Them_GiaTien);
            this.groupBox2.Controls.Add(this.txt_Them_TenHang);
            this.groupBox2.Controls.Add(this.txt_Them_MaHang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(4, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(359, 146);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm Hàng";
            // 
            // btn_ThemHang
            // 
            this.btn_ThemHang.Location = new System.Drawing.Point(224, 114);
            this.btn_ThemHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThemHang.Name = "btn_ThemHang";
            this.btn_ThemHang.Size = new System.Drawing.Size(100, 28);
            this.btn_ThemHang.TabIndex = 9;
            this.btn_ThemHang.Text = "Thêm";
            this.btn_ThemHang.UseVisualStyleBackColor = true;
            this.btn_ThemHang.Click += new System.EventHandler(this.btn_ThemHang_Click);
            // 
            // txt_Them_GiaTien
            // 
            this.txt_Them_GiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Them_GiaTien.Location = new System.Drawing.Point(85, 85);
            this.txt_Them_GiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Them_GiaTien.Name = "txt_Them_GiaTien";
            this.txt_Them_GiaTien.Size = new System.Drawing.Size(237, 26);
            this.txt_Them_GiaTien.TabIndex = 8;
            this.txt_Them_GiaTien.TextChanged += new System.EventHandler(this.txt_Them_GiaTien_TextChanged);
            this.txt_Them_GiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Them_GiaTien_KeyPress);
            // 
            // txt_Them_TenHang
            // 
            this.txt_Them_TenHang.Location = new System.Drawing.Point(85, 54);
            this.txt_Them_TenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Them_TenHang.Name = "txt_Them_TenHang";
            this.txt_Them_TenHang.Size = new System.Drawing.Size(237, 22);
            this.txt_Them_TenHang.TabIndex = 7;
            // 
            // txt_Them_MaHang
            // 
            this.txt_Them_MaHang.Location = new System.Drawing.Point(85, 23);
            this.txt_Them_MaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Them_MaHang.Name = "txt_Them_MaHang";
            this.txt_Them_MaHang.Size = new System.Drawing.Size(237, 22);
            this.txt_Them_MaHang.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Hàng";
            // 
            // table_HangHoa
            // 
            this.table_HangHoa.AllowUserToAddRows = false;
            this.table_HangHoa.AllowUserToDeleteRows = false;
            this.table_HangHoa.AllowUserToResizeRows = false;
            this.table_HangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_HangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_HangHoa.Location = new System.Drawing.Point(0, 169);
            this.table_HangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.table_HangHoa.Name = "table_HangHoa";
            this.table_HangHoa.ReadOnly = true;
            this.table_HangHoa.RowHeadersWidth = 51;
            this.table_HangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_HangHoa.Size = new System.Drawing.Size(1077, 728);
            this.table_HangHoa.TabIndex = 1;
            this.table_HangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_HangHoa_CellClick);
            this.table_HangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_HangHoa_CellContentClick);
            // 
            // QL_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table_HangHoa);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QL_HangHoa";
            this.Size = new System.Drawing.Size(1077, 897);
            this.EnabledChanged += new System.EventHandler(this.QL_HangHoa_EnabledChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_HangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_CN;
        private System.Windows.Forms.TextBox txt_CN_GiaTien;
        private System.Windows.Forms.TextBox txt_CN_TenHang;
        private System.Windows.Forms.TextBox txt_CN_MaHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_XoaHang;
        private System.Windows.Forms.TextBox txt_Xoa_GiaTien;
        private System.Windows.Forms.TextBox txt_Xoa_TenHang;
        private System.Windows.Forms.TextBox txt_Xoa_MaHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ThemHang;
        private System.Windows.Forms.TextBox txt_Them_GiaTien;
        private System.Windows.Forms.TextBox txt_Them_TenHang;
        private System.Windows.Forms.TextBox txt_Them_MaHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView table_HangHoa;
    }
}
