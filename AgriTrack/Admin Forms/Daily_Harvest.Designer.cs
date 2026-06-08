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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            button1 = new Button();
            button2 = new Button();
            btnDaillyReport = new Button();
            button4 = new Button();
            lblDate = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(-1, 2);
            button1.Name = "button1";
            button1.Size = new Size(214, 112);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(-1, 111);
            button2.Name = "button2";
            button2.Size = new Size(214, 112);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnDaillyReport
            // 
            btnDaillyReport.BackColor = Color.White;
            btnDaillyReport.BackgroundImageLayout = ImageLayout.None;
            btnDaillyReport.FlatAppearance.BorderSize = 0;
            btnDaillyReport.FlatStyle = FlatStyle.Flat;
            btnDaillyReport.Font = new Font("MV Boli", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDaillyReport.ForeColor = SystemColors.ActiveCaptionText;
            btnDaillyReport.Image = Properties.Resources.pngwing_com;
            btnDaillyReport.ImageAlign = ContentAlignment.BottomCenter;
            btnDaillyReport.Location = new Point(-1, 223);
            btnDaillyReport.Name = "btnDaillyReport";
            btnDaillyReport.Size = new Size(214, 112);
            btnDaillyReport.TabIndex = 2;
            btnDaillyReport.Text = "Daily Harvest";
            btnDaillyReport.TextAlign = ContentAlignment.MiddleRight;
            btnDaillyReport.UseVisualStyleBackColor = false;
            btnDaillyReport.Click += btnDaillyReport_Click;
            // 
            // button4
            // 
            button4.Location = new Point(-1, 337);
            button4.Name = "button4";
            button4.Size = new Size(214, 112);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(233, 35);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(98, 21);
            lblDate.TabIndex = 4;
            lblDate.Text = "Enter Date :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = SystemColors.ControlLightLight;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(333, 36);
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
            btnLoadReport.Location = new Point(530, 34);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { WorkerID, WorkerName, HarvestKg, Status });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
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
            lblTotalharvest.Location = new Point(219, 402);
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
            textBox1.Location = new Point(340, 403);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 22);
            textBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.leave1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(656, 332);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 110);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Daily_Harvest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoadReport);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblTotalharvest);
            Controls.Add(lblDate);
            Controls.Add(button4);
            Controls.Add(btnDaillyReport);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Daily_Harvest";
            Text = "Daily_Harvest";
            Load += Daily_Harvest_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnDaillyReport;
        private Button button4;
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
    }
}