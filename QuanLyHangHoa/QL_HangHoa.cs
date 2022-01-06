using System;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class QL_HangHoa : UserControl
    {
        public QL_HangHoa()
        {
            InitializeComponent();
        }

        private void txt_Them_GiaTien_TextChanged(object sender, EventArgs e)
        {
            if (txt_Them_GiaTien.Text != String.Empty)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txt_Them_GiaTien.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_Them_GiaTien.Text = String.Format(culture, "{0:N0}", value);
                txt_Them_GiaTien.Select(txt_Them_GiaTien.Text.Length, 0);
            }
        }

        private void txt_Xoa_GiaTien_TextChanged(object sender, EventArgs e)
        {
            if (txt_Xoa_GiaTien.Text != String.Empty)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txt_Xoa_GiaTien.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_Xoa_GiaTien.Text = String.Format(culture, "{0:N0}", value);
                txt_Xoa_GiaTien.Select(txt_Xoa_GiaTien.Text.Length, 0);
            }
        }

        private void txt_CN_GiaTien_TextChanged(object sender, EventArgs e)
        {
            if (txt_CN_GiaTien.Text != String.Empty)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txt_CN_GiaTien.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_CN_GiaTien.Text = String.Format(culture, "{0:N0}", value);
                txt_CN_GiaTien.Select(txt_CN_GiaTien.Text.Length, 0);
            }
        }

        public void _DanhSachHangHoa()
        {
            KetNoiDB _ketnoi = new KetNoiDB();
            string _sql = "Select MaHang[Mã Hàng], TenHang[Tên Hàng], GiaTien[Giá Tiền], TonKho[Tồn Kho] from DanhSachHangHoa";
            table_HangHoa.DataSource = _ketnoi._data_table(_sql);
        }
        private void btn_ThemHang_Click(object sender, EventArgs e)
        {
            if ((txt_Them_MaHang.Text.Trim() == string.Empty) || (txt_Them_TenHang.Text.Trim() == string.Empty) || (txt_Them_GiaTien.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin về mặt hàng.");
                return;
            }
            //MessageBox.Show(txt_Them_GiaTien.Text.Trim().Replace(",", ""));
            KetNoiDB _ketnoi = new KetNoiDB();
            string _sql = string.Format("Insert into DanhSachHangHoa values ('{0}','{1}','{2}','{3}')",
                                        txt_Them_MaHang.Text.Trim().ToUpper(), txt_Them_TenHang.Text.Trim(), decimal.Parse( txt_Them_GiaTien.Text.Trim().Replace(".", "")),0);
            _ketnoi._execute(_sql);
            _DanhSachHangHoa();

        }

        private void QL_HangHoa_EnabledChanged(object sender, EventArgs e)
        {
            _DanhSachHangHoa();
        }

        private void txt_Them_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_Xoa_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_CN_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        

        private void btn_XoaHang_Click(object sender, EventArgs e)
        {
            if (txt_Xoa_MaHang.Text == string.Empty)
            {
                MessageBox.Show("hãy chọn hàng muốn xóa ở danh sách phía dưới.");
                return;
            }
            KetNoiDB _ketnoi = new KetNoiDB();
            string _sqlLSXuatKho = "Delete from LichSuXuatKho where MaHang = '" + txt_Xoa_MaHang.Text + "'";
            string _sqlHoaDon = "Delete from HoaDon where MaHang = '" + txt_Xoa_MaHang.Text + "'";
            string _sql = "Delete from DanhSachHangHoa where MaHang = '" + txt_Xoa_MaHang.Text + "'";
            _ketnoi._execute(_sqlLSXuatKho);
            _ketnoi._execute(_sqlHoaDon);
            _ketnoi._execute(_sql);
            _DanhSachHangHoa();
            txt_Xoa_MaHang.Clear(); txt_Xoa_TenHang.Clear(); txt_Xoa_GiaTien.Clear();
            txt_CN_MaHang.Clear(); txt_CN_TenHang.Clear(); txt_CN_GiaTien.Clear();
        }
        

        private void btn_CN_Click(object sender, EventArgs e)
        {
            if (txt_CN_MaHang.Text == string.Empty)
            {
                MessageBox.Show("hãy chọn hàng muốn cập nhật ở danh sách phía dưới.");
                return;
            }
            KetNoiDB _ketnoi = new KetNoiDB();
            string _sql = string.Format("Update DanhSachHangHoa set TenHang = '{0}', GiaTien = '{1}' WHERE MaHang = '{2}'", txt_CN_TenHang.Text.Trim(),
                        txt_CN_GiaTien.Text.Trim().Replace(",", ""), txt_CN_MaHang.Text);
            _ketnoi._execute(_sql);
            _DanhSachHangHoa();
            table_HangHoa.ClearSelection();
            txt_Xoa_MaHang.Clear(); txt_Xoa_TenHang.Clear(); txt_Xoa_GiaTien.Clear();
            txt_CN_MaHang.Clear(); txt_CN_TenHang.Clear(); txt_CN_GiaTien.Clear();
        }

        private void table_HangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (table_HangHoa.CurrentRow != null)
            //{
            //    txt_Xoa_MaHang.Text = table_HangHoa.CurrentRow.Cells[0].Value.ToString().Trim();
            //    txt_Xoa_TenHang.Text = table_HangHoa.CurrentRow.Cells[1].Value.ToString().Trim();
            //    txt_Xoa_GiaTien.Text = table_HangHoa.CurrentRow.Cells[2].Value.ToString().Trim();

            //    txt_CN_MaHang.Text = table_HangHoa.CurrentRow.Cells[0].Value.ToString().Trim();
            //    txt_CN_TenHang.Text = table_HangHoa.CurrentRow.Cells[1].Value.ToString().Trim();
            //    txt_CN_GiaTien.Text = table_HangHoa.CurrentRow.Cells[2].Value.ToString().Trim();
            //}
        }

        private void table_HangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table_HangHoa.CurrentRow != null)
            {
                txt_Xoa_MaHang.Text = table_HangHoa.CurrentRow.Cells[0].Value.ToString().Trim();
                txt_Xoa_TenHang.Text = table_HangHoa.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_Xoa_GiaTien.Text = table_HangHoa.CurrentRow.Cells[2].Value.ToString().Trim();

                txt_CN_MaHang.Text = table_HangHoa.CurrentRow.Cells[0].Value.ToString().Trim();
                txt_CN_TenHang.Text = table_HangHoa.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_CN_GiaTien.Text = table_HangHoa.CurrentRow.Cells[2].Value.ToString().Trim();
            }
        }
    }
}
