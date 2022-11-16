
namespace QuanLyThuVien.GUI
{
    partial class QuanLyDocGia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThucHienTim = new System.Windows.Forms.Button();
            this.rbtnSoDienThoai = new System.Windows.Forms.RadioButton();
            this.rbtnHoTen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoiDungTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorHoTen = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNgaySinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSoDienThoai = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThucHienTim);
            this.groupBox1.Controls.Add(this.rbtnSoDienThoai);
            this.groupBox1.Controls.Add(this.rbtnHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNoiDungTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(987, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(543, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // btnThucHienTim
            // 
            this.btnThucHienTim.Location = new System.Drawing.Point(209, 217);
            this.btnThucHienTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThucHienTim.Name = "btnThucHienTim";
            this.btnThucHienTim.Size = new System.Drawing.Size(151, 38);
            this.btnThucHienTim.TabIndex = 5;
            this.btnThucHienTim.Text = "Thực Hiện Tìm";
            this.btnThucHienTim.UseVisualStyleBackColor = true;
            this.btnThucHienTim.Click += new System.EventHandler(this.btnThucHienTim_Click);
            // 
            // rbtnSoDienThoai
            // 
            this.rbtnSoDienThoai.AutoSize = true;
            this.rbtnSoDienThoai.Location = new System.Drawing.Point(349, 148);
            this.rbtnSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnSoDienThoai.Name = "rbtnSoDienThoai";
            this.rbtnSoDienThoai.Size = new System.Drawing.Size(147, 29);
            this.rbtnSoDienThoai.TabIndex = 4;
            this.rbtnSoDienThoai.TabStop = true;
            this.rbtnSoDienThoai.Text = "Số Điện Thoại";
            this.rbtnSoDienThoai.UseVisualStyleBackColor = true;
            // 
            // rbtnHoTen
            // 
            this.rbtnHoTen.AutoSize = true;
            this.rbtnHoTen.Location = new System.Drawing.Point(209, 148);
            this.rbtnHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnHoTen.Name = "rbtnHoTen";
            this.rbtnHoTen.Size = new System.Drawing.Size(92, 29);
            this.rbtnHoTen.TabIndex = 3;
            this.rbtnHoTen.TabStop = true;
            this.rbtnHoTen.Text = "Họ Tên";
            this.rbtnHoTen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm Theo:";
            // 
            // txtNoiDungTimKiem
            // 
            this.txtNoiDungTimKiem.Location = new System.Drawing.Point(183, 77);
            this.txtNoiDungTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoiDungTimKiem.Name = "txtNoiDungTimKiem";
            this.txtNoiDungTimKiem.Size = new System.Drawing.Size(331, 31);
            this.txtNoiDungTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội Dung Cần Tìm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(911, 908);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoDienThoai);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbtnNu);
            this.groupBox2.Controls.Add(this.rbtnNam);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(987, 332);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(543, 597);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm Sửa Xóa";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(169, 218);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(284, 31);
            this.dtpNgaySinh.TabIndex = 21;
            this.dtpNgaySinh.Leave += new System.EventHandler(this.dtpNgaySinh_Leave);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(427, 522);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 38);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(289, 522);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 38);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(149, 522);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 38);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(11, 522);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 38);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(169, 443);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 31);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 450);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(169, 367);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(291, 31);
            this.txtSoDienThoai.TabIndex = 14;
            this.txtSoDienThoai.Leave += new System.EventHandler(this.txtSoDienThoai_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 373);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số Điện Thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(169, 288);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(291, 31);
            this.txtDiaChi.TabIndex = 12;
            this.txtDiaChi.Leave += new System.EventHandler(this.txtDiaChi_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(301, 142);
            this.rbtnNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(61, 29);
            this.rbtnNu.TabIndex = 8;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Location = new System.Drawing.Point(169, 142);
            this.rbtnNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(75, 29);
            this.rbtnNam.TabIndex = 7;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(169, 68);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(291, 31);
            this.txtHoTen.TabIndex = 6;
            this.txtHoTen.Leave += new System.EventHandler(this.txtHoTen_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            // 
            // errorHoTen
            // 
            this.errorHoTen.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorNgaySinh
            // 
            this.errorNgaySinh.ContainerControl = this;
            // 
            // errorDiaChi
            // 
            this.errorDiaChi.ContainerControl = this;
            // 
            // errorSoDienThoai
            // 
            this.errorSoDienThoai.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // QuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1556, 948);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLyDocGia";
            this.Text = "QuanLyDocGia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbtnSoDienThoai;
        private System.Windows.Forms.RadioButton rbtnHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoiDungTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThucHienTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ErrorProvider errorHoTen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorNgaySinh;
        private System.Windows.Forms.ErrorProvider errorDiaChi;
        private System.Windows.Forms.ErrorProvider errorSoDienThoai;
        private System.Windows.Forms.ErrorProvider errorEmail;
    }
}