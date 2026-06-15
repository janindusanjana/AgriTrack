namespace Daily_Harvest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Settlment = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnDashBoard = new Button();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            btnClear = new Button();
            label4 = new Label();
            label6 = new Label();
            HarvestTXT = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
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
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 122, 79);
            panel5.Location = new Point(207, -22);
            panel5.Name = "panel5";
            panel5.Size = new Size(595, 29);
            panel5.TabIndex = 23;
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
            panel6.Location = new Point(-1, -24);
            panel6.Name = "panel6";
            panel6.Size = new Size(204, 498);
            panel6.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(247, 173);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 24;
            label1.Text = "Worker Id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(247, 237);
            label2.Name = "label2";
            label2.Size = new Size(89, 17);
            label2.TabIndex = 25;
            label2.Text = "Plucked kilos :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(247, 304);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 26;
            label3.Text = "Date :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(356, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(356, 300);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 23);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Aquamarine;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(311, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 38);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Location = new Point(520, 381);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 38);
            btnClear.TabIndex = 31;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(296, 36);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 32;
            label4.Text = "Wage rate :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(296, 89);
            label6.Name = "label6";
            label6.Size = new Size(130, 17);
            label6.TabIndex = 33;
            label6.Text = "Total Harvest Today :";
            // 
            // HarvestTXT
            // 
            HarvestTXT.BackColor = SystemColors.GradientInactiveCaption;
            HarvestTXT.Location = new Point(432, 35);
            HarvestTXT.Name = "HarvestTXT";
            HarvestTXT.ReadOnly = true;
            HarvestTXT.Size = new Size(157, 23);
            HarvestTXT.TabIndex = 35;
            HarvestTXT.TextChanged += HarvestTXT_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.GradientInactiveCaption;
            textBox4.Location = new Point(432, 89);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(157, 23);
            textBox4.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 501);
            Controls.Add(textBox4);
            Controls.Add(HarvestTXT);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Settlment;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnDashBoard;
        private PictureBox pictureBox5;
        private Label label5;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Button btnSave;
        private Button btnClear;
        private Label label4;
        private Label label6;

        public TextBox WageRateTXT { get; private set; }

        private TextBox textBox3;
        private TextBox HarvestTXT;
        private Button button1;
        private TextBox textBox4;
    }
}
