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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace testquanlifacebook
{
    public partial class Tạo_Tài_Khoản : Form
    {
        public Tạo_Tài_Khoản()
        {
            InitializeComponent();
        }
        
        KetNoi _kn = null;
        public Tạo_Tài_Khoản(string Message) 
            : this()
        {
           _kn = new KetNoi();
        }

        
        private void btn_tao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tk.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txt_tk.Focus();
                return;
            }

            string sql = "SELECT * FROM TAIKHOAN WHERE MaTK = @MaTK";
            SqlParameter[] v = new SqlParameter[] { 
                new SqlParameter("@MaTK", txt_tk.Text) 
            };

            DataTable dt = _kn.DocDuLieu(sql, v);
            
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                txt_tk.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txt_mk.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txt_mk.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_xnmk.Text))
            {
                MessageBox.Show("Bạn chưa nhập xác nhận mật khẩu");
                txt_xnmk.Focus();
                return;
            }

            if (txt_mk.Text != txt_xnmk.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                txt_xnmk.Focus();
                return;
            }

            sql = "INSERT INTO [TaiKhoan]([MaTK], [TenTK], [MatKhau], [Email], [SDT], [TrangThai]) VALUES(@MaTK, @TenTK, @MatKhau, @Email, @SDT, @TrangThai)";


            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaTK",txt_tk.Text),
                new SqlParameter("@TenTK",txt_tentk.Text),
                new SqlParameter("@MatKhau",txt_mk.Text),
                new SqlParameter("@Email", txt_email.Text),
                new SqlParameter("@SDT", txt_sdt.Text),
                new SqlParameter("@TrangThai", 1)
            };
            
            bool kq = _kn.ThucThiLenh(sql, para);
            
            if (kq == true)
            {
                MessageBox.Show("Tạo tài khoản thành công !!!");
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin !!!");
            }

        }

        private void txt_mk_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_mk_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void txt_tk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tk_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tk.Text))
            {
                e.Cancel = true;
                txt_tk.Focus();
                errorProvider1.SetError(txt_tk, "Hãy nhập vào tài khoản !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_tk, null);
            }
        }

        private void rdb_MK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienmk.Checked) 
            {
                txt_mk.PasswordChar = (char)0;
                txt_xnmk.PasswordChar = (char)0;
            }
            else
            {
                txt_mk.PasswordChar = '*';
                txt_xnmk.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
