using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testquanlifacebook
{
    public partial class Sửa_bài_Đăng : Form
    {
        // Tài khoản sửa bài
        private readonly string _maTK;
        // ID bài
        private readonly int _iD;

        public Sửa_bài_Đăng()
        {
            InitializeComponent();
        }

        KetNoi _kn;
        public Sửa_bài_Đăng(string maTK, int ID) 
            : this()
        {
            _kn = new KetNoi();
            _maTK = maTK;
            _iD = ID;
        }
        
        private void btn_sua_click(object sender, EventArgs e)
        {
            // Kiểm tra coi giá trị id có phải kiểu số hay không
            
            if (!int.TryParse(txt_ID.Text, out int Id))
            {
                MessageBox.Show("Không có bài đăng được chọn !");
                this.Close();
                return;
            }

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

            // Câu truy vấn update với các tham số
            string sql = "UPDATE [BaiDang] SET    [TieuDe] = @TieuDe, [NoiDung] = @NoiDung, [HinhAnh] = @HinhAnh, [NgayTao] = @NgayTao, [NgaySua] = @NgaySua, [TrangThai] = @TrangThai, [MaTK] = @MaTK WHERE  [ID] = @ID";

            // Khởi tạo danh sách tham số
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ID", _iD),
                new SqlParameter("@TieuDe", txt_TD.Text),
                new SqlParameter("@NoiDung", txt_ND.Text),
                new SqlParameter("@HinhAnh", txt_HA.Text),
                new SqlParameter("@NgayTao", dtp_NT.Value),
                new SqlParameter("@NgaySua", DateTime.Now),
                new SqlParameter("@TrangThai", 1),
                new SqlParameter("@MaTK", _maTK)
            };

            // Thực thi lệnh và kiểm tra kết quả
            bool kq = _kn.ThucThiLenh(sql, param);

            if (kq == true)
            {
                MessageBox.Show("Sửa bài đăng thành công !");
            }
            else
            {
                MessageBox.Show("Sửa bài đăng thất bại !");
            }
            
            this.Close();
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            // Khởi tạo hộp thoại mở tập tin để chọn file hình
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn hình ảnh";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                // Nếu người dùng nhấn ok thì lấy đường 
                // dẫn gán vào textbox
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txt_HA.Text = dlg.FileName;
                    pic_HinhAnh.ImageLocation = dlg.FileName;
                }
            }
        }

        private void HienThiThongTinBaiDang(DataTable tb)
        {
            if (tb.Rows.Count <= 0)
                return;
            // Lấy thông tin bài đăng ở dòng thứ 0 của datatable 
            // và hiển thị ra
            txt_ID.Text = tb.Rows[0]["ID"].ToString();
            txt_TD.Text = tb.Rows[0]["TieuDe"].ToString();
            txt_ND.Text = tb.Rows[0]["NoiDung"].ToString();
            txt_HA.Text = tb.Rows[0]["HinhAnh"].ToString();
            // Trường ngày tạo, ngay sửa, trạng thái có kiểu khác
            // kiểu chuỗi nên dùng hàm Field để lấy kiểu tương ứng
            dtp_NT.Value = tb.Rows[0].Field<DateTime>("NgayTao");
            dtp_NS.Value = tb.Rows[0].Field<DateTime>("NgaySua");
            txt_TT.Text = tb.Rows[0].Field<bool>("TrangThai") ? "Đang hoạt động" : "Đã xóa";
            // Hiển thị hình ảnh
            if (!string.IsNullOrWhiteSpace(txt_HA.Text))
            {
                pic_HinhAnh.ImageLocation = txt_HA.Text;
            }
        }
        
        // Khi form sửa bài đăng được nạp lên
        private void Sửa_bài_Đăng_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM BaiDang WHERE ID = @ID";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ID", _iD)
            };

            DataTable tb = _kn.DocDuLieu(sql, param);
            HienThiThongTinBaiDang(tb);
        }
    }
}
