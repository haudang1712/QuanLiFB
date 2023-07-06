using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testquanlifacebook
{
    public partial class Xóa_bài_Đăng : Form
    {
        public Xóa_bài_Đăng()
        {
            InitializeComponent();
        }

        private string _maTK;
        private int _Id;
        KetNoi _kn;
        public Xóa_bài_Đăng(string maTK, int Id) 
            : this()
        {
            _kn = new KetNoi();
            _maTK = maTK;
            _Id = Id;
        }
        
        private void HienThiThongTinBaiDang(DataTable tb)
        {
            if (tb.Rows.Count <= 0)
                return;
            
            txt_ID.Text = tb.Rows[0]["ID"].ToString();
            txt_TD.Text = tb.Rows[0]["TieuDe"].ToString();
            txt_ND.Text = tb.Rows[0]["NoiDung"].ToString();
            txt_HA.Text = tb.Rows[0]["HinhAnh"].ToString();
            dtp_NT.Value = tb.Rows[0].Field<DateTime>("NgayTao");
            dtp_NS.Value = tb.Rows[0].Field<DateTime>("NgaySua");
            txt_TT.Text = tb.Rows[0].Field<bool>("TrangThai") ? "Đang hoạt động" : "Đã xóa";

            if (!string.IsNullOrWhiteSpace(txt_HA.Text))
            {
                pic_HinhAnh.ImageLocation = txt_HA.Text;
            }
        }
        
        private void Xóa_bài_Đăng_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM BaiDang WHERE ID = @ID";
            
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ID", _Id)
            };

            DataTable tb = _kn.DocDuLieu(sql, param);
            HienThiThongTinBaiDang(tb);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_ID.Text, out int Id))
            {
                MessageBox.Show("Không có bài đăng được chọn !");
                this.Close();
                return;
            }

            // Xoá bình luận
            string sql = "DELETE FROM BinhLuan WHERE IDBaiDang = @IDBaiDang";
            
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@IDBaiDang", Id)
            };
            // Xoá tất cả bình luận có id là id bài đăng
            bool kq = _kn.ThucThiLenh(sql, param);
            
            // Xoá bài đăng
            sql = "DELETE FROM BaiDang WHERE ID = @ID";

            param = new SqlParameter[]
            {
            new SqlParameter("@ID", _Id)
            };

            kq = _kn.ThucThiLenh(sql, param);

            if (kq == true)
            {
                MessageBox.Show("Xóa bài đăng thành công !");
            }
            else
            {
                MessageBox.Show("Xóa bài đăng thất bại !");
            }
            
            this.Close();
            return;
        }
    }
}
