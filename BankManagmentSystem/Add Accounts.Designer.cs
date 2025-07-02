namespace BankManagmentSystem
{
    partial class Add_Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Accounts));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            AcNameTb = new TextBox();
            label4 = new Label();
            AcPhoneTb = new TextBox();
            label5 = new Label();
            GenCb = new ComboBox();
            label6 = new Label();
            AcAddressTb = new TextBox();
            label7 = new Label();
            OccupationTb = new TextBox();
            label8 = new Label();
            IncomeTb = new TextBox();
            label9 = new Label();
            SubmitBtn = new Button();
            CancelBtn = new Button();
            EditBtn = new Button();
            EducationCb = new ComboBox();
            AccountDGV = new DataGridView();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            SearchBtn = new Button();
            SearchTb = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 0);
            label1.Location = new Point(485, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(459, 65);
            label1.TabIndex = 4;
            label1.Text = "New Account Form";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1471, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(225, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 45);
            label3.TabIndex = 8;
            label3.Text = "Name";
            // 
            // AcNameTb
            // 
            AcNameTb.Location = new Point(225, 176);
            AcNameTb.Margin = new Padding(4, 5, 4, 5);
            AcNameTb.Name = "AcNameTb";
            AcNameTb.Size = new Size(214, 31);
            AcNameTb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(485, 121);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 45);
            label4.TabIndex = 10;
            label4.Text = "Phone";
            // 
            // AcPhoneTb
            // 
            AcPhoneTb.Location = new Point(485, 176);
            AcPhoneTb.Margin = new Padding(4, 5, 4, 5);
            AcPhoneTb.Name = "AcPhoneTb";
            AcPhoneTb.Size = new Size(214, 31);
            AcPhoneTb.TabIndex = 9;
            AcPhoneTb.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(485, 234);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 45);
            label5.TabIndex = 12;
            label5.Text = "Gender";
            // 
            // GenCb
            // 
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male", "Female", "Others" });
            GenCb.Location = new Point(485, 289);
            GenCb.Margin = new Padding(4, 5, 4, 5);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(214, 33);
            GenCb.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(739, 121);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(141, 45);
            label6.TabIndex = 15;
            label6.Text = "Address";
            // 
            // AcAddressTb
            // 
            AcAddressTb.Location = new Point(739, 176);
            AcAddressTb.Margin = new Padding(4, 5, 4, 5);
            AcAddressTb.Multiline = true;
            AcAddressTb.Name = "AcAddressTb";
            AcAddressTb.Size = new Size(224, 149);
            AcAddressTb.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(1012, 121);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(190, 45);
            label7.TabIndex = 17;
            label7.Text = "Occupation";
            // 
            // OccupationTb
            // 
            OccupationTb.Location = new Point(1012, 176);
            OccupationTb.Margin = new Padding(4, 5, 4, 5);
            OccupationTb.Name = "OccupationTb";
            OccupationTb.Size = new Size(214, 31);
            OccupationTb.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(1012, 234);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 45);
            label8.TabIndex = 19;
            label8.Text = "Income";
            // 
            // IncomeTb
            // 
            IncomeTb.Location = new Point(1012, 289);
            IncomeTb.Margin = new Padding(4, 5, 4, 5);
            IncomeTb.Name = "IncomeTb";
            IncomeTb.Size = new Size(214, 31);
            IncomeTb.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(225, 234);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(168, 45);
            label9.TabIndex = 21;
            label9.Text = "Education";
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.FromArgb(0, 64, 0);
            SubmitBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = SystemColors.Control;
            SubmitBtn.Location = new Point(350, 370);
            SubmitBtn.Margin = new Padding(4, 5, 4, 5);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(169, 65);
            SubmitBtn.TabIndex = 22;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.FromArgb(0, 64, 0);
            CancelBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = SystemColors.Control;
            CancelBtn.Location = new Point(929, 370);
            CancelBtn.Margin = new Padding(4, 5, 4, 5);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(169, 65);
            CancelBtn.TabIndex = 23;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(0, 64, 0);
            EditBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = SystemColors.Control;
            EditBtn.Location = new Point(642, 370);
            EditBtn.Margin = new Padding(4, 5, 4, 5);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(169, 65);
            EditBtn.TabIndex = 24;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // EducationCb
            // 
            EducationCb.FormattingEnabled = true;
            EducationCb.Items.AddRange(new object[] { "Uneducated", "Diploma", "UG", "PG", "PHD" });
            EducationCb.Location = new Point(225, 289);
            EducationCb.Margin = new Padding(4, 5, 4, 5);
            EducationCb.Name = "EducationCb";
            EducationCb.Size = new Size(214, 33);
            EducationCb.TabIndex = 26;
            // 
            // AccountDGV
            // 
            AccountDGV.AllowUserToOrderColumns = true;
            AccountDGV.BackgroundColor = Color.White;
            AccountDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountDGV.GridColor = Color.White;
            AccountDGV.Location = new Point(3, 584);
            AccountDGV.Name = "AccountDGV";
            AccountDGV.RowHeadersWidth = 62;
            AccountDGV.Size = new Size(1519, 476);
            AccountDGV.TabIndex = 27;
            AccountDGV.RowHeaderMouseClick += AccountDGV_RowHeaderMouseClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1449, 388);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(SearchBtn);
            panel1.Controls.Add(SearchTb);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(13, 473);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1495, 103);
            panel1.TabIndex = 52;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1070, 14);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Ivory;
            SearchBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.FromArgb(0, 64, 0);
            SearchBtn.Location = new Point(864, 27);
            SearchBtn.Margin = new Padding(4, 5, 4, 5);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(160, 45);
            SearchBtn.TabIndex = 55;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchTb
            // 
            SearchTb.Location = new Point(453, 37);
            SearchTb.Margin = new Padding(4, 5, 4, 5);
            SearchTb.Name = "SearchTb";
            SearchTb.Size = new Size(387, 31);
            SearchTb.TabIndex = 54;
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
            // Add_Accounts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1521, 1025);
            Controls.Add(panel1);
            Controls.Add(AccountDGV);
            Controls.Add(pictureBox3);
            Controls.Add(EducationCb);
            Controls.Add(EditBtn);
            Controls.Add(CancelBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(IncomeTb);
            Controls.Add(label7);
            Controls.Add(OccupationTb);
            Controls.Add(label6);
            Controls.Add(AcAddressTb);
            Controls.Add(GenCb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AcPhoneTb);
            Controls.Add(label3);
            Controls.Add(AcNameTb);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Add_Accounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Accounts";
            Load += Add_Accounts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AccountDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox AcNameTb;
        private Label label4;
        private TextBox AcPhoneTb;
        private Label label5;
        private ComboBox GenCb;
        private Label label6;
        private TextBox AcAddressTb;
        private Label label7;
        private TextBox OccupationTb;
        private Label label8;
        private TextBox IncomeTb;
        private Label label9;
        private Button SubmitBtn;
        private Button CancelBtn;
        private Button EditBtn;
        private ComboBox EducationCb;
        private DataGridView AccountDGV;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label2;
        private TextBox SearchTb;
        private Button SearchBtn;
        private PictureBox pictureBox1;
    }
}