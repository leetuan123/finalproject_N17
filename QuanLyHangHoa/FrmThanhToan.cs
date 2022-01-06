using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace QuanLyHangHoa
{
    public partial class FrmThanhToan : Form
    {
        public FrmThanhToan()
        {
            InitializeComponent();
        }
        public string _maHD = string.Empty;
        Decimal _TongTien = 0;
        private void _TaoMaQR()
        {
            var qrcode_text = $"2|99|{txtPhone.Text.Trim()}|{txtCongty.Text.Trim()}|{txtMail.Text.Trim()}|0|0|{_TongTien.ToString()}";
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);           
            picBox.Image = bitmap;
        }
        public void _TinhTongTien()
        {
            KetNoiDB _ketnoi = new KetNoiDB();
            string _sql = "Select TongTien from HoaDon Where MaHD = " + _maHD;
            var _dt = _ketnoi._data_table(_sql);
            for(int i = 0; i < _dt.Rows.Count; i++)
            {
                _TongTien += _dt.Rows[i].Field<decimal>("TongTien");
            }
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            _TinhTongTien();
            _TaoMaQR();
            lblTongTien.Text = _TongTien.ToString();
        }

        private void lblTongTien_TextChanged(object sender, EventArgs e)
        {
            if (lblTongTien.Text != String.Empty)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(lblTongTien.Text, System.Globalization.NumberStyles.AllowThousands);
                lblTongTien.Text = String.Format(culture, "{0:N0}", value);
                //lblTongTien.Select(lblTongTien.Text.Length, 0);
            }
        }
    }
}
