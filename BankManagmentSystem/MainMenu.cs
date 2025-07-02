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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UserPc\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false;");

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Add_Accounts Obj = new Add_Accounts();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Transactions Obj = new Transactions();
            Obj.Show();
            this.Hide();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Add_Accounts Obj = new Add_Accounts();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Transactions Obj = new Transactions();
            Obj.Show();
            this.Hide();
        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Update AgentTb set AStatus=@AS where AStatus=@AA", Con);
            cmd.Parameters.AddWithValue("@AS", "Inactive");
            cmd.Parameters.AddWithValue("@AA", "Active");
            cmd.ExecuteNonQuery();
            Con.Close();

            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Update AgentTb set AStatus=@AS where AStatus=@AA", Con);
            cmd.Parameters.AddWithValue("@AS", "Inactive");
            cmd.Parameters.AddWithValue("@AA", "Active");
            cmd.ExecuteNonQuery();
            Con.Close();
            Application.Exit();
        }

       
    }
}
