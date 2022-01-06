using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace QuanLyHangHoa
{
    class KetNoiDB
    {
        //Localdb connection string
        //public static string _ChuoiKetNoi = @"Data Source = (localdb)\MSSQLLocalDB;AttachDbFilename=" + Path.Combine(Application.StartupPath, "QuanLyHangHoa.mdf") + "; Integrated Security = True";

        //SQL server connection string
        public static string _ChuoiKetNoi = @"Data Source=LEETUANNEE;Initial Catalog=QuanLyHangHoa;Integrated Security=True";
        SqlConnection conn;
        public void _ketnoi()
        {
            if (conn == null)
            {
                conn = new SqlConnection(_ChuoiKetNoi);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void _ngatketnoi()
        {
            if ((conn != null) && (conn.State == ConnectionState.Open))
            {
                conn.Close();
            }
        }

        // trả về một DataTable .

        public DataTable _data_table(string sql)
        {
            _ketnoi();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _ngatketnoi();
            return dt;
        }
        // thực thi câu lệnh truy vấn insert,delete,update
        public void _execute(string sql)
        {   
            _ketnoi();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            _ngatketnoi();
        }

        // trả về DataReader
        public SqlDataReader _data_reader(string sql)
        {
            _ketnoi();
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
    }
}
