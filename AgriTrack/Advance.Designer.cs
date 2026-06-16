namespace AgriTrack
{
    partial class Advance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advance));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel6 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            pnlDivider = new Panel();
            label2 = new Label();
            txtWorkerID = new TextBox();
            btnSearchWorker = new Button();
            label3 = new Label();
            label4 = new Label();
            lblGrossSalary = new Label();
            lblAdvanceAmount = new Label();
            label7 = new Label();
            label1 = new Label();
            lblNetSalary = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            Settlment = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnDashBoard = new Button();
            pictureBox5 = new PictureBox();
            label14 = new Label();
            label15 = new Label();
            txtWorkerName = new TextBox();
            txtWorkerNIC = new TextBox();
            txtWorkerPhone = new TextBox();
            numAdvanceAmount = new NumericUpDown();
            dtpAdvanceDate = new DateTimePicker();
            lblOutstandingAdvance = new Label();
            dgvAdvanceHistory = new DataGridView();
            WorkerID = new DataGridViewTextBoxColumn();
            WorkerName = new DataGridViewTextBoxColumn();
            HarvestKg = new DataGridViewTextBoxColumn();
            btnClearAdvance = new Button();
            btnCancelAdvance = new Button();
            btnSaveAdvance = new Button();
            pnlDivider.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdvanceAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdvanceHistory).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.Location = new Point(486, 27);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(0, 0);
            panel6.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(336, 30);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(0, 0);
            panel5.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 309);
            panel2.TabIndex = 1;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(211, 209, 199);
            pnlDivider.Controls.Add(panel2);
            pnlDivider.Dock = DockStyle.Top;
            pnlDivider.Location = new Point(0, 0);
            pnlDivider.Margin = new Padding(3, 2, 3, 2);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(804, 1);
            pnlDivider.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(211, 49);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 22;
            label2.Text = "Worker ID :";
            // 
            // txtWorkerID
            // 
            txtWorkerID.Location = new Point(288, 46);
            txtWorkerID.Margin = new Padding(3, 2, 3, 2);
            txtWorkerID.Name = "txtWorkerID";
            txtWorkerID.Size = new Size(198, 23);
            txtWorkerID.TabIndex = 23;
            // 
            // btnSearchWorker
            // 
            btnSearchWorker.BackgroundImage = (Image)resources.GetObject("btnSearchWorker.BackgroundImage");
            btnSearchWorker.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearchWorker.Location = new Point(492, 42);
            btnSearchWorker.Margin = new Padding(3, 2, 3, 2);
            btnSearchWorker.Name = "btnSearchWorker";
            btnSearchWorker.Size = new Size(37, 29);
            btnSearchWorker.TabIndex = 24;
            btnSearchWorker.UseVisualStyleBackColor = true;
            btnSearchWorker.Click += btnSearchWorker_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(211, 74);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 25;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(211, 103);
            label4.Name = "label4";
            label4.Size = new Size(51, 17);
            label4.TabIndex = 26;
            label4.Text = "Phone :";
            // 
            // lblGrossSalary
            // 
            lblGrossSalary.AutoSize = true;
            lblGrossSalary.Font = new Font("Segoe UI", 9.75F);
            lblGrossSalary.Location = new Point(492, 157);
            lblGrossSalary.Name = "lblGrossSalary";
            lblGrossSalary.Size = new Size(96, 17);
            lblGrossSalary.TabIndex = 27;
            lblGrossSalary.Text = "Gross Salary :  ";
            // 
            // lblAdvanceAmount
            // 
            lblAdvanceAmount.AutoSize = true;
            lblAdvanceAmount.Font = new Font("Segoe UI", 9.75F);
            lblAdvanceAmount.Location = new Point(492, 186);
            lblAdvanceAmount.Name = "lblAdvanceAmount";
            lblAdvanceAmount.Size = new Size(125, 17);
            lblAdvanceAmount.TabIndex = 28;
            lblAdvanceAmount.Text = "Advance Amount :   ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(203, 157);
            label7.Name = "label7";
            label7.Size = new Size(117, 17);
            label7.TabIndex = 29;
            label7.Text = " Advance Amount :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(208, 188);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 54;
            label1.Text = "Advance Date :";
            // 
            // lblNetSalary
            // 
            lblNetSalary.AutoSize = true;
            lblNetSalary.Font = new Font("Segoe UI", 9.75F);
            lblNetSalary.Location = new Point(494, 213);
            lblNetSalary.Name = "lblNetSalary";
            lblNetSalary.Size = new Size(87, 17);
            lblNetSalary.TabIndex = 52;
            lblNetSalary.Text = "Net Salary :   ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 122, 79);
            panel1.Location = new Point(209, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 29);
            panel1.TabIndex = 49;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(Settlment);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnDashBoard);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 498);
            panel3.TabIndex = 48;
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
            Settlment.Click += Settlment_Click;
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
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(76, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(38, 60);
            label14.Name = "label14";
            label14.Size = new Size(132, 30);
            label14.TabIndex = 0;
            label14.Text = "AGRITRACK";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F);
            label15.Location = new Point(511, 76);
            label15.Name = "label15";
            label15.Size = new Size(36, 17);
            label15.TabIndex = 50;
            label15.Text = "NIC :";
            // 
            // txtWorkerName
            // 
            txtWorkerName.Location = new Point(289, 72);
            txtWorkerName.Margin = new Padding(3, 2, 3, 2);
            txtWorkerName.Name = "txtWorkerName";
            txtWorkerName.ReadOnly = true;
            txtWorkerName.Size = new Size(198, 23);
            txtWorkerName.TabIndex = 23;
            // 
            // txtWorkerNIC
            // 
            txtWorkerNIC.Location = new Point(563, 74);
            txtWorkerNIC.Margin = new Padding(3, 2, 3, 2);
            txtWorkerNIC.Name = "txtWorkerNIC";
            txtWorkerNIC.ReadOnly = true;
            txtWorkerNIC.Size = new Size(211, 23);
            txtWorkerNIC.TabIndex = 23;
            // 
            // txtWorkerPhone
            // 
            txtWorkerPhone.Location = new Point(288, 99);
            txtWorkerPhone.Margin = new Padding(3, 2, 3, 2);
            txtWorkerPhone.Name = "txtWorkerPhone";
            txtWorkerPhone.ReadOnly = true;
            txtWorkerPhone.Size = new Size(198, 23);
            txtWorkerPhone.TabIndex = 23;
            // 
            // numAdvanceAmount
            // 
            numAdvanceAmount.Location = new Point(326, 157);
            numAdvanceAmount.Name = "numAdvanceAmount";
            numAdvanceAmount.Size = new Size(72, 23);
            numAdvanceAmount.TabIndex = 55;
            // 
            // dtpAdvanceDate
            // 
            dtpAdvanceDate.Format = DateTimePickerFormat.Short;
            dtpAdvanceDate.Location = new Point(309, 185);
            dtpAdvanceDate.Name = "dtpAdvanceDate";
            dtpAdvanceDate.Size = new Size(89, 23);
            dtpAdvanceDate.TabIndex = 56;
            // 
            // lblOutstandingAdvance
            // 
            lblOutstandingAdvance.AutoSize = true;
            lblOutstandingAdvance.Font = new Font("Segoe UI", 9.75F);
            lblOutstandingAdvance.Location = new Point(211, 247);
            lblOutstandingAdvance.Name = "lblOutstandingAdvance";
            lblOutstandingAdvance.Size = new Size(157, 17);
            lblOutstandingAdvance.TabIndex = 54;
            lblOutstandingAdvance.Text = "Outstanding Advances:    ";
            // 
            // dgvAdvanceHistory
            // 
            dgvAdvanceHistory.BackgroundColor = SystemColors.Control;
            dgvAdvanceHistory.BorderStyle = BorderStyle.None;
            dgvAdvanceHistory.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAdvanceHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAdvanceHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdvanceHistory.Columns.AddRange(new DataGridViewColumn[] { WorkerID, WorkerName, HarvestKg });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAdvanceHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAdvanceHistory.EnableHeadersVisualStyles = false;
            dgvAdvanceHistory.GridColor = SystemColors.Control;
            dgvAdvanceHistory.Location = new Point(221, 271);
            dgvAdvanceHistory.Name = "dgvAdvanceHistory";
            dgvAdvanceHistory.RowHeadersVisible = false;
            dgvAdvanceHistory.Size = new Size(318, 142);
            dgvAdvanceHistory.TabIndex = 57;
            // 
            // WorkerID
            // 
            WorkerID.HeaderText = "AdvanceID";
            WorkerID.Name = "WorkerID";
            WorkerID.Width = 80;
            // 
            // WorkerName
            // 
            WorkerName.HeaderText = "Amount";
            WorkerName.Name = "WorkerName";
            WorkerName.Width = 120;
            // 
            // HarvestKg
            // 
            HarvestKg.HeaderText = "Date";
            HarvestKg.Name = "HarvestKg";
            // 
            // btnClearAdvance
            // 
            btnClearAdvance.BackColor = Color.FromArgb(45, 122, 79);
            btnClearAdvance.ForeColor = SystemColors.ButtonFace;
            btnClearAdvance.Location = new Point(373, 442);
            btnClearAdvance.Margin = new Padding(3, 2, 3, 2);
            btnClearAdvance.Name = "btnClearAdvance";
            btnClearAdvance.Size = new Size(144, 32);
            btnClearAdvance.TabIndex = 35;
            btnClearAdvance.Text = "Clear";
            btnClearAdvance.UseVisualStyleBackColor = false;
            btnClearAdvance.Click += btnClearAdvance_Click;
            // 
            // btnCancelAdvance
            // 
            btnCancelAdvance.BackColor = Color.FromArgb(45, 122, 79);
            btnCancelAdvance.ForeColor = SystemColors.ButtonFace;
            btnCancelAdvance.Location = new Point(544, 442);
            btnCancelAdvance.Margin = new Padding(3, 2, 3, 2);
            btnCancelAdvance.Name = "btnCancelAdvance";
            btnCancelAdvance.Size = new Size(144, 32);
            btnCancelAdvance.TabIndex = 35;
            btnCancelAdvance.Text = "Cancel";
            btnCancelAdvance.UseVisualStyleBackColor = false;
            btnCancelAdvance.Click += btnCancelAdvance_Click;
            // 
            // btnSaveAdvance
            // 
            btnSaveAdvance.BackColor = Color.FromArgb(45, 122, 79);
            btnSaveAdvance.ForeColor = SystemColors.ButtonFace;
            btnSaveAdvance.Location = new Point(221, 442);
            btnSaveAdvance.Margin = new Padding(3, 2, 3, 2);
            btnSaveAdvance.Name = "btnSaveAdvance";
            btnSaveAdvance.Size = new Size(144, 32);
            btnSaveAdvance.TabIndex = 35;
            btnSaveAdvance.Text = "Save";
            btnSaveAdvance.UseVisualStyleBackColor = false;
            btnSaveAdvance.Click += btnSaveAdvance_Click;
            // 
            // Advance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 501);
            Controls.Add(dgvAdvanceHistory);
            Controls.Add(dtpAdvanceDate);
            Controls.Add(numAdvanceAmount);
            Controls.Add(lblOutstandingAdvance);
            Controls.Add(label1);
            Controls.Add(lblNetSalary);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label15);
            Controls.Add(btnCancelAdvance);
            Controls.Add(btnSaveAdvance);
            Controls.Add(btnClearAdvance);
            Controls.Add(label7);
            Controls.Add(lblAdvanceAmount);
            Controls.Add(lblGrossSalary);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSearchWorker);
            Controls.Add(txtWorkerNIC);
            Controls.Add(txtWorkerPhone);
            Controls.Add(txtWorkerName);
            Controls.Add(txtWorkerID);
            Controls.Add(label2);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(pnlDivider);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Advance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Advance";
            pnlDivider.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdvanceAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAdvanceHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel6;
        private Panel panel5;
        private Panel panel2;
        private Panel pnlDivider;
        private Label label2;
        private TextBox txtWorkerID;
        private Button btnSearchWorker;
        private Label label3;
        private Label label4;
        private Label lblGrossSalary;
        private Label lblAdvanceAmount;
        private Label label7;
        private Label label11;
        private Button button5;
        private Label label1;
        private Label label13;
        private Label lblNetSalary;
        private Panel panel1;
        private Panel panel3;
        private Button Settlment;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnDashBoard;
        private PictureBox pictureBox5;
        private Label label14;
        private Label label15;
        private TextBox txtWorkerName;
        private TextBox txtWorkerNIC;
        private TextBox txtWorkerPhone;
        private NumericUpDown numAdvanceAmount;
        private DateTimePicker dtpAdvanceDate;
        private Label lblOutstandingAdvance;
        private DataGridView dgvAdvanceHistory;
        private DataGridViewTextBoxColumn WorkerID;
        private DataGridViewTextBoxColumn WorkerName;
        private DataGridViewTextBoxColumn HarvestKg;
        private Button btnClearAdvance;
        private Button btnCancelAdvance;
        private Button btnSaveAdvance;
    }
}