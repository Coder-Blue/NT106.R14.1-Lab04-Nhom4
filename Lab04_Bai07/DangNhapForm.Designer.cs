namespace NT106.R14._1_Lab04_Nhom4.Bai07
{
    partial class DangNhapForm
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
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblThongBao = new Label();
            btnDangNhap = new Button();
            btnHuy = new Button();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(35, 78, 120);
            lblTieuDe.Location = new Point(20, 18);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(209, 25);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG NHẬP HỆ THỐNG";
            //
            // lblTenDangNhap
            //
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10F);
            lblTenDangNhap.Location = new Point(20, 65);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(100, 19);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập";
            //
            // txtTenDangNhap
            //
            txtTenDangNhap.Font = new Font("Segoe UI", 10F);
            txtTenDangNhap.Location = new Point(20, 88);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(380, 25);
            txtTenDangNhap.TabIndex = 2;
            //
            // lblMatKhau
            //
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.Location = new Point(20, 128);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(67, 19);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "Mật khẩu";
            //
            // txtMatKhau
            //
            txtMatKhau.Font = new Font("Segoe UI", 10F);
            txtMatKhau.Location = new Point(20, 151);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(380, 25);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.UseSystemPasswordChar = true;
            //
            // lblThongBao
            //
            lblThongBao.Font = new Font("Segoe UI", 9F);
            lblThongBao.ForeColor = Color.FromArgb(190, 60, 60);
            lblThongBao.Location = new Point(20, 186);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(380, 40);
            lblThongBao.TabIndex = 5;
            //
            // btnDangNhap
            //
            btnDangNhap.BackColor = Color.FromArgb(51, 122, 183);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(20, 235);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(180, 38);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            //
            // btnHuy
            //
            btnHuy.BackColor = Color.FromArgb(140, 140, 140);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.DialogResult = DialogResult.Cancel;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(220, 235);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(180, 38);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            //
            // DangNhapForm
            //
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnHuy;
            ClientSize = new Size(424, 296);
            Controls.Add(btnHuy);
            Controls.Add(btnDangNhap);
            Controls.Add(lblThongBao);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DangNhapForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblThongBao;
        private Button btnDangNhap;
        private Button btnHuy;
    }
}
