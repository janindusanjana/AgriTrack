namespace AgriTrack
{
    partial class farmmer_add_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblHeaderIcon = new Label();
            lblFormTitle = new Label();
            lblFormSubtitle = new Label();
            panelAccentBar = new Panel();
            grpPersonal = new GroupBox();
            lblName = new Label();
            txtName = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblNic = new Label();
            txtNic = new TextBox();
            lblNicHint = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            grpProfile = new GroupBox();
            lblGender = new Label();
            panelGenderMale = new Panel();
            radioMale = new RadioButton();
            panelGenderFemale = new Panel();
            radioFemale = new RadioButton();
            lblSection = new Label();
            cmbSection = new ComboBox();
            lblJoinDate = new Label();
            dtpJoinDate = new DateTimePicker();
            panelActions = new Panel();
            btnRegister = new Button();
            btnClear = new Button();
            panelHeader.SuspendLayout();
            grpPersonal.SuspendLayout();
            grpProfile.SuspendLayout();
            panelGenderMale.SuspendLayout();
            panelGenderFemale.SuspendLayout();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblHeaderIcon);
            panelHeader.Controls.Add(lblFormTitle);
            panelHeader.Controls.Add(lblFormSubtitle);
            panelHeader.Controls.Add(panelAccentBar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20, 0, 20, 0);
            panelHeader.Size = new Size(784, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderIcon
            // 
            lblHeaderIcon.BackColor = Color.FromArgb(29, 158, 117);
            lblHeaderIcon.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderIcon.ForeColor = Color.White;
            lblHeaderIcon.Location = new Point(20, 18);
            lblHeaderIcon.Name = "lblHeaderIcon";
            lblHeaderIcon.Size = new Size(44, 44);
            lblHeaderIcon.TabIndex = 0;
            lblHeaderIcon.Text = "🌱";
            lblHeaderIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblFormTitle.Location = new Point(74, 18);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(213, 25);
            lblFormTitle.TabIndex = 1;
            lblFormTitle.Text = "New farmer registration";
            // 
            // lblFormSubtitle
            // 
            lblFormSubtitle.AutoSize = true;
            lblFormSubtitle.Font = new Font("Segoe UI", 9F);
            lblFormSubtitle.ForeColor = Color.FromArgb(110, 110, 110);
            lblFormSubtitle.Location = new Point(76, 42);
            lblFormSubtitle.Name = "lblFormSubtitle";
            lblFormSubtitle.Size = new Size(217, 15);
            lblFormSubtitle.TabIndex = 2;
            lblFormSubtitle.Text = "AgriTrack · Farmer management system";
            // 
            // panelAccentBar
            // 
            panelAccentBar.BackColor = Color.FromArgb(29, 158, 117);
            panelAccentBar.Dock = DockStyle.Bottom;
            panelAccentBar.Location = new Point(20, 78);
            panelAccentBar.Name = "panelAccentBar";
            panelAccentBar.Size = new Size(744, 2);
            panelAccentBar.TabIndex = 3;
            // 
            // grpPersonal
            // 
            grpPersonal.Controls.Add(lblName);
            grpPersonal.Controls.Add(txtName);
            grpPersonal.Controls.Add(lblAddress);
            grpPersonal.Controls.Add(txtAddress);
            grpPersonal.Controls.Add(lblNic);
            grpPersonal.Controls.Add(txtNic);
            grpPersonal.Controls.Add(lblNicHint);
            grpPersonal.Controls.Add(lblPhone);
            grpPersonal.Controls.Add(txtPhone);
            grpPersonal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            grpPersonal.ForeColor = Color.FromArgb(15, 110, 86);
            grpPersonal.Location = new Point(20, 96);
            grpPersonal.Name = "grpPersonal";
            grpPersonal.Padding = new Padding(14, 6, 14, 14);
            grpPersonal.Size = new Size(744, 188);
            grpPersonal.TabIndex = 1;
            grpPersonal.TabStop = false;
            grpPersonal.Text = "Personal information";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.ForeColor = Color.FromArgb(100, 100, 100);
            lblName.Location = new Point(16, 28);
            lblName.Name = "lblName";
            lblName.Size = new Size(122, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Full name with initials";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(248, 249, 250);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(16, 46);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "e.g.  A. B. Perera";
            txtName.Size = new Size(712, 25);
            txtName.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.ForeColor = Color.FromArgb(100, 100, 100);
            lblAddress.Location = new Point(16, 86);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(49, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(248, 249, 250);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(16, 104);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Street, city, district";
            txtAddress.Size = new Size(712, 25);
            txtAddress.TabIndex = 3;
            // 
            // lblNic
            // 
            lblNic.AutoSize = true;
            lblNic.Font = new Font("Segoe UI", 9F);
            lblNic.ForeColor = Color.FromArgb(100, 100, 100);
            lblNic.Location = new Point(16, 144);
            lblNic.Name = "lblNic";
            lblNic.Size = new Size(94, 15);
            lblNic.TabIndex = 4;
            lblNic.Text = "NIC / ID number";
            // 
            // txtNic
            // 
            txtNic.BackColor = Color.FromArgb(248, 249, 250);
            txtNic.BorderStyle = BorderStyle.FixedSingle;
            txtNic.Font = new Font("Segoe UI", 10F);
            txtNic.Location = new Point(16, 162);
            txtNic.Name = "txtNic";
            txtNic.PlaceholderText = "123456789V";
            txtNic.Size = new Size(344, 25);
            txtNic.TabIndex = 5;
            // 
            // lblNicHint
            // 
            lblNicHint.AutoSize = true;
            lblNicHint.Font = new Font("Segoe UI", 8F);
            lblNicHint.ForeColor = Color.FromArgb(160, 160, 160);
            lblNicHint.Location = new Point(18, 193);
            lblNicHint.Name = "lblNicHint";
            lblNicHint.Size = new Size(161, 13);
            lblNicHint.TabIndex = 6;
            lblNicHint.Text = "National identity card number";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F);
            lblPhone.ForeColor = Color.FromArgb(100, 100, 100);
            lblPhone.Location = new Point(376, 144);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(86, 15);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone number";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(248, 249, 250);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(376, 162);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+94 77 000 0000";
            txtPhone.Size = new Size(352, 25);
            txtPhone.TabIndex = 8;
            // 
            // grpProfile
            // 
            grpProfile.Controls.Add(lblGender);
            grpProfile.Controls.Add(panelGenderMale);
            grpProfile.Controls.Add(panelGenderFemale);
            grpProfile.Controls.Add(lblSection);
            grpProfile.Controls.Add(cmbSection);
            grpProfile.Controls.Add(lblJoinDate);
            grpProfile.Controls.Add(dtpJoinDate);
            grpProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            grpProfile.ForeColor = Color.FromArgb(15, 110, 86);
            grpProfile.Location = new Point(20, 300);
            grpProfile.Name = "grpProfile";
            grpProfile.Padding = new Padding(14, 6, 14, 14);
            grpProfile.Size = new Size(744, 156);
            grpProfile.TabIndex = 2;
            grpProfile.TabStop = false;
            grpProfile.Text = "Profile details";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9F);
            lblGender.ForeColor = Color.FromArgb(100, 100, 100);
            lblGender.Location = new Point(16, 28);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender";
            // 
            // panelGenderMale
            // 
            panelGenderMale.BackColor = Color.FromArgb(248, 249, 250);
            panelGenderMale.BorderStyle = BorderStyle.FixedSingle;
            panelGenderMale.Controls.Add(radioMale);
            panelGenderMale.Location = new Point(16, 48);
            panelGenderMale.Name = "panelGenderMale";
            panelGenderMale.Size = new Size(160, 36);
            panelGenderMale.TabIndex = 1;
            // 
            // radioMale
            // 
            radioMale.AutoSize = true;
            radioMale.Font = new Font("Segoe UI", 10F);
            radioMale.ForeColor = Color.FromArgb(30, 30, 30);
            radioMale.Location = new Point(10, 8);
            radioMale.Name = "radioMale";
            radioMale.Size = new Size(57, 23);
            radioMale.TabIndex = 0;
            radioMale.Text = "Male";
            radioMale.UseVisualStyleBackColor = true;
            // 
            // panelGenderFemale
            // 
            panelGenderFemale.BackColor = Color.FromArgb(248, 249, 250);
            panelGenderFemale.BorderStyle = BorderStyle.FixedSingle;
            panelGenderFemale.Controls.Add(radioFemale);
            panelGenderFemale.Location = new Point(186, 48);
            panelGenderFemale.Name = "panelGenderFemale";
            panelGenderFemale.Size = new Size(160, 36);
            panelGenderFemale.TabIndex = 2;
            // 
            // radioFemale
            // 
            radioFemale.AutoSize = true;
            radioFemale.Font = new Font("Segoe UI", 10F);
            radioFemale.ForeColor = Color.FromArgb(30, 30, 30);
            radioFemale.Location = new Point(10, 8);
            radioFemale.Name = "radioFemale";
            radioFemale.Size = new Size(70, 23);
            radioFemale.TabIndex = 0;
            radioFemale.Text = "Female";
            radioFemale.UseVisualStyleBackColor = true;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI", 9F);
            lblSection.ForeColor = Color.FromArgb(100, 100, 100);
            lblSection.Location = new Point(376, 28);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(94, 15);
            lblSection.TabIndex = 3;
            lblSection.Text = "Worker category";
            // 
            // cmbSection
            // 
            cmbSection.BackColor = Color.FromArgb(248, 249, 250);
            cmbSection.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSection.FlatStyle = FlatStyle.Flat;
            cmbSection.Font = new Font("Segoe UI", 10F);
            cmbSection.Items.AddRange(new object[] { "Subsistence farmer", "Commercial farmer", "Mixed farmer", "Dairy farmer", "Poultry farmer", "Livestock farmer", "Organic farmer", "Plantation farmer", "Horticultural farmer", "Aquaculture farmer" });
            cmbSection.Location = new Point(376, 48);
            cmbSection.Name = "cmbSection";
            cmbSection.Size = new Size(200, 25);
            cmbSection.TabIndex = 4;
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Font = new Font("Segoe UI", 9F);
            lblJoinDate.ForeColor = Color.FromArgb(100, 100, 100);
            lblJoinDate.Location = new Point(596, 28);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(96, 15);
            lblJoinDate.TabIndex = 5;
            lblJoinDate.Text = "Registration date";
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Font = new Font("Segoe UI", 10F);
            dtpJoinDate.Format = DateTimePickerFormat.Short;
            dtpJoinDate.Location = new Point(596, 48);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(132, 25);
            dtpJoinDate.TabIndex = 6;
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.White;
            panelActions.Controls.Add(btnRegister);
            panelActions.Controls.Add(btnClear);
            panelActions.Location = new Point(20, 470);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(744, 52);
            panelActions.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(29, 158, 117);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(15, 110, 86);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(160, 0);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(160, 40);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register farmer";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 245);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.FromArgb(80, 80, 80);
            btnClear.Location = new Point(0, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 40);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear form";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // farmmer_add_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(784, 540);
            Controls.Add(panelHeader);
            Controls.Add(grpPersonal);
            Controls.Add(grpProfile);
            Controls.Add(panelActions);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "farmmer_add_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgriTrack — New farmer registration";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            grpPersonal.ResumeLayout(false);
            grpPersonal.PerformLayout();
            grpProfile.ResumeLayout(false);
            grpProfile.PerformLayout();
            panelGenderMale.ResumeLayout(false);
            panelGenderMale.PerformLayout();
            panelGenderFemale.ResumeLayout(false);
            panelGenderFemale.PerformLayout();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ── Header
        private Panel panelHeader;
        private Panel panelAccentBar;
        private Label lblHeaderIcon;
        private Label lblFormTitle;
        private Label lblFormSubtitle;

        // ── Personal Information
        private GroupBox grpPersonal;
        private Label lblName;
        private TextBox txtName;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblNic;
        private TextBox txtNic;
        private Label lblNicHint;
        private Label lblPhone;
        private TextBox txtPhone;

        // ── Profile Details
        private GroupBox grpProfile;
        private Label lblGender;
        private Panel panelGenderMale;
        private RadioButton radioMale;
        private Panel panelGenderFemale;
        private RadioButton radioFemale;
        private Label lblSection;
        private ComboBox cmbSection;
        private Label lblJoinDate;
        private DateTimePicker dtpJoinDate;

        // ── Actions
        private Panel panelActions;
        private Button btnRegister;
        private Button btnClear;
    }
}