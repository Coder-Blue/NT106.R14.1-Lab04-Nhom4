namespace NT106.R14._1_Lab04_Nhom4.Bai03
{
    partial class FormViewSource
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
            lblInfo = new Label();
            btnCopy = new Button();
            rtbSource = new RichTextBox();
            panelTop.SuspendLayout();
            SuspendLayout();
            //
            // panelTop
            //
            panelTop.Controls.Add(lblInfo);
            panelTop.Controls.Add(btnCopy);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(900, 44);
            panelTop.TabIndex = 0;
            //
            // lblInfo
            //
            lblInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblInfo.AutoEllipsis = true;
            lblInfo.Location = new Point(10, 12);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(770, 22);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "url";
            //
            // btnCopy
            //
            btnCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCopy.Location = new Point(790, 7);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(100, 30);
            btnCopy.TabIndex = 1;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            //
            // rtbSource
            //
            rtbSource.Dock = DockStyle.Fill;
            rtbSource.Font = new Font("Consolas", 10F);
            rtbSource.Location = new Point(0, 44);
            rtbSource.Name = "rtbSource";
            rtbSource.ReadOnly = true;
            rtbSource.Size = new Size(900, 556);
            rtbSource.TabIndex = 1;
            rtbSource.Text = "";
            rtbSource.WordWrap = false;
            //
            // FormViewSource
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(rtbSource);
            Controls.Add(panelTop);
            Name = "FormViewSource";
            StartPosition = FormStartPosition.CenterParent;
            Text = "View Source";
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblInfo;
        private Button btnCopy;
        private RichTextBox rtbSource;
    }
}
