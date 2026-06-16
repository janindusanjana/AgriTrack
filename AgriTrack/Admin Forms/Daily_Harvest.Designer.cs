namespace AgriTrack.Admin_Forms
{
    partial class Daily_Harvest
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily_Harvest));
            dateTimePicker1 = new DateTimePicker();
            btnLoadReport = new Button();
            dataGridView1 = new DataGridView();
            WorkerID = new DataGridViewTextBoxColumn();
            WorkerName = new DataGridViewTextBoxColumn();
            HarvestKg = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            lblTotalharvest = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            lblDate = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            Settlment = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnDashBoard = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = SystemColors.ControlLightLight;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(333, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(106, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // btnLoadReport
            // 
            btnLoadReport.BackColor = Color.FromArgb(46, 125, 50);
            btnLoadReport.FlatAppearance.BorderSize = 0;
            btnLoadReport.FlatStyle = FlatStyle.Flat;
            btnLoadReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadReport.ForeColor = Color.Black;
            btnLoadReport.Location = new Point(490, 39);
            btnLoadReport.Name = "btnLoadReport";
            btnLoadReport.Size = new Size(115, 31);
            btnLoadReport.TabIndex = 6;
            btnLoadReport.Text = "Load Report";
            btnLoadReport.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { WorkerID, WorkerName, HarvestKg, Status });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(233, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(503, 223);
            dataGridView1.TabIndex = 7;
            // 
            // WorkerID
            // 
            WorkerID.HeaderText = "WorkerID";
            WorkerID.Name = "WorkerID";
            WorkerID.Width = 150;
            // 
            // WorkerName
            // 
            WorkerName.HeaderText = "WorkerName";
            WorkerName.Name = "WorkerName";
            WorkerName.Width = 150;
            // 
            // HarvestKg
            // 
            HarvestKg.HeaderText = "HarvestKg";
            HarvestKg.Name = "HarvestKg";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // lblTotalharvest
            // 
            lblTotalharvest.AutoSize = true;
            lblTotalharvest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalharvest.Location = new Point(228, 458);
            lblTotalharvest.Name = "lblTotalharvest";
            lblTotalharvest.Size = new Size(119, 21);
            lblTotalharvest.TabIndex = 4;
            lblTotalharvest.Text = "Total Harvest :";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(349, 459);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 22);
            textBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.leave1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(660, 379);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 110);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(228, 44);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(98, 21);
            lblDate.TabIndex = 11;
            lblDate.Text = "Enter Date :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 122, 79);
            panel1.Location = new Point(209, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 29);
            panel1.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(Settlment);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btnDashBoard);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 498);
            panel3.TabIndex = 12;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(76, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
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
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(46, 125, 50);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.Black;
            btnPrint.Location = new Point(621, 38);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(115, 31);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // Daily_Harvest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(804, 501);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(lblDate);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnPrint);
            Controls.Add(btnLoadReport);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblTotalharvest);
            DoubleBuffered = true;
            Name = "Daily_Harvest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Daily_Harvest";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Settlment_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label lblDate;
        private DateTimePicker dateTimePicker1;
        private Button btnLoadReport;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn WorkerID;
        private DataGridViewTextBoxColumn WorkerName;
        private DataGridViewTextBoxColumn HarvestKg;
        private DataGridViewTextBoxColumn Status;
        private Label lblTotalharvest;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel3;
        private Button Settlment;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnDashBoard;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnPrint;
    }
}