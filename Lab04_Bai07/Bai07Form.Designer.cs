namespace NT106.R14._1_Lab04_Nhom4.Bai07
{
    partial class Bai07Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblPhuDe = new Label();
            lblTrangThai = new Label();
            btnDangNhap = new Button();
            btnDangKy = new Button();
            btnQuanLy = new Button();
            btnDangXuat = new Button();
            lblHuongDan = new Label();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(35, 78, 120);
            lblTieuDe.Location = new Point(0, 38);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(900, 40);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BÀI 07 - HÔM NAY ĂN GÌ?";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblPhuDe
            //
            lblPhuDe.Font = new Font("Segoe UI", 10F);
            lblPhuDe.ForeColor = Color.FromArgb(100, 100, 100);
            lblPhuDe.Location = new Point(0, 82);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Size = new Size(900, 24);
            lblPhuDe.TabIndex = 1;
            lblPhuDe.Text = "Chọn món ăn ngẫu nhiên từ API nt106.uitiot.vn";
            lblPhuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblTrangThai
            //
            lblTrangThai.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTrangThai.ForeColor = Color.FromArgb(60, 60, 60);
            lblTrangThai.Location = new Point(0, 128);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(900, 26);
            lblTrangThai.TabIndex = 2;
            lblTrangThai.Text = "Chưa đăng nhập";
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnDangNhap
            //
            btnDangNhap.BackColor = Color.FromArgb(51, 122, 183);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(90, 185);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(220, 110);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            //
            // btnDangKy
            //
            btnDangKy.BackColor = Color.FromArgb(51, 122, 183);
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(340, 185);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(220, 110);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            //
            // btnQuanLy
            //
            btnQuanLy.BackColor = Color.FromArgb(51, 122, 183);
            btnQuanLy.Cursor = Cursors.Hand;
            btnQuanLy.FlatAppearance.BorderSize = 0;
            btnQuanLy.FlatStyle = FlatStyle.Flat;
            btnQuanLy.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnQuanLy.ForeColor = Color.White;
            btnQuanLy.Location = new Point(590, 185);
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Size = new Size(220, 110);
            btnQuanLy.TabIndex = 5;
            btnQuanLy.Text = "Quản lý món ăn";
            btnQuanLy.UseVisualStyleBackColor = false;
            btnQuanLy.Click += btnQuanLy_Click;
            //
            // btnDangXuat
            //
            btnDangXuat.BackColor = Color.FromArgb(140, 140, 140);
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(340, 315);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(220, 40);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            //
            // lblHuongDan
            //
            lblHuongDan.Font = new Font("Segoe UI", 9F);
            lblHuongDan.ForeColor = Color.FromArgb(120, 120, 120);
            lblHuongDan.Location = new Point(0, 390);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(900, 50);
            lblHuongDan.TabIndex = 7;
            lblHuongDan.Text = "Đăng nhập để thêm, xóa và xem các món ăn của bạn. Mục cộng đồng cho phép xem và chọn ngẫu nhiên món ăn của mọi người.";
            lblHuongDan.TextAlign = ContentAlignment.MiddleCenter;
            //
            // Bai07Form
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 470);
            Controls.Add(lblHuongDan);
            Controls.Add(btnDangXuat);
            Controls.Add(btnQuanLy);
            Controls.Add(btnDangKy);
            Controls.Add(btnDangNhap);
            Controls.Add(lblTrangThai);
            Controls.Add(lblPhuDe);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai07Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bài 07 - Hôm nay ăn gì?";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTieuDe;
        private Label lblPhuDe;
        private Label lblTrangThai;
        private Button btnDangNhap;
        private Button btnDangKy;
        private Button btnQuanLy;
        private Button btnDangXuat;
        private Label lblHuongDan;
    }
}
