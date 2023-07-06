namespace testquanlifacebook
{
    partial class Xoá_Bình_Luận
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dtp_NT = new System.Windows.Forms.DateTimePicker();
            this.txt_ND = new System.Windows.Forms.TextBox();
            this.txt_IDBinhLuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.dtp_NT);
            this.groupBox1.Controls.Add(this.txt_ND);
            this.groupBox1.Controls.Add(this.txt_IDBinhLuan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 294);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xoá bình luận";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(635, 192);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(187, 53);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "Xoá";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_xoa_Click);
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
            // txt_ND
            // 
            this.txt_ND.Location = new System.Drawing.Point(191, 104);
            this.txt_ND.Multiline = true;
            this.txt_ND.Name = "txt_ND";
            this.txt_ND.Size = new System.Drawing.Size(340, 141);
            this.txt_ND.TabIndex = 22;
            // 
            // txt_IDBinhLuan
            // 
            this.txt_IDBinhLuan.Location = new System.Drawing.Point(191, 41);
            this.txt_IDBinhLuan.Name = "txt_IDBinhLuan";
            this.txt_IDBinhLuan.ReadOnly = true;
            this.txt_IDBinhLuan.Size = new System.Drawing.Size(340, 27);
            this.txt_IDBinhLuan.TabIndex = 21;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(65, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID Bình luận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(65, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nội Dung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(448, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 44);
            this.label1.TabIndex = 16;
            this.label1.Text = "XOÁ BÌNH LUẬN";
            // 
            // Xoá_Bình_Luận
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Xoá_Bình_Luận";
            this.Text = "Xoá_Bình_Luận";
            this.Load += new System.EventHandler(this.Xoá_Bình_Luận_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dtp_NT;
        private System.Windows.Forms.TextBox txt_ND;
        private System.Windows.Forms.TextBox txt_IDBinhLuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}