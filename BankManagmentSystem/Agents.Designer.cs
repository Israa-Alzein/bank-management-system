namespace BankManagmentSystem
{
    partial class Agents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agents));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            AgentDGV = new DataGridView();
            EditBtn = new Button();
            CancelBtn = new Button();
            SubmitBtn = new Button();
            label7 = new Label();
            AphoneTb = new TextBox();
            label6 = new Label();
            AAddressTb = new TextBox();
            label4 = new Label();
            PAsswordTb = new TextBox();
            label3 = new Label();
            ANameTb = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            SettingLbl = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            reload = new PictureBox();
            SearchABtn = new Button();
            SearchATb = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)AgentDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reload).BeginInit();
            SuspendLayout();
            // 
            // AgentDGV
            // 
            AgentDGV.AllowUserToOrderColumns = true;
            AgentDGV.BackgroundColor = Color.White;
            AgentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AgentDGV.GridColor = Color.White;
            AgentDGV.Location = new Point(0, 611);
            AgentDGV.Name = "AgentDGV";
            AgentDGV.RowHeadersWidth = 62;
            AgentDGV.Size = new Size(1521, 414);
            AgentDGV.TabIndex = 29;
            AgentDGV.RowHeaderMouseClick += AgentDGV_RowHeaderMouseClick;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(0, 64, 0);
            EditBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = SystemColors.Control;
            EditBtn.Location = new Point(680, 391);
            EditBtn.Margin = new Padding(4, 5, 4, 5);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(169, 65);
            EditBtn.TabIndex = 47;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(0, 64, 0);
            CancelBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = SystemColors.Control;
            CancelBtn.Location = new Point(967, 391);
            CancelBtn.Margin = new Padding(4, 5, 4, 5);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(169, 65);
            CancelBtn.TabIndex = 46;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.FromArgb(0, 64, 0);
            SubmitBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = SystemColors.Control;
            SubmitBtn.Location = new Point(388, 391);
            SubmitBtn.Margin = new Padding(4, 5, 4, 5);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(169, 65);
            SubmitBtn.TabIndex = 45;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(974, 206);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(115, 45);
            label7.TabIndex = 41;
            label7.Text = "Phone";
            // 
            // AphoneTb
            // 
            AphoneTb.Location = new Point(974, 261);
            AphoneTb.Margin = new Padding(4, 5, 4, 5);
            AphoneTb.Name = "AphoneTb";
            AphoneTb.Size = new Size(214, 31);
            AphoneTb.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(674, 125);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(141, 45);
            label6.TabIndex = 39;
            label6.Text = "Address";
            // 
            // AAddressTb
            // 
            AAddressTb.Location = new Point(674, 180);
            AAddressTb.Margin = new Padding(4, 5, 4, 5);
            AAddressTb.Multiline = true;
            AAddressTb.Name = "AAddressTb";
            AAddressTb.Size = new Size(224, 149);
            AAddressTb.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(388, 245);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 45);
            label4.TabIndex = 35;
            label4.Text = "Password";
            // 
            // PAsswordTb
            // 
            PAsswordTb.Location = new Point(388, 300);
            PAsswordTb.Margin = new Padding(4, 5, 4, 5);
            PAsswordTb.Name = "PAsswordTb";
            PAsswordTb.Size = new Size(214, 31);
            PAsswordTb.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(388, 125);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 45);
            label3.TabIndex = 33;
            label3.Text = "Name";
            // 
            // ANameTb
            // 
            ANameTb.Location = new Point(388, 180);
            ANameTb.Margin = new Padding(4, 5, 4, 5);
            ANameTb.Name = "ANameTb";
            ANameTb.Size = new Size(214, 31);
            ANameTb.TabIndex = 32;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1469, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(601, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(383, 65);
            label1.TabIndex = 30;
            label1.Text = "Manage Agents";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(88, 14);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // SettingLbl
            // 
            SettingLbl.AutoSize = true;
            SettingLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingLbl.ForeColor = Color.Gold;
            SettingLbl.Location = new Point(152, 20);
            SettingLbl.Margin = new Padding(4, 0, 4, 0);
            SettingLbl.Name = "SettingLbl";
            SettingLbl.Size = new Size(127, 45);
            SettingLbl.TabIndex = 49;
            SettingLbl.Text = "Setting";
            SettingLbl.Click += SettingLbl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1439, 415);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(reload);
            panel1.Controls.Add(SearchABtn);
            panel1.Controls.Add(SearchATb);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(13, 500);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1495, 103);
            panel1.TabIndex = 53;
            // 
            // reload
            // 
            reload.Image = (Image)resources.GetObject("reload.Image");
            reload.Location = new Point(1070, 14);
            reload.Margin = new Padding(4, 5, 4, 5);
            reload.Name = "reload";
            reload.Size = new Size(59, 75);
            reload.SizeMode = PictureBoxSizeMode.CenterImage;
            reload.TabIndex = 56;
            reload.TabStop = false;
            reload.Click += reload_Click;
            // 
            // SearchABtn
            // 
            SearchABtn.BackColor = Color.Ivory;
            SearchABtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchABtn.ForeColor = Color.FromArgb(0, 64, 0);
            SearchABtn.Location = new Point(864, 27);
            SearchABtn.Margin = new Padding(4, 5, 4, 5);
            SearchABtn.Name = "SearchABtn";
            SearchABtn.Size = new Size(160, 45);
            SearchABtn.TabIndex = 55;
            SearchABtn.Text = "Search";
            SearchABtn.UseVisualStyleBackColor = false;
            SearchABtn.Click += SearchABtn_Click;
            // 
            // SearchATb
            // 
            SearchATb.Location = new Point(453, 37);
            SearchATb.Margin = new Padding(4, 5, 4, 5);
            SearchATb.Name = "SearchATb";
            SearchATb.Size = new Size(387, 31);
            SearchATb.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(252, 196, 25);
            label2.Location = new Point(295, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 48);
            label2.TabIndex = 53;
            label2.Text = "Search";
            // 
            // Agents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1521, 1025);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(SettingLbl);
            Controls.Add(pictureBox3);
            Controls.Add(EditBtn);
            Controls.Add(CancelBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(label7);
            Controls.Add(AphoneTb);
            Controls.Add(label6);
            Controls.Add(AAddressTb);
            Controls.Add(label4);
            Controls.Add(PAsswordTb);
            Controls.Add(label3);
            Controls.Add(ANameTb);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(AgentDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agents";
            ((System.ComponentModel.ISupportInitialize)AgentDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reload).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView AgentDGV;
        private Button EditBtn;
        private Button CancelBtn;
        private Button SubmitBtn;
        private Label label7;
        private TextBox AphoneTb;
        private Label label6;
        private TextBox AAddressTb;
        private Label label4;
        private TextBox PAsswordTb;
        private Label label3;
        private TextBox ANameTb;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label SettingLbl;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox reload;
        private Button SearchABtn;
        private TextBox SearchATb;
        private Label label2;
    }
}