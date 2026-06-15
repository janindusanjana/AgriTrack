namespace AgriTrack
{
    partial class DailyHarvestAdding
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyHarvestAdding));
            txtTotalHarvest = new TextBox();
            txtWageRate = new TextBox();
            label6 = new Label();
            label4 = new Label();
            btnClear = new Button();
            btnSave = new Button();
            dtpDate = new DateTimePicker();
            txtWorkerId = new TextBox();
            label3 = new Label();
            lblPluckedKilos = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            Settlment = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnDashBoard = new Button();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            label7 = new Label();
            txtWorkerName = new TextBox();
            numPluckedKg = new NumericUpDown();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPluckedKg).BeginInit();
            SuspendLayout();
            // 
            // txtTotalHarvest
            // 
            txtTotalHarvest.BackColor = SystemColors.ControlLightLight;
            txtTotalHarvest.Location = new Point(622, 51);
            txtTotalHarvest.Name = "txtTotalHarvest";
            txtTotalHarvest.ReadOnly = true;
            txtTotalHarvest.Size = new Size(157, 23);
            txtTotalHarvest.TabIndex = 50;
            // 
            // txtWageRate
            // 
            txtWageRate.BackColor = SystemColors.ControlLightLight;
            txtWageRate.Location = new Point(297, 48);
            txtWageRate.Name = "txtWageRate";
            txtWageRate.ReadOnly = true;
            txtWageRate.Size = new Size(157, 23);
            txtWageRate.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(486, 51);
            label6.Name = "label6";
            label6.Size = new Size(130, 17);
            label6.TabIndex = 48;
            label6.Text = "Total Harvest Today :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(216, 49);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 47;
            label4.Text = "Wage rate :";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Location = new Point(522, 406);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 38);
            btnClear.TabIndex = 46;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Aquamarine;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(313, 406);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 38);
            btnSave.TabIndex = 45;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(267, 268);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(100, 23);
            dtpDate.TabIndex = 44;
            // 
            // txtWorkerId
            // 
            txtWorkerId.Location = new Point(297, 112);
            txtWorkerId.Name = "txtWorkerId";
            txtWorkerId.Size = new Size(191, 23);
            txtWorkerId.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(219, 272);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 41;
            label3.Text = "Date :";
            // 
            // lblPluckedKilos
            // 
            lblPluckedKilos.AutoSize = true;
            lblPluckedKilos.Font = new Font("Segoe UI", 9.75F);
            lblPluckedKilos.Location = new Point(219, 219);
            lblPluckedKilos.Name = "lblPluckedKilos";
            lblPluckedKilos.Size = new Size(89, 17);
            lblPluckedKilos.TabIndex = 40;
            lblPluckedKilos.Text = "Plucked kilos :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 122, 79);
            panel5.Location = new Point(209, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(595, 29);
            panel5.TabIndex = 38;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(64, 64, 64);
            panel6.Controls.Add(Settlment);
            panel6.Controls.Add(button4);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(btnDashBoard);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(1, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(204, 498);
            panel6.TabIndex = 37;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 60);
            label5.Name = "label5";
            label5.Size = new Size(132, 30);
            label5.TabIndex = 0;
            label5.Text = "AGRITRACK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(219, 113);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 39;
            label1.Text = "Worker Id :";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(503, 112);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 51;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(219, 167);
            label7.Name = "label7";
            label7.Size = new Size(96, 17);
            label7.TabIndex = 40;
            label7.Text = "Worker Name :";
            // 
            // txtWorkerName
            // 
            txtWorkerName.Location = new Point(313, 165);
            txtWorkerName.Name = "txtWorkerName";
            txtWorkerName.ReadOnly = true;
            txtWorkerName.Size = new Size(191, 23);
            txtWorkerName.TabIndex = 43;
            // 
            // numPluckedKg
            // 
            numPluckedKg.Location = new Point(314, 216);
            numPluckedKg.Name = "numPluckedKg";
            numPluckedKg.Size = new Size(53, 23);
            numPluckedKg.TabIndex = 52;
            // 
            // DailyHarvestAdding
            // 
            ClientSize = new Size(804, 501);
            Controls.Add(numPluckedKg);
            Controls.Add(btnSearch);
            Controls.Add(txtTotalHarvest);
            Controls.Add(txtWageRate);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(dtpDate);
            Controls.Add(txtWorkerName);
            Controls.Add(txtWorkerId);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(lblPluckedKilos);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(label1);
            Name = "DailyHarvestAdding";
            Text = "AGRITRACK - Daily Harvest";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPluckedKg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtTotalHarvest;
        private TextBox txtWageRate;
        private Label label6;
        private Label label4;
        private Button btnClear;
        private Button btnSave;
        private DateTimePicker dtpDate;
        private TextBox txtWorkerId;
        private Label label3;
        private Label lblPluckedKilos;
        private Panel panel5;
        private Panel panel6;
        private Button Settlment;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnDashBoard;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label1;
        private Button btnSearch;
        private Label label7;
        private TextBox txtWorkerName;
        private NumericUpDown numPluckedKg;
    }
}
