namespace NT106.R14._1_Lab04_Nhom4.Bai03
{
    partial class FormViewSource
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
            lblInfo = new Label();
            btnCopy = new Button();
            btnLuu = new Button();
            rtbSource = new RichTextBox();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(35, 78, 120);
            lblTieuDe.Location = new Point(20, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(600, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "MÃ NGUỒN HTML";
            //
            // lblInfo
            //
            lblInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInfo.AutoEllipsis = true;
            lblInfo.Font = new Font("Segoe UI", 9.5F);
            lblInfo.ForeColor = Color.FromArgb(100, 100, 100);
            lblInfo.Location = new Point(20, 50);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(660, 24);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "url";
            //
            // btnCopy
            //
            btnCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopy.BackColor = Color.FromArgb(51, 122, 183);
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.FlatAppearance.BorderSize = 0;
            btnCopy.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 96, 145);
            btnCopy.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 138, 204);
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCopy.ForeColor = Color.White;
            btnCopy.Location = new Point(690, 12);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(90, 36);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            //
            // btnLuu
            //
            btnLuu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLuu.BackColor = Color.FromArgb(51, 122, 183);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 96, 145);
            btnLuu.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 138, 204);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(790, 12);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(90, 36);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu file";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            //
            // rtbSource
            //
            rtbSource.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbSource.BackColor = Color.White;
            rtbSource.BorderStyle = BorderStyle.FixedSingle;
            rtbSource.DetectUrls = false;
            rtbSource.Font = new Font("Consolas", 9.5F);
            rtbSource.Location = new Point(20, 88);
            rtbSource.Name = "rtbSource";
            rtbSource.ReadOnly = true;
            rtbSource.ScrollBars = RichTextBoxScrollBars.Both;
            rtbSource.Size = new Size(860, 512);
            rtbSource.TabIndex = 4;
            rtbSource.Text = "";
            rtbSource.WordWrap = false;
            //
            // FormViewSource
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 620);
            Controls.Add(rtbSource);
            Controls.Add(btnLuu);
            Controls.Add(btnCopy);
            Controls.Add(lblInfo);
            Controls.Add(lblTieuDe);
            MinimumSize = new Size(600, 400);
            Name = "FormViewSource";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mã nguồn HTML";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblInfo;
        private Button btnCopy;
        private Button btnLuu;
        private RichTextBox rtbSource;
    }
}
