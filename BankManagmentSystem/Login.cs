using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace BankManagmentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\UserPc\OneDrive\Documents\BankDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=false;");




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
            RoleCb.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select The Role");
            }
            else if (RoleCb.SelectedIndex == 0)
            {
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter Both Admin Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTbl where AdName='" + UnameTb.Text + "' and Adpass='" + PasswordTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Agents Obj = new Agents();
                        Obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin Name or Password");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    Con.Close();
                }
            }
            else
            {
                if (UnameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter Both User Name and Password");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AgentTb where AName='" + UnameTb.Text + "' and APass='" + PasswordTb.Text + "' ", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Con.Close();
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("Update AgentTb set AStatus=@AS where AName='" + UnameTb.Text + "' and APass='" + PasswordTb.Text + "'", Con);
                        cmd.Parameters.AddWithValue("@AS", "Active");
                        cmd.ExecuteNonQuery();
                        MainMenu Obj = new MainMenu();
                        Obj.Show();
                        this.Hide();
                        Con.Close();

                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name or Password");
                        UnameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    Con.Close();
                }
            }
        }
    }
}
