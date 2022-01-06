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
    public partial class QLXuatHang : UserControl
    {
        public QLXuatHang()
        {
            InitializeComponent();
        }
        public void _DanhSachDonHang()
        {
            txtMaHD.Items.Clear();
            KetNoiDB _ketnoi = new KetNoiDB();
            string _sql = "Select MaHD from QLHoaDon";
            var _reader = _ketnoi._data_reader(_sql);
            if (_reader.HasRows)
            {
                foreach(var _rd in _reader)
                {
                    txtMaHD.Items.Add(_reader["MaHD"].ToString());
                }
            }
        }

        private void txtMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHang.Items.Clear();
            if(txtMaHD.SelectedIndex != -1)
            {
                KetNoiDB _ketnoi = new KetNoiDB();
                string _sql = "Select MaHang from HoaDon where MaHD = " + txtMaHD.Text.Trim();
                var _dt = _ketnoi._data_table(_sql);
                for(int i = 0; i < _dt.Rows.Count; i++)
                {
                    txtMaHang.Items.Add(_dt.Rows[i].Field<string>("MaHang"));
                }
            }
        }

        private void txtMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtMaHang.SelectedIndex != -1)
            {
                KetNoiDB _ketnoi = new KetNoiDB();
                string _sql = "Select SoLuong,MaHD,TongTien from HoaDon where MaHD = '" + txtMaHD.Text.Trim() + "' AND MaHang = '" + txtMaHang.Text.Trim() + "'";
                var _dt = _ketnoi._data_table(_sql);
                if(_dt.Rows.Count > 0)
                {
                    txtNgayXuat.Text = DateTime.Now.ToString("dd/MM/yyyy HH:ss");
                    txtSoLuong.Value = _dt.Rows[0].Field<int>("SoLuong");
                    txtTongTien.Text = _dt.Rows[0].Field<Decimal>("TongTien").ToString();
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                table_HangHoa.Rows.Add(txtMaHD.Text, txtMaHang.Text, txtSoLuong.Value.ToString(), txtNgayXuat.Text, txtTongTien.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hãy điền đầy đủ thông tin.");
            }
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xác nhận xuất hàng ?.", "Xác nhận.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                KetNoiDB _ketnoi = new KetNoiDB();
                string _sql = "Update QLHoaDon Set HoanThanh = '1' where maHD = '" + txtMaHD.Text.Trim() + "'";
                _ketnoi._execute(_sql);
                string _sql1 = "Delete from HoaDon where MaHD = '" + txtMaHD.Text.Trim() + "'";
                _ketnoi._execute(_sql1);
                table_HangHoa.Rows.Clear();
                MessageBox.Show("Xuất hàng thành công.");
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            if (txtTongTien.Text != String.Empty)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txtTongTien.Text, System.Globalization.NumberStyles.AllowThousands);
                txtTongTien.Text = String.Format(culture, "{0:N0}", value);
                txtTongTien.Select(txtTongTien.Text.Length, 0);
            }
        }
    }
}
