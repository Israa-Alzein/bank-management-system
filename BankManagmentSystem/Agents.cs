using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagmentSystem
{
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            DisplayAgents();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UserPc\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false;");

        private void DisplayAgents()
        {
            Con.Open();
            string Query = "select * from AgentTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AgentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            ANameTb.Text = "";
            PAsswordTb.Text = "";
            AAddressTb.Text = "";
            AphoneTb.Text = "";
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || PAsswordTb.Text == "" || AAddressTb.Text == "" || AphoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AgentTb(AName,APass,APhone,Aaddress,AdId,AStatus)values(@AN,@APA,@APh,@AA,@AI,@AS)", Con);
                    cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                    cmd.Parameters.AddWithValue("@APA", PAsswordTb.Text);
                    cmd.Parameters.AddWithValue("@APh", AphoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AI", 1);
                    cmd.Parameters.AddWithValue("@AS", "Inactive");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Added!!!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
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
                MessageBox.Show("Select Agent");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AgentTb where AId=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Removed!!!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;

        private void AgentDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = AgentDGV.Rows[e.RowIndex];
                ANameTb.Text = AgentDGV.SelectedRows[0].Cells[1].Value.ToString();
                PAsswordTb.Text = AgentDGV.SelectedRows[0].Cells[2].Value.ToString();
                AphoneTb.Text = AgentDGV.SelectedRows[0].Cells[3].Value.ToString();
                AAddressTb.Text = AgentDGV.SelectedRows[0].Cells[4].Value.ToString();

            }

            if (ANameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AgentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || PAsswordTb.Text == "" || AAddressTb.Text == "" || AphoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AgentTb set AName=@AN,APass=@APA,APhone=@APh,Aaddress=@AA where AId=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                    cmd.Parameters.AddWithValue("@APA", PAsswordTb.Text);
                    cmd.Parameters.AddWithValue("@APh", AphoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent Updated!!!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingLbl_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();

        }


        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchABtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "select * from AgentTb where AName = '" + SearchATb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AgentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Query = "select * from AgentTb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AgentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }

}
