
namespace testquanlifacebook
{
    partial class Tạo_Tài_Khoản
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
            this.components = new System.ComponentModel.Container();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_tao = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_xnmk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_hienmk = new System.Windows.Forms.CheckBox();
            this.txt_tentk = new System.Windows.Forms.TextBox();
            this.lbl_tentk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(279, 98);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(343, 22);
            this.txt_tk.TabIndex = 0;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            this.txt_tk.Validating += new System.ComponentModel.CancelEventHandler(this.txt_tk_Validating);
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(279, 142);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(343, 22);
            this.txt_mk.TabIndex = 1;
            this.txt_mk.TextChanged += new System.EventHandler(this.txt_mk_TextChanged);
            this.txt_mk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mk_KeyPress);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(279, 273);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(343, 22);
            this.txt_sdt.TabIndex = 3;
            this.txt_sdt.TextChanged += new System.EventHandler(this.txt_sdt_TextChanged);
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(52, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài Khoản (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(52, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu (*)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(52, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "SĐT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // btn_tao
            // 
            this.btn_tao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_tao.Location = new System.Drawing.Point(279, 438);
            this.btn_tao.Name = "btn_tao";
            this.btn_tao.Size = new System.Drawing.Size(121, 47);
            this.btn_tao.TabIndex = 7;
            this.btn_tao.Text = "Tạo";
            this.btn_tao.UseVisualStyleBackColor = true;
            this.btn_tao.Click += new System.EventHandler(this.btn_tao_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.Location = new System.Drawing.Point(477, 438);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 47);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Trở lại";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(245, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "TẠO TÀI KHOẢN";
            // 
            // txt_xnmk
            // 
            this.txt_xnmk.Location = new System.Drawing.Point(279, 186);
            this.txt_xnmk.Name = "txt_xnmk";
            this.txt_xnmk.PasswordChar = '*';
            this.txt_xnmk.Size = new System.Drawing.Size(343, 22);
            this.txt_xnmk.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(52, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Xác nhận Mật Khẩu (*)";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(279, 318);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(343, 22);
            this.txt_email.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(52, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // chk_hienmk
            // 
            this.chk_hienmk.AutoSize = true;
            this.chk_hienmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.chk_hienmk.Location = new System.Drawing.Point(279, 374);
            this.chk_hienmk.Name = "chk_hienmk";
            this.chk_hienmk.Size = new System.Drawing.Size(137, 24);
            this.chk_hienmk.TabIndex = 13;
            this.chk_hienmk.Text = "Hiện mật khẩu";
            this.chk_hienmk.UseVisualStyleBackColor = true;
            this.chk_hienmk.CheckedChanged += new System.EventHandler(this.rdb_MK_CheckedChanged);
            // 
            // txt_tentk
            // 
            this.txt_tentk.Location = new System.Drawing.Point(279, 228);
            this.txt_tentk.Name = "txt_tentk";
            this.txt_tentk.Size = new System.Drawing.Size(343, 22);
            this.txt_tentk.TabIndex = 10;
            // 
            // lbl_tentk
            // 
            this.lbl_tentk.AutoSize = true;
            this.lbl_tentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbl_tentk.Location = new System.Drawing.Point(52, 230);
            this.lbl_tentk.Name = "lbl_tentk";
            this.lbl_tentk.Size = new System.Drawing.Size(69, 20);
            this.lbl_tentk.TabIndex = 11;
            this.lbl_tentk.Text = "Họ Tên";
            // 
            // Tạo_Tài_Khoản
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.chk_hienmk);
            this.Controls.Add(this.lbl_tentk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tentk);
            this.Controls.Add(this.txt_xnmk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_tao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Name = "Tạo_Tài_Khoản";
            this.Text = "Tạo_Tài_Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_tao;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_xnmk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.CheckBox chk_hienmk;
        private System.Windows.Forms.Label lbl_tentk;
        private System.Windows.Forms.TextBox txt_tentk;
    }
}