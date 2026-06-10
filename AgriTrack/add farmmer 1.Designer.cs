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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_farmmer_1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dateTimePicker1 = new DateTimePicker();
            addfarmmer = new Button();
            pnlDivider = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            Settlment = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnDashBoard = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Attend = new DataGridViewCheckBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            WorkerID = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            pnlDivider.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(225, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // addfarmmer
            // 
            addfarmmer.BackColor = Color.FromArgb(45, 122, 79);
            addfarmmer.Cursor = Cursors.Hand;
            addfarmmer.FlatAppearance.BorderSize = 0;
            addfarmmer.FlatStyle = FlatStyle.Flat;
            addfarmmer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addfarmmer.ForeColor = Color.FromArgb(225, 245, 238);
            addfarmmer.Location = new Point(341, 83);
            addfarmmer.Name = "addfarmmer";
            addfarmmer.Size = new Size(130, 30);
            addfarmmer.TabIndex = 0;
            addfarmmer.Text = "+ Add Worker";
            addfarmmer.UseVisualStyleBackColor = false;
            addfarmmer.Click += addfarmmer_Click;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(211, 209, 199);
            pnlDivider.Controls.Add(panel2);
            pnlDivider.Dock = DockStyle.Top;
            pnlDivider.Location = new Point(0, 0);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(804, 1);
            pnlDivider.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 412);
            panel2.TabIndex = 1;
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
            panel3.Location = new Point(1, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 498);
            panel3.TabIndex = 7;
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
            // Attend
            // 
            Attend.HeaderText = "Attend";
            Attend.Name = "Attend";
            Attend.Resizable = DataGridViewTriState.True;
            Attend.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.Width = 200;
            // 
            // WorkerID
            // 
            WorkerID.HeaderText = "Worker ID";
            WorkerID.Name = "WorkerID";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(247, 245, 240);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(247, 245, 240);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(247, 245, 240);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { WorkerID, Name, Gender, Attend });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(247, 245, 240);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(247, 245, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.FromArgb(211, 209, 199);
            dataGridView1.Location = new Point(225, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 216);
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 122, 79);
            panel1.Location = new Point(209, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 29);
            panel1.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(384, 40);
            panel5.Name = "panel5";
            panel5.Size = new Size(0, 0);
            panel5.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.Location = new Point(556, 36);
            panel6.Name = "panel6";
            panel6.Size = new Size(0, 0);
            panel6.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(554, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(514, 88);
            button1.Name = "button1";
            button1.Size = new Size(39, 23);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = true;
            // 
            // add_farmmer_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 244, 240);
            ClientSize = new Size(804, 501);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(addfarmmer);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(pnlDivider);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(820, 540);

            Text = "AgriTrack — Worker Registry";
            pnlDivider.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addfarmmer;

        // ── Divider ──
        private Panel pnlDivider;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnDashBoard;
        private DataGridViewCheckBoxColumn Attend;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn WorkerID;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button Settlment;
        private Button button4;
        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
        private TextBox textBox1;
        private Button button1;
    }
}