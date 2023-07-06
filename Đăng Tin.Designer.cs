
namespace testquanlifacebook
{
    partial class Đăng_Tin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lv_dsbaidang = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themcomment = new System.Windows.Forms.Button();
            this.lv_dsbinhluan = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_xoabinhluan = new System.Windows.Forms.Button();
            this.btn_suabinhluan = new System.Windows.Forms.Button();
            this.pic_HinhAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(106, 87);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(173, 48);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "ĐĂNG TIN";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_xoa.Location = new System.Drawing.Point(337, 87);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(199, 48);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_sua.Location = new System.Drawing.Point(577, 87);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(154, 48);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // lv_dsbaidang
            // 
            this.lv_dsbaidang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_dsbaidang.FullRowSelect = true;
            this.lv_dsbaidang.HideSelection = false;
            this.lv_dsbaidang.Location = new System.Drawing.Point(90, 150);
            this.lv_dsbaidang.MultiSelect = false;
            this.lv_dsbaidang.Name = "lv_dsbaidang";
            this.lv_dsbaidang.Size = new System.Drawing.Size(946, 260);
            this.lv_dsbaidang.TabIndex = 3;
            this.lv_dsbaidang.UseCompatibleStateImageBehavior = false;
            this.lv_dsbaidang.View = System.Windows.Forms.View.Details;
            this.lv_dsbaidang.SelectedIndexChanged += new System.EventHandler(this.lv_dsbaidang_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tiêu Đề";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nội Dung";
            this.columnHeader2.Width = 262;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hình Ảnh";
            this.columnHeader3.Width = 284;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày Tạo";
            this.columnHeader4.Width = 165;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày Sửa";
            this.columnHeader5.Width = 149;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trạng Thái";
            this.columnHeader6.Width = 603;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(528, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "ĐĂNG BÀI";
            // 
            // btn_themcomment
            // 
            this.btn_themcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_themcomment.Location = new System.Drawing.Point(90, 439);
            this.btn_themcomment.Name = "btn_themcomment";
            this.btn_themcomment.Size = new System.Drawing.Size(228, 48);
            this.btn_themcomment.TabIndex = 1;
            this.btn_themcomment.Text = "THÊM COMMENT";
            this.btn_themcomment.UseVisualStyleBackColor = true;
            this.btn_themcomment.Click += new System.EventHandler(this.btn_themcomment_Click);
            // 
            // lv_dsbinhluan
            // 
            this.lv_dsbinhluan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lv_dsbinhluan.FullRowSelect = true;
            this.lv_dsbinhluan.HideSelection = false;
            this.lv_dsbinhluan.Location = new System.Drawing.Point(90, 493);
            this.lv_dsbinhluan.MultiSelect = false;
            this.lv_dsbinhluan.Name = "lv_dsbinhluan";
            this.lv_dsbinhluan.Size = new System.Drawing.Size(1147, 200);
            this.lv_dsbinhluan.TabIndex = 5;
            this.lv_dsbinhluan.UseCompatibleStateImageBehavior = false;
            this.lv_dsbinhluan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID Bài đăng";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nội dung";
            this.columnHeader9.Width = 300;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ngày tạo";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Trạng thái";
            this.columnHeader11.Width = 120;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::testquanlifacebook.Properties.Resources._5282541_fb_social_media_facebook_facebook_logo_social_network_icon__1_;
            this.pictureBox1.InitialImage = global::testquanlifacebook.Properties.Resources._5282541_fb_social_media_facebook_facebook_logo_social_network_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(401, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_xoabinhluan
            // 
            this.btn_xoabinhluan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_xoabinhluan.Location = new System.Drawing.Point(378, 439);
            this.btn_xoabinhluan.Name = "btn_xoabinhluan";
            this.btn_xoabinhluan.Size = new System.Drawing.Size(228, 48);
            this.btn_xoabinhluan.TabIndex = 1;
            this.btn_xoabinhluan.Text = "XOÁ";
            this.btn_xoabinhluan.UseVisualStyleBackColor = true;
            this.btn_xoabinhluan.Click += new System.EventHandler(this.btn_xoabinhluan_Click);
            // 
            // btn_suabinhluan
            // 
            this.btn_suabinhluan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suabinhluan.Location = new System.Drawing.Point(678, 439);
            this.btn_suabinhluan.Name = "btn_suabinhluan";
            this.btn_suabinhluan.Size = new System.Drawing.Size(228, 48);
            this.btn_suabinhluan.TabIndex = 1;
            this.btn_suabinhluan.Text = "SỬA";
            this.btn_suabinhluan.UseVisualStyleBackColor = true;
            this.btn_suabinhluan.Click += new System.EventHandler(this.btn_suabinhluan_Click);
            // 
            // pic_HinhAnh
            // 
            this.pic_HinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_HinhAnh.Location = new System.Drawing.Point(1061, 150);
            this.pic_HinhAnh.Name = "pic_HinhAnh";
            this.pic_HinhAnh.Size = new System.Drawing.Size(186, 161);
            this.pic_HinhAnh.TabIndex = 11;
            this.pic_HinhAnh.TabStop = false;
            // 
            // Đăng_Tin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1275, 705);
            this.Controls.Add(this.pic_HinhAnh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lv_dsbinhluan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_dsbaidang);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_suabinhluan);
            this.Controls.Add(this.btn_xoabinhluan);
            this.Controls.Add(this.btn_themcomment);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Name = "Đăng_Tin";
            this.Text = "Đăng_Tin";
            this.Load += new System.EventHandler(this.Đăng_Tin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.ListView lv_dsbaidang;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_themcomment;
        private System.Windows.Forms.ListView lv_dsbinhluan;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_xoabinhluan;
        private System.Windows.Forms.Button btn_suabinhluan;
        private System.Windows.Forms.PictureBox pic_HinhAnh;
    }
}