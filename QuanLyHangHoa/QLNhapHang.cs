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
    public partial class QLNhapHang : UserControl
    {
        public QLNhapHang()
        {
            InitializeComponent();
        }
        public void _Add_item()
        {
            txtMaHang.Items.Clear();
            KetNoiDB _ketnoi = new KetNoiDB();
            string _sql = "select MaHang from DanhSachHangHoa";
            var _data = _ketnoi._data_reader(_sql);
            if (_data.HasRows)
            {
                foreach (var row in _data)
                {
                    txtMaHang.Items.Add(_data["MaHang"].ToString().Trim());
                }
            }
        }
        public void _datatable()
        {
            KetNoiDB _ketnoi = new KetNoiDB();
            string _sql = "Select MaHang[Mã Hàng], TenHang[Tên Hàng], GiaTien[Giá Tiền], TonKho[Tồn Kho] from DanhSachHangHoa";
            table_HangHoa.DataSource = _ketnoi._data_table(_sql);
        }
        private void txtMaHang_DropDown(object sender, EventArgs e)
        {
            _Add_item();
        }

        decimal _giatien = 0;
        int _soluongton = 0;
        int _soluong = 0;
        private void txtMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtMaHang.SelectedIndex != -1)
            {
               
                string _mahang = txtMaHang.SelectedItem.ToString();
                KetNoiDB _ketnoi = new KetNoiDB();
                string _sql = "Select * from DanhSachHangHoa where MaHang = '" + _mahang + "'";
                var _dt = _ketnoi._data_table(_sql);
                if(_dt.Rows.Count > 0)
                {
                    _giatien = _dt.Rows[0].Field<decimal>("GiaTien");
                    _soluongton = _dt.Rows[0].Field<int>("TonKho");
                }                
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (txtMaHang.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Xác nhận nhập hàng ?.", "Nhập hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    KetNoiDB _ketnoi = new KetNoiDB();
                    _soluong = int.Parse(txtSoLuong.Value.ToString());
                    var _Tongtien = _soluong * _giatien;
                    int _TongTonKho = _soluong + _soluongton;
                    string _sqlupdate = "Update DanhSachHangHoa Set TonKho = '" + _TongTonKho + "' where MaHang = '" + txtMaHang.SelectedItem.ToString() + "'";
                    _ketnoi._execute(_sqlupdate);
                    _datatable();
                }
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
        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtTongTien.Text = (int.Parse(txtSoLuong.Value.ToString()) * _giatien).ToString();
        }
    }
}
