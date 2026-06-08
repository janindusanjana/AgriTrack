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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            addsystem = new Button();
            button1 = new Button();
            tbxName = new TextBox();
            tbxAddress = new TextBox();
            tbxId = new TextBox();
            tbxPhoneNu = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(14, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 3);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(238, 21);
            label1.TabIndex = 1;
            label1.Text = "NEW FARMER ADDING SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 85);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 2;
            label2.Text = "1.NAME WITH INNITIAL :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 125);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 4;
            label3.Text = "2.ADDRESS         :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 169);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 6;
            label4.Text = "3.ID  NUMBER              :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 210);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 8;
            label5.Text = "4.PHONE NUMBER     :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 254);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 10;
            label6.Text = "5.SELECT GENDER    :";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(160, 254);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(56, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "MALE";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(231, 254);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "FEMALE";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 296);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 13;
            label7.Text = "6.SELECT SECTION     :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Subsistence Farmer", "Commercial Farmer", "Mixed Farmer", "Dairy Farmer", "Poultry Farmer", "Livestock Farmer", "Organic Farmer", "Plantation Farmer", "Horticultural Farmer", "Aquaculture Farmer" });
            comboBox1.Location = new Point(160, 293);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "SELECT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 336);
            label8.Name = "label8";
            label8.Size = new Size(123, 15);
            label8.TabIndex = 15;
            label8.Text = "7.JOIN DATE                :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(160, 330);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // addsystem
            // 
            addsystem.BackColor = Color.Teal;
            addsystem.ForeColor = SystemColors.ButtonHighlight;
            addsystem.Location = new Point(14, 395);
            addsystem.Name = "addsystem";
            addsystem.Size = new Size(115, 28);
            addsystem.TabIndex = 17;
            addsystem.Text = "ADD SYSTEM";
            addsystem.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(135, 395);
            button1.Name = "button1";
            button1.Size = new Size(115, 28);
            button1.TabIndex = 18;
            button1.Text = "CLEAR FORM";
            button1.UseVisualStyleBackColor = false;
            // 
            // tbxName
            // 
            tbxName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxName.Location = new Point(159, 78);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(367, 27);
            tbxName.TabIndex = 19;
            // 
            // tbxAddress
            // 
            tbxAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxAddress.Location = new Point(159, 118);
            tbxAddress.Name = "tbxAddress";
            tbxAddress.Size = new Size(367, 27);
            tbxAddress.TabIndex = 19;
            // 
            // tbxId
            // 
            tbxId.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxId.Location = new Point(160, 162);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(367, 27);
            tbxId.TabIndex = 19;
            // 
            // tbxPhoneNu
            // 
            tbxPhoneNu.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPhoneNu.Location = new Point(159, 210);
            tbxPhoneNu.Name = "tbxPhoneNu";
            tbxPhoneNu.Size = new Size(367, 27);
            tbxPhoneNu.TabIndex = 19;
            // 
            // farmmer_add_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxPhoneNu);
            Controls.Add(tbxId);
            Controls.Add(tbxAddress);
            Controls.Add(tbxName);
            Controls.Add(button1);
            Controls.Add(addsystem);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "farmmer_add_form";
            Text = "farmmer_add_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Button addsystem;
        private Button button1;
        private TextBox tbxName;
        private TextBox tbxAddress;
        private TextBox tbxId;
        private TextBox tbxPhoneNu;
    }
}