using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testquanlifacebook
{
    public partial class Đăng_Tin : Form
    {
        public Đăng_Tin()
        {
            InitializeComponent();
        }
        
        string _maTK;
        KetNoi _kn;
        // Hàm khởi tạo form đăng tin nhận vào là mã tài khoản
        // của người dùng đăng nhập
        public Đăng_Tin(string maTK) 
            : this()
        {
            _maTK = maTK; // chứa mã tài khoản vào biến cục bộ
            _kn = new KetNoi(); // Khởi tạo lớp kết nối
        }
        
        
        // Hiển thị danh sách bài đăng
        private void LoadDSBaiDang()
        {
            // Truy vấn lấy ra tất cả danh sách bài đăng
            string sql = "SELECT * FROM BaiDang";
            DataTable dsBaiDang = _kn.DocDuLieu(sql);
            // Xoá trống danh sách bài đăng
            lv_dsbaidang.Items.Clear();
            // Duyệt qua từng dòng dữ liệu bài đăng và hiển thị vào danh sách
            foreach (DataRow row in dsBaiDang.Rows)
            {
                ListViewItem item = new ListViewItem(row["ID"].ToString());
                item.SubItems.Add(row["TieuDe"].ToString());
                item.SubItems.Add(row["NoiDung"].ToString());
                item.SubItems.Add(row["HinhAnh"].ToString());
                item.SubItems.Add(row["NgayTao"].ToString());
                item.SubItems.Add(row["NgaySua"].ToString());
                item.SubItems.Add(row["TrangThai"].ToString());
                item.SubItems.Add(row["MaTK"].ToString());
                lv_dsbaidang.Items.Add(item);
            }
        }
        
        // Khi form load lên thì nạp thông tin bài đăng
        private void Đăng_Tin_Load(object sender, EventArgs e)
        {
            
            LoadDSBaiDang();
        }

        // Khi người dùng nhấn vào thêm bài đăng
        private void btn_them_Click(object sender, EventArgs e)
        {
            // Khởi tạo form thêm bài đăng
            Thêm_Bài_Đăng frm = new Thêm_Bài_Đăng(_maTK);
            frm.ShowDialog();
            // sau khi thêm vào và đóng form thêm bài đăng thì nạp lại danh sách
            // bài đăng mới 
            this.LoadDSBaiDang();
        }

        // Xoá bài đăng
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // Nếu không có mục nào được chọn trong danh sách
            // thì không làm gì cả.
            if (lv_dsbaidang.SelectedItems.Count <= 0)
                return;

            // Lấy ra mã bài đăng của mục được chọn
            if (int.TryParse(lv_dsbaidang.SelectedItems[0].Text, out int ID))
            {
                // Khởi tạo form xoá bài đăng với tham số 
                // truyền vào là mã tài khoản của người dùng đăng nhập
                // và id bài đăng
                Xóa_bài_Đăng frm = new Xóa_bài_Đăng(_maTK, ID);
                frm.ShowDialog();
                // Nạp lại danh sách bài đăng
                this.LoadDSBaiDang();
            } else
            {
                MessageBox.Show("Không thể xóa bài đăng này");
            }
        }

        // Sửa bài đăng
        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Nếu không có mục nào được chọn trong danh sách
            if (lv_dsbaidang.SelectedItems.Count <= 0)
                return;

            // Lấy ra mã bài đăng của mục được chọn
            if (int.TryParse(lv_dsbaidang.SelectedItems[0].Text, out int ID))
            {
                // Khởi tạo form sửa bài đăng với tham số
                Sửa_bài_Đăng frm = new Sửa_bài_Đăng(_maTK, ID);
                
                frm.ShowDialog();
                // Nạp lại danh sách bài đăng
                this.LoadDSBaiDang();
            }
            else
            {
                MessageBox.Show("Không thể sửa bài đăng này");
            }
        }

        private void btn_themcomment_Click(object sender, EventArgs e)
        {
            // Nếu không có mục nào được chọn trong danh sách ghi chú thì 
            // không làm gì
            if (lv_dsbaidang.SelectedItems.Count <= 0)
                return;

            // Lấy ra mã bài đăng của mục được chọn
            // Hàm tryparse chuyển chuỗi thành số và xuất ra biến giá trị 
            // vừa chuyển được
            if (int.TryParse(lv_dsbaidang.SelectedItems[0].Text, out int ID))
            {
                // Khởi tạo form thêm bình luận với tham số là mã tài khoản và id của bài đăng
                Thêm_Bình_Luận frm = new Thêm_Bình_Luận(_maTK, ID);
                frm.ShowDialog();
                this.LoadDanhSachComment();
            }
            else
            {
                MessageBox.Show("Không có bài đăng nào được chọn !");
            }
        }

        
        private void lv_dsbaidang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_dsbaidang.SelectedItems.Count <= 0)
                return;
            // Lấy ra liên kết hình ảnh tại cột thứ 4
            string hinhAnh = lv_dsbaidang.SelectedItems[0].SubItems[3].Text;
            // Hiển thị hình ảnh ra picturebox
            pic_HinhAnh.ImageLocation = hinhAnh;
            // Hiển thị danh sách comment
            LoadDanhSachComment();
        }

        // Hiển thị danh sách comment
        private void LoadDanhSachComment()
        {
            if (lv_dsbaidang.SelectedItems.Count <= 0)
                return;

            // Lấy id đang được chọn từ danh sách bài đăng
            if (int.TryParse(lv_dsbaidang.SelectedItems[0].Text, out int iD))
            {
                // Truy vấn lấy tất cả bình luận có id là id bài đăng được chọn
                string sql = "SELECT * FROM BinhLuan WHERE IDBaiDang = " + iD;
                DataTable dsBinhLuan = _kn.DocDuLieu(sql);

                lv_dsbinhluan.Items.Clear();
                // Hiển thị danh sách bình luận ra listbox
                foreach (DataRow row in dsBinhLuan.Rows)
                {
                    ListViewItem item = new ListViewItem(row["ID"].ToString());
                    item.SubItems.Add(row["IdBaiDang"].ToString());
                    item.SubItems.Add(row["NoiDung"].ToString());
                    item.SubItems.Add(row["NgayTao"].ToString());
                    item.SubItems.Add(row["TrangThai"].ToString());
                    item.SubItems.Add(row["MaTK"].ToString());
                    lv_dsbinhluan.Items.Add(item);
                }
            }  
        }

        // Xoá bình luận
        private void btn_xoabinhluan_Click(object sender, EventArgs e)
        {
            if (lv_dsbinhluan.SelectedItems.Count <= 0)
                return;

            // Lấy ra mã bài đăng của mục được chọn
            if (int.TryParse(lv_dsbinhluan.SelectedItems[0].Text, out int ID))
            {
                Xoá_Bình_Luận frm = new Xoá_Bình_Luận(ID);
                frm.ShowDialog();
                LoadDanhSachComment();
            }
            else
            {
                MessageBox.Show("Không thể xóa bình luận này");
            }
        }

        // Sửa bình luận
        private void btn_suabinhluan_Click(object sender, EventArgs e)
        {
            if (lv_dsbinhluan.SelectedItems.Count <= 0)
                return;

            // Lấy ra mã bài đăng của mục được chọn
            if (int.TryParse(lv_dsbinhluan.SelectedItems[0].Text, out int ID))
            {
                Sửa_Bình_Luận frm = new Sửa_Bình_Luận(ID);
                frm.ShowDialog();
                LoadDanhSachComment();
            }
            else
            {
                MessageBox.Show("Không thể sửa bình luận này");
            }
        }
    }
}
