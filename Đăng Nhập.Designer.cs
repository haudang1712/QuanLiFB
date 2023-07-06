
namespace testquanlifacebook
{
    partial class Form1
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
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DN = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_taotk = new System.Windows.Forms.Button();
            this.chk_hienmk = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK.Location = new System.Drawing.Point(256, 132);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(330, 27);
            this.txt_TK.TabIndex = 0;
            this.txt_TK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_TK_MouseClick);
            this.txt_TK.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_MK
            // 
            this.txt_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txt_MK.Location = new System.Drawing.Point(256, 195);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.PasswordChar = '*';
            this.txt_MK.Size = new System.Drawing.Size(330, 27);
            this.txt_MK.TabIndex = 1;
            this.txt_MK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MK_MouseClick);
            this.txt_MK.TextChanged += new System.EventHandler(this.txt_MK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(115, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu (*)";
            // 
            // btn_DN
            // 
            this.btn_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN.Location = new System.Drawing.Point(119, 343);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(148, 46);
            this.btn_DN.TabIndex = 5;
            this.btn_DN.Text = "Đăng Nhập";
            this.btn_DN.UseVisualStyleBackColor = true;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // btn_out
            // 
            this.btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_out.Location = new System.Drawing.Point(570, 343);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(108, 46);
            this.btn_out.TabIndex = 6;
            this.btn_out.Text = "Thoát";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(247, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "FACEBOOK";
            // 
            // btn_taotk
            // 
            this.btn_taotk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_taotk.Location = new System.Drawing.Point(317, 343);
            this.btn_taotk.Name = "btn_taotk";
            this.btn_taotk.Size = new System.Drawing.Size(189, 46);
            this.btn_taotk.TabIndex = 8;
            this.btn_taotk.Text = "Tạo Tài Khoản";
            this.btn_taotk.UseVisualStyleBackColor = true;
            this.btn_taotk.Click += new System.EventHandler(this.btn_taotk_Click);
            // 
            // chk_hienmk
            // 
            this.chk_hienmk.AutoSize = true;
            this.chk_hienmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.chk_hienmk.Location = new System.Drawing.Point(256, 258);
            this.chk_hienmk.Name = "chk_hienmk";
            this.chk_hienmk.Size = new System.Drawing.Size(137, 24);
            this.chk_hienmk.TabIndex = 10;
            this.chk_hienmk.Text = "Hiện mật khẩu";
            this.chk_hienmk.UseVisualStyleBackColor = true;
            this.chk_hienmk.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::testquanlifacebook.Properties.Resources._5282541_fb_social_media_facebook_facebook_logo_social_network_icon__1_;
            this.pictureBox1.InitialImage = global::testquanlifacebook.Properties.Resources._5282541_fb_social_media_facebook_facebook_logo_social_network_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 79);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chk_hienmk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_taotk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TK);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_taotk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk_hienmk;
    }
}

