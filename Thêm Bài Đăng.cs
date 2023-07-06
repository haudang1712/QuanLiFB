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
    public partial class Thêm_Bài_Đăng : Form
    {
        public Thêm_Bài_Đăng()
        {
            InitializeComponent();
        }
        
        private string _maTK;
        private KetNoi _kn;
        public Thêm_Bài_Đăng(string maTK)
            : this()
        {
            _maTK = maTK;
            _kn = new KetNoi();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TD.Text))
            {
                MessageBox.Show("Bạn chưa nhập tiêu đề");
                txt_TD.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_ND.Text))
            {
                MessageBox.Show("Bạn chưa nhập nội dung");
                txt_ND.Focus();
                return;
            }

            string sql = "INSERT INTO [BaiDang] ([TieuDe], [NoiDung], [HinhAnh], [NgayTao], [NgaySua], [TrangThai], [MaTK]) VALUES (@TieuDe, @NoiDung, @HinhAnh, @NgayTao, @NgaySua, @TrangThai, @MaTK)";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@TieuDe", txt_TD.Text),
                new SqlParameter("@NoiDung", txt_ND.Text),
                new SqlParameter("@HinhAnh", txt_HA.Text),
                new SqlParameter("@NgayTao", dtp_NT.Value),
                new SqlParameter("@NgaySua", dtp_NS.Value),
                new SqlParameter("@TrangThai", 1),
                new SqlParameter("@MaTK", _maTK)
            };

            bool kq = _kn.ThucThiLenh(sql, param);
            
            if (kq == true)
            {
                MessageBox.Show("Thêm mới bài đăng thành công !");
            } else
            {
                MessageBox.Show("Thêm mới bài đăng thất bại !");
            }
            
            this.Close();
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                   txt_HA.Text = dlg.FileName;
                   pic_HinhAnh.ImageLocation = dlg.FileName;
                }
            }
        }

        private void Thêm_Bài_Đăng_Load(object sender, EventArgs e)
        {
            dtp_NT.Value = DateTime.Now;
            dtp_NS.Value = DateTime.Now;
        }
    }
}
