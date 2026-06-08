namespace AgriTrack.Admin_Forms
{
    partial class Advance_Settlement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advance_Settlement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnDaillyReport = new Button();
            button2 = new Button();
            button1 = new Button();
            btnSettlement = new Button();
            dataGridView1 = new DataGridView();
            WorkerID = new DataGridViewTextBoxColumn();
            WorkerName = new DataGridViewTextBoxColumn();
            HarvestKg = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Kilos = new DataGridViewTextBoxColumn();
            Paid = new DataGridViewCheckBoxColumn();
            btnLoadAdvanceReport = new Button();
            dateTimePicker2 = new DateTimePicker();
            lblDate = new Label();
            btnUpdateSettlemet = new Button();
            btnSettlementPrint = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDaillyReport
            // 
            btnDaillyReport.BackColor = Color.White;
            btnDaillyReport.BackgroundImageLayout = ImageLayout.None;
            btnDaillyReport.FlatAppearance.BorderSize = 0;
            btnDaillyReport.Font = new Font("MV Boli", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDaillyReport.ForeColor = SystemColors.ActiveCaptionText;
            btnDaillyReport.Image = Properties.Resources.pngwing_com;
            btnDaillyReport.ImageAlign = ContentAlignment.BottomCenter;
            btnDaillyReport.Location = new Point(1, 226);
            btnDaillyReport.Name = "btnDaillyReport";
            btnDaillyReport.Size = new Size(214, 112);
            btnDaillyReport.TabIndex = 6;
            btnDaillyReport.Text = "Daily Harvest";
            btnDaillyReport.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(1, 114);
            button2.Name = "button2";
            button2.Size = new Size(214, 112);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1, 1);
            button1.Name = "button1";
            button1.Size = new Size(214, 112);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSettlement
            // 
            btnSettlement.BackColor = Color.White;
            btnSettlement.BackgroundImageLayout = ImageLayout.None;
            btnSettlement.FlatAppearance.BorderSize = 0;
            btnSettlement.Font = new Font("MV Boli", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSettlement.ForeColor = SystemColors.ActiveCaptionText;
            btnSettlement.Image = (Image)resources.GetObject("btnSettlement.Image");
            btnSettlement.Location = new Point(0, 339);
            btnSettlement.Name = "btnSettlement";
            btnSettlement.Size = new Size(214, 112);
            btnSettlement.TabIndex = 6;
            btnSettlement.Text = "Advance and Settlement";
            btnSettlement.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { WorkerID, WorkerName, HarvestKg, Status, Kilos, Paid });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(237, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(551, 223);
            dataGridView1.TabIndex = 8;
            // 
            // WorkerID
            // 
            WorkerID.HeaderText = "WorkerID";
            WorkerID.Name = "WorkerID";
            WorkerID.Width = 80;
            // 
            // WorkerName
            // 
            WorkerName.HeaderText = "WorkerName";
            WorkerName.Name = "WorkerName";
            WorkerName.Width = 120;
            // 
            // HarvestKg
            // 
            HarvestKg.HeaderText = "Advance";
            HarvestKg.Name = "HarvestKg";
            // 
            // Status
            // 
            Status.HeaderText = "Net Salary";
            Status.Name = "Status";
            // 
            // Kilos
            // 
            Kilos.HeaderText = "Plucked Kilos";
            Kilos.Name = "Kilos";
            Kilos.Width = 60;
            // 
            // Paid
            // 
            Paid.HeaderText = "Paid_Or-Not";
            Paid.Name = "Paid";
            Paid.Resizable = DataGridViewTriState.True;
            Paid.SortMode = DataGridViewColumnSortMode.Automatic;
            Paid.Width = 80;
            // 
            // btnLoadAdvanceReport
            // 
            btnLoadAdvanceReport.BackColor = Color.FromArgb(46, 125, 50);
            btnLoadAdvanceReport.FlatAppearance.BorderSize = 0;
            btnLoadAdvanceReport.FlatStyle = FlatStyle.Flat;
            btnLoadAdvanceReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadAdvanceReport.ForeColor = Color.Black;
            btnLoadAdvanceReport.Location = new Point(583, 38);
            btnLoadAdvanceReport.Name = "btnLoadAdvanceReport";
            btnLoadAdvanceReport.Size = new Size(115, 31);
            btnLoadAdvanceReport.TabIndex = 11;
            btnLoadAdvanceReport.Text = "Load Report";
            btnLoadAdvanceReport.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.CalendarMonthBackground = SystemColors.ControlLightLight;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(347, 43);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(106, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(237, 42);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(98, 21);
            lblDate.TabIndex = 9;
            lblDate.Text = "Enter Date :";
            // 
            // btnUpdateSettlemet
            // 
            btnUpdateSettlemet.BackColor = Color.FromArgb(46, 125, 50);
            btnUpdateSettlemet.FlatAppearance.BorderSize = 0;
            btnUpdateSettlemet.FlatStyle = FlatStyle.Flat;
            btnUpdateSettlemet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateSettlemet.ForeColor = Color.Black;
            btnUpdateSettlemet.Location = new Point(266, 394);
            btnUpdateSettlemet.Name = "btnUpdateSettlemet";
            btnUpdateSettlemet.Size = new Size(115, 31);
            btnUpdateSettlemet.TabIndex = 11;
            btnUpdateSettlemet.Text = "Update";
            btnUpdateSettlemet.UseVisualStyleBackColor = false;
            // 
            // btnSettlementPrint
            // 
            btnSettlementPrint.BackColor = Color.FromArgb(46, 125, 50);
            btnSettlementPrint.FlatAppearance.BorderSize = 0;
            btnSettlementPrint.FlatStyle = FlatStyle.Flat;
            btnSettlementPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettlementPrint.ForeColor = Color.Black;
            btnSettlementPrint.Location = new Point(388, 394);
            btnSettlementPrint.Name = "btnSettlementPrint";
            btnSettlementPrint.Size = new Size(115, 31);
            btnSettlementPrint.TabIndex = 11;
            btnSettlementPrint.Text = "Print Report";
            btnSettlementPrint.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(46, 125, 50);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(71, 750);
            button5.Name = "button5";
            button5.Size = new Size(115, 31);
            button5.TabIndex = 11;
            button5.Text = "Load Report";
            button5.UseVisualStyleBackColor = false;
            // 
            // Advance_Settlement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(btnSettlementPrint);
            Controls.Add(btnUpdateSettlemet);
            Controls.Add(btnLoadAdvanceReport);
            Controls.Add(dateTimePicker2);
            Controls.Add(lblDate);
            Controls.Add(dataGridView1);
            Controls.Add(btnSettlement);
            Controls.Add(btnDaillyReport);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Advance_Settlement";
            Text = "Advance_Settlement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDaillyReport;
        private Button button2;
        private Button button1;
        private Button btnSettlement;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn WorkerID;
        private DataGridViewTextBoxColumn WorkerName;
        private DataGridViewTextBoxColumn HarvestKg;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Kilos;
        private DataGridViewCheckBoxColumn Paid;
        private Button btnLoadAdvanceReport;
        private DateTimePicker dateTimePicker2;
        private Label lblDate;
        private Button btnUpdateSettlemet;
        private Button btnSettlementPrint;
        private Button button5;
    }
}