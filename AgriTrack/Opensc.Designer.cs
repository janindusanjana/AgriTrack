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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opensc));
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
            picWorker = new PictureBox();
            pnlDivider = new Panel();
            pnlFooter = new Panel();
            lblFooter = new Label();
            pnlWorkerLogin = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnlAdminLogin = new Panel();
            button4 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            pnlAdmin = new Panel();
            pnlAdminTop = new Panel();
            lblAdminRole = new Label();
            lblAdminSub = new Label();
            btnAdmin = new Button();
            picAdmin = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlBody.SuspendLayout();
            pnlWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWorker).BeginInit();
            pnlFooter.SuspendLayout();
            pnlWorkerLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlAdminLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
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
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(211, 16);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(72, 72);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
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
            pnlBody.Controls.Add(pnlFooter);
            pnlBody.Controls.Add(pnlWorkerLogin);
            pnlBody.Controls.Add(pnlAdmin);
            pnlBody.Controls.Add(pnlAdminLogin);
            pnlBody.Location = new Point(0, 110);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(820, 370);
            pnlBody.TabIndex = 1;
            pnlBody.Paint += pnlBody_Paint_1;
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
            lblChoose.Click += lblChoose_Click;
            // 
            // pnlWorker
            // 
            pnlWorker.BackColor = Color.White;
            pnlWorker.Controls.Add(pnlWorkerTop);
            pnlWorker.Controls.Add(lblWorkerRole);
            pnlWorker.Controls.Add(lblWorkerSub);
            pnlWorker.Controls.Add(btnWorker);
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
            lblWorkerRole.Text = "USER";
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
            btnWorker.Text = "Sign In as User";
            btnWorker.UseVisualStyleBackColor = false;
            btnWorker.Click += btnWorker_Click_1;
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
            // pnlWorkerLogin
            // 
            pnlWorkerLogin.Controls.Add(button2);
            pnlWorkerLogin.Controls.Add(button1);
            pnlWorkerLogin.Controls.Add(textBox2);
            pnlWorkerLogin.Controls.Add(textBox1);
            pnlWorkerLogin.Controls.Add(label3);
            pnlWorkerLogin.Controls.Add(label2);
            pnlWorkerLogin.Controls.Add(pictureBox1);
            pnlWorkerLogin.Controls.Add(label1);
            pnlWorkerLogin.Location = new Point(70, 56);
            pnlWorkerLogin.Name = "pnlWorkerLogin";
            pnlWorkerLogin.Size = new Size(300, 268);
            pnlWorkerLogin.TabIndex = 5;
            pnlWorkerLogin.Paint += pnlWorkerLogin_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(50, 235);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(163, 235);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 202);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 159);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Usename";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(232, 245, 233);
            pictureBox1.Image = Properties.Resources.man;
            pictureBox1.Location = new Point(97, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(120, 140, 120);
            label1.Location = new Point(-3, 117);
            label1.Name = "label1";
            label1.Size = new Size(300, 22);
            label1.TabIndex = 2;
            label1.Text = "Enter User name and Password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pnlAdminLogin
            // 
            pnlAdminLogin.Controls.Add(button4);
            pnlAdminLogin.Controls.Add(button3);
            pnlAdminLogin.Controls.Add(textBox4);
            pnlAdminLogin.Controls.Add(textBox3);
            pnlAdminLogin.Controls.Add(label6);
            pnlAdminLogin.Controls.Add(label5);
            pnlAdminLogin.Controls.Add(pictureBox2);
            pnlAdminLogin.Controls.Add(label4);
            pnlAdminLogin.Location = new Point(448, 56);
            pnlAdminLogin.Name = "pnlAdminLogin";
            pnlAdminLogin.Size = new Size(300, 268);
            pnlAdminLogin.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.ForestGreen;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(61, 232);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(162, 232);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(72, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(179, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(72, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 23);
            textBox3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 201);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 6;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 159);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 6;
            label5.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(227, 242, 253);
            pictureBox2.Image = Properties.Resources.man;
            pictureBox2.Location = new Point(97, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(120, 130, 145);
            label4.Location = new Point(0, 115);
            label4.Name = "label4";
            label4.Size = new Size(300, 22);
            label4.TabIndex = 2;
            label4.Text = "Enter Username and Password";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAdmin
            // 
            pnlAdmin.BackColor = Color.White;
            pnlAdmin.Controls.Add(pnlAdminTop);
            pnlAdmin.Controls.Add(lblAdminRole);
            pnlAdmin.Controls.Add(lblAdminSub);
            pnlAdmin.Controls.Add(btnAdmin);
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
            btnAdmin.Click += btnAdmin_Click;
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
            // Opensc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 242);
            ClientSize = new Size(804, 501);
            Controls.Add(pnlHeader);
            Controls.Add(pnlBody);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Opensc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgriTrack — Smart Worker Management";
            Load += Opensc_Load;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlBody.ResumeLayout(false);
            pnlWorker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picWorker).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlWorkerLogin.ResumeLayout(false);
            pnlWorkerLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlAdminLogin.ResumeLayout(false);
            pnlAdminLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
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

        private Panel pnlAdmin;
        private Panel pnlAdminTop;
        private PictureBox picAdmin;
        private Label lblAdminRole;
        private Label lblAdminSub;
        private Button btnAdmin;
        private Panel pnlWorkerLogin;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Panel pnlWorker;
        private Panel pnlWorkerTop;
        private Label lblWorkerRole;
        private Label lblWorkerSub;
        private Button btnWorker;
        private PictureBox picWorker;
        private Panel pnlAdminLogin;
        private Button button4;
        private Button button3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label4;
    }
}
