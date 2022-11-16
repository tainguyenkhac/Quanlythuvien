
using System;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    partial class QuanLyTacGia
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
            this.dataGridViewTacGia = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtEmail = new System.Windows.Forms.RadioButton();
            this.rbtSoDienThoai = new System.Windows.Forms.RadioButton();
            this.rbtTenTacGia = new System.Windows.Forms.RadioButton();
            this.btTimKiemTacGia = new System.Windows.Forms.Button();
            this.txtTimKiemTacGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoaTacGia = new System.Windows.Forms.Button();
            this.btSuaTacGia = new System.Windows.Forms.Button();
            this.btThemTacGia = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTacGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTacGia
            // 
            this.dataGridViewTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTacGia.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTacGia.Name = "dataGridViewTacGia";
            this.dataGridViewTacGia.RowTemplate.Height = 25;
            this.dataGridViewTacGia.Size = new System.Drawing.Size(638, 545);
            this.dataGridViewTacGia.TabIndex = 0;
            this.dataGridViewTacGia.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTacGia_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtEmail);
            this.groupBox1.Controls.Add(this.rbtSoDienThoai);
            this.groupBox1.Controls.Add(this.rbtTenTacGia);
            this.groupBox1.Controls.Add(this.btTimKiemTacGia);
            this.groupBox1.Controls.Add(this.txtTimKiemTacGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(691, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm tác giả";
            // 
            // rbtEmail
            // 
            this.rbtEmail.AutoSize = true;
            this.rbtEmail.Location = new System.Drawing.Point(270, 73);
            this.rbtEmail.Name = "rbtEmail";
            this.rbtEmail.Size = new System.Drawing.Size(104, 19);
            this.rbtEmail.TabIndex = 5;
            this.rbtEmail.TabStop = true;
            this.rbtEmail.Text = "Tìm theo Email";
            this.rbtEmail.UseVisualStyleBackColor = true;
            // 
            // rbtSoDienThoai
            // 
            this.rbtSoDienThoai.AutoSize = true;
            this.rbtSoDienThoai.Location = new System.Drawing.Point(121, 73);
            this.rbtSoDienThoai.Name = "rbtSoDienThoai";
            this.rbtSoDienThoai.Size = new System.Drawing.Size(143, 19);
            this.rbtSoDienThoai.TabIndex = 4;
            this.rbtSoDienThoai.TabStop = true;
            this.rbtSoDienThoai.Text = "Tìm theo số điện thoại";
            this.rbtSoDienThoai.UseVisualStyleBackColor = true;
            // 
            // rbtTenTacGia
            // 
            this.rbtTenTacGia.AutoSize = true;
            this.rbtTenTacGia.Location = new System.Drawing.Point(12, 73);
            this.rbtTenTacGia.Name = "rbtTenTacGia";
            this.rbtTenTacGia.Size = new System.Drawing.Size(92, 19);
            this.rbtTenTacGia.TabIndex = 3;
            this.rbtTenTacGia.TabStop = true;
            this.rbtTenTacGia.Text = "Tìm theo tên";
            this.rbtTenTacGia.UseVisualStyleBackColor = true;
            // 
            // btTimKiemTacGia
            // 
            this.btTimKiemTacGia.Location = new System.Drawing.Point(158, 98);
            this.btTimKiemTacGia.Name = "btTimKiemTacGia";
            this.btTimKiemTacGia.Size = new System.Drawing.Size(75, 23);
            this.btTimKiemTacGia.TabIndex = 2;
            this.btTimKiemTacGia.Text = "Tìm kiếm";
            this.btTimKiemTacGia.UseVisualStyleBackColor = true;
            this.btTimKiemTacGia.Click += new System.EventHandler(this.btTimKiemTacGia_Click);
            // 
            // txtTimKiemTacGia
            // 
            this.txtTimKiemTacGia.Location = new System.Drawing.Point(158, 40);
            this.txtTimKiemTacGia.Name = "txtTimKiemTacGia";
            this.txtTimKiemTacGia.Size = new System.Drawing.Size(193, 23);
            this.txtTimKiemTacGia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtSoDienThoai);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.dtNgaySinh);
            this.groupBox2.Controls.Add(this.rbtNu);
            this.groupBox2.Controls.Add(this.rbtNam);
            this.groupBox2.Controls.Add(this.txtTenTacGia);
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btXoaTacGia);
            this.groupBox2.Controls.Add(this.btSuaTacGia);
            this.groupBox2.Controls.Add(this.btThemTacGia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(691, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 358);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tác giả";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 23);
            this.txtEmail.TabIndex = 16;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(107, 187);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(228, 23);
            this.txtSoDienThoai.TabIndex = 15;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(107, 153);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(228, 23);
            this.txtDiaChi.TabIndex = 14;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(107, 119);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(228, 23);
            this.dtNgaySinh.TabIndex = 13;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Location = new System.Drawing.Point(227, 90);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(41, 19);
            this.rbtNu.TabIndex = 12;
            this.rbtNu.TabStop = true;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            this.rbtNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Location = new System.Drawing.Point(122, 90);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(51, 19);
            this.rbtNam.TabIndex = 11;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(107, 54);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(228, 23);
            this.txtTenTacGia.TabIndex = 10;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(299, 286);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoaTacGia
            // 
            this.btXoaTacGia.Location = new System.Drawing.Point(193, 286);
            this.btXoaTacGia.Name = "btXoaTacGia";
            this.btXoaTacGia.Size = new System.Drawing.Size(75, 23);
            this.btXoaTacGia.TabIndex = 8;
            this.btXoaTacGia.Text = "Xóa";
            this.btXoaTacGia.UseVisualStyleBackColor = true;
            this.btXoaTacGia.Click += new System.EventHandler(this.btXoaTacGia_Click);
            // 
            // btSuaTacGia
            // 
            this.btSuaTacGia.Location = new System.Drawing.Point(98, 286);
            this.btSuaTacGia.Name = "btSuaTacGia";
            this.btSuaTacGia.Size = new System.Drawing.Size(75, 23);
            this.btSuaTacGia.TabIndex = 7;
            this.btSuaTacGia.Text = "Sửa";
            this.btSuaTacGia.UseVisualStyleBackColor = true;
            this.btSuaTacGia.Click += new System.EventHandler(this.btSuaTacGia_Click);
            // 
            // btThemTacGia
            // 
            this.btThemTacGia.Location = new System.Drawing.Point(6, 286);
            this.btThemTacGia.Name = "btThemTacGia";
            this.btThemTacGia.Size = new System.Drawing.Size(75, 23);
            this.btThemTacGia.TabIndex = 6;
            this.btThemTacGia.Text = "Thêm";
            this.btThemTacGia.UseVisualStyleBackColor = true;
            this.btThemTacGia.Click += new System.EventHandler(this.btThemTacGia_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // QuanLyTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewTacGia);
            this.Name = "QuanLyTacGia";
            this.Text = "QuanLyTacGia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTacGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTacGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTimKiemTacGia;
        private System.Windows.Forms.TextBox txtTimKiemTacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoaTacGia;
        private System.Windows.Forms.Button btSuaTacGia;
        private System.Windows.Forms.Button btThemTacGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.RadioButton rbtNu;
        private System.Windows.Forms.RadioButton rbtNam;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RadioButton rbtEmail;
        private System.Windows.Forms.RadioButton rbtSoDienThoai;
        private System.Windows.Forms.RadioButton rbtTenTacGia;
    }
}