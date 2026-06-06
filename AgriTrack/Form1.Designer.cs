namespace dashboard
{
    partial class Dashboard
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
            button1 = new Button();
            report = new Button();
            sales = new Button();
            inventory = new Button();
            livest = new Button();
            crops = new Button();
            Farmmer = new Button();
            Dashboard = new Button();
            AGRITRACK = new Label();
            panel10 = new Panel();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(report);
            panel1.Controls.Add(sales);
            panel1.Controls.Add(inventory);
            panel1.Controls.Add(livest);
            panel1.Controls.Add(crops);
            panel1.Controls.Add(Farmmer);
            panel1.Controls.Add(Dashboard);
            panel1.Controls.Add(AGRITRACK);
            panel1.Location = new Point(6, 8);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 510);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(3, 398);
            button1.Name = "button1";
            button1.Size = new Size(205, 37);
            button1.TabIndex = 17;
            button1.Text = "Setting";
            button1.UseVisualStyleBackColor = false;
            // 
            // report
            // 
            report.BackColor = Color.Gray;
            report.ForeColor = SystemColors.ControlLightLight;
            report.Location = new Point(3, 355);
            report.Name = "report";
            report.Size = new Size(205, 37);
            report.TabIndex = 16;
            report.Text = "Report";
            report.UseVisualStyleBackColor = false;
            report.Click += report_Click;
            // 
            // sales
            // 
            sales.BackColor = Color.Gray;
            sales.ForeColor = SystemColors.ControlLightLight;
            sales.Location = new Point(3, 312);
            sales.Name = "sales";
            sales.Size = new Size(205, 37);
            sales.TabIndex = 15;
            sales.Text = "Sales";
            sales.UseVisualStyleBackColor = false;
            // 
            // inventory
            // 
            inventory.BackColor = Color.Gray;
            inventory.ForeColor = SystemColors.ControlLightLight;
            inventory.Location = new Point(3, 269);
            inventory.Name = "inventory";
            inventory.Size = new Size(205, 37);
            inventory.TabIndex = 14;
            inventory.Text = "Inventory";
            inventory.UseVisualStyleBackColor = false;
            // 
            // livest
            // 
            livest.BackColor = Color.Gray;
            livest.ForeColor = SystemColors.ControlLightLight;
            livest.Location = new Point(3, 225);
            livest.Name = "livest";
            livest.Size = new Size(205, 37);
            livest.TabIndex = 13;
            livest.Text = "Live Stock";
            livest.UseVisualStyleBackColor = false;
            // 
            // crops
            // 
            crops.BackColor = Color.Gray;
            crops.ForeColor = SystemColors.ControlLightLight;
            crops.Location = new Point(3, 180);
            crops.Name = "crops";
            crops.Size = new Size(205, 37);
            crops.TabIndex = 12;
            crops.Text = "Crops";
            crops.UseVisualStyleBackColor = false;
            // 
            // Farmmer
            // 
            Farmmer.BackColor = Color.Gray;
            Farmmer.ForeColor = SystemColors.ControlLightLight;
            Farmmer.Location = new Point(3, 137);
            Farmmer.Name = "Farmmer";
            Farmmer.Size = new Size(205, 37);
            Farmmer.TabIndex = 11;
            Farmmer.Text = "Farmmers";
            Farmmer.UseVisualStyleBackColor = false;
            Farmmer.Click += Farmmer_Click;
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.Gray;
            Dashboard.BackgroundImageLayout = ImageLayout.None;
            Dashboard.ForeColor = Color.White;
            Dashboard.Location = new Point(3, 93);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(205, 37);
            Dashboard.TabIndex = 10;
            Dashboard.Text = "Dashboard";
            Dashboard.UseVisualStyleBackColor = false;
            Dashboard.Click += Dashboard_Click;
            // 
            // AGRITRACK
            // 
            AGRITRACK.AutoSize = true;
            AGRITRACK.Font = new Font("Roboto", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AGRITRACK.ForeColor = SystemColors.ButtonHighlight;
            AGRITRACK.Location = new Point(47, 46);
            AGRITRACK.Margin = new Padding(4, 0, 4, 0);
            AGRITRACK.Name = "AGRITRACK";
            AGRITRACK.Size = new Size(122, 25);
            AGRITRACK.TabIndex = 0;
            AGRITRACK.Text = "AGRITRACK";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.AppWorkspace;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Location = new Point(225, 54);
            panel10.Name = "panel10";
            panel10.Size = new Size(720, 2);
            panel10.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Image = AgriTrack.Properties.Resources.man;
            pictureBox7.Location = new Point(843, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(51, 51);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 4;
            pictureBox7.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(235, 27);
            label7.Name = "label7";
            label7.Size = new Size(160, 21);
            label7.TabIndex = 9;
            label7.Text = "Agritrack Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(725, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 10;
            label1.Text = "Coustommer Name";
            // 
            // button1
            // 
            button1.Location = new Point(858, 578);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "database check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(pictureBox7);
            Controls.Add(panel10);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AGRITRACK;
        private Panel panel10;
        private PictureBox pictureBox7;
        private Label label7;
        private Button Dashboard;
        private Button inventory;
        private Button livest;
        private Button crops;
        private Button Farmmer;
        private Button report;
        private Button sales;
        private Button button1;
        private Label label1;
        private AgriTrack.Dashboard dashboard1;
    }
}

