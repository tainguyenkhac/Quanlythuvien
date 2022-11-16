
namespace QuanLyThuVien.GUI
{
    partial class Main
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
            this.btnQuanLyDocGia = new System.Windows.Forms.Button();
            this.btnQuanLyTacGia = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanLyMuonTra = new System.Windows.Forms.Button();
            this.btnQuanLySach = new System.Windows.Forms.Button();
            this.btnQuanLyLoaiSach = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuanLyDocGia
            // 
            this.btnQuanLyDocGia.Location = new System.Drawing.Point(70, 77);
            this.btnQuanLyDocGia.Name = "btnQuanLyDocGia";
            this.btnQuanLyDocGia.Size = new System.Drawing.Size(144, 70);
            this.btnQuanLyDocGia.TabIndex = 0;
            this.btnQuanLyDocGia.Text = "Quản Lý Người Mượn";
            this.btnQuanLyDocGia.UseVisualStyleBackColor = true;
            this.btnQuanLyDocGia.Click += new System.EventHandler(this.btnQuanLyDocGia_Click);
            // 
            // btnQuanLyTacGia
            // 
            this.btnQuanLyTacGia.Location = new System.Drawing.Point(70, 167);
            this.btnQuanLyTacGia.Name = "btnQuanLyTacGia";
            this.btnQuanLyTacGia.Size = new System.Drawing.Size(144, 70);
            this.btnQuanLyTacGia.TabIndex = 3;
            this.btnQuanLyTacGia.Text = "Quản Lý Tác Giả";
            this.btnQuanLyTacGia.UseVisualStyleBackColor = true;
            this.btnQuanLyTacGia.Click += new System.EventHandler(this.btnQuanLyTacGia_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(410, 167);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(144, 70);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQuanLyMuonTra
            // 
            this.btnQuanLyMuonTra.Location = new System.Drawing.Point(237, 77);
            this.btnQuanLyMuonTra.Name = "btnQuanLyMuonTra";
            this.btnQuanLyMuonTra.Size = new System.Drawing.Size(144, 70);
            this.btnQuanLyMuonTra.TabIndex = 1;
            this.btnQuanLyMuonTra.Text = "Quản Lý Mượn Trả Sách";
            this.btnQuanLyMuonTra.UseVisualStyleBackColor = true;
            this.btnQuanLyMuonTra.Click += new System.EventHandler(this.btnQuanLyMuonTra_Click);
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.Location = new System.Drawing.Point(410, 77);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Size = new System.Drawing.Size(144, 70);
            this.btnQuanLySach.TabIndex = 2;
            this.btnQuanLySach.Text = "Quản Lý Sách";
            this.btnQuanLySach.UseVisualStyleBackColor = true;
            this.btnQuanLySach.Click += new System.EventHandler(this.btnQuanLySach_Click);
            // 
            // btnQuanLyLoaiSach
            // 
            this.btnQuanLyLoaiSach.Location = new System.Drawing.Point(237, 167);
            this.btnQuanLyLoaiSach.Name = "btnQuanLyLoaiSach";
            this.btnQuanLyLoaiSach.Size = new System.Drawing.Size(144, 70);
            this.btnQuanLyLoaiSach.TabIndex = 4;
            this.btnQuanLyLoaiSach.Text = "Quản Lý Loại Sách";
            this.btnQuanLyLoaiSach.UseVisualStyleBackColor = true;
            this.btnQuanLyLoaiSach.Click += new System.EventHandler(this.btnQuanLyLoaiSach_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(289, 26);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(0, 15);
            this.lbUsername.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 280);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btnQuanLyLoaiSach);
            this.Controls.Add(this.btnQuanLySach);
            this.Controls.Add(this.btnQuanLyMuonTra);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnQuanLyTacGia);
            this.Controls.Add(this.btnQuanLyDocGia);
            this.Name = "Main";
            this.Text = "Hệ Thống Quản Lý Thư Viện";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyDocGia;
        private System.Windows.Forms.Button btnQuanLyTacGia;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuanLyMuonTra;
        private System.Windows.Forms.Button btnQuanLySach;
        private System.Windows.Forms.Button btnQuanLyLoaiSach;
        private System.Windows.Forms.Label lbUsername;
    }
}