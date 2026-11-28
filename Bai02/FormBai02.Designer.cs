namespace NT106.R14._1_Lab04_Nhom4.Bai02
{
    partial class FormBai02
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
            lblTitle = new Label();
            lblUrl = new Label();
            txtUrl = new TextBox();
            lblSavePath = new Label();
            txtSavePath = new TextBox();
            btnBrowse = new Button();
            btnDownload = new Button();
            rtbContent = new RichTextBox();
            lblStatus = new Label();
            SuspendLayout();
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 84, 166);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bài 2 - Download trang web";
            //
            // lblUrl
            //
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(14, 62);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(38, 20);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "URL:";
            //
            // txtUrl
            //
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.Location = new Point(96, 59);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(556, 27);
            txtUrl.TabIndex = 2;
            txtUrl.Text = "https://uit.edu.vn";
            //
            // lblSavePath
            //
            lblSavePath.AutoSize = true;
            lblSavePath.Location = new Point(14, 98);
            lblSavePath.Name = "lblSavePath";
            lblSavePath.Size = new Size(64, 20);
            lblSavePath.TabIndex = 3;
            lblSavePath.Text = "Lưu vào:";
            //
            // txtSavePath
            //
            txtSavePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSavePath.Location = new Point(96, 95);
            txtSavePath.Name = "txtSavePath";
            txtSavePath.Size = new Size(510, 27);
            txtSavePath.TabIndex = 4;
            //
            // btnBrowse
            //
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(612, 94);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(40, 29);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            //
            // btnDownload
            //
            btnDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDownload.BackColor = Color.FromArgb(0, 84, 166);
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.ForeColor = Color.White;
            btnDownload.Location = new Point(658, 57);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(110, 66);
            btnDownload.TabIndex = 6;
            btnDownload.Text = "DOWNLOAD";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            //
            // rtbContent
            //
            rtbContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbContent.Font = new Font("Consolas", 10F);
            rtbContent.Location = new Point(14, 134);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(754, 364);
            rtbContent.TabIndex = 7;
            rtbContent.Text = "";
            rtbContent.WordWrap = false;
            //
            // lblStatus
            //
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.DimGray;
            lblStatus.Location = new Point(14, 507);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(70, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Sẵn sàng.";
            //
            // FormBai02
            //
            AcceptButton = btnDownload;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 536);
            Controls.Add(lblStatus);
            Controls.Add(rtbContent);
            Controls.Add(btnDownload);
            Controls.Add(btnBrowse);
            Controls.Add(txtSavePath);
            Controls.Add(lblSavePath);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Controls.Add(lblTitle);
            MinimumSize = new Size(600, 400);
            Name = "FormBai02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 4 - Bài 2: Download trang web (WebClient)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUrl;
        private TextBox txtUrl;
        private Label lblSavePath;
        private TextBox txtSavePath;
        private Button btnBrowse;
        private Button btnDownload;
        private RichTextBox rtbContent;
        private Label lblStatus;
    }
}
