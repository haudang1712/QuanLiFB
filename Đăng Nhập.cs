using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using testquanlifacebook;

namespace testquanlifacebook
{
    public partial class Form1 : Form
    {

        public static string TaiKhoan = "";

        public object ConfigurationManager { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        // radio hiện mật khẩu
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienmk.Checked)
            {
                txt_MK.PasswordChar = (char)0;
            }
            else
            {
                txt_MK.PasswordChar = '*';
            }
        }
        //button đăng nhập
        private void btn_DN_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên tài khoản nhập vào không được rỗng
            if (string.IsNullOrWhiteSpace(txt_TK.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txt_TK.Focus();
                return;
            }
            
            // Kiểm tra mật khẩu nhập vào không được rỗng
            if (string.IsNullOrWhiteSpace(txt_MK.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txt_MK.Focus();
                return;
            }
            
            // Lấy giá trị của tài khoản và mật khẩu vào 2 biến tk và mk
            string tk = txt_TK.Text;
            string mk = txt_MK.Text;

            // Tạo câu truy vấn để kiểm tra tài khoản và mật khẩu có tồn tại trong CSDL hay không, với 2 tham số cần truyền vào là @MaTK và @MatKhau
            string sql = "select * from TaiKhoan where MaTK = @MaTK and MatKhau = @MatKhau";

            // Khai báo danh sách tham số cần truyền và giá trị tương ứng
            // được nhận từ 2 biến tk và mk
            SqlParameter[] v = new SqlParameter[] {
                new SqlParameter("@MaTK", tk),
                new SqlParameter("@MatKhau", mk)
            };

            // Gọi hàm đọc dữ liệu từ lớp kết nối với câu truy vấn và danh sách 
            // tham số, lấy kết quả trả về là một datatable
            // chứa các dòng dữ liệu nếu tài khoản và mật khẩu đúng
            DataTable tb = _kn.DocDuLieu(sql, v);

            // Nếu có dữ liệu
            if (tb.Rows.Count > 0)
            {
                // Ẩn form đăng nhập
                this.Hide();
                // Hiển thị thông báo đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công !");
                // Khởi tạo form đăng tin và hiển thị
                Đăng_Tin child = new Đăng_Tin(txt_TK.Text);
                child.ShowDialog();
                // Sau khi form đăng tin được đóng thì đóng luôn hộp thoại
                // login để đóng ứng dụng
                this.Close();
            } else
            {
                // Nếu không có dữ liệu thì thông báo đăng nhập thất bại
                MessageBox.Show("Đăng nhập không thành công ! Vui lòng kiểm tra lại tài khoản và mật khẩu !");
                return;
            }
            
        }

        private void txt_MK_TextChanged(object sender, EventArgs e)
        {
        }
        // Khi click chuột vào textbox tài khoản
        // thì chọn tất cả giá trị đang có trong textbox
        private void txt_TK_MouseClick(object sender, MouseEventArgs e)
        {
            txt_TK.SelectAll();
        }

        // Tương tự như textbox tài khoản
        private void txt_MK_MouseClick(object sender, MouseEventArgs e)
        {
            txt_MK.SelectAll();
        }

        // Khi người dùng nhấn nút thoát
        private void btn_out_Click(object sender, EventArgs e)
        {
            // Hỏi bạn có muốn thoát ứng dụng, nếu người dùng chọn 
            // yes thì thoát 
            
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_taotk_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Khởi tạo hộp thoại tạo tài khoản khi người dùng nhấn nút tạo tài khoản
            Tạo_Tài_Khoản child = new Tạo_Tài_Khoản(txt_TK.Text);
            // Hiển thị form tạo tài khoản
            child.ShowDialog();
            this.Show();
        }
        // Lớp kết nối dùng thao tác với csdl
        KetNoi _kn;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo lớp kết nối
            _kn = new KetNoi();
        }
    }
}

        
    

