using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            qlNhapHang1.Hide();
            qlXuatHang1.Hide();
            datMuaSP1.Hide();
            qL_HangHoa1.Hide();
        }

        private void btnQLDSHangHoa_Click(object sender, EventArgs e)
        {
            qL_HangHoa1.BringToFront();
            qL_HangHoa1.Show();
            qL_HangHoa1._DanhSachHangHoa();
        }

        private void btnQLNhapHang_Click(object sender, EventArgs e)
        {
            qlNhapHang1.BringToFront();
            qlNhapHang1.Show();
            qlNhapHang1._datatable();
            qlNhapHang1._Add_item();
        }

        private void btnQLXuatHang_Click(object sender, EventArgs e)
        {
            qlXuatHang1.BringToFront();
            qlXuatHang1.Show();
            qlXuatHang1._DanhSachDonHang();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            datMuaSP1.BringToFront();
            datMuaSP1.Show();
            datMuaSP1._TaoMaHD_MaHang();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDangNhap_Click(this, null);
            lblDangNhap.Text = "";
        }

        private void btn_XacNhanDN_Click(object sender, EventArgs e)
        {
            KetNoiDB _ketnoi = new KetNoiDB();
            string _sql = "Select * from NhanVien where TaiKhoan = '" + txtTaiKhoan.Text.Trim() + "' AND MatKhau = '" + txtMatKhau.Text.Trim() + "'";
            var _ketqua = _ketnoi._data_table(_sql);
            if(_ketqua.Rows.Count > 0)
            {
                lblDangNhap.Text = "Đăng nhập thành công.";
                if(_ketqua.Rows[0].Field<bool>("ChucVu") == true) //Quản lý
                {
                    btnQLXuatHang.Visible = true;
                    btnQLNhapHang.Visible = true;
                    btnQLDSHangHoa.Visible = true;
                }
                else
                {
                    btnQLDSHangHoa.Visible = false;
                    btnQLNhapHang.Visible = false;
                    btnQLXuatHang.Visible = false;
                }
            }
            else
            {
                lblDangNhap.Text = "Đăng nhập thất bại";
            }
        }

        private void btn_QuenMK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gọi số: 0123456789 để xin cấp lại mật khẩu.");
        }
    }
}
