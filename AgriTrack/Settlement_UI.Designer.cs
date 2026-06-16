namespace AgriTrack
{
    partial class Settlement_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settlement_UI));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dtpMonth = new DateTimePicker();
            lblMonth = new Label();
            panel3 = new Panel();
            Settlment = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnDashBoard = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblWorkerID = new Label();
            txtWorkerID = new TextBox();
            lblName = new Label();
            lblTotalKg = new Label();
            txtName = new TextBox();
            btnSearch = new Button();
            txtTotalKgPlucked = new TextBox();
            lblTotalAdvance = new Label();
            txtTotalAdvance = new TextBox();
            lblGrossSalary = new Label();
            txtGrossSalary = new TextBox();
            lblNetSalary = new Label();
            txtNetSalary = new TextBox();
            lblSalaryStatus = new Label();
            cmbstatus = new ComboBox();
            btnCalculate = new Button();
            btnUpdate = new Button();
            btnPrint = new Button();
            Status = new DataGridViewTextBoxColumn();
            NetSalary = new DataGridViewTextBoxColumn();
            Advance = new DataGridViewTextBoxColumn();
            KG = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            WorkerID = new DataGridViewTextBoxColumn();
            dgvSettlement = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSettlement).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 122, 79);
            panel1.Controls.Add(dtpMonth);
            panel1.Controls.Add(lblMonth);
            panel1.Location = new Point(209, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 29);
            panel1.TabIndex = 10;
            // 
            // dtpMonth
            // 
            dtpMonth.CustomFormat = "";
            dtpMonth.Format = DateTimePickerFormat.Short;
            dtpMonth.Location = new Point(87, 3);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.Size = new Size(81, 23);
            dtpMonth.TabIndex = 1;
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonth.ForeColor = Color.White;
            lblMonth.Location = new Point(23, 4);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(64, 20);
            lblMonth.TabIndex = 0;
            lblMonth.Text = "Month :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(Settlment);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnDashBoard);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 498);
            panel3.TabIndex = 9;
            // 
            // Settlment
            // 
            Settlment.BackColor = Color.FromArgb(45, 122, 79);
            Settlment.ForeColor = Color.White;
            Settlment.Location = new Point(1, 323);
            Settlment.Name = "Settlment";
            Settlment.Size = new Size(200, 48);
            Settlment.TabIndex = 6;
            Settlment.Text = "Settlement";
            Settlment.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(45, 122, 79);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1, 271);
            button4.Name = "button4";
            button4.Size = new Size(200, 48);
            button4.TabIndex = 5;
            button4.Text = "Advance";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(45, 122, 79);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 218);
            button3.Name = "button3";
            button3.Size = new Size(200, 48);
            button3.TabIndex = 4;
            button3.Text = "Daily Harvest";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(45, 122, 79);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1, 166);
            button2.Name = "button2";
            button2.Size = new Size(200, 48);
            button2.TabIndex = 3;
            button2.Text = "Worker";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.BackColor = Color.FromArgb(45, 122, 79);
            btnDashBoard.ForeColor = Color.White;
            btnDashBoard.Location = new Point(2, 112);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(200, 48);
            btnDashBoard.TabIndex = 2;
            btnDashBoard.Text = "Dashboard";
            btnDashBoard.UseVisualStyleBackColor = false;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 60);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 0;
            label1.Text = "AGRITRACK";
            // 
            // lblWorkerID
            // 
            lblWorkerID.AutoSize = true;
            lblWorkerID.Font = new Font("Segoe UI", 9.75F);
            lblWorkerID.Location = new Point(231, 50);
            lblWorkerID.Name = "lblWorkerID";
            lblWorkerID.Size = new Size(73, 17);
            lblWorkerID.TabIndex = 11;
            lblWorkerID.Text = "Worker ID :";
            // 
            // txtWorkerID
            // 
            txtWorkerID.Font = new Font("Segoe UI", 9.75F);
            txtWorkerID.Location = new Point(325, 51);
            txtWorkerID.Name = "txtWorkerID";
            txtWorkerID.Size = new Size(209, 25);
            txtWorkerID.TabIndex = 12;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F);
            lblName.Location = new Point(231, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 17);
            lblName.TabIndex = 11;
            lblName.Text = "Name :";
            // 
            // lblTotalKg
            // 
            lblTotalKg.AutoSize = true;
            lblTotalKg.Font = new Font("Segoe UI", 9.75F);
            lblTotalKg.Location = new Point(231, 115);
            lblTotalKg.Name = "lblTotalKg";
            lblTotalKg.Size = new Size(111, 17);
            lblTotalKg.TabIndex = 11;
            lblTotalKg.Text = "Total KG Plucked :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9.75F);
            txtName.Location = new Point(325, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 25);
            txtName.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(545, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.TopCenter;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTotalKgPlucked
            // 
            txtTotalKgPlucked.Font = new Font("Segoe UI", 9.75F);
            txtTotalKgPlucked.Location = new Point(367, 112);
            txtTotalKgPlucked.Name = "txtTotalKgPlucked";
            txtTotalKgPlucked.Size = new Size(209, 25);
            txtTotalKgPlucked.TabIndex = 12;
            // 
            // lblTotalAdvance
            // 
            lblTotalAdvance.AutoSize = true;
            lblTotalAdvance.Font = new Font("Segoe UI", 9.75F);
            lblTotalAdvance.Location = new Point(231, 146);
            lblTotalAdvance.Name = "lblTotalAdvance";
            lblTotalAdvance.Size = new Size(96, 17);
            lblTotalAdvance.TabIndex = 11;
            lblTotalAdvance.Text = "Total Advance :";
            // 
            // txtTotalAdvance
            // 
            txtTotalAdvance.Font = new Font("Segoe UI", 9.75F);
            txtTotalAdvance.Location = new Point(367, 143);
            txtTotalAdvance.Name = "txtTotalAdvance";
            txtTotalAdvance.Size = new Size(209, 25);
            txtTotalAdvance.TabIndex = 12;
            // 
            // lblGrossSalary
            // 
            lblGrossSalary.AutoSize = true;
            lblGrossSalary.Font = new Font("Segoe UI", 9.75F);
            lblGrossSalary.Location = new Point(231, 177);
            lblGrossSalary.Name = "lblGrossSalary";
            lblGrossSalary.Size = new Size(88, 17);
            lblGrossSalary.TabIndex = 11;
            lblGrossSalary.Text = "Gross Salary :";
            // 
            // txtGrossSalary
            // 
            txtGrossSalary.Font = new Font("Segoe UI", 9.75F);
            txtGrossSalary.Location = new Point(367, 174);
            txtGrossSalary.Name = "txtGrossSalary";
            txtGrossSalary.ReadOnly = true;
            txtGrossSalary.Size = new Size(209, 25);
            txtGrossSalary.TabIndex = 12;
            // 
            // lblNetSalary
            // 
            lblNetSalary.AutoSize = true;
            lblNetSalary.Font = new Font("Segoe UI", 9.75F);
            lblNetSalary.Location = new Point(233, 209);
            lblNetSalary.Name = "lblNetSalary";
            lblNetSalary.Size = new Size(75, 17);
            lblNetSalary.TabIndex = 11;
            lblNetSalary.Text = "Net Salary :";
            // 
            // txtNetSalary
            // 
            txtNetSalary.Font = new Font("Segoe UI", 9.75F);
            txtNetSalary.Location = new Point(369, 206);
            txtNetSalary.Name = "txtNetSalary";
            txtNetSalary.ReadOnly = true;
            txtNetSalary.Size = new Size(209, 25);
            txtNetSalary.TabIndex = 12;
            // 
            // lblSalaryStatus
            // 
            lblSalaryStatus.AutoSize = true;
            lblSalaryStatus.Font = new Font("Segoe UI", 9.75F);
            lblSalaryStatus.Location = new Point(233, 241);
            lblSalaryStatus.Name = "lblSalaryStatus";
            lblSalaryStatus.Size = new Size(89, 17);
            lblSalaryStatus.TabIndex = 11;
            lblSalaryStatus.Text = "Salary Status :";
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "Paid", "Non-Paid" });
            cmbstatus.Location = new Point(369, 238);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(121, 23);
            cmbstatus.TabIndex = 14;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(45, 122, 79);
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(233, 270);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(85, 30);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(45, 122, 79);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(337, 270);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 30);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(45, 122, 79);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(438, 269);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(85, 30);
            btnPrint.TabIndex = 15;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 80;
            // 
            // NetSalary
            // 
            NetSalary.HeaderText = "Net Salary";
            NetSalary.Name = "NetSalary";
            // 
            // Advance
            // 
            Advance.HeaderText = "Advance";
            Advance.Name = "Advance";
            // 
            // KG
            // 
            KG.HeaderText = "KG";
            KG.Name = "KG";
            KG.Width = 50;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            // 
            // WorkerID
            // 
            WorkerID.HeaderText = "Worker ID";
            WorkerID.Name = "WorkerID";
            // 
            // dgvSettlement
            // 
            dgvSettlement.BackgroundColor = Color.White;
            dgvSettlement.BorderStyle = BorderStyle.None;
            dgvSettlement.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSettlement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSettlement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSettlement.Columns.AddRange(new DataGridViewColumn[] { WorkerID, colName, KG, Advance, NetSalary, Status });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSettlement.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSettlement.Location = new Point(211, 324);
            dgvSettlement.Name = "dgvSettlement";
            dgvSettlement.Size = new Size(582, 150);
            dgvSettlement.TabIndex = 16;
            // 
            // Settlement_UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(804, 501);
            Controls.Add(dgvSettlement);
            Controls.Add(btnPrint);
            Controls.Add(btnUpdate);
            Controls.Add(btnCalculate);
            Controls.Add(cmbstatus);
            Controls.Add(btnSearch);
            Controls.Add(txtNetSalary);
            Controls.Add(txtGrossSalary);
            Controls.Add(txtTotalAdvance);
            Controls.Add(txtTotalKgPlucked);
            Controls.Add(txtName);
            Controls.Add(txtWorkerID);
            Controls.Add(lblSalaryStatus);
            Controls.Add(lblNetSalary);
            Controls.Add(lblGrossSalary);
            Controls.Add(lblTotalAdvance);
            Controls.Add(lblTotalKg);
            Controls.Add(lblName);
            Controls.Add(lblWorkerID);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Settlement_UI";
           
            Text = "Settlement_UI";
            Load += Settlement_UI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSettlement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button Settlment;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnDashBoard;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblWorkerID;
        private TextBox txtWorkerID;
        private Label lblName;
        private Label lblTotalKg;
        private TextBox txtName;
        private DateTimePicker dtpMonth;
        private Label lblMonth;
        private Button btnSearch;
        private TextBox txtTotalKgPlucked;
        private Label lblTotalAdvance;
        private TextBox txtTotalAdvance;
        private Label lblGrossSalary;
        private TextBox txtGrossSalary;
        private Label lblNetSalary;
        private TextBox txtNetSalary;
        private Label lblSalaryStatus;
        private ComboBox cmbstatus;
        private Button btnCalculate;
        private Button btnUpdate;
        private Button btnPrint;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn NetSalary;
        private DataGridViewTextBoxColumn Advance;
        private DataGridViewTextBoxColumn KG;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn WorkerID;
        private DataGridView dgvSettlement;
    }
}