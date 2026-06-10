namespace AgriTrack
{
    partial class add_farmmer_1
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
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle30 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle28 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle29 = new DataGridViewCellStyle();
            pnlTopBar = new Panel();
            lblAppTitle = new Label();
            lblSubTitle = new Label();
            pnlToolbar = new Panel();
            addfarmmer = new Button();
            pnlSearch = new Panel();
            lblSearchIcon = new Label();
            txtSearch = new TextBox();
            pnlStats = new Panel();
            pnlStatTotal = new Panel();
            lblStatTotalLbl = new Label();
            lblStatTotalVal = new Label();
            pnlStatActive = new Panel();
            lblStatActiveLbl = new Label();
            lblStatActiveVal = new Label();
            pnlStatSections = new Panel();
            lblStatSectionsLbl = new Label();
            lblStatSectionsVal = new Label();
            pnlDivider = new Panel();
            pnlColHeader = new Panel();
            lblColEmpNo = new Label();
            lblColName = new Label();
            lblColDate = new Label();
            lblColSection = new Label();
            lblColActions = new Label();
            dgvFarmers = new DataGridView();
            colEmpNo = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colJoinDate = new DataGridViewTextBoxColumn();
            colSection = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewButtonColumn();
            pnlPagination = new Panel();
            lblPageInfo = new Label();
            pnlPageBtns = new Panel();
            btnPrev = new Button();
            pagenb = new Button();
            pagenb2 = new Button();
            btnNext = new Button();
            pnlTopBar.SuspendLayout();
            pnlToolbar.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlStats.SuspendLayout();
            pnlStatTotal.SuspendLayout();
            pnlStatActive.SuspendLayout();
            pnlStatSections.SuspendLayout();
            pnlColHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFarmers).BeginInit();
            pnlPagination.SuspendLayout();
            pnlPageBtns.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(26, 60, 52);
            pnlTopBar.Controls.Add(lblColEmpNo);
            pnlTopBar.Controls.Add(lblColName);
            pnlTopBar.Controls.Add(lblColDate);
            pnlTopBar.Controls.Add(lblColSection);
            pnlTopBar.Controls.Add(lblColActions);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 189);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(820, 33);
            pnlTopBar.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.ForeColor = Color.FromArgb(225, 245, 238);
            lblAppTitle.Location = new Point(29, 18);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(253, 21);
            lblAppTitle.TabIndex = 0;
            lblAppTitle.Text = "🌿  AgriTrack — Worker Registry";
            lblAppTitle.Click += lblAppTitle_Click;
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitle.ForeColor = Color.FromArgb(159, 225, 203);
            lblSubTitle.Location = new Point(63, 42);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(101, 13);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Section A & B · 2025";
            lblSubTitle.Click += lblSubTitle_Click_1;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.FromArgb(255, 255, 255);
            pnlToolbar.Controls.Add(addfarmmer);
            pnlToolbar.Controls.Add(pnlSearch);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 135);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(14, 0, 14, 0);
            pnlToolbar.Size = new Size(820, 54);
            pnlToolbar.TabIndex = 1;
            // 
            // addfarmmer
            // 
            addfarmmer.BackColor = Color.FromArgb(45, 122, 79);
            addfarmmer.Cursor = Cursors.Hand;
            addfarmmer.FlatAppearance.BorderSize = 0;
            addfarmmer.FlatStyle = FlatStyle.Flat;
            addfarmmer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addfarmmer.ForeColor = Color.FromArgb(225, 245, 238);
            addfarmmer.Location = new Point(14, 12);
            addfarmmer.Name = "addfarmmer";
            addfarmmer.Size = new Size(130, 30);
            addfarmmer.TabIndex = 0;
            addfarmmer.Text = "+ Add Farmer";
            addfarmmer.UseVisualStyleBackColor = false;
            addfarmmer.Click += addfarmmer_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(241, 239, 232);
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(lblSearchIcon);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Location = new Point(600, 12);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(200, 30);
            pnlSearch.TabIndex = 1;
            // 
            // lblSearchIcon
            // 
            lblSearchIcon.AutoSize = true;
            lblSearchIcon.Font = new Font("Segoe UI", 10F);
            lblSearchIcon.ForeColor = Color.FromArgb(136, 135, 128);
            lblSearchIcon.Location = new Point(6, 5);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new Size(28, 19);
            lblSearchIcon.TabIndex = 0;
            lblSearchIcon.Text = "🔍";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(241, 239, 232);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.ForeColor = Color.FromArgb(44, 44, 42);
            txtSearch.Location = new Point(28, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search name or ID…";
            txtSearch.Size = new Size(162, 16);
            txtSearch.TabIndex = 1;
            // 
            // pnlStats
            // 
            pnlStats.BackColor = Color.FromArgb(255, 255, 255);
            pnlStats.Controls.Add(pnlStatTotal);
            pnlStats.Controls.Add(pnlStatActive);
            pnlStats.Controls.Add(pnlStatSections);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(0, 63);
            pnlStats.Name = "pnlStats";
            pnlStats.Padding = new Padding(14, 10, 14, 10);
            pnlStats.Size = new Size(820, 72);
            pnlStats.TabIndex = 2;
            // 
            // pnlStatTotal
            // 
            pnlStatTotal.BackColor = Color.FromArgb(241, 239, 232);
            pnlStatTotal.Controls.Add(lblStatTotalLbl);
            pnlStatTotal.Controls.Add(lblStatTotalVal);
            pnlStatTotal.Location = new Point(14, 10);
            pnlStatTotal.Name = "pnlStatTotal";
            pnlStatTotal.Size = new Size(150, 52);
            pnlStatTotal.TabIndex = 0;
            // 
            // lblStatTotalLbl
            // 
            lblStatTotalLbl.AutoSize = true;
            lblStatTotalLbl.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatTotalLbl.ForeColor = Color.FromArgb(95, 94, 90);
            lblStatTotalLbl.Location = new Point(8, 6);
            lblStatTotalLbl.Name = "lblStatTotalLbl";
            lblStatTotalLbl.Size = new Size(91, 13);
            lblStatTotalLbl.TabIndex = 0;
            lblStatTotalLbl.Text = "TOTAL WORKERS";
            // 
            // lblStatTotalVal
            // 
            lblStatTotalVal.AutoSize = true;
            lblStatTotalVal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatTotalVal.ForeColor = Color.FromArgb(15, 110, 86);
            lblStatTotalVal.Location = new Point(8, 22);
            lblStatTotalVal.Name = "lblStatTotalVal";
            lblStatTotalVal.Size = new Size(51, 32);
            lblStatTotalVal.TabIndex = 1;
            lblStatTotalVal.Text = "124";
            // 
            // pnlStatActive
            // 
            pnlStatActive.BackColor = Color.FromArgb(241, 239, 232);
            pnlStatActive.Controls.Add(lblStatActiveLbl);
            pnlStatActive.Controls.Add(lblStatActiveVal);
            pnlStatActive.Location = new Point(174, 10);
            pnlStatActive.Name = "pnlStatActive";
            pnlStatActive.Size = new Size(150, 52);
            pnlStatActive.TabIndex = 1;
            // 
            // lblStatActiveLbl
            // 
            lblStatActiveLbl.AutoSize = true;
            lblStatActiveLbl.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatActiveLbl.ForeColor = Color.FromArgb(95, 94, 90);
            lblStatActiveLbl.Location = new Point(8, 6);
            lblStatActiveLbl.Name = "lblStatActiveLbl";
            lblStatActiveLbl.Size = new Size(110, 13);
            lblStatActiveLbl.TabIndex = 0;
            lblStatActiveLbl.Text = "ACTIVE THIS MONTH";
            // 
            // lblStatActiveVal
            // 
            lblStatActiveVal.AutoSize = true;
            lblStatActiveVal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatActiveVal.ForeColor = Color.FromArgb(44, 44, 42);
            lblStatActiveVal.Location = new Point(8, 22);
            lblStatActiveVal.Name = "lblStatActiveVal";
            lblStatActiveVal.Size = new Size(47, 32);
            lblStatActiveVal.TabIndex = 1;
            lblStatActiveVal.Text = "118";
            // 
            // pnlStatSections
            // 
            pnlStatSections.BackColor = Color.FromArgb(241, 239, 232);
            pnlStatSections.Controls.Add(lblStatSectionsLbl);
            pnlStatSections.Controls.Add(lblStatSectionsVal);
            pnlStatSections.Location = new Point(334, 10);
            pnlStatSections.Name = "pnlStatSections";
            pnlStatSections.Size = new Size(150, 52);
            pnlStatSections.TabIndex = 2;
            // 
            // lblStatSectionsLbl
            // 
            lblStatSectionsLbl.AutoSize = true;
            lblStatSectionsLbl.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatSectionsLbl.ForeColor = Color.FromArgb(95, 94, 90);
            lblStatSectionsLbl.Location = new Point(8, 6);
            lblStatSectionsLbl.Name = "lblStatSectionsLbl";
            lblStatSectionsLbl.Size = new Size(57, 13);
            lblStatSectionsLbl.TabIndex = 0;
            lblStatSectionsLbl.Text = "SECTIONS";
            // 
            // lblStatSectionsVal
            // 
            lblStatSectionsVal.AutoSize = true;
            lblStatSectionsVal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatSectionsVal.ForeColor = Color.FromArgb(44, 44, 42);
            lblStatSectionsVal.Location = new Point(8, 22);
            lblStatSectionsVal.Name = "lblStatSectionsVal";
            lblStatSectionsVal.Size = new Size(28, 32);
            lblStatSectionsVal.TabIndex = 1;
            lblStatSectionsVal.Text = "4";
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(211, 209, 199);
            pnlDivider.Dock = DockStyle.Top;
            pnlDivider.Location = new Point(0, 62);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(820, 1);
            pnlDivider.TabIndex = 3;
            // 
            // pnlColHeader
            // 
            pnlColHeader.BackColor = Color.FromArgb(26, 60, 52);
            pnlColHeader.Controls.Add(lblSubTitle);
            pnlColHeader.Controls.Add(lblAppTitle);
            pnlColHeader.Dock = DockStyle.Top;
            pnlColHeader.Location = new Point(0, 0);
            pnlColHeader.Name = "pnlColHeader";
            pnlColHeader.Size = new Size(820, 62);
            pnlColHeader.TabIndex = 4;
            // 
            // lblColEmpNo
            // 
            lblColEmpNo.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColEmpNo.ForeColor = Color.FromArgb(159, 225, 203);
            lblColEmpNo.Location = new Point(22, 9);
            lblColEmpNo.Name = "lblColEmpNo";
            lblColEmpNo.Size = new Size(90, 16);
            lblColEmpNo.TabIndex = 0;
            lblColEmpNo.Text = "ID NO.";
            // 
            // lblColName
            // 
            lblColName.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColName.ForeColor = Color.FromArgb(159, 225, 203);
            lblColName.Location = new Point(129, 9);
            lblColName.Name = "lblColName";
            lblColName.Size = new Size(220, 16);
            lblColName.TabIndex = 1;
            lblColName.Text = "FULL NAME";
            lblColName.Click += lblColName_Click;
            // 
            // lblColDate
            // 
            lblColDate.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColDate.ForeColor = Color.FromArgb(159, 225, 203);
            lblColDate.Location = new Point(355, 9);
            lblColDate.Name = "lblColDate";
            lblColDate.Size = new Size(130, 16);
            lblColDate.TabIndex = 2;
            lblColDate.Text = "JOIN DATE";
            // 
            // lblColSection
            // 
            lblColSection.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColSection.ForeColor = Color.FromArgb(159, 225, 203);
            lblColSection.Location = new Point(505, 9);
            lblColSection.Name = "lblColSection";
            lblColSection.Size = new Size(130, 16);
            lblColSection.TabIndex = 3;
            lblColSection.Text = "SECTION";
            // 
            // lblColActions
            // 
            lblColActions.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColActions.ForeColor = Color.FromArgb(159, 225, 203);
            lblColActions.Location = new Point(670, 9);
            lblColActions.Name = "lblColActions";
            lblColActions.Size = new Size(100, 16);
            lblColActions.TabIndex = 4;
            lblColActions.Text = "ACTIONS";
            lblColActions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvFarmers
            // 
            dgvFarmers.AllowUserToAddRows = false;
            dgvFarmers.AllowUserToDeleteRows = false;
            dgvFarmers.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = Color.FromArgb(247, 245, 240);
            dgvFarmers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dgvFarmers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFarmers.BackgroundColor = Color.FromArgb(247, 245, 240);
            dgvFarmers.BorderStyle = BorderStyle.None;
            dgvFarmers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFarmers.ColumnHeadersVisible = false;
            dgvFarmers.Columns.AddRange(new DataGridViewColumn[] { colEmpNo, colFullName, colJoinDate, colSection, colActions });
            dataGridViewCellStyle30.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle30.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle30.ForeColor = Color.FromArgb(44, 44, 42);
            dataGridViewCellStyle30.Padding = new Padding(6);
            dataGridViewCellStyle30.SelectionBackColor = Color.FromArgb(225, 245, 238);
            dataGridViewCellStyle30.SelectionForeColor = Color.FromArgb(26, 60, 52);
            dataGridViewCellStyle30.WrapMode = DataGridViewTriState.False;
            dgvFarmers.DefaultCellStyle = dataGridViewCellStyle30;
            dgvFarmers.Dock = DockStyle.Fill;
            dgvFarmers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvFarmers.GridColor = Color.FromArgb(211, 209, 199);
            dgvFarmers.Location = new Point(0, 0);
            dgvFarmers.MultiSelect = false;
            dgvFarmers.Name = "dgvFarmers";
            dgvFarmers.ReadOnly = true;
            dgvFarmers.RowHeadersVisible = false;
            dgvFarmers.RowTemplate.Height = 40;
            dgvFarmers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFarmers.Size = new Size(820, 494);
            dgvFarmers.TabIndex = 5;
            // 
            // colEmpNo
            // 
            dataGridViewCellStyle26.Font = new Font("Consolas", 9F);
            dataGridViewCellStyle26.ForeColor = Color.FromArgb(95, 94, 90);
            colEmpNo.DefaultCellStyle = dataGridViewCellStyle26;
            colEmpNo.FillWeight = 12F;
            colEmpNo.HeaderText = "Emp No.";
            colEmpNo.Name = "colEmpNo";
            colEmpNo.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.FillWeight = 28F;
            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colJoinDate
            // 
            dataGridViewCellStyle27.ForeColor = Color.FromArgb(95, 94, 90);
            colJoinDate.DefaultCellStyle = dataGridViewCellStyle27;
            colJoinDate.FillWeight = 18F;
            colJoinDate.HeaderText = "Join Date";
            colJoinDate.Name = "colJoinDate";
            colJoinDate.ReadOnly = true;
            // 
            // colSection
            // 
            dataGridViewCellStyle28.BackColor = Color.FromArgb(225, 245, 238);
            dataGridViewCellStyle28.ForeColor = Color.FromArgb(8, 80, 65);
            colSection.DefaultCellStyle = dataGridViewCellStyle28;
            colSection.FillWeight = 18F;
            colSection.HeaderText = "Section";
            colSection.Name = "colSection";
            colSection.ReadOnly = true;
            // 
            // colActions
            // 
            dataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = Color.FromArgb(45, 122, 79);
            dataGridViewCellStyle29.ForeColor = Color.FromArgb(225, 245, 238);
            colActions.DefaultCellStyle = dataGridViewCellStyle29;
            colActions.FillWeight = 14F;
            colActions.FlatStyle = FlatStyle.Flat;
            colActions.HeaderText = "Actions";
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Text = "Edit";
            colActions.UseColumnTextForButtonValue = true;
            // 
            // pnlPagination
            // 
            pnlPagination.BackColor = Color.FromArgb(255, 255, 255);
            pnlPagination.Controls.Add(lblPageInfo);
            pnlPagination.Controls.Add(pnlPageBtns);
            pnlPagination.Dock = DockStyle.Bottom;
            pnlPagination.Location = new Point(0, 494);
            pnlPagination.Name = "pnlPagination";
            pnlPagination.Size = new Size(820, 46);
            pnlPagination.TabIndex = 6;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageInfo.ForeColor = Color.FromArgb(95, 94, 90);
            lblPageInfo.Location = new Point(14, 15);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(159, 15);
            lblPageInfo.TabIndex = 0;
            lblPageInfo.Text = "Showing 1–10 of 124 workers";
            // 
            // pnlPageBtns
            // 
            pnlPageBtns.BackColor = Color.Transparent;
            pnlPageBtns.Controls.Add(btnPrev);
            pnlPageBtns.Controls.Add(pagenb);
            pnlPageBtns.Controls.Add(pagenb2);
            pnlPageBtns.Controls.Add(btnNext);
            pnlPageBtns.Location = new Point(620, 9);
            pnlPageBtns.Name = "pnlPageBtns";
            pnlPageBtns.Size = new Size(185, 28);
            pnlPageBtns.TabIndex = 1;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.FromArgb(241, 239, 232);
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.FlatAppearance.BorderColor = Color.FromArgb(180, 178, 168);
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrev.ForeColor = Color.FromArgb(95, 94, 90);
            btnPrev.Location = new Point(0, 0);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(36, 28);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "‹";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // pagenb
            // 
            pagenb.BackColor = Color.FromArgb(45, 122, 79);
            pagenb.Cursor = Cursors.Hand;
            pagenb.FlatAppearance.BorderSize = 0;
            pagenb.FlatStyle = FlatStyle.Flat;
            pagenb.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pagenb.ForeColor = Color.FromArgb(225, 245, 238);
            pagenb.Location = new Point(42, 0);
            pagenb.Name = "pagenb";
            pagenb.Size = new Size(30, 28);
            pagenb.TabIndex = 1;
            pagenb.Text = "1";
            pagenb.UseVisualStyleBackColor = false;
            // 
            // pagenb2
            // 
            pagenb2.BackColor = Color.FromArgb(241, 239, 232);
            pagenb2.Cursor = Cursors.Hand;
            pagenb2.FlatAppearance.BorderColor = Color.FromArgb(180, 178, 168);
            pagenb2.FlatStyle = FlatStyle.Flat;
            pagenb2.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pagenb2.ForeColor = Color.FromArgb(95, 94, 90);
            pagenb2.Location = new Point(78, 0);
            pagenb2.Name = "pagenb2";
            pagenb2.Size = new Size(30, 28);
            pagenb2.TabIndex = 2;
            pagenb2.Text = "2";
            pagenb2.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(241, 239, 232);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(180, 178, 168);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FromArgb(95, 94, 90);
            btnNext.Location = new Point(114, 0);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 28);
            btnNext.TabIndex = 3;
            btnNext.Text = "›";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // add_farmmer_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 244, 240);
            ClientSize = new Size(820, 540);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlStats);
            Controls.Add(pnlDivider);
            Controls.Add(pnlColHeader);
            Controls.Add(dgvFarmers);
            Controls.Add(pnlPagination);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(820, 540);
            Name = "add_farmmer_1";
            Text = "AgriTrack — Worker Registry";
            pnlTopBar.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlStats.ResumeLayout(false);
            pnlStatTotal.ResumeLayout(false);
            pnlStatTotal.PerformLayout();
            pnlStatActive.ResumeLayout(false);
            pnlStatActive.PerformLayout();
            pnlStatSections.ResumeLayout(false);
            pnlStatSections.PerformLayout();
            pnlColHeader.ResumeLayout(false);
            pnlColHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFarmers).EndInit();
            pnlPagination.ResumeLayout(false);
            pnlPagination.PerformLayout();
            pnlPageBtns.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // ── Top bar ──
        private Panel pnlTopBar;
        private Label lblAppTitle;
        private Label lblSubTitle;

        // ── Toolbar ──
        private Panel pnlToolbar;
        private Button addfarmmer;
        private Panel pnlSearch;
        private TextBox txtSearch;
        private Label lblSearchIcon;

        // ── Stats ──
        private Panel pnlStats;
        private Panel pnlStatTotal;
        private Label lblStatTotalVal;
        private Label lblStatTotalLbl;
        private Panel pnlStatActive;
        private Label lblStatActiveVal;
        private Label lblStatActiveLbl;
        private Panel pnlStatSections;
        private Label lblStatSectionsVal;
        private Label lblStatSectionsLbl;

        // ── Divider ──
        private Panel pnlDivider;

        // ── Column header ──
        private Panel pnlColHeader;
        private Label lblColEmpNo;
        private Label lblColName;
        private Label lblColDate;
        private Label lblColSection;
        private Label lblColActions;

        // ── Data grid ──
        private DataGridView dgvFarmers;

        // ── Pagination ──
        private Panel pnlPagination;
        private Label lblPageInfo;
        private Panel pnlPageBtns;
        private Button btnPrev;
        private Button pagenb;
        private Button pagenb2;
        private Button btnNext;
        private DataGridViewTextBoxColumn colEmpNo;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colJoinDate;
        private DataGridViewTextBoxColumn colSection;
        private DataGridViewButtonColumn colActions;
    }
}