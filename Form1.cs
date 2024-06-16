using System;
using System.Windows.Forms;

namespace RotaGenius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerAuthentication Managerauthentication = new ManagerAuthentication();
            Managerauthentication.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffDashboard StaffDashboard1 = new StaffDashboard();
            StaffDashboard1.Show();
            this.Hide();
        }
    }
}
