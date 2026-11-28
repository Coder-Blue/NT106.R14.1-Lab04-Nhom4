namespace NT106.R14._1_Lab04_Nhom4.Bai07
{
    partial class FormMonNgauNhien
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
            picAnh = new PictureBox();
            lblTen = new Label();
            lblGia = new Label();
            lblDiaChi = new Label();
            lblNguoiDongGop = new Label();
            lblMoTa = new Label();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(35, 78, 120);
            lblTieuDe.Location = new Point(20, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(480, 30);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĂN MÓN NÀY ĐI!!!";
            //
            // picAnh
            //
            picAnh.BackColor = Color.FromArgb(240, 240, 240);
            picAnh.BorderStyle = BorderStyle.FixedSingle;
            picAnh.Location = new Point(20, 60);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(200, 240);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 1;
            picAnh.TabStop = false;
            //
            // lblTen
            //
            lblTen.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTen.ForeColor = Color.FromArgb(190, 90, 50);
            lblTen.Location = new Point(240, 60);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(250, 32);
            lblTen.TabIndex = 2;
            //
            // lblGia
            //
            lblGia.Font = new Font("Segoe UI", 10F);
            lblGia.Location = new Point(240, 100);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(250, 24);
            lblGia.TabIndex = 3;
            //
            // lblDiaChi
            //
            lblDiaChi.Font = new Font("Segoe UI", 10F);
            lblDiaChi.Location = new Point(240, 130);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(250, 24);
            lblDiaChi.TabIndex = 4;
            //
            // lblNguoiDongGop
            //
            lblNguoiDongGop.Font = new Font("Segoe UI", 10F);
            lblNguoiDongGop.Location = new Point(240, 160);
            lblNguoiDongGop.Name = "lblNguoiDongGop";
            lblNguoiDongGop.Size = new Size(250, 24);
            lblNguoiDongGop.TabIndex = 5;
            //
            // lblMoTa
            //
            lblMoTa.Font = new Font("Segoe UI", 9F);
            lblMoTa.ForeColor = Color.FromArgb(90, 90, 90);
            lblMoTa.Location = new Point(240, 195);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(250, 80);
            lblMoTa.TabIndex = 6;
            //
            // btnDong
            //
            btnDong.BackColor = Color.FromArgb(51, 122, 183);
            btnDong.Cursor = Cursors.Hand;
            btnDong.DialogResult = DialogResult.OK;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(330, 285);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(160, 40);
            btnDong.TabIndex = 7;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            //
            // FormMonNgauNhien
            //
            AcceptButton = btnDong;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnDong;
            ClientSize = new Size(520, 345);
            Controls.Add(btnDong);
            Controls.Add(lblMoTa);
            Controls.Add(lblNguoiDongGop);
            Controls.Add(lblDiaChi);
            Controls.Add(lblGia);
            Controls.Add(lblTen);
            Controls.Add(picAnh);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMonNgauNhien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hôm nay ăn gì?";
            Load += FormMonNgauNhien_Load;
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTieuDe;
        private PictureBox picAnh;
        private Label lblTen;
        private Label lblGia;
        private Label lblDiaChi;
        private Label lblNguoiDongGop;
        private Label lblMoTa;
        private Button btnDong;
    }
}
