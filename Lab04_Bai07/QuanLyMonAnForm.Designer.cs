namespace NT106.R14._1_Lab04_Nhom4.Bai07
{
    partial class QuanLyMonAnForm
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
            lblNguoiDung = new Label();
            tabControl = new TabControl();
            tabCuaToi = new TabPage();
            dgvCuaToi = new DataGridView();
            btnLamMoiCuaToi = new Button();
            btnXoa = new Button();
            btnRandomCuaToi = new Button();
            btnTruocCuaToi = new Button();
            lblTrangCuaToi = new Label();
            btnSauCuaToi = new Button();
            tabTatCa = new TabPage();
            dgvTatCa = new DataGridView();
            btnLamMoiTatCa = new Button();
            btnRandomTatCa = new Button();
            btnTruocTatCa = new Button();
            lblTrangTatCa = new Label();
            btnSauTatCa = new Button();
            tabThem = new TabPage();
            lblTenMonAn = new Label();
            txtTenMonAn = new TextBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            lblHinhAnh = new Label();
            txtHinhAnh = new TextBox();
            lblGia = new Label();
            txtGia = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            btnThem = new Button();
            lblGhiChu = new Label();
            lblThongBao = new Label();
            tabControl.SuspendLayout();
            tabCuaToi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuaToi).BeginInit();
            tabTatCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTatCa).BeginInit();
            tabThem.SuspendLayout();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(35, 78, 120);
            lblTieuDe.Location = new Point(20, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(220, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "QUẢN LÝ MÓN ĂN";
            //
            // lblNguoiDung
            //
            lblNguoiDung.AutoSize = true;
            lblNguoiDung.Font = new Font("Segoe UI", 10F);
            lblNguoiDung.ForeColor = Color.FromArgb(90, 90, 90);
            lblNguoiDung.Location = new Point(20, 48);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Size = new Size(80, 19);
            lblNguoiDung.TabIndex = 1;
            lblNguoiDung.Text = "Xin chào";
            //
            // tabControl
            //
            tabControl.Controls.Add(tabCuaToi);
            tabControl.Controls.Add(tabTatCa);
            tabControl.Controls.Add(tabThem);
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.Location = new Point(20, 78);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1050, 600);
            tabControl.TabIndex = 2;
            //
            // tabCuaToi
            //
            tabCuaToi.BackColor = Color.White;
            tabCuaToi.Controls.Add(btnSauCuaToi);
            tabCuaToi.Controls.Add(lblTrangCuaToi);
            tabCuaToi.Controls.Add(btnTruocCuaToi);
            tabCuaToi.Controls.Add(btnRandomCuaToi);
            tabCuaToi.Controls.Add(btnXoa);
            tabCuaToi.Controls.Add(btnLamMoiCuaToi);
            tabCuaToi.Controls.Add(dgvCuaToi);
            tabCuaToi.Location = new Point(4, 26);
            tabCuaToi.Name = "tabCuaToi";
            tabCuaToi.Padding = new Padding(3);
            tabCuaToi.Size = new Size(1042, 570);
            tabCuaToi.TabIndex = 0;
            tabCuaToi.Text = "Món ăn của tôi";
            //
            // dgvCuaToi
            //
            dgvCuaToi.AllowUserToAddRows = false;
            dgvCuaToi.AllowUserToDeleteRows = false;
            dgvCuaToi.BackgroundColor = Color.White;
            dgvCuaToi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuaToi.Location = new Point(12, 12);
            dgvCuaToi.MultiSelect = false;
            dgvCuaToi.Name = "dgvCuaToi";
            dgvCuaToi.ReadOnly = true;
            dgvCuaToi.RowHeadersVisible = false;
            dgvCuaToi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCuaToi.Size = new Size(1016, 425);
            dgvCuaToi.TabIndex = 0;
            //
            // btnLamMoiCuaToi
            //
            btnLamMoiCuaToi.BackColor = Color.FromArgb(51, 122, 183);
            btnLamMoiCuaToi.Cursor = Cursors.Hand;
            btnLamMoiCuaToi.FlatAppearance.BorderSize = 0;
            btnLamMoiCuaToi.FlatStyle = FlatStyle.Flat;
            btnLamMoiCuaToi.ForeColor = Color.White;
            btnLamMoiCuaToi.Location = new Point(12, 450);
            btnLamMoiCuaToi.Name = "btnLamMoiCuaToi";
            btnLamMoiCuaToi.Size = new Size(100, 36);
            btnLamMoiCuaToi.TabIndex = 1;
            btnLamMoiCuaToi.Text = "Làm mới";
            btnLamMoiCuaToi.UseVisualStyleBackColor = false;
            btnLamMoiCuaToi.Click += btnLamMoiCuaToi_Click;
            //
            // btnXoa
            //
            btnXoa.BackColor = Color.FromArgb(190, 60, 60);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(120, 450);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 36);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa món";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            //
            // btnRandomCuaToi
            //
            btnRandomCuaToi.BackColor = Color.FromArgb(51, 122, 183);
            btnRandomCuaToi.Cursor = Cursors.Hand;
            btnRandomCuaToi.FlatAppearance.BorderSize = 0;
            btnRandomCuaToi.FlatStyle = FlatStyle.Flat;
            btnRandomCuaToi.ForeColor = Color.White;
            btnRandomCuaToi.Location = new Point(228, 450);
            btnRandomCuaToi.Name = "btnRandomCuaToi";
            btnRandomCuaToi.Size = new Size(160, 36);
            btnRandomCuaToi.TabIndex = 3;
            btnRandomCuaToi.Text = "Random món của tôi";
            btnRandomCuaToi.UseVisualStyleBackColor = false;
            btnRandomCuaToi.Click += btnRandomCuaToi_Click;
            //
            // btnTruocCuaToi
            //
            btnTruocCuaToi.BackColor = Color.FromArgb(51, 122, 183);
            btnTruocCuaToi.Cursor = Cursors.Hand;
            btnTruocCuaToi.FlatAppearance.BorderSize = 0;
            btnTruocCuaToi.FlatStyle = FlatStyle.Flat;
            btnTruocCuaToi.ForeColor = Color.White;
            btnTruocCuaToi.Location = new Point(700, 450);
            btnTruocCuaToi.Name = "btnTruocCuaToi";
            btnTruocCuaToi.Size = new Size(80, 36);
            btnTruocCuaToi.TabIndex = 4;
            btnTruocCuaToi.Text = "Trước";
            btnTruocCuaToi.UseVisualStyleBackColor = false;
            btnTruocCuaToi.Click += btnTruocCuaToi_Click;
            //
            // lblTrangCuaToi
            //
            lblTrangCuaToi.Font = new Font("Segoe UI", 10F);
            lblTrangCuaToi.Location = new Point(790, 456);
            lblTrangCuaToi.Name = "lblTrangCuaToi";
            lblTrangCuaToi.Size = new Size(120, 24);
            lblTrangCuaToi.TabIndex = 5;
            lblTrangCuaToi.Text = "Trang 1/1";
            lblTrangCuaToi.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnSauCuaToi
            //
            btnSauCuaToi.BackColor = Color.FromArgb(51, 122, 183);
            btnSauCuaToi.Cursor = Cursors.Hand;
            btnSauCuaToi.FlatAppearance.BorderSize = 0;
            btnSauCuaToi.FlatStyle = FlatStyle.Flat;
            btnSauCuaToi.ForeColor = Color.White;
            btnSauCuaToi.Location = new Point(920, 450);
            btnSauCuaToi.Name = "btnSauCuaToi";
            btnSauCuaToi.Size = new Size(80, 36);
            btnSauCuaToi.TabIndex = 6;
            btnSauCuaToi.Text = "Sau";
            btnSauCuaToi.UseVisualStyleBackColor = false;
            btnSauCuaToi.Click += btnSauCuaToi_Click;
            //
            // tabTatCa
            //
            tabTatCa.BackColor = Color.White;
            tabTatCa.Controls.Add(btnSauTatCa);
            tabTatCa.Controls.Add(lblTrangTatCa);
            tabTatCa.Controls.Add(btnTruocTatCa);
            tabTatCa.Controls.Add(btnRandomTatCa);
            tabTatCa.Controls.Add(btnLamMoiTatCa);
            tabTatCa.Controls.Add(dgvTatCa);
            tabTatCa.Location = new Point(4, 26);
            tabTatCa.Name = "tabTatCa";
            tabTatCa.Padding = new Padding(3);
            tabTatCa.Size = new Size(1042, 570);
            tabTatCa.TabIndex = 1;
            tabTatCa.Text = "Cộng đồng";
            //
            // dgvTatCa
            //
            dgvTatCa.AllowUserToAddRows = false;
            dgvTatCa.AllowUserToDeleteRows = false;
            dgvTatCa.BackgroundColor = Color.White;
            dgvTatCa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTatCa.Location = new Point(12, 12);
            dgvTatCa.MultiSelect = false;
            dgvTatCa.Name = "dgvTatCa";
            dgvTatCa.ReadOnly = true;
            dgvTatCa.RowHeadersVisible = false;
            dgvTatCa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTatCa.Size = new Size(1016, 425);
            dgvTatCa.TabIndex = 0;
            //
            // btnLamMoiTatCa
            //
            btnLamMoiTatCa.BackColor = Color.FromArgb(51, 122, 183);
            btnLamMoiTatCa.Cursor = Cursors.Hand;
            btnLamMoiTatCa.FlatAppearance.BorderSize = 0;
            btnLamMoiTatCa.FlatStyle = FlatStyle.Flat;
            btnLamMoiTatCa.ForeColor = Color.White;
            btnLamMoiTatCa.Location = new Point(12, 450);
            btnLamMoiTatCa.Name = "btnLamMoiTatCa";
            btnLamMoiTatCa.Size = new Size(100, 36);
            btnLamMoiTatCa.TabIndex = 1;
            btnLamMoiTatCa.Text = "Làm mới";
            btnLamMoiTatCa.UseVisualStyleBackColor = false;
            btnLamMoiTatCa.Click += btnLamMoiTatCa_Click;
            //
            // btnRandomTatCa
            //
            btnRandomTatCa.BackColor = Color.FromArgb(51, 122, 183);
            btnRandomTatCa.Cursor = Cursors.Hand;
            btnRandomTatCa.FlatAppearance.BorderSize = 0;
            btnRandomTatCa.FlatStyle = FlatStyle.Flat;
            btnRandomTatCa.ForeColor = Color.White;
            btnRandomTatCa.Location = new Point(120, 450);
            btnRandomTatCa.Name = "btnRandomTatCa";
            btnRandomTatCa.Size = new Size(180, 36);
            btnRandomTatCa.TabIndex = 2;
            btnRandomTatCa.Text = "Random cả cộng đồng";
            btnRandomTatCa.UseVisualStyleBackColor = false;
            btnRandomTatCa.Click += btnRandomTatCa_Click;
            //
            // btnTruocTatCa
            //
            btnTruocTatCa.BackColor = Color.FromArgb(51, 122, 183);
            btnTruocTatCa.Cursor = Cursors.Hand;
            btnTruocTatCa.FlatAppearance.BorderSize = 0;
            btnTruocTatCa.FlatStyle = FlatStyle.Flat;
            btnTruocTatCa.ForeColor = Color.White;
            btnTruocTatCa.Location = new Point(700, 450);
            btnTruocTatCa.Name = "btnTruocTatCa";
            btnTruocTatCa.Size = new Size(80, 36);
            btnTruocTatCa.TabIndex = 3;
            btnTruocTatCa.Text = "Trước";
            btnTruocTatCa.UseVisualStyleBackColor = false;
            btnTruocTatCa.Click += btnTruocTatCa_Click;
            //
            // lblTrangTatCa
            //
            lblTrangTatCa.Font = new Font("Segoe UI", 10F);
            lblTrangTatCa.Location = new Point(790, 456);
            lblTrangTatCa.Name = "lblTrangTatCa";
            lblTrangTatCa.Size = new Size(120, 24);
            lblTrangTatCa.TabIndex = 4;
            lblTrangTatCa.Text = "Trang 1/1";
            lblTrangTatCa.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnSauTatCa
            //
            btnSauTatCa.BackColor = Color.FromArgb(51, 122, 183);
            btnSauTatCa.Cursor = Cursors.Hand;
            btnSauTatCa.FlatAppearance.BorderSize = 0;
            btnSauTatCa.FlatStyle = FlatStyle.Flat;
            btnSauTatCa.ForeColor = Color.White;
            btnSauTatCa.Location = new Point(920, 450);
            btnSauTatCa.Name = "btnSauTatCa";
            btnSauTatCa.Size = new Size(80, 36);
            btnSauTatCa.TabIndex = 5;
            btnSauTatCa.Text = "Sau";
            btnSauTatCa.UseVisualStyleBackColor = false;
            btnSauTatCa.Click += btnSauTatCa_Click;
            //
            // tabThem
            //
            tabThem.BackColor = Color.White;
            tabThem.Controls.Add(lblGhiChu);
            tabThem.Controls.Add(btnThem);
            tabThem.Controls.Add(txtDiaChi);
            tabThem.Controls.Add(lblDiaChi);
            tabThem.Controls.Add(txtGia);
            tabThem.Controls.Add(lblGia);
            tabThem.Controls.Add(txtHinhAnh);
            tabThem.Controls.Add(lblHinhAnh);
            tabThem.Controls.Add(txtMoTa);
            tabThem.Controls.Add(lblMoTa);
            tabThem.Controls.Add(txtTenMonAn);
            tabThem.Controls.Add(lblTenMonAn);
            tabThem.Location = new Point(4, 26);
            tabThem.Name = "tabThem";
            tabThem.Padding = new Padding(3);
            tabThem.Size = new Size(1042, 570);
            tabThem.TabIndex = 2;
            tabThem.Text = "Thêm món ăn";
            //
            // lblTenMonAn
            //
            lblTenMonAn.AutoSize = true;
            lblTenMonAn.Font = new Font("Segoe UI", 9F);
            lblTenMonAn.Location = new Point(20, 20);
            lblTenMonAn.Name = "lblTenMonAn";
            lblTenMonAn.Size = new Size(72, 15);
            lblTenMonAn.TabIndex = 0;
            lblTenMonAn.Text = "Tên món ăn";
            //
            // txtTenMonAn
            //
            txtTenMonAn.Font = new Font("Segoe UI", 10F);
            txtTenMonAn.Location = new Point(20, 40);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(600, 25);
            txtTenMonAn.TabIndex = 1;
            //
            // lblMoTa
            //
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 9F);
            lblMoTa.Location = new Point(20, 80);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(39, 15);
            lblMoTa.TabIndex = 2;
            lblMoTa.Text = "Mô tả";
            //
            // txtMoTa
            //
            txtMoTa.Font = new Font("Segoe UI", 10F);
            txtMoTa.Location = new Point(20, 100);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(600, 75);
            txtMoTa.TabIndex = 3;
            //
            // lblHinhAnh
            //
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Font = new Font("Segoe UI", 9F);
            lblHinhAnh.Location = new Point(20, 190);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(88, 15);
            lblHinhAnh.TabIndex = 4;
            lblHinhAnh.Text = "URL hình ảnh";
            //
            // txtHinhAnh
            //
            txtHinhAnh.Font = new Font("Segoe UI", 10F);
            txtHinhAnh.Location = new Point(20, 210);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(600, 25);
            txtHinhAnh.TabIndex = 5;
            //
            // lblGia
            //
            lblGia.AutoSize = true;
            lblGia.Font = new Font("Segoe UI", 9F);
            lblGia.Location = new Point(20, 250);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(24, 15);
            lblGia.TabIndex = 6;
            lblGia.Text = "Giá";
            //
            // txtGia
            //
            txtGia.Font = new Font("Segoe UI", 10F);
            txtGia.Location = new Point(20, 270);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(280, 25);
            txtGia.TabIndex = 7;
            //
            // lblDiaChi
            //
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI", 9F);
            lblDiaChi.Location = new Point(20, 310);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(43, 15);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa chỉ";
            //
            // txtDiaChi
            //
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(20, 330);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(600, 25);
            txtDiaChi.TabIndex = 9;
            //
            // btnThem
            //
            btnThem.BackColor = Color.FromArgb(51, 122, 183);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(20, 380);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(180, 40);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm món ăn";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            //
            // lblGhiChu
            //
            lblGhiChu.Font = new Font("Segoe UI", 9F);
            lblGhiChu.ForeColor = Color.FromArgb(120, 120, 120);
            lblGhiChu.Location = new Point(220, 382);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(500, 40);
            lblGhiChu.TabIndex = 11;
            lblGhiChu.Text = "Nhập giá là số, ví dụ 35000. Hình ảnh có thể để trống nếu không có.";
            //
            // lblThongBao
            //
            lblThongBao.Font = new Font("Segoe UI", 9F);
            lblThongBao.ForeColor = Color.FromArgb(100, 100, 100);
            lblThongBao.Location = new Point(20, 688);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(1000, 24);
            lblThongBao.TabIndex = 3;
            //
            // QuanLyMonAnForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1090, 725);
            Controls.Add(lblThongBao);
            Controls.Add(tabControl);
            Controls.Add(lblNguoiDung);
            Controls.Add(lblTieuDe);
            MinimumSize = new Size(1100, 760);
            Name = "QuanLyMonAnForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý món ăn";
            Load += QuanLyMonAnForm_Load;
            tabControl.ResumeLayout(false);
            tabCuaToi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCuaToi).EndInit();
            tabTatCa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTatCa).EndInit();
            tabThem.ResumeLayout(false);
            tabThem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblNguoiDung;
        private TabControl tabControl;
        private TabPage tabCuaToi;
        private DataGridView dgvCuaToi;
        private Button btnLamMoiCuaToi;
        private Button btnXoa;
        private Button btnRandomCuaToi;
        private Button btnTruocCuaToi;
        private Label lblTrangCuaToi;
        private Button btnSauCuaToi;
        private TabPage tabTatCa;
        private DataGridView dgvTatCa;
        private Button btnLamMoiTatCa;
        private Button btnRandomTatCa;
        private Button btnTruocTatCa;
        private Label lblTrangTatCa;
        private Button btnSauTatCa;
        private TabPage tabThem;
        private Label lblTenMonAn;
        private TextBox txtTenMonAn;
        private Label lblMoTa;
        private TextBox txtMoTa;
        private Label lblHinhAnh;
        private TextBox txtHinhAnh;
        private Label lblGia;
        private TextBox txtGia;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Button btnThem;
        private Label lblGhiChu;
        private Label lblThongBao;
    }
}
