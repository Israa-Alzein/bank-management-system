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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UserPc\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false;");
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemeBtn_Click(object sender, EventArgs e)
        {
            if (ThemeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select A Theme");

            }
            else if (ThemeCb.SelectedIndex == 0)
            {
                panel1.BackColor = Color.Gold;
             

            }
            else if (ThemeCb.SelectedIndex == 1)
            {
                panel1.BackColor = Color.Crimson;
            }
            else
            {
                panel1.BackColor = Color.Green;
            }
        }

        private void NewPassBtn_Click(object sender, EventArgs e)
        {
            if (NewPassTb.Text == "")
            {
                MessageBox.Show("Enter New Password");
            }
            else
            {
                try
                {
                    using (SqlConnection Con = GetConnection())
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("Update AdminTbl set AdPass=@AP where AdId=@AKey", Con);
                        cmd.Parameters.AddWithValue("@AP", NewPassTb.Text);

                        cmd.Parameters.AddWithValue("@AKey", 1);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Updated!!!");
                        Con.Close();
                        NewPassTb.Text = "";
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
