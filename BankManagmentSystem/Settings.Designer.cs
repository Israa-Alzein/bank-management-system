namespace BankManagmentSystem
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            NewPassTb = new TextBox();
            label2 = new Label();
            ThemeCb = new ComboBox();
            NewPassBtn = new Button();
            ThemeBtn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 623);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(330, 47);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(213, 65);
            label4.TabIndex = 11;
            label4.Text = "Settings";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(169, 206);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(349, 45);
            label3.TabIndex = 13;
            label3.Text = "Admin New Password";
            // 
            // NewPassTb
            // 
            NewPassTb.Location = new Point(169, 261);
            NewPassTb.Margin = new Padding(4, 5, 4, 5);
            NewPassTb.Name = "NewPassTb";
            NewPassTb.Size = new Size(349, 31);
            NewPassTb.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(169, 367);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 45);
            label2.TabIndex = 17;
            label2.Text = "Theme";
            // 
            // ThemeCb
            // 
            ThemeCb.FormattingEnabled = true;
            ThemeCb.Items.AddRange(new object[] { "Gold", "Crimson", "Default" });
            ThemeCb.Location = new Point(169, 429);
            ThemeCb.Margin = new Padding(4, 5, 4, 5);
            ThemeCb.Name = "ThemeCb";
            ThemeCb.Size = new Size(349, 33);
            ThemeCb.TabIndex = 27;
            ThemeCb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // NewPassBtn
            // 
            NewPassBtn.BackColor = Color.FromArgb(0, 64, 0);
            NewPassBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewPassBtn.ForeColor = SystemColors.Control;
            NewPassBtn.Location = new Point(589, 261);
            NewPassBtn.Margin = new Padding(4, 5, 4, 5);
            NewPassBtn.Name = "NewPassBtn";
            NewPassBtn.Size = new Size(142, 45);
            NewPassBtn.TabIndex = 28;
            NewPassBtn.Text = "Submit";
            NewPassBtn.UseVisualStyleBackColor = false;
            NewPassBtn.Click += NewPassBtn_Click;
            // 
            // ThemeBtn
            // 
            ThemeBtn.BackColor = Color.FromArgb(0, 64, 0);
            ThemeBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThemeBtn.ForeColor = SystemColors.Control;
            ThemeBtn.Location = new Point(589, 417);
            ThemeBtn.Margin = new Padding(4, 5, 4, 5);
            ThemeBtn.Name = "ThemeBtn";
            ThemeBtn.Size = new Size(142, 45);
            ThemeBtn.TabIndex = 30;
            ThemeBtn.Text = "Submit";
            ThemeBtn.UseVisualStyleBackColor = false;
            ThemeBtn.Click += ThemeBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(787, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(838, 623);
            Controls.Add(pictureBox2);
            Controls.Add(ThemeBtn);
            Controls.Add(NewPassBtn);
            Controls.Add(ThemeCb);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(NewPassTb);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private TextBox NewPassTb;
        private Label label2;
        private ComboBox ThemeCb;
        private Button NewPassBtn;
        private Button ThemeBtn;
        private PictureBox pictureBox2;
    }
}