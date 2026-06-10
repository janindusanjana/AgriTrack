namespace AgriTrack
{
    partial class Opensc
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            picLogo = new PictureBox();
            lblAppName = new Label();
            lblTagline = new Label();
            pnlHeaderAccent = new Panel();
            pnlBody = new Panel();
            lblChoose = new Label();
            pnlWorker = new Panel();
            pnlWorkerTop = new Panel();
            lblWorkerRole = new Label();
            lblWorkerSub = new Label();
            btnWorker = new Button();
            lnkWorker = new LinkLabel();
            picWorker = new PictureBox();
            pnlDivider = new Panel();
            pnlAdmin = new Panel();
            pnlAdminTop = new Panel();
            lblAdminRole = new Label();
            lblAdminSub = new Label();
            btnAdmin = new Button();
            lnkAdmin = new LinkLabel();
            picAdmin = new PictureBox();
            pnlFooter = new Panel();
            lblFooter = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlBody.SuspendLayout();
            pnlWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWorker).BeginInit();
            pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(27, 68, 33);
            pnlHeader.Controls.Add(picLogo);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(lblTagline);
            pnlHeader.Controls.Add(pnlHeaderAccent);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(820, 110);
            pnlHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Location = new Point(36, 18);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(72, 72);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(289, 12);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(350, 50);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "AGRITRACK";
            // 
            // lblTagline
            // 
            lblTagline.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTagline.ForeColor = Color.FromArgb(188, 226, 195);
            lblTagline.Location = new Point(289, 62);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(380, 26);
            lblTagline.TabIndex = 2;
            lblTagline.Text = "Smart Worker Management System";
            // 
            // pnlHeaderAccent
            // 
            pnlHeaderAccent.BackColor = Color.FromArgb(76, 175, 80);
            pnlHeaderAccent.Location = new Point(0, 107);
            pnlHeaderAccent.Name = "pnlHeaderAccent";
            pnlHeaderAccent.Size = new Size(820, 3);
            pnlHeaderAccent.TabIndex = 3;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(245, 247, 242);
            pnlBody.Controls.Add(lblChoose);
            pnlBody.Controls.Add(pnlWorker);
            pnlBody.Controls.Add(pnlDivider);
            pnlBody.Controls.Add(pnlAdmin);
            pnlBody.Controls.Add(pnlFooter);
            pnlBody.Location = new Point(0, 110);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(820, 370);
            pnlBody.TabIndex = 1;
            // 
            // lblChoose
            // 
            lblChoose.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoose.ForeColor = Color.FromArgb(100, 120, 100);
            lblChoose.Location = new Point(0, 18);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(820, 30);
            lblChoose.TabIndex = 0;
            lblChoose.Text = "Choose your role to continue";
            lblChoose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlWorker
            // 
            pnlWorker.BackColor = Color.White;
            pnlWorker.Controls.Add(pnlWorkerTop);
            pnlWorker.Controls.Add(lblWorkerRole);
            pnlWorker.Controls.Add(lblWorkerSub);
            pnlWorker.Controls.Add(btnWorker);
            pnlWorker.Controls.Add(lnkWorker);
            pnlWorker.Controls.Add(picWorker);
            pnlWorker.Location = new Point(70, 56);
            pnlWorker.Name = "pnlWorker";
            pnlWorker.Size = new Size(300, 268);
            pnlWorker.TabIndex = 1;
            // 
            // pnlWorkerTop
            // 
            pnlWorkerTop.BackColor = Color.FromArgb(56, 142, 60);
            pnlWorkerTop.Location = new Point(0, 0);
            pnlWorkerTop.Name = "pnlWorkerTop";
            pnlWorkerTop.Size = new Size(300, 6);
            pnlWorkerTop.TabIndex = 0;
            // 
            // lblWorkerRole
            // 
            lblWorkerRole.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWorkerRole.ForeColor = Color.FromArgb(27, 94, 32);
            lblWorkerRole.Location = new Point(0, 126);
            lblWorkerRole.Name = "lblWorkerRole";
            lblWorkerRole.Size = new Size(300, 30);
            lblWorkerRole.TabIndex = 1;
            lblWorkerRole.Text = "WORKER";
            lblWorkerRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWorkerSub
            // 
            lblWorkerSub.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWorkerSub.ForeColor = Color.FromArgb(120, 140, 120);
            lblWorkerSub.Location = new Point(0, 156);
            lblWorkerSub.Name = "lblWorkerSub";
            lblWorkerSub.Size = new Size(300, 22);
            lblWorkerSub.TabIndex = 2;
            lblWorkerSub.Text = "Log attendance & view your schedule";
            lblWorkerSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnWorker
            // 
            btnWorker.BackColor = Color.FromArgb(56, 142, 60);
            btnWorker.Cursor = Cursors.Hand;
            btnWorker.FlatAppearance.BorderSize = 0;
            btnWorker.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            btnWorker.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 125, 50);
            btnWorker.FlatStyle = FlatStyle.Flat;
            btnWorker.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWorker.ForeColor = Color.White;
            btnWorker.Location = new Point(70, 192);
            btnWorker.Name = "btnWorker";
            btnWorker.Size = new Size(160, 38);
            btnWorker.TabIndex = 1;
            btnWorker.Text = "Sign In as Worker";
            btnWorker.UseVisualStyleBackColor = false;
            // 
            // lnkWorker
            // 
            lnkWorker.ActiveLinkColor = Color.FromArgb(27, 94, 32);
            lnkWorker.AutoSize = true;
            lnkWorker.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkWorker.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkWorker.LinkColor = Color.FromArgb(56, 142, 60);
            lnkWorker.Location = new Point(60, 242);
            lnkWorker.Name = "lnkWorker";
            lnkWorker.Size = new Size(191, 15);
            lnkWorker.TabIndex = 2;
            lnkWorker.TabStop = true;
            lnkWorker.Text = "I don't have an account — Register";
            lnkWorker.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picWorker
            // 
            picWorker.BackColor = Color.FromArgb(232, 245, 233);
            picWorker.Image = Properties.Resources.man;
            picWorker.Location = new Point(102, 22);
            picWorker.Name = "picWorker";
            picWorker.Size = new Size(96, 96);
            picWorker.SizeMode = PictureBoxSizeMode.Zoom;
            picWorker.TabIndex = 3;
            picWorker.TabStop = false;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(200, 215, 200);
            pnlDivider.Location = new Point(408, 56);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(1, 250);
            pnlDivider.TabIndex = 2;
            // 
            // pnlAdmin
            // 
            pnlAdmin.BackColor = Color.White;
            pnlAdmin.Controls.Add(pnlAdminTop);
            pnlAdmin.Controls.Add(lblAdminRole);
            pnlAdmin.Controls.Add(lblAdminSub);
            pnlAdmin.Controls.Add(btnAdmin);
            pnlAdmin.Controls.Add(lnkAdmin);
            pnlAdmin.Controls.Add(picAdmin);
            pnlAdmin.Location = new Point(448, 56);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(300, 268);
            pnlAdmin.TabIndex = 3;
            // 
            // pnlAdminTop
            // 
            pnlAdminTop.BackColor = Color.FromArgb(30, 77, 120);
            pnlAdminTop.Location = new Point(0, 0);
            pnlAdminTop.Name = "pnlAdminTop";
            pnlAdminTop.Size = new Size(300, 6);
            pnlAdminTop.TabIndex = 0;
            // 
            // lblAdminRole
            // 
            lblAdminRole.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminRole.ForeColor = Color.FromArgb(13, 71, 161);
            lblAdminRole.Location = new Point(0, 126);
            lblAdminRole.Name = "lblAdminRole";
            lblAdminRole.Size = new Size(300, 30);
            lblAdminRole.TabIndex = 1;
            lblAdminRole.Text = "ADMIN";
            lblAdminRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdminSub
            // 
            lblAdminSub.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminSub.ForeColor = Color.FromArgb(120, 130, 145);
            lblAdminSub.Location = new Point(0, 156);
            lblAdminSub.Name = "lblAdminSub";
            lblAdminSub.Size = new Size(300, 22);
            lblAdminSub.TabIndex = 2;
            lblAdminSub.Text = "Manage workers & generate reports";
            lblAdminSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(30, 77, 120);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 53, 88);
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 65, 105);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(70, 192);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(160, 38);
            btnAdmin.TabIndex = 3;
            btnAdmin.Text = "Sign In as Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // lnkAdmin
            // 
            lnkAdmin.ActiveLinkColor = Color.FromArgb(13, 53, 88);
            lnkAdmin.AutoSize = true;
            lnkAdmin.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkAdmin.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkAdmin.LinkColor = Color.FromArgb(30, 77, 120);
            lnkAdmin.Location = new Point(55, 242);
            lnkAdmin.Name = "lnkAdmin";
            lnkAdmin.Size = new Size(191, 15);
            lnkAdmin.TabIndex = 4;
            lnkAdmin.TabStop = true;
            lnkAdmin.Text = "I don't have an account — Register";
            lnkAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picAdmin
            // 
            picAdmin.BackColor = Color.FromArgb(227, 242, 253);
            picAdmin.Image = Properties.Resources.man;
            picAdmin.Location = new Point(102, 22);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(96, 96);
            picAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            picAdmin.TabIndex = 5;
            picAdmin.TabStop = false;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(236, 240, 235);
            pnlFooter.Controls.Add(lblFooter);
            pnlFooter.Location = new Point(0, 334);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(820, 36);
            pnlFooter.TabIndex = 4;
            // 
            // lblFooter
            // 
            lblFooter.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooter.ForeColor = Color.FromArgb(140, 155, 140);
            lblFooter.Location = new Point(0, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(820, 36);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "© 2025 AgriTrack  ·  Smart Worker Management  ·  All rights reserved";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Opensc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 242);
            ClientSize = new Size(820, 520);
            Controls.Add(pnlHeader);
            Controls.Add(pnlBody);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Opensc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgriTrack — Smart Worker Management";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlBody.ResumeLayout(false);
            pnlWorker.ResumeLayout(false);
            pnlWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picWorker).EndInit();
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Win32 helper for rounded panels (no external library needed)
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        #endregion

        // ── Field declarations ────────────────────────────────────────────────────
        private Panel pnlHeader;
        private Panel pnlHeaderAccent;
        private Panel pnlBody;
        private Panel pnlDivider;
        private Panel pnlFooter;

        private PictureBox picLogo;

        private Label lblAppName;
        private Label lblTagline;
        private Label lblChoose;
        private Label lblFooter;

        private Panel pnlWorker;
        private Panel pnlWorkerTop;
        private PictureBox picWorker;
        private Label lblWorkerRole;
        private Label lblWorkerSub;
        private Button btnWorker;
        private LinkLabel lnkWorker;

        private Panel pnlAdmin;
        private Panel pnlAdminTop;
        private PictureBox picAdmin;
        private Label lblAdminRole;
        private Label lblAdminSub;
        private Button btnAdmin;
        private LinkLabel lnkAdmin;
    }
}
