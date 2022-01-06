using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class DatMuaSP : UserControl
    {
        public DatMuaSP()
        {
            InitializeComponent();
        }
        public void _TaoMaHD_MaHang()
        {
            KetNoiDB _ketnoi = new KetNoiDB();
            string _sql = "Select * from QLHoaDon";
            var _dt = _ketnoi._data_table(_sql);
            txtMaHoaDon.Text = (_dt.Rows.Count + 1).ToString();

            string _sqlMaHang = "Select MaHang from DanhSachHangHoa";
            var _dtMaHang = _ketnoi._data_table(_sqlMaHang);
            txtMaHang.Items.Clear();
            for(int i = 0; i < _dtMaHang.Rows.Count; i++)
            {
                txtMaHang.Items.Add(_dtMaHang.Rows[i].Field<string>("MaHang"));
            }
        }
        private void btnDatMua_Click(object sender, EventArgs e)
        {
            if(table_HangHoa.Rows.Count <= 0 )
            {
                MessageBox.Show("Chưa chọn mua hàng hóa nào. Hãy chọn mua hàng trước khi thanh toán");
                return;
            }
            if((txtHoTen.Text.Trim() == String.Empty) || (txtDiaChi.Text.Trim() == String.Empty) || (txtSDT.Text.Trim() == String.Empty))
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin nhận hàng.");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn muốn đặt mua các sản phẩm ở trong danh sách ?.", "Xác nhận mua hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                KetNoiDB _ketnoi = new KetNoiDB();
                string _sqlMaHD = string.Format("Insert into QLHoaDon values ('{0}','{1}','{2}','{3}','0')", txtMaHoaDon.Text.Trim(), txtHoTen.Text.Trim(),
                    txtDiaChi.Text.Trim(), txtSDT.Text.Trim());
                _ketnoi._execute(_sqlMaHD);
                foreach (DataGridViewRow row in table_HangHoa.Rows)
                {
                    string _sql = string.Format("Insert into HoaDon values ('{0}','{1}','{2}','{3}')", txtMaHoaDon.Text.Trim(), row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString().Replace(",",""));
                    _ketnoi._execute(_sql);
                }

                FrmThanhToan frm = new FrmThanhToan();
                frm._maHD = txtMaHoaDon.Text;
                frm.ShowDialog();
                table_HangHoa.Rows.Clear();
                txtGiaTien.Clear();
                txtSoLuong.Value = 0;
                txtMaHang.SelectedIndex = -1;
            }
        }
        decimal _GiaTien = 0;
        int _TonKho = 0;
        private void txtMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtMaHang.SelectedIndex != -1)
            {
                KetNoiDB _ketnoi = new KetNoiDB();
                string _sql = "Select GiaTien, TonKho from DanhSachHangHoa where MaHang = '" + txtMaHang.SelectedItem.ToString() + "'";
                var _dt = _ketnoi._data_table(_sql);
                if (_dt.Rows.Count > 0)
                {
                    _GiaTien = _dt.Rows[0].Field<decimal>("GiaTien");
                    _TonKho = _dt.Rows[0].Field<int>("TonKho");
                }
            }
        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if(txtSoLuong.Value > _TonKho)
            {
                MessageBox.Show("Hàng tồn kho chỉ còn: " + _TonKho + ", không thể đặt thêm");
                txtSoLuong.Value = _TonKho;
                return;
            }
            txtGiaTien.Text = (_GiaTien * int.Parse(txtSoLuong.Value.ToString())).ToString();
        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaTien.Text != String.Empty)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txtGiaTien.Text, System.Globalization.NumberStyles.AllowThousands);
                txtGiaTien.Text = String.Format(culture, "{0:N0}", value);
                txtGiaTien.Select(txtGiaTien.Text.Length, 0);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            table_HangHoa.Rows.Add(txtMaHang.Text, txtSoLuong.Value.ToString(), txtGiaTien.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (table_HangHoa.CurrentRow != null)
            {
                table_HangHoa.Rows.Remove(table_HangHoa.CurrentRow);
            }
        }
    }
}
