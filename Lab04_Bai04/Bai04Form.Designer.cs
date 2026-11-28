namespace NT106.R14._1_Lab04_Nhom4.Bai04
{
    partial class Bai04Form
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
            lblUrl = new Label();
            txtUrl = new TextBox();
            btnTai = new Button();
            progressBar = new ProgressBar();
            lblTrangThai = new Label();
            flpPhim = new FlowLayoutPanel();
            panelDatVe = new Panel();
            lblDatVe = new Label();
            lblPhimChon = new Label();
            lblKhachHang = new Label();
            txtKhachHang = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblLoaiGhe = new Label();
            cboLoaiGhe = new ComboBox();
            lblSoLuong = new Label();
            numSoLuong = new NumericUpDown();
            lblTongTien = new Label();
            btnDatVe = new Button();
            lblGhiChu = new Label();
            panelDatVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(35, 78, 120);
            lblTieuDe.Location = new Point(20, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(380, 32);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BÀI 04 - QUẢN LÝ PHÒNG VÉ";
            //
            // lblUrl
            //
            lblUrl.AutoSize = true;
            lblUrl.Font = new Font("Segoe UI", 10F);
            lblUrl.Location = new Point(20, 61);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(57, 19);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "Địa chỉ:";
            //
            // txtUrl
            //
            txtUrl.Font = new Font("Segoe UI", 10F);
            txtUrl.Location = new Point(83, 58);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(530, 25);
            txtUrl.TabIndex = 2;
            //
            // btnTai
            //
            btnTai.BackColor = Color.FromArgb(51, 122, 183);
            btnTai.Cursor = Cursors.Hand;
            btnTai.FlatAppearance.BorderSize = 0;
            btnTai.FlatStyle = FlatStyle.Flat;
            btnTai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTai.ForeColor = Color.White;
            btnTai.Location = new Point(625, 54);
            btnTai.Name = "btnTai";
            btnTai.Size = new Size(130, 32);
            btnTai.TabIndex = 3;
            btnTai.Text = "Tải dữ liệu";
            btnTai.UseVisualStyleBackColor = false;
            btnTai.Click += btnTai_Click;
            //
            // progressBar
            //
            progressBar.Location = new Point(775, 60);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(390, 20);
            progressBar.TabIndex = 4;
            //
            // lblTrangThai
            //
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9F);
            lblTrangThai.ForeColor = Color.FromArgb(100, 100, 100);
            lblTrangThai.Location = new Point(20, 92);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(199, 15);
            lblTrangThai.TabIndex = 5;
            lblTrangThai.Text = "Chọn \"Tải dữ liệu\" để lấy danh sách phim.";
            //
            // flpPhim
            //
            flpPhim.AutoScroll = true;
            flpPhim.BackColor = Color.White;
            flpPhim.BorderStyle = BorderStyle.FixedSingle;
            flpPhim.Location = new Point(20, 120);
            flpPhim.Name = "flpPhim";
            flpPhim.Padding = new Padding(4);
            flpPhim.Size = new Size(730, 600);
            flpPhim.TabIndex = 6;
            //
            // panelDatVe
            //
            panelDatVe.BackColor = Color.White;
            panelDatVe.BorderStyle = BorderStyle.FixedSingle;
            panelDatVe.Controls.Add(lblGhiChu);
            panelDatVe.Controls.Add(btnDatVe);
            panelDatVe.Controls.Add(lblTongTien);
            panelDatVe.Controls.Add(numSoLuong);
            panelDatVe.Controls.Add(lblSoLuong);
            panelDatVe.Controls.Add(cboLoaiGhe);
            panelDatVe.Controls.Add(lblLoaiGhe);
            panelDatVe.Controls.Add(txtSoDienThoai);
            panelDatVe.Controls.Add(lblSoDienThoai);
            panelDatVe.Controls.Add(txtKhachHang);
            panelDatVe.Controls.Add(lblKhachHang);
            panelDatVe.Controls.Add(lblPhimChon);
            panelDatVe.Controls.Add(lblDatVe);
            panelDatVe.Location = new Point(770, 120);
            panelDatVe.Name = "panelDatVe";
            panelDatVe.Size = new Size(395, 600);
            panelDatVe.TabIndex = 7;
            //
            // lblDatVe
            //
            lblDatVe.AutoSize = true;
            lblDatVe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblDatVe.ForeColor = Color.FromArgb(35, 78, 120);
            lblDatVe.Location = new Point(20, 15);
            lblDatVe.Name = "lblDatVe";
            lblDatVe.Size = new Size(214, 25);
            lblDatVe.TabIndex = 0;
            lblDatVe.Text = "THÔNG TIN ĐẶT VÉ";
            //
            // lblPhimChon
            //
            lblPhimChon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhimChon.Location = new Point(20, 52);
            lblPhimChon.Name = "lblPhimChon";
            lblPhimChon.Size = new Size(355, 60);
            lblPhimChon.TabIndex = 1;
            lblPhimChon.Text = "Chưa chọn phim";
            //
            // lblKhachHang
            //
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 10F);
            lblKhachHang.Location = new Point(20, 125);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(113, 19);
            lblKhachHang.TabIndex = 2;
            lblKhachHang.Text = "Họ tên khách hàng";
            //
            // txtKhachHang
            //
            txtKhachHang.Font = new Font("Segoe UI", 10F);
            txtKhachHang.Location = new Point(20, 150);
            txtKhachHang.Name = "txtKhachHang";
            txtKhachHang.Size = new Size(355, 25);
            txtKhachHang.TabIndex = 3;
            //
            // lblSoDienThoai
            //
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Segoe UI", 10F);
            lblSoDienThoai.Location = new Point(20, 190);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(89, 19);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại";
            //
            // txtSoDienThoai
            //
            txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            txtSoDienThoai.Location = new Point(20, 215);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(355, 25);
            txtSoDienThoai.TabIndex = 5;
            //
            // lblLoaiGhe
            //
            lblLoaiGhe.AutoSize = true;
            lblLoaiGhe.Font = new Font("Segoe UI", 10F);
            lblLoaiGhe.Location = new Point(20, 255);
            lblLoaiGhe.Name = "lblLoaiGhe";
            lblLoaiGhe.Size = new Size(59, 19);
            lblLoaiGhe.TabIndex = 6;
            lblLoaiGhe.Text = "Loại ghế";
            //
            // cboLoaiGhe
            //
            cboLoaiGhe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiGhe.Font = new Font("Segoe UI", 10F);
            cboLoaiGhe.FormattingEnabled = true;
            cboLoaiGhe.Items.AddRange(new object[] { "Ghế thường - 70.000đ", "Ghế VIP - 100.000đ", "Ghế đôi - 150.000đ" });
            cboLoaiGhe.Location = new Point(20, 280);
            cboLoaiGhe.Name = "cboLoaiGhe";
            cboLoaiGhe.Size = new Size(355, 25);
            cboLoaiGhe.TabIndex = 7;
            cboLoaiGhe.SelectedIndexChanged += cboLoaiGhe_SelectedIndexChanged;
            //
            // lblSoLuong
            //
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 10F);
            lblSoLuong.Location = new Point(20, 320);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(76, 19);
            lblSoLuong.TabIndex = 8;
            lblSoLuong.Text = "Số lượng vé";
            //
            // numSoLuong
            //
            numSoLuong.Font = new Font("Segoe UI", 10F);
            numSoLuong.Location = new Point(20, 345);
            numSoLuong.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(120, 25);
            numSoLuong.TabIndex = 9;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.ValueChanged += numSoLuong_ValueChanged;
            //
            // lblTongTien
            //
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.FromArgb(190, 60, 60);
            lblTongTien.Location = new Point(20, 390);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(355, 35);
            lblTongTien.TabIndex = 10;
            lblTongTien.Text = "Tổng tiền: 0 đ";
            //
            // btnDatVe
            //
            btnDatVe.BackColor = Color.FromArgb(51, 122, 183);
            btnDatVe.Cursor = Cursors.Hand;
            btnDatVe.FlatAppearance.BorderSize = 0;
            btnDatVe.FlatStyle = FlatStyle.Flat;
            btnDatVe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDatVe.ForeColor = Color.White;
            btnDatVe.Location = new Point(20, 440);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(355, 45);
            btnDatVe.TabIndex = 11;
            btnDatVe.Text = "ĐẶT VÉ";
            btnDatVe.UseVisualStyleBackColor = false;
            btnDatVe.Click += btnDatVe_Click;
            //
            // lblGhiChu
            //
            lblGhiChu.Font = new Font("Segoe UI", 9F);
            lblGhiChu.ForeColor = Color.FromArgb(120, 120, 120);
            lblGhiChu.Location = new Point(20, 505);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(355, 70);
            lblGhiChu.TabIndex = 12;
            lblGhiChu.Text = "Chọn phim bên trái, nhập thông tin khách hàng rồi bấm ĐẶT VÉ. Bấm vào ảnh phim để xem chi tiết trên website.";
            //
            // Bai04Form
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 740);
            Controls.Add(panelDatVe);
            Controls.Add(flpPhim);
            Controls.Add(lblTrangThai);
            Controls.Add(progressBar);
            Controls.Add(btnTai);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Controls.Add(lblTieuDe);
            MinimumSize = new Size(1100, 700);
            Name = "Bai04Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bài 04 - Quản lý phòng vé";
            panelDatVe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblUrl;
        private TextBox txtUrl;
        private Button btnTai;
        private ProgressBar progressBar;
        private Label lblTrangThai;
        private FlowLayoutPanel flpPhim;
        private Panel panelDatVe;
        private Label lblDatVe;
        private Label lblPhimChon;
        private Label lblKhachHang;
        private TextBox txtKhachHang;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblLoaiGhe;
        private ComboBox cboLoaiGhe;
        private Label lblSoLuong;
        private NumericUpDown numSoLuong;
        private Label lblTongTien;
        private Button btnDatVe;
        private Label lblGhiChu;
    }
}
