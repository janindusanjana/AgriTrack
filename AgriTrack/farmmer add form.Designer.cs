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
            addsystem = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
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
            label1.Size = new Size(242, 21);
            label1.TabIndex = 1;
            label1.Text = "NEW FARMMER ADING SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 85);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 2;
            label2.Text = "1.FULL NAME :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 125);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "2.WORK ID         :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 169);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 6;
            label4.Text = "3.NIC  NUMBER              :";
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
            label6.Size = new Size(112, 15);
            label6.TabIndex = 10;
            label6.Text = "5.RATE PER KILLO   :";
            // 
            // addsystem
            // 
            addsystem.BackColor = Color.Teal;
            addsystem.ForeColor = SystemColors.ButtonHighlight;
            addsystem.Location = new Point(16, 356);
            addsystem.Name = "addsystem";
            addsystem.Size = new Size(115, 28);
            addsystem.TabIndex = 17;
            addsystem.Text = "SUBMIT";
            addsystem.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(141, 356);
            button1.Name = "button1";
            button1.Size = new Size(115, 28);
            button1.TabIndex = 18;
            button1.Text = "CLEAR FORM";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(572, 23);
            textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(572, 23);
            textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(160, 207);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(160, 251);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 23;
            // 
            // farmmer_add_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(addsystem);
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
        private Button addsystem;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}