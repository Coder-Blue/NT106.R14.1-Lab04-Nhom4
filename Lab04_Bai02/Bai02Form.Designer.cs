namespace NT106.R14._1_Lab04_Nhom4.Bai02
{
    partial class Bai02Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            lblMoTa = new Label();
            lblUrl = new Label();
            txtUrl = new TextBox();
            lblLuuFile = new Label();
            txtLuuFile = new TextBox();
            btnChonFile = new Button();
            btnTai = new Button();
            grpNoiDung = new GroupBox();
            rtbNoiDung = new RichTextBox();
            lblTrangThai = new Label();
            grpNoiDung.SuspendLayout();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(35, 78, 120);
            lblTieuDe.Location = new Point(24, 16);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(650, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BÀI 02 - DOWNLOAD TRANG WEB";
            //
            // lblMoTa
            //
            lblMoTa.Font = new Font("Segoe UI", 9.5F);
            lblMoTa.ForeColor = Color.FromArgb(100, 100, 100);
            lblMoTa.Location = new Point(24, 54);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(852, 24);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Tải nội dung trang web bằng WebClient, lưu thành file HTML rồi hiển thị lên form.";
            //
            // lblUrl
            //
            lblUrl.Font = new Font("Segoe UI", 10F);
            lblUrl.Location = new Point(24, 100);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(90, 24);
            lblUrl.TabIndex = 2;
            lblUrl.Text = "Địa chỉ URL:";
            //
            // txtUrl
            //
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.Font = new Font("Segoe UI", 10F);
            txtUrl.Location = new Point(120, 96);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(600, 30);
            txtUrl.TabIndex = 3;
            txtUrl.Text = "https://uit.edu.vn";
            //
            // lblLuuFile
            //
            lblLuuFile.Font = new Font("Segoe UI", 10F);
            lblLuuFile.Location = new Point(24, 140);
            lblLuuFile.Name = "lblLuuFile";
            lblLuuFile.Size = new Size(90, 24);
            lblLuuFile.TabIndex = 4;
            lblLuuFile.Text = "Lưu file:";
            //
            // txtLuuFile
            //
            txtLuuFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLuuFile.Font = new Font("Segoe UI", 10F);
            txtLuuFile.Location = new Point(120, 136);
            txtLuuFile.Name = "txtLuuFile";
            txtLuuFile.Size = new Size(520, 30);
            txtLuuFile.TabIndex = 5;
            //
            // btnChonFile
            //
            btnChonFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChonFile.Location = new Point(650, 134);
            btnChonFile.Name = "btnChonFile";
            btnChonFile.Size = new Size(70, 32);
            btnChonFile.TabIndex = 6;
            btnChonFile.Text = "...";
            btnChonFile.UseVisualStyleBackColor = true;
            btnChonFile.Click += btnChonFile_Click;
            //
            // btnTai
            //
            btnTai.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTai.BackColor = Color.FromArgb(51, 122, 183);
            btnTai.Cursor = Cursors.Hand;
            btnTai.FlatAppearance.BorderSize = 0;
            btnTai.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 96, 145);
            btnTai.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 138, 204);
            btnTai.FlatStyle = FlatStyle.Flat;
            btnTai.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTai.ForeColor = Color.White;
            btnTai.Location = new Point(730, 96);
            btnTai.Name = "btnTai";
            btnTai.Size = new Size(146, 70);
            btnTai.TabIndex = 7;
            btnTai.Text = "Tải về";
            btnTai.UseVisualStyleBackColor = false;
            btnTai.Click += btnTai_Click;
            //
            // grpNoiDung
            //
            grpNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpNoiDung.Controls.Add(rtbNoiDung);
            grpNoiDung.Font = new Font("Segoe UI", 10F);
            grpNoiDung.Location = new Point(24, 186);
            grpNoiDung.Name = "grpNoiDung";
            grpNoiDung.Size = new Size(852, 354);
            grpNoiDung.TabIndex = 8;
            grpNoiDung.TabStop = false;
            grpNoiDung.Text = "Nội dung HTML";
            //
            // rtbNoiDung
            //
            rtbNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbNoiDung.BackColor = Color.White;
            rtbNoiDung.BorderStyle = BorderStyle.FixedSingle;
            rtbNoiDung.DetectUrls = false;
            rtbNoiDung.Font = new Font("Consolas", 9.5F);
            rtbNoiDung.Location = new Point(14, 26);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.ScrollBars = RichTextBoxScrollBars.Both;
            rtbNoiDung.Size = new Size(824, 314);
            rtbNoiDung.TabIndex = 0;
            rtbNoiDung.Text = "";
            rtbNoiDung.WordWrap = false;
            //
            // lblTrangThai
            //
            lblTrangThai.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTrangThai.Font = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lblTrangThai.ForeColor = Color.FromArgb(100, 100, 100);
            lblTrangThai.Location = new Point(24, 552);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(852, 24);
            lblTrangThai.TabIndex = 9;
            lblTrangThai.Text = "Sẵn sàng.";
            //
            // Bai02Form
            //
            AcceptButton = btnTai;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            Controls.Add(lblTrangThai);
            Controls.Add(grpNoiDung);
            Controls.Add(btnTai);
            Controls.Add(btnChonFile);
            Controls.Add(txtLuuFile);
            Controls.Add(lblLuuFile);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Controls.Add(lblMoTa);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Bai02Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bài 02 - Download trang web";
            grpNoiDung.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblMoTa;
        private Label lblUrl;
        private TextBox txtUrl;
        private Label lblLuuFile;
        private TextBox txtLuuFile;
        private Button btnChonFile;
        private Button btnTai;
        private GroupBox grpNoiDung;
        private RichTextBox rtbNoiDung;
        private Label lblTrangThai;
    }
}
