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
    public partial class Sửa_Bình_Luận : Form
    {
        private int _idBinhLuan;
        private KetNoi _kn;

        public Sửa_Bình_Luận()
        {
            InitializeComponent();
        }

        public Sửa_Bình_Luận(int idBinhLuan)
            : this()
        {
            _idBinhLuan = idBinhLuan;
            _kn = new KetNoi();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_IDBinhLuan.Text, out int IDBinhLuan))
            {
                MessageBox.Show("Không có bình luận được chọn !");
                this.Close();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_ND.Text))
            {
                MessageBox.Show("Bạn chưa nhập nội dung");
                txt_ND.Focus();
                return;
            }

            string sql = "UPDATE [BinhLuan] SET [NoiDung] = @NoiDung WHERE  [ID] = @ID";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ID", _idBinhLuan),
                new SqlParameter("@NoiDung", txt_ND.Text)
            };

            bool kq = _kn.ThucThiLenh(sql, param);

            if (kq == true)
            {
                MessageBox.Show("Cập nhật bình luận thành công !");
            }
            else
            {
                MessageBox.Show("Cập nhật bình luận không thành công !");
            }

            this.Close();
        }

        private void Sửa_Bình_Luận_Load(object sender, EventArgs e)
        {
            HienThiBinhLuan();
        }

        private void HienThiBinhLuan()
        {
            string sql = "SELECT * FROM BinhLuan WHERE ID = @ID";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ID", _idBinhLuan)
            };

            DataTable dt = _kn.DocDuLieu(sql, param);

            if (dt.Rows.Count > 0)
            {
                txt_IDBinhLuan.Text = dt.Rows[0]["ID"].ToString();
                txt_ND.Text = dt.Rows[0]["NoiDung"].ToString();
                dtp_NT.Value = (DateTime)dt.Rows[0]["NgayTao"];
            }
        }
    }
}
