﻿
namespace testquanlifacebook
{
    partial class Xóa_bài_Đăng
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
            this.btn_add = new System.Windows.Forms.Button();
            this.dtp_NS = new System.Windows.Forms.DateTimePicker();
            this.dtp_NT = new System.Windows.Forms.DateTimePicker();
            this.txt_TT = new System.Windows.Forms.TextBox();
            this.txt_HA = new System.Windows.Forms.TextBox();
            this.txt_ND = new System.Windows.Forms.TextBox();
            this.txt_TD = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_HinhAnh = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(704, 285);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(187, 53);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "Xóa";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dtp_NS
            // 
            this.dtp_NS.CustomFormat = "dd/MM/yyyy";
            this.dtp_NS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtp_NS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NS.Location = new System.Drawing.Point(688, 94);
            this.dtp_NS.Name = "dtp_NS";
            this.dtp_NS.Size = new System.Drawing.Size(286, 27);
            this.dtp_NS.TabIndex = 28;
            // 
            // dtp_NT
            // 
            this.dtp_NT.CustomFormat = "dd/MM/yyyy";
            this.dtp_NT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtp_NT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NT.Location = new System.Drawing.Point(688, 48);
            this.dtp_NT.Name = "dtp_NT";
            this.dtp_NT.Size = new System.Drawing.Size(286, 27);
            this.dtp_NT.TabIndex = 27;
            // 
            // txt_TT
            // 
            this.txt_TT.Location = new System.Drawing.Point(688, 146);
            this.txt_TT.Name = "txt_TT";
            this.txt_TT.Size = new System.Drawing.Size(286, 27);
            this.txt_TT.TabIndex = 26;
            // 
            // txt_HA
            // 
            this.txt_HA.Location = new System.Drawing.Point(192, 311);
            this.txt_HA.Name = "txt_HA";
            this.txt_HA.Size = new System.Drawing.Size(340, 27);
            this.txt_HA.TabIndex = 23;
            // 
            // txt_ND
            // 
            this.txt_ND.Location = new System.Drawing.Point(192, 143);
            this.txt_ND.Multiline = true;
            this.txt_ND.Name = "txt_ND";
            this.txt_ND.Size = new System.Drawing.Size(340, 141);
            this.txt_ND.TabIndex = 22;
            // 
            // txt_TD
            // 
            this.txt_TD.Location = new System.Drawing.Point(192, 96);
            this.txt_TD.Name = "txt_TD";
            this.txt_TD.Size = new System.Drawing.Size(340, 27);
            this.txt_TD.TabIndex = 21;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(192, 48);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(340, 27);
            this.txt_ID.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.Location = new System.Drawing.Point(593, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Trạng Thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(593, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ngày Sửa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(593, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày Tạo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(66, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "HÌnh Ảnh ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(66, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nội Dung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(66, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tiêu Đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic_HinhAnh);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.dtp_NS);
            this.groupBox1.Controls.Add(this.dtp_NT);
            this.groupBox1.Controls.Add(this.txt_TT);
            this.groupBox1.Controls.Add(this.txt_HA);
            this.groupBox1.Controls.Add(this.txt_ND);
            this.groupBox1.Controls.Add(this.txt_TD);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(134, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 445);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xóa Bài Viết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(540, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 44);
            this.label1.TabIndex = 14;
            this.label1.Text = "XÓA BÀI ĐĂNG";
            // 
            // pic_HinhAnh
            // 
            this.pic_HinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_HinhAnh.Location = new System.Drawing.Point(192, 346);
            this.pic_HinhAnh.Name = "pic_HinhAnh";
            this.pic_HinhAnh.Size = new System.Drawing.Size(97, 82);
            this.pic_HinhAnh.TabIndex = 30;
            this.pic_HinhAnh.TabStop = false;
            // 
            // Xóa_bài_Đăng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Xóa_bài_Đăng";
            this.Text = "Xóa_bài_Đăng";
            this.Load += new System.EventHandler(this.Xóa_bài_Đăng_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dtp_NS;
        private System.Windows.Forms.DateTimePicker dtp_NT;
        private System.Windows.Forms.TextBox txt_TT;
        private System.Windows.Forms.TextBox txt_HA;
        private System.Windows.Forms.TextBox txt_ND;
        private System.Windows.Forms.TextBox txt_TD;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_HinhAnh;
    }
}