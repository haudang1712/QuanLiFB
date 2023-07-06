using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace testquanlifacebook
{
    // Lớp kết nối
    public class KetNoi
    {
        // Chuỗi kết nối với csdl, Datasource là địa chỉ máy tính, catalog là tên database
        private string chuoiKetNoi = "Data Source=LAPTOP-A9AFGL7F;Initial Catalog=QuanLyTaiKhoan;User ID=sa;Password=123";
        
        private SqlConnection conn;
        public KetNoi()
        {
            // Khởi tạo đối tượng kết nối
            conn = new SqlConnection(chuoiKetNoi);
        }

        // Đọc dữ liệu ra datatable với tham số nhận
        // vào là câu truy vấn và danh sách tham số 
        public DataTable DocDuLieu(string sql, SqlParameter[] v = null)
        {
            // Biến kết quả để trả về
            DataTable ketQua = new DataTable();
            // Mở kết nối nếu nếu nối chưa được mở
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string query = sql;
            // Tạo đối tượng command để chạy lệnh 
            SqlCommand cmd = new SqlCommand(query, conn);
            // Nếu có danh sách tham số truyền vào thì thêm vào
            // danh sách tham số của command
            if (v != null)
                cmd.Parameters.AddRange (v);
            //Khỏi tạo đối tượng dataadapter để chạy command
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                //Chạy command và lấy giá trị vào biến kết quả
                da.Fill(ketQua);
            }
            catch (Exception)
            {
            }
            // Đóng các đối tượng và kết nối khi chạy xong
            cmd.Dispose();
            conn.Close();
            da.Dispose();
            // Lấy ra kết quả
            return ketQua;
        }

        // Thực thi lệnh và kiểm tra số dòng bị tác động
        // bởi lệnh dùng cho các câu truy vấn update và delete
        // do không tra về giá trị
        public bool ThucThiLenh(string sql, SqlParameter[] v = null)
        {
            DataTable ketQua = new DataTable();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string query = sql;
            SqlCommand cmd = new SqlCommand(query, conn);
            if (v != null)
                cmd.Parameters.AddRange(v);
            bool result = false;
            try
            {
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                result = false;
            }
            cmd.Dispose();
            conn.Close();
            return result;
        }
    }
}
