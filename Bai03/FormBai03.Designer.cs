namespace NT106.R14._1_Lab04_Nhom4.Bai03
{
    partial class FormBai03
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
            panelTop = new Panel();
            btnBack = new Button();
            btnForward = new Button();
            btnReload = new Button();
            txtAddress = new TextBox();
            btnGo = new Button();
            btnDownloadHtml = new Button();
            btnDownloadResource = new Button();
            btnViewSource = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            progressBar = new ToolStripProgressBar();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            //
            // panelTop
            //
            panelTop.BackColor = Color.FromArgb(240, 244, 250);
            panelTop.Controls.Add(btnBack);
            panelTop.Controls.Add(btnForward);
            panelTop.Controls.Add(btnReload);
            panelTop.Controls.Add(txtAddress);
            panelTop.Controls.Add(btnGo);
            panelTop.Controls.Add(btnDownloadHtml);
            panelTop.Controls.Add(btnDownloadResource);
            panelTop.Controls.Add(btnViewSource);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1000, 86);
            panelTop.TabIndex = 0;
            //
            // btnBack
            //
            btnBack.Enabled = false;
            btnBack.Location = new Point(10, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 30);
            btnBack.TabIndex = 0;
            btnBack.Text = "◀";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // btnForward
            //
            btnForward.Enabled = false;
            btnForward.Location = new Point(54, 8);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(40, 30);
            btnForward.TabIndex = 1;
            btnForward.Text = "▶";
            btnForward.UseVisualStyleBackColor = true;
            btnForward.Click += btnForward_Click;
            //
            // btnReload
            //
            btnReload.Location = new Point(98, 8);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(40, 30);
            btnReload.TabIndex = 2;
            btnReload.Text = "⟳";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            //
            // txtAddress
            //
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(146, 10);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(760, 27);
            txtAddress.TabIndex = 3;
            //
            // btnGo
            //
            btnGo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGo.BackColor = Color.FromArgb(0, 84, 166);
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.ForeColor = Color.White;
            btnGo.Location = new Point(912, 8);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(78, 30);
            btnGo.TabIndex = 4;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += btnGo_Click;
            //
            // btnDownloadHtml
            //
            btnDownloadHtml.Location = new Point(10, 46);
            btnDownloadHtml.Name = "btnDownloadHtml";
            btnDownloadHtml.Size = new Size(150, 32);
            btnDownloadHtml.TabIndex = 5;
            btnDownloadHtml.Text = "Download HTML";
            btnDownloadHtml.UseVisualStyleBackColor = true;
            btnDownloadHtml.Click += btnDownloadHtml_Click;
            //
            // btnDownloadResource
            //
            btnDownloadResource.Location = new Point(166, 46);
            btnDownloadResource.Name = "btnDownloadResource";
            btnDownloadResource.Size = new Size(170, 32);
            btnDownloadResource.TabIndex = 6;
            btnDownloadResource.Text = "Download Resource";
            btnDownloadResource.UseVisualStyleBackColor = true;
            btnDownloadResource.Click += btnDownloadResource_Click;
            //
            // btnViewSource
            //
            btnViewSource.Location = new Point(342, 46);
            btnViewSource.Name = "btnViewSource";
            btnViewSource.Size = new Size(130, 32);
            btnViewSource.TabIndex = 7;
            btnViewSource.Text = "View Source";
            btnViewSource.UseVisualStyleBackColor = true;
            btnViewSource.Click += btnViewSource_Click;
            //
            // webView
            //
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 86);
            webView.Name = "webView";
            webView.Size = new Size(1000, 538);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            //
            // statusStrip
            //
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus, progressBar });
            statusStrip.Location = new Point(0, 624);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1000, 26);
            statusStrip.TabIndex = 2;
            //
            // lblStatus
            //
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(783, 20);
            lblStatus.Spring = true;
            lblStatus.Text = "Sẵn sàng.";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            //
            // progressBar
            //
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(200, 18);
            //
            // FormBai03
            //
            AcceptButton = btnGo;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(webView);
            Controls.Add(statusStrip);
            Controls.Add(panelTop);
            MinimumSize = new Size(700, 450);
            Name = "FormBai03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 4 - Bài 3: Web Browser";
            Load += FormBai03_Load;
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
        private Button btnBack;
        private Button btnForward;
        private Button btnReload;
        private TextBox txtAddress;
        private Button btnGo;
        private Button btnDownloadHtml;
        private Button btnDownloadResource;
        private Button btnViewSource;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private ToolStripProgressBar progressBar;
    }
}
