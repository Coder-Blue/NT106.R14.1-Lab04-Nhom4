namespace NT106.R14._1_Lab04_Nhom4.Bai03
{
    partial class Bai03Form
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
            panelTop = new Panel();
            lblTieuDe = new Label();
            lblMoTa = new Label();
            btnQuayLai = new Button();
            btnTien = new Button();
            btnTaiLai = new Button();
            btnTrangChu = new Button();
            txtDiaChi = new TextBox();
            btnMo = new Button();
            btnTaiHtml = new Button();
            btnTaiHinh = new Button();
            btnXemNguon = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            statusStrip = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            progressBar = new ToolStripProgressBar();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            //
            // panelTop
            //
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(lblTieuDe);
            panelTop.Controls.Add(lblMoTa);
            panelTop.Controls.Add(btnQuayLai);
            panelTop.Controls.Add(btnTien);
            panelTop.Controls.Add(btnTaiLai);
            panelTop.Controls.Add(btnTrangChu);
            panelTop.Controls.Add(txtDiaChi);
            panelTop.Controls.Add(btnMo);
            panelTop.Controls.Add(btnTaiHtml);
            panelTop.Controls.Add(btnTaiHinh);
            panelTop.Controls.Add(btnXemNguon);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1100, 165);
            panelTop.TabIndex = 0;
            //
            // lblTieuDe
            //
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(35, 78, 120);
            lblTieuDe.Location = new Point(24, 14);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(700, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BÀI 03 - WEB BROWSER";
            //
            // lblMoTa
            //
            lblMoTa.Font = new Font("Segoe UI", 9.5F);
            lblMoTa.ForeColor = Color.FromArgb(100, 100, 100);
            lblMoTa.Location = new Point(24, 52);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(900, 22);
            lblMoTa.TabIndex = 1;
            lblMoTa.Text = "Xem website, tải file HTML, tải hình ảnh và xem mã nguồn.";
            //
            // btnQuayLai
            //
            btnQuayLai.BackColor = Color.FromArgb(240, 244, 250);
            btnQuayLai.Cursor = Cursors.Hand;
            btnQuayLai.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 225);
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 10F);
            btnQuayLai.Location = new Point(24, 84);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(40, 32);
            btnQuayLai.TabIndex = 2;
            btnQuayLai.Text = "◀";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            //
            // btnTien
            //
            btnTien.BackColor = Color.FromArgb(240, 244, 250);
            btnTien.Cursor = Cursors.Hand;
            btnTien.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 225);
            btnTien.FlatStyle = FlatStyle.Flat;
            btnTien.Font = new Font("Segoe UI", 10F);
            btnTien.Location = new Point(70, 84);
            btnTien.Name = "btnTien";
            btnTien.Size = new Size(40, 32);
            btnTien.TabIndex = 3;
            btnTien.Text = "▶";
            btnTien.UseVisualStyleBackColor = false;
            btnTien.Click += btnTien_Click;
            //
            // btnTaiLai
            //
            btnTaiLai.BackColor = Color.FromArgb(240, 244, 250);
            btnTaiLai.Cursor = Cursors.Hand;
            btnTaiLai.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 225);
            btnTaiLai.FlatStyle = FlatStyle.Flat;
            btnTaiLai.Font = new Font("Segoe UI", 10F);
            btnTaiLai.Location = new Point(116, 84);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(40, 32);
            btnTaiLai.TabIndex = 4;
            btnTaiLai.Text = "⟳";
            btnTaiLai.UseVisualStyleBackColor = false;
            btnTaiLai.Click += btnTaiLai_Click;
            //
            // btnTrangChu
            //
            btnTrangChu.BackColor = Color.FromArgb(240, 244, 250);
            btnTrangChu.Cursor = Cursors.Hand;
            btnTrangChu.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 225);
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Segoe UI", 10F);
            btnTrangChu.Location = new Point(162, 84);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(40, 32);
            btnTrangChu.TabIndex = 5;
            btnTrangChu.Text = "⌂";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            //
            // txtDiaChi
            //
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(210, 86);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(760, 30);
            txtDiaChi.TabIndex = 6;
            //
            // btnMo
            //
            btnMo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMo.BackColor = Color.FromArgb(51, 122, 183);
            btnMo.Cursor = Cursors.Hand;
            btnMo.FlatAppearance.BorderSize = 0;
            btnMo.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 96, 145);
            btnMo.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 138, 204);
            btnMo.FlatStyle = FlatStyle.Flat;
            btnMo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMo.ForeColor = Color.White;
            btnMo.Location = new Point(980, 84);
            btnMo.Name = "btnMo";
            btnMo.Size = new Size(90, 32);
            btnMo.TabIndex = 7;
            btnMo.Text = "Mở";
            btnMo.UseVisualStyleBackColor = false;
            btnMo.Click += btnMo_Click;
            //
            // btnTaiHtml
            //
            btnTaiHtml.BackColor = Color.FromArgb(51, 122, 183);
            btnTaiHtml.Cursor = Cursors.Hand;
            btnTaiHtml.FlatAppearance.BorderSize = 0;
            btnTaiHtml.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 96, 145);
            btnTaiHtml.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 138, 204);
            btnTaiHtml.FlatStyle = FlatStyle.Flat;
            btnTaiHtml.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTaiHtml.ForeColor = Color.White;
            btnTaiHtml.Location = new Point(24, 124);
            btnTaiHtml.Name = "btnTaiHtml";
            btnTaiHtml.Size = new Size(140, 30);
            btnTaiHtml.TabIndex = 8;
            btnTaiHtml.Text = "Tải HTML";
            btnTaiHtml.UseVisualStyleBackColor = false;
            btnTaiHtml.Click += btnTaiHtml_Click;
            //
            // btnTaiHinh
            //
            btnTaiHinh.BackColor = Color.FromArgb(51, 122, 183);
            btnTaiHinh.Cursor = Cursors.Hand;
            btnTaiHinh.FlatAppearance.BorderSize = 0;
            btnTaiHinh.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 96, 145);
            btnTaiHinh.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 138, 204);
            btnTaiHinh.FlatStyle = FlatStyle.Flat;
            btnTaiHinh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTaiHinh.ForeColor = Color.White;
            btnTaiHinh.Location = new Point(172, 124);
            btnTaiHinh.Name = "btnTaiHinh";
            btnTaiHinh.Size = new Size(160, 30);
            btnTaiHinh.TabIndex = 9;
            btnTaiHinh.Text = "Tải hình ảnh";
            btnTaiHinh.UseVisualStyleBackColor = false;
            btnTaiHinh.Click += btnTaiHinh_Click;
            //
            // btnXemNguon
            //
            btnXemNguon.BackColor = Color.FromArgb(51, 122, 183);
            btnXemNguon.Cursor = Cursors.Hand;
            btnXemNguon.FlatAppearance.BorderSize = 0;
            btnXemNguon.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 96, 145);
            btnXemNguon.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 138, 204);
            btnXemNguon.FlatStyle = FlatStyle.Flat;
            btnXemNguon.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXemNguon.ForeColor = Color.White;
            btnXemNguon.Location = new Point(340, 124);
            btnXemNguon.Name = "btnXemNguon";
            btnXemNguon.Size = new Size(140, 30);
            btnXemNguon.TabIndex = 10;
            btnXemNguon.Text = "Xem mã nguồn";
            btnXemNguon.UseVisualStyleBackColor = false;
            btnXemNguon.Click += btnXemNguon_Click;
            //
            // webView
            //
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 165);
            webView.Name = "webView";
            webView.Size = new Size(1100, 529);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            //
            // statusStrip
            //
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTrangThai, progressBar });
            statusStrip.Location = new Point(0, 694);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1100, 26);
            statusStrip.TabIndex = 2;
            //
            // lblTrangThai
            //
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(883, 20);
            lblTrangThai.Spring = true;
            lblTrangThai.Text = "Sẵn sàng.";
            lblTrangThai.TextAlign = ContentAlignment.MiddleLeft;
            //
            // progressBar
            //
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(200, 18);
            progressBar.Visible = false;
            //
            // Bai03Form
            //
            AcceptButton = btnMo;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 720);
            Controls.Add(webView);
            Controls.Add(statusStrip);
            Controls.Add(panelTop);
            MinimumSize = new Size(820, 520);
            Name = "Bai03Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bài 03 - Web Browser";
            Load += Bai03Form_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label lblTieuDe;
        private Label lblMoTa;
        private Button btnQuayLai;
        private Button btnTien;
        private Button btnTaiLai;
        private Button btnTrangChu;
        private TextBox txtDiaChi;
        private Button btnMo;
        private Button btnTaiHtml;
        private Button btnTaiHinh;
        private Button btnXemNguon;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripProgressBar progressBar;
    }
}
