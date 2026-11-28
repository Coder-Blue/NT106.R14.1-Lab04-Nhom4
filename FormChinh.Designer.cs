namespace NT106.R14._1_Lab04_Nhom4
{
    partial class FormChinh
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
            lblPhuDe = new Label();
            lblHuongDan = new Label();
            btnBai02 = new Button();
            btnBai03 = new Button();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(35, 78, 120);
            lblTieuDe.Location = new Point(0, 26);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(980, 46);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "LAB 04 - TRUYỀN THÔNG VỚI WEB SERVER TRONG C#";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblPhuDe
            //
            lblPhuDe.Font = new Font("Segoe UI", 11F);
            lblPhuDe.ForeColor = Color.FromArgb(100, 100, 100);
            lblPhuDe.Location = new Point(0, 78);
            lblPhuDe.Name = "lblPhuDe";
            lblPhuDe.Size = new Size(980, 28);
            lblPhuDe.TabIndex = 1;
            lblPhuDe.Text = "NT106.R14.1 - Nhóm 4";
            lblPhuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblHuongDan
            //
            lblHuongDan.Font = new Font("Segoe UI", 10F);
            lblHuongDan.ForeColor = Color.FromArgb(70, 70, 70);
            lblHuongDan.Location = new Point(0, 128);
            lblHuongDan.Name = "lblHuongDan";
            lblHuongDan.Size = new Size(980, 26);
            lblHuongDan.TabIndex = 2;
            lblHuongDan.Text = "Chọn một bài thực hành để mở form điều hướng.";
            lblHuongDan.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnBai02
            //
            btnBai02.BackColor = Color.FromArgb(51, 122, 183);
            btnBai02.Cursor = Cursors.Hand;
            btnBai02.FlatAppearance.BorderSize = 0;
            btnBai02.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 96, 145);
            btnBai02.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 138, 204);
            btnBai02.FlatStyle = FlatStyle.Flat;
            btnBai02.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnBai02.ForeColor = Color.White;
            btnBai02.Location = new Point(150, 200);
            btnBai02.Name = "btnBai02";
            btnBai02.Size = new Size(300, 112);
            btnBai02.TabIndex = 3;
            btnBai02.Text = "Bài 02\nDownload trang web";
            btnBai02.UseVisualStyleBackColor = false;
            btnBai02.Click += btnBai02_Click;
            //
            // btnBai03
            //
            btnBai03.BackColor = Color.FromArgb(51, 122, 183);
            btnBai03.Cursor = Cursors.Hand;
            btnBai03.FlatAppearance.BorderSize = 0;
            btnBai03.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 96, 145);
            btnBai03.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 138, 204);
            btnBai03.FlatStyle = FlatStyle.Flat;
            btnBai03.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnBai03.ForeColor = Color.White;
            btnBai03.Location = new Point(530, 200);
            btnBai03.Name = "btnBai03";
            btnBai03.Size = new Size(300, 112);
            btnBai03.TabIndex = 4;
            btnBai03.Text = "Bài 03\nWeb Browser";
            btnBai03.UseVisualStyleBackColor = false;
            btnBai03.Click += btnBai03_Click;
            //
            // FormChinh
            //
            AcceptButton = btnBai02;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(980, 540);
            Controls.Add(btnBai03);
            Controls.Add(btnBai02);
            Controls.Add(lblHuongDan);
            Controls.Add(lblPhuDe);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 04 - NT106.R14.1 - Nhóm 4";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTieuDe;
        private Label lblPhuDe;
        private Label lblHuongDan;
        private Button btnBai02;
        private Button btnBai03;
    }
}
