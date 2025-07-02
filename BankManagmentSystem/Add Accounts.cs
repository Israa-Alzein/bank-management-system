using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static BankManagmentSystem.Login;

namespace BankManagmentSystem
{
    public partial class Add_Accounts : Form
    {

        public Add_Accounts()
        {
            InitializeComponent();
            DisplayAccounts();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UserPc\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false;");

        private void DisplayAccounts()
        {
            Con.Open();
            string Query = "select * from AccountTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AccountDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            AcNameTb.Text = "";
            AcPhoneTb.Text = "";
            AcAddressTb.Text = "";
            GenCb.SelectedIndex = -1;
            OccupationTb.Text = "";
            IncomeTb.Text = "";
            EducationCb.SelectedIndex = -1;
        }


        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == "" || AcPhoneTb.Text == "" || AcAddressTb.Text == "" || GenCb.SelectedIndex == -1 || OccupationTb.Text == "" || EducationCb.SelectedIndex == -1 || IncomeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccountTbl(ACName,ACphone,AcAddress,AcGen,AcOccup,AcEduc,AcInc,AcBal)values(@AN,@AP,@AA,@AG,@AO,@AE,@AI,@AB)", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    if (GenCb.SelectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@AG", GenCb.SelectedItem.ToString());
                    }
                    cmd.Parameters.AddWithValue("@AO", OccupationTb.Text);
                    if (EducationCb.SelectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@AE", EducationCb.SelectedItem.ToString());
                    }
                    cmd.Parameters.AddWithValue("@AI", IncomeTb.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created!!!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }



        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Account");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AccountTbl where ACNum=@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Deleted!!!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;

        private void AccountDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = AccountDGV.Rows[e.RowIndex];
                AcNameTb.Text = AccountDGV.SelectedRows[0].Cells[1].Value.ToString();
                AcPhoneTb.Text = AccountDGV.SelectedRows[0].Cells[2].Value.ToString();
                AcAddressTb.Text = AccountDGV.SelectedRows[0].Cells[3].Value.ToString();
                GenCb.SelectedItem = AccountDGV.SelectedRows[0].Cells[4].Value.ToString();
                OccupationTb.Text = AccountDGV.SelectedRows[0].Cells[5].Value.ToString();
                EducationCb.SelectedItem = AccountDGV.SelectedRows[0].Cells[6].Value.ToString();
                IncomeTb.Text = AccountDGV.SelectedRows[0].Cells[7].Value.ToString();

            }

            if (AcNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AccountDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == "" || AcPhoneTb.Text == "" || AcAddressTb.Text == "" || GenCb.SelectedIndex == -1 || OccupationTb.Text == "" || EducationCb.SelectedIndex == -1 || IncomeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set ACName=@AN,ACphone=@AP,AcAddress=@AA,AcGen=@AG,AcOccup=@AO,AcEduc=@AE,AcInc=@AI where ACNum=@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    if (GenCb.SelectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@AG", GenCb.SelectedItem.ToString());
                    }
                    cmd.Parameters.AddWithValue("@AO", OccupationTb.Text);
                    if (EducationCb.SelectedItem != null)
                    {
                        cmd.Parameters.AddWithValue("@AE", EducationCb.SelectedItem.ToString());
                    }
                    cmd.Parameters.AddWithValue("@AI", IncomeTb.Text);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated!!!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Add_Accounts_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Update AgentTb set AStatus=@AS where AStatus=@AA", Con);
            cmd.Parameters.AddWithValue("@AS", "Inactive");
            cmd.Parameters.AddWithValue("@AA", "Active");
            cmd.ExecuteNonQuery();
            Con.Close();
            Application.Exit();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "select * from AccountTbl where ACName = '" + SearchTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AccountDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "select * from AccountTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AccountDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
