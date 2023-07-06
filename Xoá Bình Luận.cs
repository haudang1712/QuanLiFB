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
    public partial class Xoá_Bình_Luận : Form
    {
        private int _idBinhLuan;
        private KetNoi _kn;

        public Xoá_Bình_Luận()
        {
            InitializeComponent();
        }

        public Xoá_Bình_Luận(int idBinhLuan)
            : this()
        {
            _idBinhLuan = idBinhLuan;
            _kn = new KetNoi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_IDBinhLuan.Text, out int IDBinhLuan))
            {
                MessageBox.Show("Không có bình luận được chọn !");
                this.Close();
                return;
            }

            string sql = "DELETE FROM [BinhLuan] WHERE [ID] = @ID";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ID", IDBinhLuan)
            };

            bool kq = _kn.ThucThiLenh(sql, param);

            if (kq == true)
            {
                MessageBox.Show("Xoá bình luận thành công !");
            }
            else
            {
                MessageBox.Show("Xoá bình luận thất bại !");
            }
            this.Close();
            
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
        
        private void Xoá_Bình_Luận_Load(object sender, EventArgs e)
        {
            HienThiBinhLuan();
        }
    }
}
