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
    public partial class Thêm_Bình_Luận : Form
    {
        private string _maTK;
        private int _idBaiDang;
        private KetNoi _kn;

        public Thêm_Bình_Luận()
        {
            InitializeComponent();
        }

        public Thêm_Bình_Luận(string maTK, int idBaiDang)
            : this()
        {
            _maTK = maTK;
            _idBaiDang = idBaiDang;
            _kn = new KetNoi();
        }
        
        private void Thêm_Bình_Luận_Load(object sender, EventArgs e)
        {
            txt_IDBaiDang.Text = _idBaiDang.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_IDBaiDang.Text, out int IdBaiDang))
            {
                MessageBox.Show("Không có bài đăng được chọn !");
                this.Close();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txt_ND.Text))
            {
                MessageBox.Show("Bạn chưa nhập nội dung");
                txt_ND.Focus();
                return;
            }

            string sql = "INSERT INTO [BinhLuan] ([IDBaiDang], [NoiDung], [NgayTao], [TrangThai], [MaTK]) VALUES (@IDBaiDang, @NoiDung, @NgayTao, @TrangThai, @MaTK)";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@IdBaiDang", IdBaiDang),
                new SqlParameter("@NoiDung", txt_ND.Text),
                new SqlParameter("@NgayTao", dtp_NT.Value),
                new SqlParameter("@TrangThai", 1),
                new SqlParameter("@MaTK", _maTK)
            };

            bool kq = _kn.ThucThiLenh(sql, param);

            if (kq == true)
            {
                MessageBox.Show("Thêm mới bình luận thành công !");
            }
            else
            {
                MessageBox.Show("Thêm mới bình luận thất bại !");
            }

            this.Close();
        }
    }
}
