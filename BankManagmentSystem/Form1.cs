namespace BankManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int startP = 0;
        /*private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            MyProgress.Value = startP;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;

            if (startP > 100)
            {
                startP = 0;
                MyProgress.Value = startP;
                timer1.Stop();
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MyProgress.Value = startP;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void MyProgress_Click(object sender, EventArgs e)
        {

        }

    }
}
