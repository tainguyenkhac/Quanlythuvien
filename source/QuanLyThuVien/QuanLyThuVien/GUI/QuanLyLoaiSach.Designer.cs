
namespace QuanLyThuVien.GUI
{
    partial class QuanLyLoaiSach
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
            this.dataGridViewLoaiSach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTimKiemLoaiSach = new System.Windows.Forms.Button();
            this.txtTimKiemLoaiSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoaLoaiSach = new System.Windows.Forms.Button();
            this.btSuaLoaiSach = new System.Windows.Forms.Button();
            this.btThemLoaiSach = new System.Windows.Forms.Button();
            this.txtTenLoaiSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLoaiSach
            // 
            this.dataGridViewLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiSach.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLoaiSach.Name = "dataGridViewLoaiSach";
            this.dataGridViewLoaiSach.RowTemplate.Height = 25;
            this.dataGridViewLoaiSach.Size = new System.Drawing.Size(143, 323);
            this.dataGridViewLoaiSach.TabIndex = 0;
            this.dataGridViewLoaiSach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoaiSach_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTimKiemLoaiSach);
            this.groupBox1.Controls.Add(this.txtTimKiemLoaiSach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(181, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btTimKiemLoaiSach
            // 
            this.btTimKiemLoaiSach.Location = new System.Drawing.Point(149, 87);
            this.btTimKiemLoaiSach.Name = "btTimKiemLoaiSach";
            this.btTimKiemLoaiSach.Size = new System.Drawing.Size(75, 23);
            this.btTimKiemLoaiSach.TabIndex = 2;
            this.btTimKiemLoaiSach.Text = "Tìm kiếm";
            this.btTimKiemLoaiSach.UseVisualStyleBackColor = true;
            this.btTimKiemLoaiSach.Click += new System.EventHandler(this.btTimKiemLoaiSach_Click);
            // 
            // txtTimKiemLoaiSach
            // 
            this.txtTimKiemLoaiSach.Location = new System.Drawing.Point(130, 46);
            this.txtTimKiemLoaiSach.Name = "txtTimKiemLoaiSach";
            this.txtTimKiemLoaiSach.Size = new System.Drawing.Size(214, 23);
            this.txtTimKiemLoaiSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btXoaLoaiSach);
            this.groupBox2.Controls.Add(this.btSuaLoaiSach);
            this.groupBox2.Controls.Add(this.btThemLoaiSach);
            this.groupBox2.Controls.Add(this.txtTenLoaiSach);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(181, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý loại sách";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(294, 116);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoaLoaiSach
            // 
            this.btXoaLoaiSach.Location = new System.Drawing.Point(196, 116);
            this.btXoaLoaiSach.Name = "btXoaLoaiSach";
            this.btXoaLoaiSach.Size = new System.Drawing.Size(75, 23);
            this.btXoaLoaiSach.TabIndex = 4;
            this.btXoaLoaiSach.Text = "Xóa";
            this.btXoaLoaiSach.UseVisualStyleBackColor = true;
            this.btXoaLoaiSach.Click += new System.EventHandler(this.btXoaLoaiSach_Click);
            // 
            // btSuaLoaiSach
            // 
            this.btSuaLoaiSach.Location = new System.Drawing.Point(100, 116);
            this.btSuaLoaiSach.Name = "btSuaLoaiSach";
            this.btSuaLoaiSach.Size = new System.Drawing.Size(75, 23);
            this.btSuaLoaiSach.TabIndex = 3;
            this.btSuaLoaiSach.Text = "Sửa";
            this.btSuaLoaiSach.UseVisualStyleBackColor = true;
            this.btSuaLoaiSach.Click += new System.EventHandler(this.btSuaLoaiSach_Click);
            // 
            // btThemLoaiSach
            // 
            this.btThemLoaiSach.Location = new System.Drawing.Point(6, 116);
            this.btThemLoaiSach.Name = "btThemLoaiSach";
            this.btThemLoaiSach.Size = new System.Drawing.Size(75, 23);
            this.btThemLoaiSach.TabIndex = 2;
            this.btThemLoaiSach.Text = "Thêm";
            this.btThemLoaiSach.UseVisualStyleBackColor = true;
            this.btThemLoaiSach.Click += new System.EventHandler(this.btThemLoaiSach_Click);
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Location = new System.Drawing.Point(130, 58);
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Size = new System.Drawing.Size(214, 23);
            this.txtTenLoaiSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại sách";
            // 
            // QuanLyLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewLoaiSach);
            this.Name = "QuanLyLoaiSach";
            this.Text = "QuanLyLoaiSach";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLoaiSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTimKiemLoaiSach;
        private System.Windows.Forms.TextBox txtTimKiemLoaiSach;
        private System.Windows.Forms.TextBox txtTenLoaiSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btXoaLoaiSach;
        private System.Windows.Forms.Button btSuaLoaiSach;
        private System.Windows.Forms.Button btThemLoaiSach;
        private System.Windows.Forms.Button btThoat;
    }
}